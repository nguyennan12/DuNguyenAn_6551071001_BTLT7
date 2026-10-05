using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Cau3_QuanLyPhongHomestay.Models;

namespace Cau3_QuanLyPhongHomestay;

public partial class FormLoaiPhong : Form
{
    private SunriseHomestayContext _context;
    private bool _isBinding = false;

    public FormLoaiPhong()
    {
        InitializeComponent();
        _context = new SunriseHomestayContext();
    }

    private async void FormLoaiPhong_Load(object sender, EventArgs e)
    {
        await LoadDataAsync();
    }

    private async Task LoadDataAsync()
    {
        try
        {
            _isBinding = true;
            var list = await _context.LoaiPhongs.AsNoTracking()
                .OrderBy(x => x.MaLoai)
                .Select(x => new
                {
                    MaLoai = x.MaLoai,
                    TenLoai = x.TenLoai,
                    GiaMoiDem = x.GiaMoiDem,
                    MoTa = x.MoTa
                })
                .ToListAsync();

            dgvLoaiPhong.DataSource = list;

            if (dgvLoaiPhong.Columns.Contains("MaLoai"))
            {
                dgvLoaiPhong.Columns["MaLoai"].HeaderText = "Mã loại";
                dgvLoaiPhong.Columns["MaLoai"].Width = 80;
            }
            if (dgvLoaiPhong.Columns.Contains("TenLoai"))
            {
                dgvLoaiPhong.Columns["TenLoai"].HeaderText = "Tên loại phòng";
                dgvLoaiPhong.Columns["TenLoai"].Width = 200;
            }
            if (dgvLoaiPhong.Columns.Contains("GiaMoiDem"))
            {
                dgvLoaiPhong.Columns["GiaMoiDem"].HeaderText = "Giá mỗi đêm (VNĐ)";
                dgvLoaiPhong.Columns["GiaMoiDem"].DefaultCellStyle.Format = "N0";
                dgvLoaiPhong.Columns["GiaMoiDem"].Width = 150;
            }
            if (dgvLoaiPhong.Columns.Contains("MoTa"))
            {
                dgvLoaiPhong.Columns["MoTa"].HeaderText = "Mô tả";
                dgvLoaiPhong.Columns["MoTa"].Width = 250;
            }

            dgvLoaiPhong.ClearSelection();
            ClearInputs();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi khi nạp danh sách loại phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            _isBinding = false;
        }
    }

    private void dgvLoaiPhong_SelectionChanged(object sender, EventArgs e)
    {
        if (_isBinding || dgvLoaiPhong.CurrentRow == null || dgvLoaiPhong.CurrentRow.Index < 0)
            return;

        var row = dgvLoaiPhong.CurrentRow;
        txtMaLoai.Text = row.Cells["MaLoai"].Value?.ToString() ?? "";
        txtTenLoai.Text = row.Cells["TenLoai"].Value?.ToString() ?? "";
        txtMoTa.Text = row.Cells["MoTa"].Value?.ToString() ?? "";

        if (row.Cells["GiaMoiDem"].Value != null && decimal.TryParse(row.Cells["GiaMoiDem"].Value.ToString(), out decimal gia))
        {
            numGiaMoiDem.Value = gia;
        }
        else
        {
            numGiaMoiDem.Value = 0;
        }
    }

    private void ClearInputs()
    {
        txtMaLoai.Clear();
        txtTenLoai.Clear();
        txtMoTa.Clear();
        numGiaMoiDem.Value = 0;
    }

    private async void btnThem_Click(object sender, EventArgs e)
    {
        string ten = txtTenLoai.Text.Trim();
        if (string.IsNullOrWhiteSpace(ten))
        {
            MessageBox.Show("Tên loại phòng không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtTenLoai.Focus();
            return;
        }

        try
        {
            bool exists = await _context.LoaiPhongs.AnyAsync(x => x.TenLoai.ToLower() == ten.ToLower());
            if (exists)
            {
                MessageBox.Show("Tên loại phòng đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var lp = new LoaiPhong
            {
                TenLoai = ten,
                GiaMoiDem = numGiaMoiDem.Value,
                MoTa = string.IsNullOrWhiteSpace(txtMoTa.Text) ? null : txtMoTa.Text.Trim()
            };

            _context.LoaiPhongs.Add(lp);
            await _context.SaveChangesAsync();

            MessageBox.Show("Thêm loại phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            await LoadDataAsync();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi khi thêm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnSua_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtMaLoai.Text) || !int.TryParse(txtMaLoai.Text, out int maLoai))
        {
            MessageBox.Show("Vui lòng chọn loại phòng để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        string ten = txtTenLoai.Text.Trim();
        if (string.IsNullOrWhiteSpace(ten))
        {
            MessageBox.Show("Tên loại phòng không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtTenLoai.Focus();
            return;
        }

        try
        {
            bool exists = await _context.LoaiPhongs.AnyAsync(x => x.MaLoai != maLoai && x.TenLoai.ToLower() == ten.ToLower());
            if (exists)
            {
                MessageBox.Show("Tên loại phòng này đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var lp = await _context.LoaiPhongs.FindAsync(maLoai);
            if (lp == null) return;

            lp.TenLoai = ten;
            lp.GiaMoiDem = numGiaMoiDem.Value;
            lp.MoTa = string.IsNullOrWhiteSpace(txtMoTa.Text) ? null : txtMoTa.Text.Trim();

            await _context.SaveChangesAsync();

            MessageBox.Show("Cập nhật loại phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            await LoadDataAsync();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi khi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnXoa_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtMaLoai.Text) || !int.TryParse(txtMaLoai.Text, out int maLoai))
        {
            MessageBox.Show("Vui lòng chọn loại phòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var confirm = MessageBox.Show(
            $"Bạn có chắc chắn muốn xóa loại phòng: \"{txtTenLoai.Text}\"?",
            "Xác nhận xóa",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (confirm != DialogResult.Yes) return;

        try
        {
            var lp = await _context.LoaiPhongs.FindAsync(maLoai);
            if (lp == null) return;

            _context.LoaiPhongs.Remove(lp);
            await _context.SaveChangesAsync();

            MessageBox.Show("Đã xóa loại phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            await LoadDataAsync();
        }
        catch (DbUpdateException)
        {
            MessageBox.Show("Không thể xóa loại phòng này vì đang có các phòng thuộc loại này!", "Lỗi ràng buộc", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnLamMoi_Click(object sender, EventArgs e)
    {
        await LoadDataAsync();
    }

    private void FormLoaiPhong_FormClosing(object sender, FormClosingEventArgs e)
    {
        _context?.Dispose();
    }
}
