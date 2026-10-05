namespace Cau2_QuanLyHoiVien;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        this.lblTieuDe = new System.Windows.Forms.Label();
        this.grpThongTin = new System.Windows.Forms.GroupBox();
        this.lblMaHV = new System.Windows.Forms.Label();
        this.txtMaHV = new System.Windows.Forms.TextBox();
        this.lblHoTen = new System.Windows.Forms.Label();
        this.txtHoTen = new System.Windows.Forms.TextBox();
        this.grpGioiTinh = new System.Windows.Forms.GroupBox();
        this.rdoNam = new System.Windows.Forms.RadioButton();
        this.rdoNu = new System.Windows.Forms.RadioButton();
        this.lblNgaySinh = new System.Windows.Forms.Label();
        this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
        this.lblSDT = new System.Windows.Forms.Label();
        this.txtSDT = new System.Windows.Forms.TextBox();
        this.lblEmail = new System.Windows.Forms.Label();
        this.txtEmail = new System.Windows.Forms.TextBox();
        this.lblHangThanhVien = new System.Windows.Forms.Label();
        this.cboHangThanhVien = new System.Windows.Forms.ComboBox();
        this.chkTrangThai = new System.Windows.Forms.CheckBox();
        this.lblNgayDangKy = new System.Windows.Forms.Label();
        this.lblNgayDangKyValue = new System.Windows.Forms.Label();
        this.btnThem = new System.Windows.Forms.Button();
        this.btnSua = new System.Windows.Forms.Button();
        this.btnXoa = new System.Windows.Forms.Button();
        this.btnLamMoi = new System.Windows.Forms.Button();
        this.grpTimKiem = new System.Windows.Forms.GroupBox();
        this.lblTimTen = new System.Windows.Forms.Label();
        this.txtTimTen = new System.Windows.Forms.TextBox();
        this.lblLocHang = new System.Windows.Forms.Label();
        this.cboLocHang = new System.Windows.Forms.ComboBox();
        this.btnTimKiem = new System.Windows.Forms.Button();
        this.btnHienTatCa = new System.Windows.Forms.Button();
        this.grpDanhSach = new System.Windows.Forms.GroupBox();
        this.dgvHoiVien = new System.Windows.Forms.DataGridView();

        this.grpThongTin.SuspendLayout();
        this.grpGioiTinh.SuspendLayout();
        this.grpTimKiem.SuspendLayout();
        this.grpDanhSach.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvHoiVien)).BeginInit();
        this.SuspendLayout();

        // lblTieuDe
        this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
        this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblTieuDe.ForeColor = System.Drawing.Color.DarkSlateGray;
        this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
        this.lblTieuDe.Name = "lblTieuDe";
        this.lblTieuDe.Size = new System.Drawing.Size(980, 50);
        this.lblTieuDe.TabIndex = 0;
        this.lblTieuDe.Text = "QUẢN LÝ HỘI VIÊN - PHÒNG TẬP FITZONE";
        this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        // grpThongTin
        this.grpThongTin.Controls.Add(this.lblMaHV);
        this.grpThongTin.Controls.Add(this.txtMaHV);
        this.grpThongTin.Controls.Add(this.lblHoTen);
        this.grpThongTin.Controls.Add(this.txtHoTen);
        this.grpThongTin.Controls.Add(this.grpGioiTinh);
        this.grpThongTin.Controls.Add(this.lblNgaySinh);
        this.grpThongTin.Controls.Add(this.dtpNgaySinh);
        this.grpThongTin.Controls.Add(this.lblSDT);
        this.grpThongTin.Controls.Add(this.txtSDT);
        this.grpThongTin.Controls.Add(this.lblEmail);
        this.grpThongTin.Controls.Add(this.txtEmail);
        this.grpThongTin.Controls.Add(this.lblHangThanhVien);
        this.grpThongTin.Controls.Add(this.cboHangThanhVien);
        this.grpThongTin.Controls.Add(this.chkTrangThai);
        this.grpThongTin.Controls.Add(this.lblNgayDangKy);
        this.grpThongTin.Controls.Add(this.lblNgayDangKyValue);
        this.grpThongTin.Controls.Add(this.btnThem);
        this.grpThongTin.Controls.Add(this.btnSua);
        this.grpThongTin.Controls.Add(this.btnXoa);
        this.grpThongTin.Controls.Add(this.btnLamMoi);
        this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.grpThongTin.Location = new System.Drawing.Point(16, 52);
        this.grpThongTin.Name = "grpThongTin";
        this.grpThongTin.Size = new System.Drawing.Size(948, 220);
        this.grpThongTin.TabIndex = 1;
        this.grpThongTin.TabStop = false;
        this.grpThongTin.Text = "Thông tin hội viên";

        // lblMaHV
        this.lblMaHV.AutoSize = true;
        this.lblMaHV.Location = new System.Drawing.Point(20, 30);
        this.lblMaHV.Name = "lblMaHV";
        this.lblMaHV.Size = new System.Drawing.Size(84, 17);
        this.lblMaHV.Text = "Mã hội viên:";

        // txtMaHV
        this.txtMaHV.Location = new System.Drawing.Point(120, 27);
        this.txtMaHV.Name = "txtMaHV";
        this.txtMaHV.ReadOnly = true;
        this.txtMaHV.Size = new System.Drawing.Size(120, 24);
        this.txtMaHV.TabIndex = 0;

        // lblHoTen
        this.lblHoTen.AutoSize = true;
        this.lblHoTen.Location = new System.Drawing.Point(260, 30);
        this.lblHoTen.Name = "lblHoTen";
        this.lblHoTen.Size = new System.Drawing.Size(66, 17);
        this.lblHoTen.Text = "Họ và tên:";

        // txtHoTen
        this.txtHoTen.Location = new System.Drawing.Point(340, 27);
        this.txtHoTen.Name = "txtHoTen";
        this.txtHoTen.Size = new System.Drawing.Size(240, 24);
        this.txtHoTen.TabIndex = 1;

        // grpGioiTinh
        this.grpGioiTinh.Controls.Add(this.rdoNam);
        this.grpGioiTinh.Controls.Add(this.rdoNu);
        this.grpGioiTinh.Location = new System.Drawing.Point(600, 16);
        this.grpGioiTinh.Name = "grpGioiTinh";
        this.grpGioiTinh.Size = new System.Drawing.Size(180, 42);
        this.grpGioiTinh.TabIndex = 2;
        this.grpGioiTinh.TabStop = false;
        this.grpGioiTinh.Text = "Giới tính";

        // rdoNam
        this.rdoNam.AutoSize = true;
        this.rdoNam.Checked = true;
        this.rdoNam.Location = new System.Drawing.Point(20, 16);
        this.rdoNam.Name = "rdoNam";
        this.rdoNam.Size = new System.Drawing.Size(54, 21);
        this.rdoNam.TabIndex = 0;
        this.rdoNam.TabStop = true;
        this.rdoNam.Text = "Nam";
        this.rdoNam.UseVisualStyleBackColor = true;

        // rdoNu
        this.rdoNu.AutoSize = true;
        this.rdoNu.Location = new System.Drawing.Point(100, 16);
        this.rdoNu.Name = "rdoNu";
        this.rdoNu.Size = new System.Drawing.Size(43, 21);
        this.rdoNu.TabIndex = 1;
        this.rdoNu.Text = "Nữ";
        this.rdoNu.UseVisualStyleBackColor = true;

        // chkTrangThai
        this.chkTrangThai.AutoSize = true;
        this.chkTrangThai.Checked = true;
        this.chkTrangThai.CheckState = System.Windows.Forms.CheckState.Checked;
        this.chkTrangThai.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.chkTrangThai.ForeColor = System.Drawing.Color.Green;
        this.chkTrangThai.Location = new System.Drawing.Point(800, 30);
        this.chkTrangThai.Name = "chkTrangThai";
        this.chkTrangThai.Size = new System.Drawing.Size(126, 21);
        this.chkTrangThai.TabIndex = 3;
        this.chkTrangThai.Text = "Đang hoạt động";
        this.chkTrangThai.UseVisualStyleBackColor = true;

        // lblNgaySinh
        this.lblNgaySinh.AutoSize = true;
        this.lblNgaySinh.Location = new System.Drawing.Point(20, 75);
        this.lblNgaySinh.Name = "lblNgaySinh";
        this.lblNgaySinh.Size = new System.Drawing.Size(69, 17);
        this.lblNgaySinh.Text = "Ngày sinh:";

        // dtpNgaySinh
        this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
        this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        this.dtpNgaySinh.Location = new System.Drawing.Point(120, 72);
        this.dtpNgaySinh.Name = "dtpNgaySinh";
        this.dtpNgaySinh.Size = new System.Drawing.Size(120, 24);
        this.dtpNgaySinh.TabIndex = 4;

        // lblSDT
        this.lblSDT.AutoSize = true;
        this.lblSDT.Location = new System.Drawing.Point(260, 75);
        this.lblSDT.Name = "lblSDT";
        this.lblSDT.Size = new System.Drawing.Size(45, 17);
        this.lblSDT.Text = "Số ĐT:";

        // txtSDT
        this.txtSDT.Location = new System.Drawing.Point(340, 72);
        this.txtSDT.Name = "txtSDT";
        this.txtSDT.Size = new System.Drawing.Size(240, 24);
        this.txtSDT.TabIndex = 5;

        // lblEmail
        this.lblEmail.AutoSize = true;
        this.lblEmail.Location = new System.Drawing.Point(600, 75);
        this.lblEmail.Name = "lblEmail";
        this.lblEmail.Size = new System.Drawing.Size(42, 17);
        this.lblEmail.Text = "Email:";

        // txtEmail
        this.txtEmail.Location = new System.Drawing.Point(660, 72);
        this.txtEmail.Name = "txtEmail";
        this.txtEmail.Size = new System.Drawing.Size(266, 24);
        this.txtEmail.TabIndex = 6;

        // lblHangThanhVien
        this.lblHangThanhVien.AutoSize = true;
        this.lblHangThanhVien.Location = new System.Drawing.Point(20, 120);
        this.lblHangThanhVien.Name = "lblHangThanhVien";
        this.lblHangThanhVien.Size = new System.Drawing.Size(78, 17);
        this.lblHangThanhVien.Text = "Hạng TV:";

        // cboHangThanhVien
        this.cboHangThanhVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboHangThanhVien.FormattingEnabled = true;
        this.cboHangThanhVien.Items.AddRange(new object[] { "Basic", "VIP", "Premium" });
        this.cboHangThanhVien.Location = new System.Drawing.Point(120, 117);
        this.cboHangThanhVien.Name = "cboHangThanhVien";
        this.cboHangThanhVien.Size = new System.Drawing.Size(120, 24);
        this.cboHangThanhVien.TabIndex = 7;

        // lblNgayDangKy
        this.lblNgayDangKy.AutoSize = true;
        this.lblNgayDangKy.Location = new System.Drawing.Point(260, 120);
        this.lblNgayDangKy.Name = "lblNgayDangKy";
        this.lblNgayDangKy.Size = new System.Drawing.Size(92, 17);
        this.lblNgayDangKy.Text = "Ngày đăng ký:";

        // lblNgayDangKyValue
        this.lblNgayDangKyValue.AutoSize = true;
        this.lblNgayDangKyValue.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
        this.lblNgayDangKyValue.ForeColor = System.Drawing.Color.DarkSlateGray;
        this.lblNgayDangKyValue.Location = new System.Drawing.Point(360, 120);
        this.lblNgayDangKyValue.Name = "lblNgayDangKyValue";
        this.lblNgayDangKyValue.Size = new System.Drawing.Size(28, 17);
        this.lblNgayDangKyValue.Text = "---";

        // btnThem
        this.btnThem.BackColor = System.Drawing.Color.LightSkyBlue;
        this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnThem.Location = new System.Drawing.Point(500, 162);
        this.btnThem.Name = "btnThem";
        this.btnThem.Size = new System.Drawing.Size(100, 38);
        this.btnThem.TabIndex = 8;
        this.btnThem.Text = "Thêm";
        this.btnThem.UseVisualStyleBackColor = false;
        this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

        // btnSua
        this.btnSua.BackColor = System.Drawing.Color.Khaki;
        this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnSua.Location = new System.Drawing.Point(612, 162);
        this.btnSua.Name = "btnSua";
        this.btnSua.Size = new System.Drawing.Size(100, 38);
        this.btnSua.TabIndex = 9;
        this.btnSua.Text = "Sửa";
        this.btnSua.UseVisualStyleBackColor = false;
        this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

        // btnXoa
        this.btnXoa.BackColor = System.Drawing.Color.LightCoral;
        this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnXoa.Location = new System.Drawing.Point(724, 162);
        this.btnXoa.Name = "btnXoa";
        this.btnXoa.Size = new System.Drawing.Size(100, 38);
        this.btnXoa.TabIndex = 10;
        this.btnXoa.Text = "Xóa";
        this.btnXoa.UseVisualStyleBackColor = false;
        this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

        // btnLamMoi
        this.btnLamMoi.BackColor = System.Drawing.Color.LightGray;
        this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnLamMoi.Location = new System.Drawing.Point(836, 162);
        this.btnLamMoi.Name = "btnLamMoi";
        this.btnLamMoi.Size = new System.Drawing.Size(95, 38);
        this.btnLamMoi.TabIndex = 11;
        this.btnLamMoi.Text = "Làm mới";
        this.btnLamMoi.UseVisualStyleBackColor = false;
        this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

        // grpTimKiem
        this.grpTimKiem.Controls.Add(this.lblTimTen);
        this.grpTimKiem.Controls.Add(this.txtTimTen);
        this.grpTimKiem.Controls.Add(this.lblLocHang);
        this.grpTimKiem.Controls.Add(this.cboLocHang);
        this.grpTimKiem.Controls.Add(this.btnTimKiem);
        this.grpTimKiem.Controls.Add(this.btnHienTatCa);
        this.grpTimKiem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.grpTimKiem.Location = new System.Drawing.Point(16, 280);
        this.grpTimKiem.Name = "grpTimKiem";
        this.grpTimKiem.Size = new System.Drawing.Size(948, 65);
        this.grpTimKiem.TabIndex = 2;
        this.grpTimKiem.TabStop = false;
        this.grpTimKiem.Text = "Tìm kiếm kết hợp";

        // lblTimTen
        this.lblTimTen.AutoSize = true;
        this.lblTimTen.Location = new System.Drawing.Point(20, 28);
        this.lblTimTen.Name = "lblTimTen";
        this.lblTimTen.Size = new System.Drawing.Size(107, 17);
        this.lblTimTen.TabIndex = 0;
        this.lblTimTen.Text = "Họ tên hội viên:";

        // txtTimTen
        this.txtTimTen.Location = new System.Drawing.Point(135, 25);
        this.txtTimTen.Name = "txtTimTen";
        this.txtTimTen.PlaceholderText = "Nhập họ tên cần tìm...";
        this.txtTimTen.Size = new System.Drawing.Size(260, 24);
        this.txtTimTen.TabIndex = 1;
        this.txtTimTen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimTen_KeyDown);

        // lblLocHang
        this.lblLocHang.AutoSize = true;
        this.lblLocHang.Location = new System.Drawing.Point(420, 28);
        this.lblLocHang.Name = "lblLocHang";
        this.lblLocHang.Size = new System.Drawing.Size(106, 17);
        this.lblLocHang.TabIndex = 2;
        this.lblLocHang.Text = "Hạng thành viên:";

        // cboLocHang
        this.cboLocHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboLocHang.FormattingEnabled = true;
        this.cboLocHang.Items.AddRange(new object[] { "-- Tất cả --", "Basic", "VIP", "Premium" });
        this.cboLocHang.Location = new System.Drawing.Point(535, 25);
        this.cboLocHang.Name = "cboLocHang";
        this.cboLocHang.Size = new System.Drawing.Size(140, 24);
        this.cboLocHang.TabIndex = 3;

        // btnTimKiem
        this.btnTimKiem.BackColor = System.Drawing.Color.LightCyan;
        this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnTimKiem.Location = new System.Drawing.Point(700, 20);
        this.btnTimKiem.Name = "btnTimKiem";
        this.btnTimKiem.Size = new System.Drawing.Size(110, 32);
        this.btnTimKiem.TabIndex = 4;
        this.btnTimKiem.Text = "Tìm kiếm";
        this.btnTimKiem.UseVisualStyleBackColor = false;
        this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);

        // btnHienTatCa
        this.btnHienTatCa.Location = new System.Drawing.Point(820, 20);
        this.btnHienTatCa.Name = "btnHienTatCa";
        this.btnHienTatCa.Size = new System.Drawing.Size(115, 32);
        this.btnHienTatCa.TabIndex = 5;
        this.btnHienTatCa.Text = "Hiện tất cả";
        this.btnHienTatCa.UseVisualStyleBackColor = true;
        this.btnHienTatCa.Click += new System.EventHandler(this.btnHienTatCa_Click);

        // grpDanhSach
        this.grpDanhSach.Controls.Add(this.dgvHoiVien);
        this.grpDanhSach.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.grpDanhSach.Location = new System.Drawing.Point(16, 355);
        this.grpDanhSach.Name = "grpDanhSach";
        this.grpDanhSach.Size = new System.Drawing.Size(948, 290);
        this.grpDanhSach.TabIndex = 3;
        this.grpDanhSach.TabStop = false;
        this.grpDanhSach.Text = "Danh sách hội viên";

        // dgvHoiVien
        this.dgvHoiVien.AllowUserToAddRows = false;
        this.dgvHoiVien.AllowUserToDeleteRows = false;
        this.dgvHoiVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvHoiVien.BackgroundColor = System.Drawing.Color.White;
        this.dgvHoiVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvHoiVien.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dgvHoiVien.Location = new System.Drawing.Point(3, 20);
        this.dgvHoiVien.MultiSelect = false;
        this.dgvHoiVien.Name = "dgvHoiVien";
        this.dgvHoiVien.ReadOnly = true;
        this.dgvHoiVien.RowHeadersWidth = 51;
        this.dgvHoiVien.RowTemplate.Height = 29;
        this.dgvHoiVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvHoiVien.Size = new System.Drawing.Size(942, 267);
        this.dgvHoiVien.TabIndex = 0;
        this.dgvHoiVien.SelectionChanged += new System.EventHandler(this.dgvHoiVien_SelectionChanged);

        // Form1
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(980, 660);
        this.Controls.Add(this.grpDanhSach);
        this.Controls.Add(this.grpTimKiem);
        this.Controls.Add(this.grpThongTin);
        this.Controls.Add(this.lblTieuDe);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.Name = "Form1";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Quản lý Hội viên - FitZone";
        this.Load += new System.EventHandler(this.Form1_Load);
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);

        this.grpThongTin.ResumeLayout(false);
        this.grpThongTin.PerformLayout();
        this.grpGioiTinh.ResumeLayout(false);
        this.grpGioiTinh.PerformLayout();
        this.grpTimKiem.ResumeLayout(false);
        this.grpTimKiem.PerformLayout();
        this.grpDanhSach.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dgvHoiVien)).EndInit();
        this.ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Label lblTieuDe;
    private System.Windows.Forms.GroupBox grpThongTin;
    private System.Windows.Forms.Label lblMaHV;
    private System.Windows.Forms.TextBox txtMaHV;
    private System.Windows.Forms.Label lblHoTen;
    private System.Windows.Forms.TextBox txtHoTen;
    private System.Windows.Forms.GroupBox grpGioiTinh;
    private System.Windows.Forms.RadioButton rdoNam;
    private System.Windows.Forms.RadioButton rdoNu;
    private System.Windows.Forms.Label lblNgaySinh;
    private System.Windows.Forms.DateTimePicker dtpNgaySinh;
    private System.Windows.Forms.Label lblSDT;
    private System.Windows.Forms.TextBox txtSDT;
    private System.Windows.Forms.Label lblEmail;
    private System.Windows.Forms.TextBox txtEmail;
    private System.Windows.Forms.Label lblHangThanhVien;
    private System.Windows.Forms.ComboBox cboHangThanhVien;
    private System.Windows.Forms.CheckBox chkTrangThai;
    private System.Windows.Forms.Label lblNgayDangKy;
    private System.Windows.Forms.Label lblNgayDangKyValue;
    private System.Windows.Forms.Button btnThem;
    private System.Windows.Forms.Button btnSua;
    private System.Windows.Forms.Button btnXoa;
    private System.Windows.Forms.Button btnLamMoi;
    private System.Windows.Forms.GroupBox grpTimKiem;
    private System.Windows.Forms.Label lblTimTen;
    private System.Windows.Forms.TextBox txtTimTen;
    private System.Windows.Forms.Label lblLocHang;
    private System.Windows.Forms.ComboBox cboLocHang;
    private System.Windows.Forms.Button btnTimKiem;
    private System.Windows.Forms.Button btnHienTatCa;
    private System.Windows.Forms.GroupBox grpDanhSach;
    private System.Windows.Forms.DataGridView dgvHoiVien;
}
