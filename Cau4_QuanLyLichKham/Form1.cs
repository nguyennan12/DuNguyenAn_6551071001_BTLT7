using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Cau4_QuanLyLichKham.Models;

namespace Cau4_QuanLyLichKham;

public partial class Form1 : Form
{
    private AnKhangClinicContext _context;
    private bool _isBinding = false;

    public Form1()
    {
        InitializeComponent();
        _context = new AnKhangClinicContext();
    }

    private async void Form1_Load(object sender, EventArgs e)
    {
        dtpTuNgay.Value = DateTime.Today.AddDays(-7);
        dtpDenNgay.Value = DateTime.Today.AddDays(14);
        dtpNgayKham.Value = DateTime.Today;
        dtpGioKham.Value = DateTime.Today.AddHours(8).AddMinutes(0);
        cboTrangThai.SelectedIndex = 0; // Chờ khám

        await LoadBacSiComboBoxesAsync();
        await LoadDataAsync();
    }

    private async Task LoadBacSiComboBoxesAsync()
    {
        try
        {
            var bacSis = await _context.BacSis.AsNoTracking()
                .OrderBy(x => x.MaBs)
                .Select(x => new
                {
                    MaBS = x.MaBs,
                    DisplayName = x.HoTen + " - " + (x.ChuyenKhoa ?? "Đa khoa")
                })
                .ToListAsync();

            // ComboBox nhập liệu
            cboBacSi.DataSource = bacSis;
            cboBacSi.DisplayMember = "DisplayName";
            cboBacSi.ValueMember = "MaBS";

            // ComboBox lọc
            var locList = bacSis.ToList();
            locList.Insert(0, new { MaBS = 0, DisplayName = "-- Tất cả bác sĩ --" });
            cboLocBacSi.DataSource = locList;
            cboLocBacSi.DisplayMember = "DisplayName";
            cboLocBacSi.ValueMember = "MaBS";
            cboLocBacSi.SelectedIndex = 0;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi nạp danh sách bác sĩ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async Task LoadDataAsync(DateOnly? tuNgay = null, DateOnly? denNgay = null, int? maBS = null)
    {
        try
        {
            _isBinding = true;

            // Sử dụng LINQ Include(x => x.MaBsNavigation) để JOIN lấy thông tin bác sĩ
            var query = _context.LichKhams.AsNoTracking()
                .Include(x => x.MaBsNavigation)
                .AsQueryable();

            // Lọc theo khoảng ngày khám
            if (tuNgay.HasValue)
            {
                query = query.Where(x => x.NgayKham >= tuNgay.Value);
            }

            if (denNgay.HasValue)
            {
                query = query.Where(x => x.NgayKham <= denNgay.Value);
            }

            // Lọc theo bác sĩ
            if (maBS.HasValue && maBS.Value > 0)
            {
                query = query.Where(x => x.MaBs == maBS.Value);
            }

            var list = await query
                .OrderBy(x => x.NgayKham)
                .ThenBy(x => x.GioKham)
                .Select(x => new
                {
                    MaLich = x.MaLich,
                    TenBenhNhan = x.TenBenhNhan,
                    SDT = x.Sdt,
                    NgayKham = x.NgayKham.HasValue ? x.NgayKham.Value.ToString("dd/MM/yyyy") : "",
                    NgayKhamRaw = x.NgayKham,
                    GioKham = x.GioKham,
                    BacSi = x.MaBsNavigation != null ? x.MaBsNavigation.HoTen : "Chưa chỉ định",
                    ChuyenKhoa = x.MaBsNavigation != null ? x.MaBsNavigation.ChuyenKhoa : "",
                    TrangThai = x.TrangThai,
                    MaBS = x.MaBs
                })
                .ToListAsync();

            dgvLichKham.DataSource = list;

            // Đặt tên cột tiếng Việt
            if (dgvLichKham.Columns.Contains("MaLich"))
            {
                dgvLichKham.Columns["MaLich"].HeaderText = "Mã lịch";
                dgvLichKham.Columns["MaLich"].Width = 70;
            }
            if (dgvLichKham.Columns.Contains("TenBenhNhan"))
            {
                dgvLichKham.Columns["TenBenhNhan"].HeaderText = "Tên bệnh nhân";
                dgvLichKham.Columns["TenBenhNhan"].Width = 170;
            }
            if (dgvLichKham.Columns.Contains("SDT"))
            {
                dgvLichKham.Columns["SDT"].HeaderText = "Số ĐT";
                dgvLichKham.Columns["SDT"].Width = 110;
            }
            if (dgvLichKham.Columns.Contains("NgayKham"))
            {
                dgvLichKham.Columns["NgayKham"].HeaderText = "Ngày khám";
                dgvLichKham.Columns["NgayKham"].Width = 100;
            }
            if (dgvLichKham.Columns.Contains("GioKham"))
            {
                dgvLichKham.Columns["GioKham"].HeaderText = "Giờ khám";
                dgvLichKham.Columns["GioKham"].Width = 90;
            }
            if (dgvLichKham.Columns.Contains("BacSi"))
            {
                dgvLichKham.Columns["BacSi"].HeaderText = "Bác sĩ phụ trách";
                dgvLichKham.Columns["BacSi"].Width = 170;
            }
            if (dgvLichKham.Columns.Contains("ChuyenKhoa"))
            {
                dgvLichKham.Columns["ChuyenKhoa"].HeaderText = "Chuyên khoa";
                dgvLichKham.Columns["ChuyenKhoa"].Width = 140;
            }
            if (dgvLichKham.Columns.Contains("TrangThai"))
            {
                dgvLichKham.Columns["TrangThai"].HeaderText = "Trạng thái";
                dgvLichKham.Columns["TrangThai"].Width = 110;
            }

            // Ẩn cột kỹ thuật
            if (dgvLichKham.Columns.Contains("NgayKhamRaw")) dgvLichKham.Columns["NgayKhamRaw"].Visible = false;
            if (dgvLichKham.Columns.Contains("MaBS")) dgvLichKham.Columns["MaBS"].Visible = false;

            dgvLichKham.ClearSelection();
            ClearInputs();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi khi tải dữ liệu lịch khám: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            _isBinding = false;
        }
    }

    private void dgvLichKham_SelectionChanged(object sender, EventArgs e)
    {
        if (_isBinding || dgvLichKham.CurrentRow == null || dgvLichKham.CurrentRow.Index < 0)
            return;

        var row = dgvLichKham.CurrentRow;
        txtMaLich.Text = row.Cells["MaLich"].Value?.ToString() ?? "";
        txtTenBenhNhan.Text = row.Cells["TenBenhNhan"].Value?.ToString() ?? "";
        txtSDT.Text = row.Cells["SDT"].Value?.ToString() ?? "";

        // Ngày khám
        var nkVal = row.Cells["NgayKhamRaw"].Value;
        if (nkVal is DateOnly dOnly)
        {
            dtpNgayKham.Value = dOnly.ToDateTime(TimeOnly.MinValue);
        }
        else if (DateTime.TryParse(row.Cells["NgayKham"].Value?.ToString(), out DateTime dt))
        {
            dtpNgayKham.Value = dt;
        }

        // Giờ khám
        string gio = row.Cells["GioKham"].Value?.ToString() ?? "";
        if (TimeOnly.TryParse(gio, out TimeOnly tOnly))
        {
            dtpGioKham.Value = DateTime.Today.Add(tOnly.ToTimeSpan());
        }

        // Bác sĩ
        if (row.Cells["MaBS"].Value != null && int.TryParse(row.Cells["MaBS"].Value.ToString(), out int maBS))
        {
            cboBacSi.SelectedValue = maBS;
        }

        // Trạng thái
        string trangThai = row.Cells["TrangThai"].Value?.ToString() ?? "Chờ khám";
        int idx = cboTrangThai.FindStringExact(trangThai);
        cboTrangThai.SelectedIndex = idx >= 0 ? idx : 0;
    }

    private void ClearInputs()
    {
        txtMaLich.Clear();
        txtTenBenhNhan.Clear();
        txtSDT.Clear();
        dtpNgayKham.Value = DateTime.Today;
        dtpGioKham.Value = DateTime.Today.AddHours(8);
        if (cboBacSi.Items.Count > 0) cboBacSi.SelectedIndex = 0;
        if (cboTrangThai.Items.Count > 0) cboTrangThai.SelectedIndex = 0;
    }

    private bool ValidateInput(bool isCreatingNew)
    {
        // 1. Tên bệnh nhân
        if (string.IsNullOrWhiteSpace(txtTenBenhNhan.Text))
        {
            MessageBox.Show("Vui lòng nhập tên bệnh nhân!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtTenBenhNhan.Focus();
            return false;
        }

        // 2. Số điện thoại
        if (string.IsNullOrWhiteSpace(txtSDT.Text))
        {
            MessageBox.Show("Vui lòng nhập số điện thoại bệnh nhân!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtSDT.Focus();
            return false;
        }

        // 3. Bác sĩ
        if (cboBacSi.SelectedValue == null)
        {
            MessageBox.Show("Vui lòng chọn bác sĩ khám!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            cboBacSi.Focus();
            return false;
        }

        // 4. Validate ngày trong quá khứ
        if (dtpNgayKham.Value.Date < DateTime.Today)
        {
            MessageBox.Show("Không thể đặt lịch khám vào ngày trong quá khứ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dtpNgayKham.Focus();
            return false;
        }

        return true;
    }

    private async void btnThem_Click(object sender, EventArgs e)
    {
        if (!ValidateInput(true)) return;

        try
        {
            var lich = new LichKham
            {
                TenBenhNhan = txtTenBenhNhan.Text.Trim(),
                Sdt = txtSDT.Text.Trim(),
                NgayKham = DateOnly.FromDateTime(dtpNgayKham.Value),
                GioKham = dtpGioKham.Value.ToString("HH:mm"),
                MaBs = (int)cboBacSi.SelectedValue,
                TrangThai = cboTrangThai.SelectedItem?.ToString() ?? "Chờ khám"
            };

            _context.LichKhams.Add(lich);
            await _context.SaveChangesAsync();

            MessageBox.Show("Đặt lịch khám mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            await LoadDataAsync();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi khi thêm lịch khám: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnSua_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtMaLich.Text) || !int.TryParse(txtMaLich.Text, out int maLich))
        {
            MessageBox.Show("Vui lòng chọn một lịch khám trong danh sách để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (!ValidateInput(false)) return;

        try
        {
            var lich = await _context.LichKhams.FindAsync(maLich);
            if (lich == null) return;

            lich.TenBenhNhan = txtTenBenhNhan.Text.Trim();
            lich.Sdt = txtSDT.Text.Trim();
            lich.NgayKham = DateOnly.FromDateTime(dtpNgayKham.Value);
            lich.GioKham = dtpGioKham.Value.ToString("HH:mm");
            lich.MaBs = (int)cboBacSi.SelectedValue;
            lich.TrangThai = cboTrangThai.SelectedItem?.ToString() ?? "Chờ khám";

            await _context.SaveChangesAsync();

            MessageBox.Show("Cập nhật lịch khám thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            await LoadDataAsync();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi khi cập nhật lịch khám: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnXoa_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtMaLich.Text) || !int.TryParse(txtMaLich.Text, out int maLich))
        {
            MessageBox.Show("Vui lòng chọn một lịch khám trong danh sách để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var confirm = MessageBox.Show(
            $"Bạn có chắc chắn muốn xóa lịch khám của bệnh nhân: \"{txtTenBenhNhan.Text}\"?",
            "Xác nhận xóa lịch khám",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (confirm != DialogResult.Yes) return;

        try
        {
            var lich = await _context.LichKhams.FindAsync(maLich);
            if (lich == null) return;

            _context.LichKhams.Remove(lich);
            await _context.SaveChangesAsync();

            MessageBox.Show("Đã xóa lịch khám thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            await LoadDataAsync();
        }
        catch (DbUpdateException)
        {
            MessageBox.Show("Không thể xóa lịch khám do có ràng buộc dữ liệu!", "Lỗi ràng buộc", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi khi xóa lịch khám: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnLamMoi_Click(object sender, EventArgs e)
    {
        dtpTuNgay.Value = DateTime.Today.AddDays(-7);
        dtpDenNgay.Value = DateTime.Today.AddDays(14);
        cboLocBacSi.SelectedIndex = 0;
        await LoadDataAsync();
    }

    private async void btnTimKiem_Click(object sender, EventArgs e)
    {
        if (dtpTuNgay.Value.Date > dtpDenNgay.Value.Date)
        {
            MessageBox.Show("Thời gian 'Từ ngày' không được lớn hơn 'Đến ngày'!", "Lỗi tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var tuNgay = DateOnly.FromDateTime(dtpTuNgay.Value);
        var denNgay = DateOnly.FromDateTime(dtpDenNgay.Value);
        int? maBS = cboLocBacSi.SelectedValue is int bsId ? bsId : (int?)null;

        await LoadDataAsync(tuNgay, denNgay, maBS);
    }

    private async void btnHienTatCa_Click(object sender, EventArgs e)
    {
        dtpTuNgay.Value = DateTime.Today.AddDays(-7);
        dtpDenNgay.Value = DateTime.Today.AddDays(14);
        cboLocBacSi.SelectedIndex = 0;
        await LoadDataAsync();
    }

    private async void btnQuanLyBacSi_Click(object sender, EventArgs e)
    {
        using var frm = new FormBacSi();
        frm.ShowDialog();

        // Sau khi quản lý bác sĩ, nạp lại ComboBox và lưới dữ liệu
        await LoadBacSiComboBoxesAsync();
        await LoadDataAsync();
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        _context?.Dispose();
    }
}
