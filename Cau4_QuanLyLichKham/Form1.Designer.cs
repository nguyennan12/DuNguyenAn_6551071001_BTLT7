namespace Cau4_QuanLyLichKham;

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
        this.lblMaLich = new System.Windows.Forms.Label();
        this.txtMaLich = new System.Windows.Forms.TextBox();
        this.lblTenBenhNhan = new System.Windows.Forms.Label();
        this.txtTenBenhNhan = new System.Windows.Forms.TextBox();
        this.lblSDT = new System.Windows.Forms.Label();
        this.txtSDT = new System.Windows.Forms.TextBox();
        this.lblNgayKham = new System.Windows.Forms.Label();
        this.dtpNgayKham = new System.Windows.Forms.DateTimePicker();
        this.lblGioKham = new System.Windows.Forms.Label();
        this.dtpGioKham = new System.Windows.Forms.DateTimePicker();
        this.lblBacSi = new System.Windows.Forms.Label();
        this.cboBacSi = new System.Windows.Forms.ComboBox();
        this.btnQuanLyBacSi = new System.Windows.Forms.Button();
        this.lblTrangThai = new System.Windows.Forms.Label();
        this.cboTrangThai = new System.Windows.Forms.ComboBox();
        this.btnThem = new System.Windows.Forms.Button();
        this.btnSua = new System.Windows.Forms.Button();
        this.btnXoa = new System.Windows.Forms.Button();
        this.btnLamMoi = new System.Windows.Forms.Button();
        this.grpTimKiem = new System.Windows.Forms.GroupBox();
        this.lblTuNgay = new System.Windows.Forms.Label();
        this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
        this.lblDenNgay = new System.Windows.Forms.Label();
        this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
        this.lblLocBacSi = new System.Windows.Forms.Label();
        this.cboLocBacSi = new System.Windows.Forms.ComboBox();
        this.btnTimKiem = new System.Windows.Forms.Button();
        this.btnHienTatCa = new System.Windows.Forms.Button();
        this.grpDanhSach = new System.Windows.Forms.GroupBox();
        this.dgvLichKham = new System.Windows.Forms.DataGridView();

        this.grpThongTin.SuspendLayout();
        this.grpTimKiem.SuspendLayout();
        this.grpDanhSach.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvLichKham)).BeginInit();
        this.SuspendLayout();

        // lblTieuDe
        this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
        this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblTieuDe.ForeColor = System.Drawing.Color.MidnightBlue;
        this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
        this.lblTieuDe.Name = "lblTieuDe";
        this.lblTieuDe.Size = new System.Drawing.Size(1020, 50);
        this.lblTieuDe.TabIndex = 0;
        this.lblTieuDe.Text = "QUẢN LÝ LỊCH KHÁM BỆNH - AN KHANG CLINIC";
        this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        // grpThongTin
        this.grpThongTin.Controls.Add(this.lblMaLich);
        this.grpThongTin.Controls.Add(this.txtMaLich);
        this.grpThongTin.Controls.Add(this.lblTenBenhNhan);
        this.grpThongTin.Controls.Add(this.txtTenBenhNhan);
        this.grpThongTin.Controls.Add(this.lblSDT);
        this.grpThongTin.Controls.Add(this.txtSDT);
        this.grpThongTin.Controls.Add(this.lblNgayKham);
        this.grpThongTin.Controls.Add(this.dtpNgayKham);
        this.grpThongTin.Controls.Add(this.lblGioKham);
        this.grpThongTin.Controls.Add(this.dtpGioKham);
        this.grpThongTin.Controls.Add(this.lblBacSi);
        this.grpThongTin.Controls.Add(this.cboBacSi);
        this.grpThongTin.Controls.Add(this.btnQuanLyBacSi);
        this.grpThongTin.Controls.Add(this.lblTrangThai);
        this.grpThongTin.Controls.Add(this.cboTrangThai);
        this.grpThongTin.Controls.Add(this.btnThem);
        this.grpThongTin.Controls.Add(this.btnSua);
        this.grpThongTin.Controls.Add(this.btnXoa);
        this.grpThongTin.Controls.Add(this.btnLamMoi);
        this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.grpThongTin.Location = new System.Drawing.Point(16, 52);
        this.grpThongTin.Name = "grpThongTin";
        this.grpThongTin.Size = new System.Drawing.Size(988, 205);
        this.grpThongTin.TabIndex = 1;
        this.grpThongTin.TabStop = false;
        this.grpThongTin.Text = "Thông tin lịch hẹn khám";

        // lblMaLich
        this.lblMaLich.AutoSize = true;
        this.lblMaLich.Location = new System.Drawing.Point(20, 30);
        this.lblMaLich.Name = "lblMaLich";
        this.lblMaLich.Size = new System.Drawing.Size(56, 17);
        this.lblMaLich.TabIndex = 0;
        this.lblMaLich.Text = "Mã lịch:";

        // txtMaLich
        this.txtMaLich.Location = new System.Drawing.Point(120, 27);
        this.txtMaLich.Name = "txtMaLich";
        this.txtMaLich.ReadOnly = true;
        this.txtMaLich.Size = new System.Drawing.Size(120, 24);
        this.txtMaLich.TabIndex = 1;

        // lblTenBenhNhan
        this.lblTenBenhNhan.AutoSize = true;
        this.lblTenBenhNhan.Location = new System.Drawing.Point(260, 30);
        this.lblTenBenhNhan.Name = "lblTenBenhNhan";
        this.lblTenBenhNhan.Size = new System.Drawing.Size(96, 17);
        this.lblTenBenhNhan.TabIndex = 2;
        this.lblTenBenhNhan.Text = "Tên bệnh nhân:";

        // txtTenBenhNhan
        this.txtTenBenhNhan.Location = new System.Drawing.Point(365, 27);
        this.txtTenBenhNhan.Name = "txtTenBenhNhan";
        this.txtTenBenhNhan.Size = new System.Drawing.Size(240, 24);
        this.txtTenBenhNhan.TabIndex = 3;

        // lblSDT
        this.lblSDT.AutoSize = true;
        this.lblSDT.Location = new System.Drawing.Point(630, 30);
        this.lblSDT.Name = "lblSDT";
        this.lblSDT.Size = new System.Drawing.Size(88, 17);
        this.lblSDT.TabIndex = 4;
        this.lblSDT.Text = "Số điện thoại:";

        // txtSDT
        this.txtSDT.Location = new System.Drawing.Point(725, 27);
        this.txtSDT.Name = "txtSDT";
        this.txtSDT.Size = new System.Drawing.Size(235, 24);
        this.txtSDT.TabIndex = 5;

        // lblNgayKham
        this.lblNgayKham.AutoSize = true;
        this.lblNgayKham.Location = new System.Drawing.Point(20, 72);
        this.lblNgayKham.Name = "lblNgayKham";
        this.lblNgayKham.Size = new System.Drawing.Size(78, 17);
        this.lblNgayKham.TabIndex = 6;
        this.lblNgayKham.Text = "Ngày khám:";

        // dtpNgayKham
        this.dtpNgayKham.CustomFormat = "dd/MM/yyyy";
        this.dtpNgayKham.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        this.dtpNgayKham.Location = new System.Drawing.Point(120, 69);
        this.dtpNgayKham.Name = "dtpNgayKham";
        this.dtpNgayKham.Size = new System.Drawing.Size(120, 24);
        this.dtpNgayKham.TabIndex = 7;

        // lblGioKham
        this.lblGioKham.AutoSize = true;
        this.lblGioKham.Location = new System.Drawing.Point(260, 72);
        this.lblGioKham.Name = "lblGioKham";
        this.lblGioKham.Size = new System.Drawing.Size(67, 17);
        this.lblGioKham.TabIndex = 8;
        this.lblGioKham.Text = "Giờ khám:";

        // dtpGioKham
        this.dtpGioKham.CustomFormat = "HH:mm";
        this.dtpGioKham.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        this.dtpGioKham.Location = new System.Drawing.Point(365, 69);
        this.dtpGioKham.Name = "dtpGioKham";
        this.dtpGioKham.ShowUpDown = true;
        this.dtpGioKham.Size = new System.Drawing.Size(100, 24);
        this.dtpGioKham.TabIndex = 9;

        // lblTrangThai
        this.lblTrangThai.AutoSize = true;
        this.lblTrangThai.Location = new System.Drawing.Point(630, 72);
        this.lblTrangThai.Name = "lblTrangThai";
        this.lblTrangThai.Size = new System.Drawing.Size(70, 17);
        this.lblTrangThai.TabIndex = 10;
        this.lblTrangThai.Text = "Trạng thái:";

        // cboTrangThai
        this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboTrangThai.FormattingEnabled = true;
        this.cboTrangThai.Items.AddRange(new object[] { "Chờ khám", "Đã khám", "Đã hủy" });
        this.cboTrangThai.Location = new System.Drawing.Point(725, 69);
        this.cboTrangThai.Name = "cboTrangThai";
        this.cboTrangThai.Size = new System.Drawing.Size(235, 24);
        this.cboTrangThai.TabIndex = 11;

        // lblBacSi
        this.lblBacSi.AutoSize = true;
        this.lblBacSi.Location = new System.Drawing.Point(20, 114);
        this.lblBacSi.Name = "lblBacSi";
        this.lblBacSi.Size = new System.Drawing.Size(46, 17);
        this.lblBacSi.TabIndex = 12;
        this.lblBacSi.Text = "Bác sĩ:";

        // cboBacSi
        this.cboBacSi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboBacSi.FormattingEnabled = true;
        this.cboBacSi.Location = new System.Drawing.Point(120, 111);
        this.cboBacSi.Name = "cboBacSi";
        this.cboBacSi.Size = new System.Drawing.Size(485, 24);
        this.cboBacSi.TabIndex = 13;

        // btnQuanLyBacSi
        this.btnQuanLyBacSi.BackColor = System.Drawing.Color.PaleGoldenrod;
        this.btnQuanLyBacSi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnQuanLyBacSi.Location = new System.Drawing.Point(620, 109);
        this.btnQuanLyBacSi.Name = "btnQuanLyBacSi";
        this.btnQuanLyBacSi.Size = new System.Drawing.Size(140, 28);
        this.btnQuanLyBacSi.TabIndex = 14;
        this.btnQuanLyBacSi.Text = "Quản lý Bác sĩ...";
        this.btnQuanLyBacSi.UseVisualStyleBackColor = false;
        this.btnQuanLyBacSi.Click += new System.EventHandler(this.btnQuanLyBacSi_Click);

        // btnThem
        this.btnThem.BackColor = System.Drawing.Color.LightSkyBlue;
        this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnThem.Location = new System.Drawing.Point(520, 155);
        this.btnThem.Name = "btnThem";
        this.btnThem.Size = new System.Drawing.Size(100, 36);
        this.btnThem.TabIndex = 15;
        this.btnThem.Text = "Thêm";
        this.btnThem.UseVisualStyleBackColor = false;
        this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

        // btnSua
        this.btnSua.BackColor = System.Drawing.Color.Khaki;
        this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnSua.Location = new System.Drawing.Point(635, 155);
        this.btnSua.Name = "btnSua";
        this.btnSua.Size = new System.Drawing.Size(100, 36);
        this.btnSua.TabIndex = 16;
        this.btnSua.Text = "Sửa";
        this.btnSua.UseVisualStyleBackColor = false;
        this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

        // btnXoa
        this.btnXoa.BackColor = System.Drawing.Color.LightCoral;
        this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnXoa.Location = new System.Drawing.Point(750, 155);
        this.btnXoa.Name = "btnXoa";
        this.btnXoa.Size = new System.Drawing.Size(100, 36);
        this.btnXoa.TabIndex = 17;
        this.btnXoa.Text = "Xóa";
        this.btnXoa.UseVisualStyleBackColor = false;
        this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

        // btnLamMoi
        this.btnLamMoi.BackColor = System.Drawing.Color.LightGray;
        this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnLamMoi.Location = new System.Drawing.Point(865, 155);
        this.btnLamMoi.Name = "btnLamMoi";
        this.btnLamMoi.Size = new System.Drawing.Size(95, 36);
        this.btnLamMoi.TabIndex = 18;
        this.btnLamMoi.Text = "Làm mới";
        this.btnLamMoi.UseVisualStyleBackColor = false;
        this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

        // grpTimKiem
        this.grpTimKiem.Controls.Add(this.lblTuNgay);
        this.grpTimKiem.Controls.Add(this.dtpTuNgay);
        this.grpTimKiem.Controls.Add(this.lblDenNgay);
        this.grpTimKiem.Controls.Add(this.dtpDenNgay);
        this.grpTimKiem.Controls.Add(this.lblLocBacSi);
        this.grpTimKiem.Controls.Add(this.cboLocBacSi);
        this.grpTimKiem.Controls.Add(this.btnTimKiem);
        this.grpTimKiem.Controls.Add(this.btnHienTatCa);
        this.grpTimKiem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.grpTimKiem.Location = new System.Drawing.Point(16, 265);
        this.grpTimKiem.Name = "grpTimKiem";
        this.grpTimKiem.Size = new System.Drawing.Size(988, 65);
        this.grpTimKiem.TabIndex = 2;
        this.grpTimKiem.TabStop = false;
        this.grpTimKiem.Text = "Tìm kiếm kết hợp (Khoảng ngày khám && Bác sĩ)";

        // lblTuNgay
        this.lblTuNgay.AutoSize = true;
        this.lblTuNgay.Location = new System.Drawing.Point(20, 27);
        this.lblTuNgay.Name = "lblTuNgay";
        this.lblTuNgay.Size = new System.Drawing.Size(59, 17);
        this.lblTuNgay.TabIndex = 0;
        this.lblTuNgay.Text = "Từ ngày:";

        // dtpTuNgay
        this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
        this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        this.dtpTuNgay.Location = new System.Drawing.Point(85, 24);
        this.dtpTuNgay.Name = "dtpTuNgay";
        this.dtpTuNgay.Size = new System.Drawing.Size(115, 24);
        this.dtpTuNgay.TabIndex = 1;

        // lblDenNgay
        this.lblDenNgay.AutoSize = true;
        this.lblDenNgay.Location = new System.Drawing.Point(215, 27);
        this.lblDenNgay.Name = "lblDenNgay";
        this.lblDenNgay.Size = new System.Drawing.Size(68, 17);
        this.lblDenNgay.TabIndex = 2;
        this.lblDenNgay.Text = "Đến ngày:";

        // dtpDenNgay
        this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
        this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        this.dtpDenNgay.Location = new System.Drawing.Point(290, 24);
        this.dtpDenNgay.Name = "dtpDenNgay";
        this.dtpDenNgay.Size = new System.Drawing.Size(115, 24);
        this.dtpDenNgay.TabIndex = 3;

        // lblLocBacSi
        this.lblLocBacSi.AutoSize = true;
        this.lblLocBacSi.Location = new System.Drawing.Point(420, 27);
        this.lblLocBacSi.Name = "lblLocBacSi";
        this.lblLocBacSi.Size = new System.Drawing.Size(46, 17);
        this.lblLocBacSi.TabIndex = 4;
        this.lblLocBacSi.Text = "Bác sĩ:";

        // cboLocBacSi
        this.cboLocBacSi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboLocBacSi.FormattingEnabled = true;
        this.cboLocBacSi.Location = new System.Drawing.Point(475, 24);
        this.cboLocBacSi.Name = "cboLocBacSi";
        this.cboLocBacSi.Size = new System.Drawing.Size(260, 24);
        this.cboLocBacSi.TabIndex = 5;

        // btnTimKiem
        this.btnTimKiem.BackColor = System.Drawing.Color.LightCyan;
        this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnTimKiem.Location = new System.Drawing.Point(750, 20);
        this.btnTimKiem.Name = "btnTimKiem";
        this.btnTimKiem.Size = new System.Drawing.Size(105, 32);
        this.btnTimKiem.TabIndex = 6;
        this.btnTimKiem.Text = "Tìm kiếm";
        this.btnTimKiem.UseVisualStyleBackColor = false;
        this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);

        // btnHienTatCa
        this.btnHienTatCa.Location = new System.Drawing.Point(865, 20);
        this.btnHienTatCa.Name = "btnHienTatCa";
        this.btnHienTatCa.Size = new System.Drawing.Size(105, 32);
        this.btnHienTatCa.TabIndex = 7;
        this.btnHienTatCa.Text = "Hiện tất cả";
        this.btnHienTatCa.UseVisualStyleBackColor = true;
        this.btnHienTatCa.Click += new System.EventHandler(this.btnHienTatCa_Click);

        // grpDanhSach
        this.grpDanhSach.Controls.Add(this.dgvLichKham);
        this.grpDanhSach.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.grpDanhSach.Location = new System.Drawing.Point(16, 335);
        this.grpDanhSach.Name = "grpDanhSach";
        this.grpDanhSach.Size = new System.Drawing.Size(988, 305);
        this.grpDanhSach.TabIndex = 3;
        this.grpDanhSach.TabStop = false;
        this.grpDanhSach.Text = "Danh sách lịch khám bệnh";

        // dgvLichKham
        this.dgvLichKham.AllowUserToAddRows = false;
        this.dgvLichKham.AllowUserToDeleteRows = false;
        this.dgvLichKham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvLichKham.BackgroundColor = System.Drawing.Color.White;
        this.dgvLichKham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvLichKham.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dgvLichKham.Location = new System.Drawing.Point(3, 20);
        this.dgvLichKham.MultiSelect = false;
        this.dgvLichKham.Name = "dgvLichKham";
        this.dgvLichKham.ReadOnly = true;
        this.dgvLichKham.RowHeadersWidth = 51;
        this.dgvLichKham.RowTemplate.Height = 29;
        this.dgvLichKham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvLichKham.Size = new System.Drawing.Size(982, 282);
        this.dgvLichKham.TabIndex = 0;
        this.dgvLichKham.SelectionChanged += new System.EventHandler(this.dgvLichKham_SelectionChanged);

        // Form1
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(1020, 650);
        this.Controls.Add(this.grpDanhSach);
        this.Controls.Add(this.grpTimKiem);
        this.Controls.Add(this.grpThongTin);
        this.Controls.Add(this.lblTieuDe);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.Name = "Form1";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Quản lý Lịch khám bệnh - An Khang Clinic";
        this.Load += new System.EventHandler(this.Form1_Load);
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);

        this.grpThongTin.ResumeLayout(false);
        this.grpThongTin.PerformLayout();
        this.grpTimKiem.ResumeLayout(false);
        this.grpTimKiem.PerformLayout();
        this.grpDanhSach.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dgvLichKham)).EndInit();
        this.ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Label lblTieuDe;
    private System.Windows.Forms.GroupBox grpThongTin;
    private System.Windows.Forms.Label lblMaLich;
    private System.Windows.Forms.TextBox txtMaLich;
    private System.Windows.Forms.Label lblTenBenhNhan;
    private System.Windows.Forms.TextBox txtTenBenhNhan;
    private System.Windows.Forms.Label lblSDT;
    private System.Windows.Forms.TextBox txtSDT;
    private System.Windows.Forms.Label lblNgayKham;
    private System.Windows.Forms.DateTimePicker dtpNgayKham;
    private System.Windows.Forms.Label lblGioKham;
    private System.Windows.Forms.DateTimePicker dtpGioKham;
    private System.Windows.Forms.Label lblBacSi;
    private System.Windows.Forms.ComboBox cboBacSi;
    private System.Windows.Forms.Button btnQuanLyBacSi;
    private System.Windows.Forms.Label lblTrangThai;
    private System.Windows.Forms.ComboBox cboTrangThai;
    private System.Windows.Forms.Button btnThem;
    private System.Windows.Forms.Button btnSua;
    private System.Windows.Forms.Button btnXoa;
    private System.Windows.Forms.Button btnLamMoi;
    private System.Windows.Forms.GroupBox grpTimKiem;
    private System.Windows.Forms.Label lblTuNgay;
    private System.Windows.Forms.DateTimePicker dtpTuNgay;
    private System.Windows.Forms.Label lblDenNgay;
    private System.Windows.Forms.DateTimePicker dtpDenNgay;
    private System.Windows.Forms.Label lblLocBacSi;
    private System.Windows.Forms.ComboBox cboLocBacSi;
    private System.Windows.Forms.Button btnTimKiem;
    private System.Windows.Forms.Button btnHienTatCa;
    private System.Windows.Forms.GroupBox grpDanhSach;
    private System.Windows.Forms.DataGridView dgvLichKham;
}
