using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Cau3_QuanLyPhongHomestay.Models;

namespace Cau3_QuanLyPhongHomestay;

public partial class Form1 : Form
{
    private SunriseHomestayContext _context;
    private bool _isBinding = false;
    private readonly string _imagesDirectory;

    public Form1()
    {
        InitializeComponent();
        _context = new SunriseHomestayContext();
        _imagesDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");
        if (!Directory.Exists(_imagesDirectory))
        {
            Directory.CreateDirectory(_imagesDirectory);
        }
    }

    private async void Form1_Load(object sender, EventArgs e)
    {
        await LoadLoaiPhongComboBoxesAsync();
        cboTinhTrang.SelectedIndex = 0;
        cboLocTinhTrang.SelectedIndex = 0;
        await LoadDataAsync();
    }

    private async Task LoadLoaiPhongComboBoxesAsync()
    {
        try
        {
            var loaiPhongs = await _context.LoaiPhongs.AsNoTracking()
                .OrderBy(x => x.MaLoai)
                .Select(x => new { x.MaLoai, x.TenLoai })
                .ToListAsync();

            // ComboBox nhập liệu
            cboLoaiPhong.DataSource = loaiPhongs;
            cboLoaiPhong.DisplayMember = "TenLoai";
            cboLoaiPhong.ValueMember = "MaLoai";

            // ComboBox lọc tìm kiếm (thêm mục Tất cả)
            var locList = loaiPhongs.ToList();
            locList.Insert(0, new { MaLoai = 0, TenLoai = "-- Tất cả loại phòng --" });
            cboLocLoaiPhong.DataSource = locList;
            cboLocLoaiPhong.DisplayMember = "TenLoai";
            cboLocLoaiPhong.ValueMember = "MaLoai";
            cboLocLoaiPhong.SelectedIndex = 0;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi nạp danh sách loại phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async Task LoadDataAsync(int? locMaLoai = null, string? locTinhTrang = null)
    {
        try
        {
            _isBinding = true;

            // Sử dụng LINQ Include(x => x.MaLoaiNavigation) để Eager Load bảng LoaiPhong
            var query = _context.Phongs.AsNoTracking()
                .Include(x => x.MaLoaiNavigation)
                .AsQueryable();

            if (locMaLoai.HasValue && locMaLoai.Value > 0)
            {
                query = query.Where(x => x.MaLoai == locMaLoai.Value);
            }

            if (!string.IsNullOrWhiteSpace(locTinhTrang) && locTinhTrang != "-- Tất cả --")
            {
                query = query.Where(x => x.TinhTrang == locTinhTrang);
            }

            var phongs = await query
                .OrderBy(x => x.MaPhong)
                .ToListAsync();

            // Tạo danh sách ViewModel có ảnh thumbnail để hiển thị trên DataGridView
            var displayList = phongs.Select(p => new
            {
                MaPhong = p.MaPhong,
                SoPhong = p.SoPhong,
                TangSo = p.TangSo,
                TenLoai = p.MaLoaiNavigation != null ? p.MaLoaiNavigation.TenLoai : "Chưa phân loại",
                GiaMoiDem = p.MaLoaiNavigation?.GiaMoiDem,
                TinhTrang = p.TinhTrang,
                HinhAnhThumbnail = LoadThumbnailSafely(p.HinhAnh, 80, 50),
                TenFileHinhAnh = p.HinhAnh,
                MaLoai = p.MaLoai
            }).ToList();

            dgvPhong.DataSource = displayList;

            // Thiết lập cột DataGridView
            if (dgvPhong.Columns.Contains("MaPhong"))
            {
                dgvPhong.Columns["MaPhong"].HeaderText = "Mã";
                dgvPhong.Columns["MaPhong"].Width = 60;
            }
            if (dgvPhong.Columns.Contains("SoPhong"))
            {
                dgvPhong.Columns["SoPhong"].HeaderText = "Số phòng";
                dgvPhong.Columns["SoPhong"].Width = 100;
            }
            if (dgvPhong.Columns.Contains("TangSo"))
            {
                dgvPhong.Columns["TangSo"].HeaderText = "Tầng";
                dgvPhong.Columns["TangSo"].Width = 60;
            }
            if (dgvPhong.Columns.Contains("TenLoai"))
            {
                dgvPhong.Columns["TenLoai"].HeaderText = "Loại phòng";
                dgvPhong.Columns["TenLoai"].Width = 160;
            }
            if (dgvPhong.Columns.Contains("GiaMoiDem"))
            {
                dgvPhong.Columns["GiaMoiDem"].HeaderText = "Giá/đêm (VNĐ)";
                dgvPhong.Columns["GiaMoiDem"].DefaultCellStyle.Format = "N0";
                dgvPhong.Columns["GiaMoiDem"].Width = 120;
            }
            if (dgvPhong.Columns.Contains("TinhTrang"))
            {
                dgvPhong.Columns["TinhTrang"].HeaderText = "Tình trạng";
                dgvPhong.Columns["TinhTrang"].Width = 100;
            }
            if (dgvPhong.Columns.Contains("HinhAnhThumbnail"))
            {
                var imgCol = (DataGridViewImageColumn)dgvPhong.Columns["HinhAnhThumbnail"];
                imgCol.HeaderText = "Hình ảnh";
                imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                imgCol.Width = 110;
            }

            // Ẩn cột kỹ thuật
            if (dgvPhong.Columns.Contains("TenFileHinhAnh")) dgvPhong.Columns["TenFileHinhAnh"].Visible = false;
            if (dgvPhong.Columns.Contains("MaLoai")) dgvPhong.Columns["MaLoai"].Visible = false;

            dgvPhong.ClearSelection();
            ClearInputs();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi khi tải danh sách phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            _isBinding = false;
        }
    }

    private void dgvPhong_SelectionChanged(object sender, EventArgs e)
    {
        if (_isBinding || dgvPhong.CurrentRow == null || dgvPhong.CurrentRow.Index < 0)
            return;

        var row = dgvPhong.CurrentRow;
        txtMaPhong.Text = row.Cells["MaPhong"].Value?.ToString() ?? "";
        txtSoPhong.Text = row.Cells["SoPhong"].Value?.ToString() ?? "";

        if (row.Cells["TangSo"].Value != null && int.TryParse(row.Cells["TangSo"].Value.ToString(), out int tang))
        {
            numTangSo.Value = tang;
        }
        else
        {
            numTangSo.Value = 1;
        }

        if (row.Cells["MaLoai"].Value != null && int.TryParse(row.Cells["MaLoai"].Value.ToString(), out int maLoai))
        {
            cboLoaiPhong.SelectedValue = maLoai;
        }

        string tinhTrang = row.Cells["TinhTrang"].Value?.ToString() ?? "Trống";
        int idx = cboTinhTrang.FindStringExact(tinhTrang);
        cboTinhTrang.SelectedIndex = idx >= 0 ? idx : 0;

        string? tenFile = row.Cells["TenFileHinhAnh"].Value?.ToString();
        txtHinhAnh.Text = tenFile ?? "";

        // Hiển thị hình ảnh phòng trên PictureBox
        ShowImageOnPictureBox(tenFile);
    }

    private void ShowImageOnPictureBox(string? fileName)
    {
        if (picHinhAnh.Image != null)
        {
            var oldImg = picHinhAnh.Image;
            picHinhAnh.Image = null;
            oldImg.Dispose();
        }

        if (string.IsNullOrWhiteSpace(fileName))
            return;

        string fullPath = Path.Combine(_imagesDirectory, fileName);
        if (File.Exists(fullPath))
        {
            try
            {
                // Đọc an toàn qua MemoryStream để không khóa file ảnh
                using var fs = new FileStream(fullPath, FileMode.Open, FileAccess.Read);
                using var ms = new MemoryStream();
                fs.CopyTo(ms);
                ms.Position = 0;
                picHinhAnh.Image = Image.FromStream(ms);
            }
            catch
            {
                picHinhAnh.Image = null;
            }
        }
    }

    private Image? LoadThumbnailSafely(string? fileName, int width, int height)
    {
        if (string.IsNullOrWhiteSpace(fileName)) return null;

        string fullPath = Path.Combine(_imagesDirectory, fileName);
        if (!File.Exists(fullPath)) return null;

        try
        {
            using var fs = new FileStream(fullPath, FileMode.Open, FileAccess.Read);
            using var original = Image.FromStream(fs);
            var thumb = new Bitmap(width, height);
            using (var g = Graphics.FromImage(thumb))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(original, 0, 0, width, height);
            }
            return thumb;
        }
        catch
        {
            return null;
        }
    }

    private void ClearInputs()
    {
        txtMaPhong.Clear();
        txtSoPhong.Clear();
        numTangSo.Value = 1;
        if (cboLoaiPhong.Items.Count > 0) cboLoaiPhong.SelectedIndex = 0;
        if (cboTinhTrang.Items.Count > 0) cboTinhTrang.SelectedIndex = 0;
        txtHinhAnh.Clear();
        if (picHinhAnh.Image != null)
        {
            var old = picHinhAnh.Image;
            picHinhAnh.Image = null;
            old.Dispose();
        }
    }

    private void btnChonAnh_Click(object sender, EventArgs e)
    {
        using var ofd = new OpenFileDialog();
        ofd.Title = "Chọn ảnh phòng";
        ofd.Filter = "Tệp hình ảnh (*.jpg;*.jpeg;*.png;*.bmp;*.webp)|*.jpg;*.jpeg;*.png;*.bmp;*.webp|Tất cả tệp (*.*)|*.*";

        if (ofd.ShowDialog() == DialogResult.OK)
        {
            try
            {
                string sourceFile = ofd.FileName;
                string extension = Path.GetExtension(sourceFile);
                string fileNameOnly = Path.GetFileName(sourceFile);

                // Tạo tên file an toàn nếu cần tránh trùng đè tệp khác
                string destFile = Path.Combine(_imagesDirectory, fileNameOnly);

                // Copy file vào thư mục Images của ứng dụng
                File.Copy(sourceFile, destFile, true);

                // Chỉ lưu tên file (không lưu full path)
                txtHinhAnh.Text = fileNameOnly;
                ShowImageOnPictureBox(fileNameOnly);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải ảnh lên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private async void btnThem_Click(object sender, EventArgs e)
    {
        string soPhong = txtSoPhong.Text.Trim();
        if (string.IsNullOrWhiteSpace(soPhong))
        {
            MessageBox.Show("Vui lòng nhập số phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtSoPhong.Focus();
            return;
        }

        if (cboLoaiPhong.SelectedValue == null)
        {
            MessageBox.Show("Vui lòng chọn loại phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            // Kiểm tra trùng số phòng
            bool exists = await _context.Phongs.AnyAsync(x => x.SoPhong.ToLower() == soPhong.ToLower());
            if (exists)
            {
                MessageBox.Show("Số phòng này đã tồn tại! Vui lòng chọn số phòng khác.", "Trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoPhong.Focus();
                return;
            }

            var p = new Phong
            {
                SoPhong = soPhong,
                TangSo = (int)numTangSo.Value,
                MaLoai = (int)cboLoaiPhong.SelectedValue,
                TinhTrang = cboTinhTrang.SelectedItem?.ToString() ?? "Trống",
                HinhAnh = string.IsNullOrWhiteSpace(txtHinhAnh.Text) ? null : txtHinhAnh.Text.Trim()
            };

            _context.Phongs.Add(p);
            await _context.SaveChangesAsync();

            MessageBox.Show("Thêm mới phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            await LoadDataAsync();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi khi thêm phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnSua_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtMaPhong.Text) || !int.TryParse(txtMaPhong.Text, out int maPhong))
        {
            MessageBox.Show("Vui lòng chọn một phòng trong danh sách để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        string soPhong = txtSoPhong.Text.Trim();
        if (string.IsNullOrWhiteSpace(soPhong))
        {
            MessageBox.Show("Số phòng không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtSoPhong.Focus();
            return;
        }

        try
        {
            // Kiểm tra trùng số phòng với phòng khác
            bool exists = await _context.Phongs.AnyAsync(x => x.MaPhong != maPhong && x.SoPhong.ToLower() == soPhong.ToLower());
            if (exists)
            {
                MessageBox.Show("Số phòng này đã tồn tại trên phòng khác!", "Trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoPhong.Focus();
                return;
            }

            var p = await _context.Phongs.FindAsync(maPhong);
            if (p == null) return;

            p.SoPhong = soPhong;
            p.TangSo = (int)numTangSo.Value;
            p.MaLoai = (int)cboLoaiPhong.SelectedValue;
            p.TinhTrang = cboTinhTrang.SelectedItem?.ToString() ?? "Trống";
            p.HinhAnh = string.IsNullOrWhiteSpace(txtHinhAnh.Text) ? null : txtHinhAnh.Text.Trim();

            await _context.SaveChangesAsync();

            MessageBox.Show("Cập nhật thông tin phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            await LoadDataAsync();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi khi cập nhật phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnXoa_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtMaPhong.Text) || !int.TryParse(txtMaPhong.Text, out int maPhong))
        {
            MessageBox.Show("Vui lòng chọn một phòng trong danh sách để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var confirm = MessageBox.Show(
            $"Bạn có chắc chắn muốn xóa phòng: \"{txtSoPhong.Text}\"?",
            "Xác nhận xóa phòng",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (confirm != DialogResult.Yes) return;

        try
        {
            var p = await _context.Phongs.FindAsync(maPhong);
            if (p == null) return;

            _context.Phongs.Remove(p);
            await _context.SaveChangesAsync();

            MessageBox.Show("Đã xóa phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            await LoadDataAsync();
        }
        catch (DbUpdateException)
        {
            MessageBox.Show("Không thể xóa phòng này do có ràng buộc dữ liệu!", "Lỗi ràng buộc", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi khi xóa phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnLamMoi_Click(object sender, EventArgs e)
    {
        cboLocLoaiPhong.SelectedIndex = 0;
        cboLocTinhTrang.SelectedIndex = 0;
        await LoadDataAsync();
    }

    private async void btnTimKiem_Click(object sender, EventArgs e)
    {
        int? locMaLoai = cboLocLoaiPhong.SelectedValue is int ml ? ml : (int?)null;
        string? locTinhTrang = cboLocTinhTrang.SelectedItem?.ToString();
        await LoadDataAsync(locMaLoai, locTinhTrang);
    }

    private async void btnHienTatCa_Click(object sender, EventArgs e)
    {
        cboLocLoaiPhong.SelectedIndex = 0;
        cboLocTinhTrang.SelectedIndex = 0;
        await LoadDataAsync();
    }

    private async void btnQuanLyLoaiPhong_Click(object sender, EventArgs e)
    {
        using var frm = new FormLoaiPhong();
        frm.ShowDialog();

        // Sau khi đóng FormLoaiPhong, cập nhật lại ComboBox Loại phòng và nạp lại grid
        await LoadLoaiPhongComboBoxesAsync();
        await LoadDataAsync();
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (picHinhAnh.Image != null)
        {
            picHinhAnh.Image.Dispose();
            picHinhAnh.Image = null;
        }
        _context?.Dispose();
    }
}
