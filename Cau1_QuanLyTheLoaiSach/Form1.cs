using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Cau1_QuanLyTheLoaiSach.Models;

namespace Cau1_QuanLyTheLoaiSach;

public partial class Form1 : Form
{
    private TriThucBooksContext _context;
    private bool _isBinding = false;

    public Form1()
    {
        InitializeComponent();
        _context = new TriThucBooksContext();
    }

    private async void Form1_Load(object sender, EventArgs e)
    {
        await LoadDataAsync();
    }

    private async Task LoadDataAsync(string? searchKeyword = null)
    {
        try
        {
            _isBinding = true;

            var query = _context.TheLoaiSaches.AsNoTracking().AsQueryable();

            if (!string.IsNullOrWhiteSpace(searchKeyword))
            {
                query = query.Where(x => x.TenTheLoai.Contains(searchKeyword));
            }

            var list = await query
                .OrderBy(x => x.MaTl)
                .Select(x => new
                {
                    MaTL = x.MaTl,
                    TenTheLoai = x.TenTheLoai,
                    MoTa = x.MoTa,
                    SoLuongSach = x.SoLuongSach,
                    NgayTao = x.NgayTao
                })
                .ToListAsync();

            dgvTheLoai.DataSource = list;

            // Đặt tên cột tiếng Việt
            if (dgvTheLoai.Columns.Contains("MaTL"))
            {
                dgvTheLoai.Columns["MaTL"].HeaderText = "Mã TL";
                dgvTheLoai.Columns["MaTL"].Width = 80;
            }
            if (dgvTheLoai.Columns.Contains("TenTheLoai"))
            {
                dgvTheLoai.Columns["TenTheLoai"].HeaderText = "Tên thể loại";
                dgvTheLoai.Columns["TenTheLoai"].Width = 200;
            }
            if (dgvTheLoai.Columns.Contains("MoTa"))
            {
                dgvTheLoai.Columns["MoTa"].HeaderText = "Mô tả";
                dgvTheLoai.Columns["MoTa"].Width = 250;
            }
            if (dgvTheLoai.Columns.Contains("SoLuongSach"))
            {
                dgvTheLoai.Columns["SoLuongSach"].HeaderText = "Số lượng sách";
                dgvTheLoai.Columns["SoLuongSach"].Width = 120;
            }
            if (dgvTheLoai.Columns.Contains("NgayTao"))
            {
                dgvTheLoai.Columns["NgayTao"].HeaderText = "Ngày tạo";
                dgvTheLoai.Columns["NgayTao"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                dgvTheLoai.Columns["NgayTao"].Width = 140;
            }

            dgvTheLoai.ClearSelection();
            ClearInputs();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            _isBinding = false;
        }
    }

    private void dgvTheLoai_SelectionChanged(object sender, EventArgs e)
    {
        if (_isBinding || dgvTheLoai.CurrentRow == null || dgvTheLoai.CurrentRow.Index < 0)
            return;

        var row = dgvTheLoai.CurrentRow;
        txtMaTL.Text = row.Cells["MaTL"].Value?.ToString() ?? "";
        txtTenTheLoai.Text = row.Cells["TenTheLoai"].Value?.ToString() ?? "";
        txtMoTa.Text = row.Cells["MoTa"].Value?.ToString() ?? "";

        if (row.Cells["SoLuongSach"].Value != null && int.TryParse(row.Cells["SoLuongSach"].Value.ToString(), out int sl))
        {
            numSoLuongSach.Value = sl;
        }
        else
        {
            numSoLuongSach.Value = 0;
        }

        if (row.Cells["NgayTao"].Value != null && DateTime.TryParse(row.Cells["NgayTao"].Value.ToString(), out DateTime ngayTao))
        {
            lblNgayTaoValue.Text = ngayTao.ToString("dd/MM/yyyy HH:mm:ss");
        }
        else
        {
            lblNgayTaoValue.Text = "---";
        }
    }

    private void ClearInputs()
    {
        txtMaTL.Clear();
        txtTenTheLoai.Clear();
        txtMoTa.Clear();
        numSoLuongSach.Value = 0;
        lblNgayTaoValue.Text = "---";
    }

    private async void btnThem_Click(object sender, EventArgs e)
    {
        string tenTheLoai = txtTenTheLoai.Text.Trim();
        if (string.IsNullOrWhiteSpace(tenTheLoai))
        {
            MessageBox.Show("Vui lòng nhập tên thể loại sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtTenTheLoai.Focus();
            return;
        }

        try
        {
            // Kiểm tra trùng tên thể loại
            bool exists = await _context.TheLoaiSaches
                .AnyAsync(x => x.TenTheLoai.ToLower() == tenTheLoai.ToLower());

            if (exists)
            {
                MessageBox.Show("Tên thể loại đã tồn tại! Vui lòng nhập tên khác.", "Cảnh báo trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTheLoai.Focus();
                return;
            }

            var newItem = new TheLoaiSach
            {
                TenTheLoai = tenTheLoai,
                MoTa = string.IsNullOrWhiteSpace(txtMoTa.Text) ? null : txtMoTa.Text.Trim(),
                SoLuongSach = (int)numSoLuongSach.Value,
                NgayTao = DateTime.Now
            };

            _context.TheLoaiSaches.Add(newItem);
            await _context.SaveChangesAsync();

            MessageBox.Show("Thêm mới thể loại sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            await LoadDataAsync();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi khi thêm mới: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnSua_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtMaTL.Text) || !int.TryParse(txtMaTL.Text, out int maTL))
        {
            MessageBox.Show("Vui lòng chọn một thể loại trong danh sách để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        string tenTheLoai = txtTenTheLoai.Text.Trim();
        if (string.IsNullOrWhiteSpace(tenTheLoai))
        {
            MessageBox.Show("Tên thể loại không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtTenTheLoai.Focus();
            return;
        }

        try
        {
            // Kiểm tra trùng tên với thể loại khác
            bool exists = await _context.TheLoaiSaches
                .AnyAsync(x => x.MaTl != maTL && x.TenTheLoai.ToLower() == tenTheLoai.ToLower());

            if (exists)
            {
                MessageBox.Show("Tên thể loại này đã được sử dụng cho bản ghi khác!", "Cảnh báo trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTheLoai.Focus();
                return;
            }

            var item = await _context.TheLoaiSaches.FindAsync(maTL);
            if (item == null)
            {
                MessageBox.Show("Không tìm thấy thể loại cần sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            item.TenTheLoai = tenTheLoai;
            item.MoTa = string.IsNullOrWhiteSpace(txtMoTa.Text) ? null : txtMoTa.Text.Trim();
            item.SoLuongSach = (int)numSoLuongSach.Value;

            await _context.SaveChangesAsync();

            MessageBox.Show("Cập nhật thông tin thể loại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            await LoadDataAsync();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi khi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnXoa_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtMaTL.Text) || !int.TryParse(txtMaTL.Text, out int maTL))
        {
            MessageBox.Show("Vui lòng chọn một thể loại trong danh sách để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var confirm = MessageBox.Show(
            $"Bạn có chắc chắn muốn xóa thể loại: \"{txtTenTheLoai.Text}\" (Mã: {maTL})?",
            "Xác nhận xóa",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (confirm != DialogResult.Yes)
            return;

        try
        {
            var item = await _context.TheLoaiSaches.FindAsync(maTL);
            if (item == null)
            {
                MessageBox.Show("Không tìm thấy thể loại để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _context.TheLoaiSaches.Remove(item);
            await _context.SaveChangesAsync();

            MessageBox.Show("Xóa thể loại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            await LoadDataAsync();
        }
        catch (DbUpdateException)
        {
            MessageBox.Show("Không thể xóa thể loại này vì dữ liệu đang được bảng sách khác tham chiếu!", "Lỗi ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnLamMoi_Click(object sender, EventArgs e)
    {
        txtTimKiem.Clear();
        await LoadDataAsync();
    }

    private async void btnTimKiem_Click(object sender, EventArgs e)
    {
        string keyword = txtTimKiem.Text.Trim();
        await LoadDataAsync(keyword);
    }

    private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            e.SuppressKeyPress = true;
            btnTimKiem.PerformClick();
        }
    }

    private async void btnHienTatCa_Click(object sender, EventArgs e)
    {
        txtTimKiem.Clear();
        await LoadDataAsync();
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        _context?.Dispose();
    }
}
