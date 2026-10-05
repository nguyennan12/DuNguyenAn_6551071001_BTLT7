using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Cau4_QuanLyLichKham.Models;

namespace Cau4_QuanLyLichKham;

public partial class FormBacSi : Form
{
    private AnKhangClinicContext _context;
    private bool _isBinding = false;

    public FormBacSi()
    {
        InitializeComponent();
        _context = new AnKhangClinicContext();
    }

    private async void FormBacSi_Load(object sender, EventArgs e)
    {
        await LoadDataAsync();
    }

    private async Task LoadDataAsync()
    {
        try
        {
            _isBinding = true;
            var list = await _context.BacSis.AsNoTracking()
                .OrderBy(x => x.MaBs)
                .Select(x => new
                {
                    MaBS = x.MaBs,
                    HoTen = x.HoTen,
                    ChuyenKhoa = x.ChuyenKhoa,
                    SDT = x.Sdt
                })
                .ToListAsync();

            dgvBacSi.DataSource = list;

            if (dgvBacSi.Columns.Contains("MaBS"))
            {
                dgvBacSi.Columns["MaBS"].HeaderText = "Mã BS";
                dgvBacSi.Columns["MaBS"].Width = 80;
            }
            if (dgvBacSi.Columns.Contains("HoTen"))
            {
                dgvBacSi.Columns["HoTen"].HeaderText = "Họ và tên bác sĩ";
                dgvBacSi.Columns["HoTen"].Width = 220;
            }
            if (dgvBacSi.Columns.Contains("ChuyenKhoa"))
            {
                dgvBacSi.Columns["ChuyenKhoa"].HeaderText = "Chuyên khoa";
                dgvBacSi.Columns["ChuyenKhoa"].Width = 200;
            }
            if (dgvBacSi.Columns.Contains("SDT"))
            {
                dgvBacSi.Columns["SDT"].HeaderText = "Số điện thoại";
                dgvBacSi.Columns["SDT"].Width = 140;
            }

            dgvBacSi.ClearSelection();
            ClearInputs();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi khi nạp danh sách bác sĩ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            _isBinding = false;
        }
    }

    private void dgvBacSi_SelectionChanged(object sender, EventArgs e)
    {
        if (_isBinding || dgvBacSi.CurrentRow == null || dgvBacSi.CurrentRow.Index < 0)
            return;

        var row = dgvBacSi.CurrentRow;
        txtMaBS.Text = row.Cells["MaBS"].Value?.ToString() ?? "";
        txtHoTen.Text = row.Cells["HoTen"].Value?.ToString() ?? "";
        txtChuyenKhoa.Text = row.Cells["ChuyenKhoa"].Value?.ToString() ?? "";
        txtSDT.Text = row.Cells["SDT"].Value?.ToString() ?? "";
    }

    private void ClearInputs()
    {
        txtMaBS.Clear();
        txtHoTen.Clear();
        txtChuyenKhoa.Clear();
        txtSDT.Clear();
    }

    private async void btnThem_Click(object sender, EventArgs e)
    {
        string hoTen = txtHoTen.Text.Trim();
        if (string.IsNullOrWhiteSpace(hoTen))
        {
            MessageBox.Show("Họ và tên bác sĩ không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtHoTen.Focus();
            return;
        }

        try
        {
            var bs = new BacSi
            {
                HoTen = hoTen,
                ChuyenKhoa = string.IsNullOrWhiteSpace(txtChuyenKhoa.Text) ? null : txtChuyenKhoa.Text.Trim(),
                Sdt = string.IsNullOrWhiteSpace(txtSDT.Text) ? null : txtSDT.Text.Trim()
            };

            _context.BacSis.Add(bs);
            await _context.SaveChangesAsync();

            MessageBox.Show("Thêm mới bác sĩ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            await LoadDataAsync();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi khi thêm bác sĩ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnSua_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtMaBS.Text) || !int.TryParse(txtMaBS.Text, out int maBS))
        {
            MessageBox.Show("Vui lòng chọn bác sĩ để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        string hoTen = txtHoTen.Text.Trim();
        if (string.IsNullOrWhiteSpace(hoTen))
        {
            MessageBox.Show("Họ và tên bác sĩ không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtHoTen.Focus();
            return;
        }

        try
        {
            var bs = await _context.BacSis.FindAsync(maBS);
            if (bs == null) return;

            bs.HoTen = hoTen;
            bs.ChuyenKhoa = string.IsNullOrWhiteSpace(txtChuyenKhoa.Text) ? null : txtChuyenKhoa.Text.Trim();
            bs.Sdt = string.IsNullOrWhiteSpace(txtSDT.Text) ? null : txtSDT.Text.Trim();

            await _context.SaveChangesAsync();

            MessageBox.Show("Cập nhật thông tin bác sĩ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            await LoadDataAsync();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi khi cập nhật bác sĩ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnXoa_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtMaBS.Text) || !int.TryParse(txtMaBS.Text, out int maBS))
        {
            MessageBox.Show("Vui lòng chọn bác sĩ để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var confirm = MessageBox.Show(
            $"Bạn có chắc chắn muốn xóa bác sĩ: \"{txtHoTen.Text}\"?",
            "Xác nhận xóa bác sĩ",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (confirm != DialogResult.Yes) return;

        try
        {
            var bs = await _context.BacSis.FindAsync(maBS);
            if (bs == null) return;

            _context.BacSis.Remove(bs);
            await _context.SaveChangesAsync();

            MessageBox.Show("Đã xóa bác sĩ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            await LoadDataAsync();
        }
        catch (DbUpdateException)
        {
            MessageBox.Show("Không thể xóa bác sĩ này do đã có lịch khám liên kết!", "Lỗi ràng buộc", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi khi xóa bác sĩ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnLamMoi_Click(object sender, EventArgs e)
    {
        await LoadDataAsync();
    }

    private void FormBacSi_FormClosing(object sender, FormClosingEventArgs e)
    {
        _context?.Dispose();
    }
}
