namespace Cau3_QuanLyPhongHomestay;

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
        this.lblMaPhong = new System.Windows.Forms.Label();
        this.txtMaPhong = new System.Windows.Forms.TextBox();
        this.lblSoPhong = new System.Windows.Forms.Label();
        this.txtSoPhong = new System.Windows.Forms.TextBox();
        this.lblTangSo = new System.Windows.Forms.Label();
        this.numTangSo = new System.Windows.Forms.NumericUpDown();
        this.lblLoaiPhong = new System.Windows.Forms.Label();
        this.cboLoaiPhong = new System.Windows.Forms.ComboBox();
        this.btnQuanLyLoaiPhong = new System.Windows.Forms.Button();
        this.lblTinhTrang = new System.Windows.Forms.Label();
        this.cboTinhTrang = new System.Windows.Forms.ComboBox();
        this.lblHinhAnh = new System.Windows.Forms.Label();
        this.txtHinhAnh = new System.Windows.Forms.TextBox();
        this.btnChonAnh = new System.Windows.Forms.Button();
        this.picHinhAnh = new System.Windows.Forms.PictureBox();
        this.btnThem = new System.Windows.Forms.Button();
        this.btnSua = new System.Windows.Forms.Button();
        this.btnXoa = new System.Windows.Forms.Button();
        this.btnLamMoi = new System.Windows.Forms.Button();
        this.grpTimKiem = new System.Windows.Forms.GroupBox();
        this.lblLocLoaiPhong = new System.Windows.Forms.Label();
        this.cboLocLoaiPhong = new System.Windows.Forms.ComboBox();
        this.lblLocTinhTrang = new System.Windows.Forms.Label();
        this.cboLocTinhTrang = new System.Windows.Forms.ComboBox();
        this.btnTimKiem = new System.Windows.Forms.Button();
        this.btnHienTatCa = new System.Windows.Forms.Button();
        this.grpDanhSach = new System.Windows.Forms.GroupBox();
        this.dgvPhong = new System.Windows.Forms.DataGridView();

        this.grpThongTin.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.numTangSo)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).BeginInit();
        this.grpTimKiem.SuspendLayout();
        this.grpDanhSach.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
        this.SuspendLayout();

        // lblTieuDe
        this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
        this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblTieuDe.ForeColor = System.Drawing.Color.DarkOliveGreen;
        this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
        this.lblTieuDe.Name = "lblTieuDe";
        this.lblTieuDe.Size = new System.Drawing.Size(1020, 50);
        this.lblTieuDe.TabIndex = 0;
        this.lblTieuDe.Text = "QUẢN LÝ PHÒNG Ở - SUNRISE HOMESTAY";
        this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        // grpThongTin
        this.grpThongTin.Controls.Add(this.lblMaPhong);
        this.grpThongTin.Controls.Add(this.txtMaPhong);
        this.grpThongTin.Controls.Add(this.lblSoPhong);
        this.grpThongTin.Controls.Add(this.txtSoPhong);
        this.grpThongTin.Controls.Add(this.lblTangSo);
        this.grpThongTin.Controls.Add(this.numTangSo);
        this.grpThongTin.Controls.Add(this.lblLoaiPhong);
        this.grpThongTin.Controls.Add(this.cboLoaiPhong);
        this.grpThongTin.Controls.Add(this.btnQuanLyLoaiPhong);
        this.grpThongTin.Controls.Add(this.lblTinhTrang);
        this.grpThongTin.Controls.Add(this.cboTinhTrang);
        this.grpThongTin.Controls.Add(this.lblHinhAnh);
        this.grpThongTin.Controls.Add(this.txtHinhAnh);
        this.grpThongTin.Controls.Add(this.btnChonAnh);
        this.grpThongTin.Controls.Add(this.picHinhAnh);
        this.grpThongTin.Controls.Add(this.btnThem);
        this.grpThongTin.Controls.Add(this.btnSua);
        this.grpThongTin.Controls.Add(this.btnXoa);
        this.grpThongTin.Controls.Add(this.btnLamMoi);
        this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.grpThongTin.Location = new System.Drawing.Point(16, 52);
        this.grpThongTin.Name = "grpThongTin";
        this.grpThongTin.Size = new System.Drawing.Size(988, 230);
        this.grpThongTin.TabIndex = 1;
        this.grpThongTin.TabStop = false;
        this.grpThongTin.Text = "Thông tin phòng";

        // lblMaPhong
        this.lblMaPhong.AutoSize = true;
        this.lblMaPhong.Location = new System.Drawing.Point(20, 28);
        this.lblMaPhong.Name = "lblMaPhong";
        this.lblMaPhong.Size = new System.Drawing.Size(73, 17);
        this.lblMaPhong.TabIndex = 0;
        this.lblMaPhong.Text = "Mã phòng:";

        // txtMaPhong
        this.txtMaPhong.Location = new System.Drawing.Point(100, 25);
        this.txtMaPhong.Name = "txtMaPhong";
        this.txtMaPhong.ReadOnly = true;
        this.txtMaPhong.Size = new System.Drawing.Size(120, 24);
        this.txtMaPhong.TabIndex = 1;

        // lblSoPhong
        this.lblSoPhong.AutoSize = true;
        this.lblSoPhong.Location = new System.Drawing.Point(240, 28);
        this.lblSoPhong.Name = "lblSoPhong";
        this.lblSoPhong.Size = new System.Drawing.Size(68, 17);
        this.lblSoPhong.TabIndex = 2;
        this.lblSoPhong.Text = "Số phòng:";

        // txtSoPhong
        this.txtSoPhong.Location = new System.Drawing.Point(315, 25);
        this.txtSoPhong.Name = "txtSoPhong";
        this.txtSoPhong.Size = new System.Drawing.Size(130, 24);
        this.txtSoPhong.TabIndex = 3;

        // lblTangSo
        this.lblTangSo.AutoSize = true;
        this.lblTangSo.Location = new System.Drawing.Point(465, 28);
        this.lblTangSo.Name = "lblTangSo";
        this.lblTangSo.Size = new System.Drawing.Size(57, 17);
        this.lblTangSo.TabIndex = 4;
        this.lblTangSo.Text = "Tầng số:";

        // numTangSo
        this.numTangSo.Location = new System.Drawing.Point(530, 25);
        this.numTangSo.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
        this.numTangSo.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        this.numTangSo.Name = "numTangSo";
        this.numTangSo.Size = new System.Drawing.Size(80, 24);
        this.numTangSo.TabIndex = 5;
        this.numTangSo.Value = new decimal(new int[] { 1, 0, 0, 0 });

        // lblLoaiPhong
        this.lblLoaiPhong.AutoSize = true;
        this.lblLoaiPhong.Location = new System.Drawing.Point(20, 70);
        this.lblLoaiPhong.Name = "lblLoaiPhong";
        this.lblLoaiPhong.Size = new System.Drawing.Size(76, 17);
        this.lblLoaiPhong.TabIndex = 6;
        this.lblLoaiPhong.Text = "Loại phòng:";

        // cboLoaiPhong
        this.cboLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboLoaiPhong.FormattingEnabled = true;
        this.cboLoaiPhong.Location = new System.Drawing.Point(100, 67);
        this.cboLoaiPhong.Name = "cboLoaiPhong";
        this.cboLoaiPhong.Size = new System.Drawing.Size(210, 24);
        this.cboLoaiPhong.TabIndex = 7;

        // btnQuanLyLoaiPhong
        this.btnQuanLyLoaiPhong.BackColor = System.Drawing.Color.PaleGoldenrod;
        this.btnQuanLyLoaiPhong.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnQuanLyLoaiPhong.Location = new System.Drawing.Point(315, 65);
        this.btnQuanLyLoaiPhong.Name = "btnQuanLyLoaiPhong";
        this.btnQuanLyLoaiPhong.Size = new System.Drawing.Size(130, 28);
        this.btnQuanLyLoaiPhong.TabIndex = 8;
        this.btnQuanLyLoaiPhong.Text = "QL Loại phòng...";
        this.btnQuanLyLoaiPhong.UseVisualStyleBackColor = false;
        this.btnQuanLyLoaiPhong.Click += new System.EventHandler(this.btnQuanLyLoaiPhong_Click);

        // lblTinhTrang
        this.lblTinhTrang.AutoSize = true;
        this.lblTinhTrang.Location = new System.Drawing.Point(465, 70);
        this.lblTinhTrang.Name = "lblTinhTrang";
        this.lblTinhTrang.Size = new System.Drawing.Size(71, 17);
        this.lblTinhTrang.TabIndex = 9;
        this.lblTinhTrang.Text = "Tình trạng:";

        // cboTinhTrang
        this.cboTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboTinhTrang.FormattingEnabled = true;
        this.cboTinhTrang.Items.AddRange(new object[] { "Trống", "Đang ở", "Đang dọn" });
        this.cboTinhTrang.Location = new System.Drawing.Point(540, 67);
        this.cboTinhTrang.Name = "cboTinhTrang";
        this.cboTinhTrang.Size = new System.Drawing.Size(120, 24);
        this.cboTinhTrang.TabIndex = 10;

        // lblHinhAnh
        this.lblHinhAnh.AutoSize = true;
        this.lblHinhAnh.Location = new System.Drawing.Point(20, 115);
        this.lblHinhAnh.Name = "lblHinhAnh";
        this.lblHinhAnh.Size = new System.Drawing.Size(63, 17);
        this.lblHinhAnh.TabIndex = 11;
        this.lblHinhAnh.Text = "Hình ảnh:";

        // txtHinhAnh
        this.txtHinhAnh.Location = new System.Drawing.Point(100, 112);
        this.txtHinhAnh.Name = "txtHinhAnh";
        this.txtHinhAnh.ReadOnly = true;
        this.txtHinhAnh.Size = new System.Drawing.Size(345, 24);
        this.txtHinhAnh.TabIndex = 12;

        // btnChonAnh
        this.btnChonAnh.BackColor = System.Drawing.Color.LightCyan;
        this.btnChonAnh.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnChonAnh.Location = new System.Drawing.Point(455, 110);
        this.btnChonAnh.Name = "btnChonAnh";
        this.btnChonAnh.Size = new System.Drawing.Size(105, 28);
        this.btnChonAnh.TabIndex = 13;
        this.btnChonAnh.Text = "Chọn ảnh...";
        this.btnChonAnh.UseVisualStyleBackColor = false;
        this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);

        // picHinhAnh
        this.picHinhAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.picHinhAnh.Location = new System.Drawing.Point(740, 20);
        this.picHinhAnh.Name = "picHinhAnh";
        this.picHinhAnh.Size = new System.Drawing.Size(230, 150);
        this.picHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        this.picHinhAnh.TabIndex = 14;
        this.picHinhAnh.TabStop = false;

        // btnThem
        this.btnThem.BackColor = System.Drawing.Color.LightSkyBlue;
        this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnThem.Location = new System.Drawing.Point(100, 170);
        this.btnThem.Name = "btnThem";
        this.btnThem.Size = new System.Drawing.Size(100, 38);
        this.btnThem.TabIndex = 15;
        this.btnThem.Text = "Thêm";
        this.btnThem.UseVisualStyleBackColor = false;
        this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

        // btnSua
        this.btnSua.BackColor = System.Drawing.Color.Khaki;
        this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnSua.Location = new System.Drawing.Point(215, 170);
        this.btnSua.Name = "btnSua";
        this.btnSua.Size = new System.Drawing.Size(100, 38);
        this.btnSua.TabIndex = 16;
        this.btnSua.Text = "Sửa";
        this.btnSua.UseVisualStyleBackColor = false;
        this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

        // btnXoa
        this.btnXoa.BackColor = System.Drawing.Color.LightCoral;
        this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnXoa.Location = new System.Drawing.Point(330, 170);
        this.btnXoa.Name = "btnXoa";
        this.btnXoa.Size = new System.Drawing.Size(100, 38);
        this.btnXoa.TabIndex = 17;
        this.btnXoa.Text = "Xóa";
        this.btnXoa.UseVisualStyleBackColor = false;
        this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

        // btnLamMoi
        this.btnLamMoi.BackColor = System.Drawing.Color.LightGray;
        this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnLamMoi.Location = new System.Drawing.Point(445, 170);
        this.btnLamMoi.Name = "btnLamMoi";
        this.btnLamMoi.Size = new System.Drawing.Size(100, 38);
        this.btnLamMoi.TabIndex = 18;
        this.btnLamMoi.Text = "Làm mới";
        this.btnLamMoi.UseVisualStyleBackColor = false;
        this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

        // grpTimKiem
        this.grpTimKiem.Controls.Add(this.lblLocLoaiPhong);
        this.grpTimKiem.Controls.Add(this.cboLocLoaiPhong);
        this.grpTimKiem.Controls.Add(this.lblLocTinhTrang);
        this.grpTimKiem.Controls.Add(this.cboLocTinhTrang);
        this.grpTimKiem.Controls.Add(this.btnTimKiem);
        this.grpTimKiem.Controls.Add(this.btnHienTatCa);
        this.grpTimKiem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.grpTimKiem.Location = new System.Drawing.Point(16, 290);
        this.grpTimKiem.Name = "grpTimKiem";
        this.grpTimKiem.Size = new System.Drawing.Size(988, 65);
        this.grpTimKiem.TabIndex = 2;
        this.grpTimKiem.TabStop = false;
        this.grpTimKiem.Text = "Tìm kiếm kết hợp (Loại phòng && Tình trạng)";

        // lblLocLoaiPhong
        this.lblLocLoaiPhong.AutoSize = true;
        this.lblLocLoaiPhong.Location = new System.Drawing.Point(20, 27);
        this.lblLocLoaiPhong.Name = "lblLocLoaiPhong";
        this.lblLocLoaiPhong.Size = new System.Drawing.Size(76, 17);
        this.lblLocLoaiPhong.TabIndex = 0;
        this.lblLocLoaiPhong.Text = "Loại phòng:";

        // cboLocLoaiPhong
        this.cboLocLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboLocLoaiPhong.FormattingEnabled = true;
        this.cboLocLoaiPhong.Location = new System.Drawing.Point(105, 24);
        this.cboLocLoaiPhong.Name = "cboLocLoaiPhong";
        this.cboLocLoaiPhong.Size = new System.Drawing.Size(220, 24);
        this.cboLocLoaiPhong.TabIndex = 1;

        // lblLocTinhTrang
        this.lblLocTinhTrang.AutoSize = true;
        this.lblLocTinhTrang.Location = new System.Drawing.Point(345, 27);
        this.lblLocTinhTrang.Name = "lblLocTinhTrang";
        this.lblLocTinhTrang.Size = new System.Drawing.Size(71, 17);
        this.lblLocTinhTrang.TabIndex = 2;
        this.lblLocTinhTrang.Text = "Tình trạng:";

        // cboLocTinhTrang
        this.cboLocTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboLocTinhTrang.FormattingEnabled = true;
        this.cboLocTinhTrang.Items.AddRange(new object[] { "-- Tất cả --", "Trống", "Đang ở", "Đang dọn" });
        this.cboLocTinhTrang.Location = new System.Drawing.Point(425, 24);
        this.cboLocTinhTrang.Name = "cboLocTinhTrang";
        this.cboLocTinhTrang.Size = new System.Drawing.Size(150, 24);
        this.cboLocTinhTrang.TabIndex = 3;

        // btnTimKiem
        this.btnTimKiem.BackColor = System.Drawing.Color.LightCyan;
        this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnTimKiem.Location = new System.Drawing.Point(620, 20);
        this.btnTimKiem.Name = "btnTimKiem";
        this.btnTimKiem.Size = new System.Drawing.Size(110, 32);
        this.btnTimKiem.TabIndex = 4;
        this.btnTimKiem.Text = "Tìm kiếm";
        this.btnTimKiem.UseVisualStyleBackColor = false;
        this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);

        // btnHienTatCa
        this.btnHienTatCa.Location = new System.Drawing.Point(745, 20);
        this.btnHienTatCa.Name = "btnHienTatCa";
        this.btnHienTatCa.Size = new System.Drawing.Size(120, 32);
        this.btnHienTatCa.TabIndex = 5;
        this.btnHienTatCa.Text = "Hiện tất cả";
        this.btnHienTatCa.UseVisualStyleBackColor = true;
        this.btnHienTatCa.Click += new System.EventHandler(this.btnHienTatCa_Click);

        // grpDanhSach
        this.grpDanhSach.Controls.Add(this.dgvPhong);
        this.grpDanhSach.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.grpDanhSach.Location = new System.Drawing.Point(16, 365);
        this.grpDanhSach.Name = "grpDanhSach";
        this.grpDanhSach.Size = new System.Drawing.Size(988, 280);
        this.grpDanhSach.TabIndex = 3;
        this.grpDanhSach.TabStop = false;
        this.grpDanhSach.Text = "Danh sách phòng";

        // dgvPhong
        this.dgvPhong.AllowUserToAddRows = false;
        this.dgvPhong.AllowUserToDeleteRows = false;
        this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvPhong.BackgroundColor = System.Drawing.Color.White;
        this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvPhong.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dgvPhong.Location = new System.Drawing.Point(3, 20);
        this.dgvPhong.MultiSelect = false;
        this.dgvPhong.Name = "dgvPhong";
        this.dgvPhong.ReadOnly = true;
        this.dgvPhong.RowHeadersWidth = 51;
        this.dgvPhong.RowTemplate.Height = 60;
        this.dgvPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvPhong.Size = new System.Drawing.Size(982, 257);
        this.dgvPhong.TabIndex = 0;
        this.dgvPhong.SelectionChanged += new System.EventHandler(this.dgvPhong_SelectionChanged);

        // Form1
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(1020, 660);
        this.Controls.Add(this.grpDanhSach);
        this.Controls.Add(this.grpTimKiem);
        this.Controls.Add(this.grpThongTin);
        this.Controls.Add(this.lblTieuDe);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.Name = "Form1";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Quản lý Phòng ở - Sunrise Homestay";
        this.Load += new System.EventHandler(this.Form1_Load);
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);

        this.grpThongTin.ResumeLayout(false);
        this.grpThongTin.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.numTangSo)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).EndInit();
        this.grpTimKiem.ResumeLayout(false);
        this.grpTimKiem.PerformLayout();
        this.grpDanhSach.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
        this.ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Label lblTieuDe;
    private System.Windows.Forms.GroupBox grpThongTin;
    private System.Windows.Forms.Label lblMaPhong;
    private System.Windows.Forms.TextBox txtMaPhong;
    private System.Windows.Forms.Label lblSoPhong;
    private System.Windows.Forms.TextBox txtSoPhong;
    private System.Windows.Forms.Label lblTangSo;
    private System.Windows.Forms.NumericUpDown numTangSo;
    private System.Windows.Forms.Label lblLoaiPhong;
    private System.Windows.Forms.ComboBox cboLoaiPhong;
    private System.Windows.Forms.Button btnQuanLyLoaiPhong;
    private System.Windows.Forms.Label lblTinhTrang;
    private System.Windows.Forms.ComboBox cboTinhTrang;
    private System.Windows.Forms.Label lblHinhAnh;
    private System.Windows.Forms.TextBox txtHinhAnh;
    private System.Windows.Forms.Button btnChonAnh;
    private System.Windows.Forms.PictureBox picHinhAnh;
    private System.Windows.Forms.Button btnThem;
    private System.Windows.Forms.Button btnSua;
    private System.Windows.Forms.Button btnXoa;
    private System.Windows.Forms.Button btnLamMoi;
    private System.Windows.Forms.GroupBox grpTimKiem;
    private System.Windows.Forms.Label lblLocLoaiPhong;
    private System.Windows.Forms.ComboBox cboLocLoaiPhong;
    private System.Windows.Forms.Label lblLocTinhTrang;
    private System.Windows.Forms.ComboBox cboLocTinhTrang;
    private System.Windows.Forms.Button btnTimKiem;
    private System.Windows.Forms.Button btnHienTatCa;
    private System.Windows.Forms.GroupBox grpDanhSach;
    private System.Windows.Forms.DataGridView dgvPhong;
}
