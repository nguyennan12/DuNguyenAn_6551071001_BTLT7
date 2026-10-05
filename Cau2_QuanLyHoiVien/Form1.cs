using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Cau2_QuanLyHoiVien.Models;

namespace Cau2_QuanLyHoiVien;

public partial class Form1 : Form
{
    private FitZoneContext _context;
    private bool _isBinding = false;

    public Form1()
    {
        InitializeComponent();
        _context = new FitZoneContext();
    }

    private async void Form1_Load(object sender, EventArgs e)
    {
        cboHangThanhVien.SelectedIndex = 0; // Default Basic
        cboLocHang.SelectedIndex = 0;        // Default -- Tất cả --
        dtpNgaySinh.Value = DateTime.Today.AddYears(-20); // Default 20 tuổi
        await LoadDataAsync();
    }

    private async Task LoadDataAsync(string? searchName = null, string? searchHang = null)
    {
        try
        {
            _isBinding = true;

            var query = _context.HoiViens.AsNoTracking().AsQueryable();

            // Tìm kiếm kết hợp dùng LINQ Where với toán tử &&
            if (!string.IsNullOrWhiteSpace(searchName) && !string.IsNullOrWhiteSpace(searchHang) && searchHang != "-- Tất cả --")
            {
                query = query.Where(x => x.HoTen.Contains(searchName) && x.HangThanhVien == searchHang);
            }
            else if (!string.IsNullOrWhiteSpace(searchName))
            {
                query = query.Where(x => x.HoTen.Contains(searchName));
            }
            else if (!string.IsNullOrWhiteSpace(searchHang) && searchHang != "-- Tất cả --")
            {
                query = query.Where(x => x.HangThanhVien == searchHang);
            }

            var list = await query
                .OrderBy(x => x.MaHv)
                .Select(x => new
                {
                    MaHV = x.MaHv,
                    HoTen = x.HoTen,
                    GioiTinh = x.GioiTinh == true ? "Nam" : "Nữ",
                    GioiTinhRaw = x.GioiTinh,
                    NgaySinh = x.NgaySinh.HasValue ? x.NgaySinh.Value.ToString("dd/MM/yyyy") : "",
                    NgaySinhRaw = x.NgaySinh,
                    SDT = x.Sdt,
                    Email = x.Email,
                    HangThanhVien = x.HangThanhVien,
                    NgayDangKy = x.NgayDangKy,
                    TrangThai = x.TrangThai == true ? "Đang hoạt động" : "Tạm ngưng",
                    TrangThaiRaw = x.TrangThai
                })
                .ToListAsync();

            dgvHoiVien.DataSource = list;

            // Đặt tên cột tiếng Việt
            if (dgvHoiVien.Columns.Contains("MaHV"))
            {
                dgvHoiVien.Columns["MaHV"].HeaderText = "Mã HV";
                dgvHoiVien.Columns["MaHV"].Width = 70;
            }
            if (dgvHoiVien.Columns.Contains("HoTen"))
            {
                dgvHoiVien.Columns["HoTen"].HeaderText = "Họ và tên";
                dgvHoiVien.Columns["HoTen"].Width = 160;
            }
            if (dgvHoiVien.Columns.Contains("GioiTinh"))
            {
                dgvHoiVien.Columns["GioiTinh"].HeaderText = "Giới tính";
                dgvHoiVien.Columns["GioiTinh"].Width = 80;
            }
            if (dgvHoiVien.Columns.Contains("NgaySinh"))
            {
                dgvHoiVien.Columns["NgaySinh"].HeaderText = "Ngày sinh";
                dgvHoiVien.Columns["NgaySinh"].Width = 95;
            }
            if (dgvHoiVien.Columns.Contains("SDT"))
            {
                dgvHoiVien.Columns["SDT"].HeaderText = "Số ĐT";
                dgvHoiVien.Columns["SDT"].Width = 100;
            }
            if (dgvHoiVien.Columns.Contains("Email"))
            {
                dgvHoiVien.Columns["Email"].HeaderText = "Email";
                dgvHoiVien.Columns["Email"].Width = 160;
            }
            if (dgvHoiVien.Columns.Contains("HangThanhVien"))
            {
                dgvHoiVien.Columns["HangThanhVien"].HeaderText = "Hạng TV";
                dgvHoiVien.Columns["HangThanhVien"].Width = 90;
            }
            if (dgvHoiVien.Columns.Contains("NgayDangKy"))
            {
                dgvHoiVien.Columns["NgayDangKy"].HeaderText = "Ngày ĐK";
                dgvHoiVien.Columns["NgayDangKy"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvHoiVien.Columns["NgayDangKy"].Width = 95;
            }
            if (dgvHoiVien.Columns.Contains("TrangThai"))
            {
                dgvHoiVien.Columns["TrangThai"].HeaderText = "Trạng thái";
                dgvHoiVien.Columns["TrangThai"].Width = 120;
            }

            // Ẩn các cột dữ liệu raw
            if (dgvHoiVien.Columns.Contains("GioiTinhRaw")) dgvHoiVien.Columns["GioiTinhRaw"].Visible = false;
            if (dgvHoiVien.Columns.Contains("NgaySinhRaw")) dgvHoiVien.Columns["NgaySinhRaw"].Visible = false;
            if (dgvHoiVien.Columns.Contains("TrangThaiRaw")) dgvHoiVien.Columns["TrangThaiRaw"].Visible = false;

            dgvHoiVien.ClearSelection();
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

    private void dgvHoiVien_SelectionChanged(object sender, EventArgs e)
    {
        if (_isBinding || dgvHoiVien.CurrentRow == null || dgvHoiVien.CurrentRow.Index < 0)
            return;

        var row = dgvHoiVien.CurrentRow;
        txtMaHV.Text = row.Cells["MaHV"].Value?.ToString() ?? "";
        txtHoTen.Text = row.Cells["HoTen"].Value?.ToString() ?? "";
        txtSDT.Text = row.Cells["SDT"].Value?.ToString() ?? "";
        txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";

        // Giới tính (RadioButton)
        var gtValue = row.Cells["GioiTinhRaw"].Value;
        if (gtValue is bool gt)
        {
            rdoNam.Checked = gt;
            rdoNu.Checked = !gt;
        }
        else
        {
            rdoNam.Checked = true;
        }

        // Ngày sinh (DateTimePicker)
        var nsValue = row.Cells["NgaySinhRaw"].Value;
        if (nsValue is DateOnly dOnly)
        {
            dtpNgaySinh.Value = dOnly.ToDateTime(TimeOnly.MinValue);
        }
        else if (DateTime.TryParse(row.Cells["NgaySinh"].Value?.ToString(), out DateTime dt))
        {
            dtpNgaySinh.Value = dt;
        }

        // Hạng thành viên (ComboBox)
        string hang = row.Cells["HangThanhVien"].Value?.ToString() ?? "Basic";
        int index = cboHangThanhVien.FindStringExact(hang);
        cboHangThanhVien.SelectedIndex = index >= 0 ? index : 0;

        // Trạng thái (CheckBox)
        var ttValue = row.Cells["TrangThaiRaw"].Value;
        chkTrangThai.Checked = ttValue is bool tt && tt;

        // Ngày đăng ký
        if (row.Cells["NgayDangKy"].Value != null && DateTime.TryParse(row.Cells["NgayDangKy"].Value.ToString(), out DateTime ngayDK))
        {
            lblNgayDangKyValue.Text = ngayDK.ToString("dd/MM/yyyy HH:mm");
        }
        else
        {
            lblNgayDangKyValue.Text = "---";
        }
    }

    private void ClearInputs()
    {
        txtMaHV.Clear();
        txtHoTen.Clear();
        txtSDT.Clear();
        txtEmail.Clear();
        rdoNam.Checked = true;
        dtpNgaySinh.Value = DateTime.Today.AddYears(-20);
        cboHangThanhVien.SelectedIndex = 0;
        chkTrangThai.Checked = true;
        lblNgayDangKyValue.Text = "---";
    }

    private bool ValidateInput()
    {
        // 1. Kiểm tra Họ tên
        string hoTen = txtHoTen.Text.Trim();
        if (string.IsNullOrWhiteSpace(hoTen))
        {
            MessageBox.Show("Họ và tên không được để trống!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtHoTen.Focus();
            return false;
        }

        // 2. Kiểm tra Số điện thoại (chỉ chứa chữ số và 9-11 ký tự)
        string sdt = txtSDT.Text.Trim();
        if (string.IsNullOrWhiteSpace(sdt))
        {
            MessageBox.Show("Số điện thoại không được để trống!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtSDT.Focus();
            return false;
        }
        if (!Regex.IsMatch(sdt, @"^[0-9]{9,11}$"))
        {
            MessageBox.Show("Số điện thoại phải chỉ chứa chữ số và có độ dài từ 9 đến 11 chữ số!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtSDT.Focus();
            return false;
        }

        // 3. Kiểm tra Email (phải chứa '@')
        string email = txtEmail.Text.Trim();
        if (string.IsNullOrWhiteSpace(email))
        {
            MessageBox.Show("Email không được để trống!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtEmail.Focus();
            return false;
        }
        if (!email.Contains('@') || !email.Contains('.'))
        {
            MessageBox.Show("Email không hợp lệ (phải chứa ký tự '@' và tên miền hợp lệ)!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtEmail.Focus();
            return false;
        }

        // 4. Kiểm tra Tuổi hội viên (>= 15 tuổi)
        DateTime birthDate = dtpNgaySinh.Value.Date;
        DateTime today = DateTime.Today;
        int age = today.Year - birthDate.Year;
        if (birthDate > today.AddYears(-age)) age--;

        if (age < 15)
        {
            MessageBox.Show($"Hội viên phải từ 15 tuổi trở lên mới được đăng ký! (Tuổi hiện tại: {age} tuổi)", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dtpNgaySinh.Focus();
            return false;
        }

        // 5. Kiểm tra Hạng thành viên
        if (cboHangThanhVien.SelectedIndex < 0)
        {
            MessageBox.Show("Vui lòng chọn Hạng thành viên!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            cboHangThanhVien.Focus();
            return false;
        }

        return true;
    }

    private async void btnThem_Click(object sender, EventArgs e)
    {
        if (!ValidateInput()) return;

        try
        {
            var hv = new HoiVien
            {
                HoTen = txtHoTen.Text.Trim(),
                GioiTinh = rdoNam.Checked,
                NgaySinh = DateOnly.FromDateTime(dtpNgaySinh.Value),
                Sdt = txtSDT.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                HangThanhVien = cboHangThanhVien.SelectedItem?.ToString() ?? "Basic",
                NgayDangKy = DateTime.Now,
                TrangThai = chkTrangThai.Checked
            };

            _context.HoiViens.Add(hv);
            await _context.SaveChangesAsync();

            MessageBox.Show("Thêm mới hội viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            await LoadDataAsync();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi khi thêm hội viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnSua_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtMaHV.Text) || !int.TryParse(txtMaHV.Text, out int maHV))
        {
            MessageBox.Show("Vui lòng chọn một hội viên trong danh sách để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (!ValidateInput()) return;

        try
        {
            var hv = await _context.HoiViens.FindAsync(maHV);
            if (hv == null)
            {
                MessageBox.Show("Không tìm thấy hội viên cần cập nhật!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            hv.HoTen = txtHoTen.Text.Trim();
            hv.GioiTinh = rdoNam.Checked;
            hv.NgaySinh = DateOnly.FromDateTime(dtpNgaySinh.Value);
            hv.Sdt = txtSDT.Text.Trim();
            hv.Email = txtEmail.Text.Trim();
            hv.HangThanhVien = cboHangThanhVien.SelectedItem?.ToString() ?? "Basic";
            hv.TrangThai = chkTrangThai.Checked;

            await _context.SaveChangesAsync();

            MessageBox.Show("Cập nhật thông tin hội viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            await LoadDataAsync();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi khi cập nhật hội viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnXoa_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtMaHV.Text) || !int.TryParse(txtMaHV.Text, out int maHV))
        {
            MessageBox.Show("Vui lòng chọn một hội viên trong danh sách để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var confirm = MessageBox.Show(
            $"Bạn có chắc chắn muốn xóa hội viên: \"{txtHoTen.Text}\" (Mã HV: {maHV})?",
            "Xác nhận xóa hội viên",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (confirm != DialogResult.Yes) return;

        try
        {
            var hv = await _context.HoiViens.FindAsync(maHV);
            if (hv == null)
            {
                MessageBox.Show("Không tìm thấy hội viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _context.HoiViens.Remove(hv);
            await _context.SaveChangesAsync();

            MessageBox.Show("Đã xóa hội viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            await LoadDataAsync();
        }
        catch (DbUpdateException)
        {
            MessageBox.Show("Không thể xóa hội viên này do có ràng buộc dữ liệu!", "Lỗi ràng buộc", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi khi xóa hội viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnLamMoi_Click(object sender, EventArgs e)
    {
        txtTimTen.Clear();
        cboLocHang.SelectedIndex = 0;
        await LoadDataAsync();
    }

    private async void btnTimKiem_Click(object sender, EventArgs e)
    {
        string ten = txtTimTen.Text.Trim();
        string hang = cboLocHang.SelectedItem?.ToString() ?? "-- Tất cả --";
        await LoadDataAsync(ten, hang);
    }

    private void txtTimTen_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            e.SuppressKeyPress = true;
            btnTimKiem.PerformClick();
        }
    }

    private async void btnHienTatCa_Click(object sender, EventArgs e)
    {
        txtTimTen.Clear();
        cboLocHang.SelectedIndex = 0;
        await LoadDataAsync();
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        _context?.Dispose();
    }
}
