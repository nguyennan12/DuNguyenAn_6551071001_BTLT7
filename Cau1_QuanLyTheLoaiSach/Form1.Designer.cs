namespace Cau1_QuanLyTheLoaiSach;

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
        this.components = new System.ComponentModel.Container();
        this.grpThongTin = new System.Windows.Forms.GroupBox();
        this.lblMaTL = new System.Windows.Forms.Label();
        this.txtMaTL = new System.Windows.Forms.TextBox();
        this.lblTenTheLoai = new System.Windows.Forms.Label();
        this.txtTenTheLoai = new System.Windows.Forms.TextBox();
        this.lblSoLuongSach = new System.Windows.Forms.Label();
        this.numSoLuongSach = new System.Windows.Forms.NumericUpDown();
        this.lblNgayTao = new System.Windows.Forms.Label();
        this.lblNgayTaoValue = new System.Windows.Forms.Label();
        this.lblMoTa = new System.Windows.Forms.Label();
        this.txtMoTa = new System.Windows.Forms.TextBox();
        this.btnThem = new System.Windows.Forms.Button();
        this.btnSua = new System.Windows.Forms.Button();
        this.btnXoa = new System.Windows.Forms.Button();
        this.btnLamMoi = new System.Windows.Forms.Button();
        this.grpTimKiem = new System.Windows.Forms.GroupBox();
        this.lblTimKiem = new System.Windows.Forms.Label();
        this.txtTimKiem = new System.Windows.Forms.TextBox();
        this.btnTimKiem = new System.Windows.Forms.Button();
        this.btnHienTatCa = new System.Windows.Forms.Button();
        this.grpDanhSach = new System.Windows.Forms.GroupBox();
        this.dgvTheLoai = new System.Windows.Forms.DataGridView();
        this.lblTieuDe = new System.Windows.Forms.Label();

        this.grpThongTin.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.numSoLuongSach)).BeginInit();
        this.grpTimKiem.SuspendLayout();
        this.grpDanhSach.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvTheLoai)).BeginInit();
        this.SuspendLayout();

        // lblTieuDe
        this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
        this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblTieuDe.ForeColor = System.Drawing.Color.DarkBlue;
        this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
        this.lblTieuDe.Name = "lblTieuDe";
        this.lblTieuDe.Size = new System.Drawing.Size(920, 50);
        this.lblTieuDe.TabIndex = 0;
        this.lblTieuDe.Text = "QUẢN LÝ THỂ LOẠI SÁCH - NHÀ SÁCH TRI THỨC BOOKS";
        this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        // grpThongTin
        this.grpThongTin.Controls.Add(this.lblMaTL);
        this.grpThongTin.Controls.Add(this.txtMaTL);
        this.grpThongTin.Controls.Add(this.lblTenTheLoai);
        this.grpThongTin.Controls.Add(this.txtTenTheLoai);
        this.grpThongTin.Controls.Add(this.lblSoLuongSach);
        this.grpThongTin.Controls.Add(this.numSoLuongSach);
        this.grpThongTin.Controls.Add(this.lblNgayTao);
        this.grpThongTin.Controls.Add(this.lblNgayTaoValue);
        this.grpThongTin.Controls.Add(this.lblMoTa);
        this.grpThongTin.Controls.Add(this.txtMoTa);
        this.grpThongTin.Controls.Add(this.btnThem);
        this.grpThongTin.Controls.Add(this.btnSua);
        this.grpThongTin.Controls.Add(this.btnXoa);
        this.grpThongTin.Controls.Add(this.btnLamMoi);
        this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.grpThongTin.Location = new System.Drawing.Point(16, 55);
        this.grpThongTin.Name = "grpThongTin";
        this.grpThongTin.Size = new System.Drawing.Size(888, 200);
        this.grpThongTin.TabIndex = 1;
        this.grpThongTin.TabStop = false;
        this.grpThongTin.Text = "Thông tin thể loại sách";

        // lblMaTL
        this.lblMaTL.AutoSize = true;
        this.lblMaTL.Location = new System.Drawing.Point(20, 32);
        this.lblMaTL.Name = "lblMaTL";
        this.lblMaTL.Size = new System.Drawing.Size(79, 17);
        this.lblMaTL.Text = "Mã thể loại:";

        // txtMaTL
        this.txtMaTL.Location = new System.Drawing.Point(110, 28);
        this.txtMaTL.Name = "txtMaTL";
        this.txtMaTL.ReadOnly = true;
        this.txtMaTL.Size = new System.Drawing.Size(260, 24);
        this.txtMaTL.TabIndex = 0;

        // lblTenTheLoai
        this.lblTenTheLoai.AutoSize = true;
        this.lblTenTheLoai.Location = new System.Drawing.Point(20, 68);
        this.lblTenTheLoai.Name = "lblTenTheLoai";
        this.lblTenTheLoai.Size = new System.Drawing.Size(80, 17);
        this.lblTenTheLoai.Text = "Tên thể loại:";

        // txtTenTheLoai
        this.txtTenTheLoai.Location = new System.Drawing.Point(110, 64);
        this.txtTenTheLoai.Name = "txtTenTheLoai";
        this.txtTenTheLoai.Size = new System.Drawing.Size(260, 24);
        this.txtTenTheLoai.TabIndex = 1;

        // lblSoLuongSach
        this.lblSoLuongSach.AutoSize = true;
        this.lblSoLuongSach.Location = new System.Drawing.Point(20, 106);
        this.lblSoLuongSach.Name = "lblSoLuongSach";
        this.lblSoLuongSach.Size = new System.Drawing.Size(95, 17);
        this.lblSoLuongSach.Text = "Số lượng sách:";

        // numSoLuongSach
        this.numSoLuongSach.Location = new System.Drawing.Point(110, 102);
        this.numSoLuongSach.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
        this.numSoLuongSach.Name = "numSoLuongSach";
        this.numSoLuongSach.Size = new System.Drawing.Size(120, 24);
        this.numSoLuongSach.TabIndex = 2;

        // lblNgayTao
        this.lblNgayTao.AutoSize = true;
        this.lblNgayTao.Location = new System.Drawing.Point(20, 142);
        this.lblNgayTao.Name = "lblNgayTao";
        this.lblNgayTao.Size = new System.Drawing.Size(65, 17);
        this.lblNgayTao.Text = "Ngày tạo:";

        // lblNgayTaoValue
        this.lblNgayTaoValue.AutoSize = true;
        this.lblNgayTaoValue.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
        this.lblNgayTaoValue.ForeColor = System.Drawing.Color.DarkSlateGray;
        this.lblNgayTaoValue.Location = new System.Drawing.Point(110, 142);
        this.lblNgayTaoValue.Name = "lblNgayTaoValue";
        this.lblNgayTaoValue.Size = new System.Drawing.Size(28, 17);
        this.lblNgayTaoValue.Text = "---";

        // lblMoTa
        this.lblMoTa.AutoSize = true;
        this.lblMoTa.Location = new System.Drawing.Point(400, 32);
        this.lblMoTa.Name = "lblMoTa";
        this.lblMoTa.Size = new System.Drawing.Size(46, 17);
        this.lblMoTa.Text = "Mô tả:";

        // txtMoTa
        this.txtMoTa.Location = new System.Drawing.Point(455, 28);
        this.txtMoTa.Multiline = true;
        this.txtMoTa.Name = "txtMoTa";
        this.txtMoTa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.txtMoTa.Size = new System.Drawing.Size(415, 98);
        this.txtMoTa.TabIndex = 3;

        // btnThem
        this.btnThem.BackColor = System.Drawing.Color.LightSkyBlue;
        this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnThem.Location = new System.Drawing.Point(455, 142);
        this.btnThem.Name = "btnThem";
        this.btnThem.Size = new System.Drawing.Size(95, 36);
        this.btnThem.TabIndex = 4;
        this.btnThem.Text = "Thêm";
        this.btnThem.UseVisualStyleBackColor = false;
        this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

        // btnSua
        this.btnSua.BackColor = System.Drawing.Color.Khaki;
        this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnSua.Location = new System.Drawing.Point(560, 142);
        this.btnSua.Name = "btnSua";
        this.btnSua.Size = new System.Drawing.Size(95, 36);
        this.btnSua.TabIndex = 5;
        this.btnSua.Text = "Sửa";
        this.btnSua.UseVisualStyleBackColor = false;
        this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

        // btnXoa
        this.btnXoa.BackColor = System.Drawing.Color.LightCoral;
        this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnXoa.Location = new System.Drawing.Point(665, 142);
        this.btnXoa.Name = "btnXoa";
        this.btnXoa.Size = new System.Drawing.Size(95, 36);
        this.btnXoa.TabIndex = 6;
        this.btnXoa.Text = "Xóa";
        this.btnXoa.UseVisualStyleBackColor = false;
        this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

        // btnLamMoi
        this.btnLamMoi.BackColor = System.Drawing.Color.LightGray;
        this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnLamMoi.Location = new System.Drawing.Point(775, 142);
        this.btnLamMoi.Name = "btnLamMoi";
        this.btnLamMoi.Size = new System.Drawing.Size(95, 36);
        this.btnLamMoi.TabIndex = 7;
        this.btnLamMoi.Text = "Làm mới";
        this.btnLamMoi.UseVisualStyleBackColor = false;
        this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

        // grpTimKiem
        this.grpTimKiem.Controls.Add(this.lblTimKiem);
        this.grpTimKiem.Controls.Add(this.txtTimKiem);
        this.grpTimKiem.Controls.Add(this.btnTimKiem);
        this.grpTimKiem.Controls.Add(this.btnHienTatCa);
        this.grpTimKiem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.grpTimKiem.Location = new System.Drawing.Point(16, 262);
        this.grpTimKiem.Name = "grpTimKiem";
        this.grpTimKiem.Size = new System.Drawing.Size(888, 65);
        this.grpTimKiem.TabIndex = 2;
        this.grpTimKiem.TabStop = false;
        this.grpTimKiem.Text = "Tìm kiếm";

        // lblTimKiem
        this.lblTimKiem.AutoSize = true;
        this.lblTimKiem.Location = new System.Drawing.Point(20, 27);
        this.lblTimKiem.Name = "lblTimKiem";
        this.lblTimKiem.Size = new System.Drawing.Size(126, 17);
        this.lblTimKiem.TabIndex = 0;
        this.lblTimKiem.Text = "Tìm theo tên thể loại:";

        // txtTimKiem
        this.txtTimKiem.Location = new System.Drawing.Point(160, 24);
        this.txtTimKiem.Name = "txtTimKiem";
        this.txtTimKiem.PlaceholderText = "Nhập tên thể loại cần tìm...";
        this.txtTimKiem.Size = new System.Drawing.Size(450, 24);
        this.txtTimKiem.TabIndex = 1;
        this.txtTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyDown);

        // btnTimKiem
        this.btnTimKiem.BackColor = System.Drawing.Color.LightCyan;
        this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnTimKiem.Location = new System.Drawing.Point(625, 20);
        this.btnTimKiem.Name = "btnTimKiem";
        this.btnTimKiem.Size = new System.Drawing.Size(110, 32);
        this.btnTimKiem.TabIndex = 2;
        this.btnTimKiem.Text = "Tìm kiếm";
        this.btnTimKiem.UseVisualStyleBackColor = false;
        this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);

        // btnHienTatCa
        this.btnHienTatCa.Location = new System.Drawing.Point(745, 20);
        this.btnHienTatCa.Name = "btnHienTatCa";
        this.btnHienTatCa.Size = new System.Drawing.Size(125, 32);
        this.btnHienTatCa.TabIndex = 3;
        this.btnHienTatCa.Text = "Hiện tất cả";
        this.btnHienTatCa.UseVisualStyleBackColor = true;
        this.btnHienTatCa.Click += new System.EventHandler(this.btnHienTatCa_Click);

        // grpDanhSach
        this.grpDanhSach.Controls.Add(this.dgvTheLoai);
        this.grpDanhSach.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.grpDanhSach.Location = new System.Drawing.Point(16, 335);
        this.grpDanhSach.Name = "grpDanhSach";
        this.grpDanhSach.Size = new System.Drawing.Size(888, 275);
        this.grpDanhSach.TabIndex = 3;
        this.grpDanhSach.TabStop = false;
        this.grpDanhSach.Text = "Danh sách thể loại sách";

        // dgvTheLoai
        this.dgvTheLoai.AllowUserToAddRows = false;
        this.dgvTheLoai.AllowUserToDeleteRows = false;
        this.dgvTheLoai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvTheLoai.BackgroundColor = System.Drawing.Color.White;
        this.dgvTheLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvTheLoai.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dgvTheLoai.Location = new System.Drawing.Point(3, 20);
        this.dgvTheLoai.MultiSelect = false;
        this.dgvTheLoai.Name = "dgvTheLoai";
        this.dgvTheLoai.ReadOnly = true;
        this.dgvTheLoai.RowHeadersWidth = 51;
        this.dgvTheLoai.RowTemplate.Height = 29;
        this.dgvTheLoai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvTheLoai.Size = new System.Drawing.Size(882, 252);
        this.dgvTheLoai.TabIndex = 0;
        this.dgvTheLoai.SelectionChanged += new System.EventHandler(this.dgvTheLoai_SelectionChanged);

        // Form1
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(920, 625);
        this.Controls.Add(this.grpDanhSach);
        this.Controls.Add(this.grpTimKiem);
        this.Controls.Add(this.grpThongTin);
        this.Controls.Add(this.lblTieuDe);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.Name = "Form1";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Quản lý Thể loại Sách - Tri Thức Books";
        this.Load += new System.EventHandler(this.Form1_Load);
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);

        this.grpThongTin.ResumeLayout(false);
        this.grpThongTin.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.numSoLuongSach)).EndInit();
        this.grpTimKiem.ResumeLayout(false);
        this.grpTimKiem.PerformLayout();
        this.grpDanhSach.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dgvTheLoai)).EndInit();
        this.ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Label lblTieuDe;
    private System.Windows.Forms.GroupBox grpThongTin;
    private System.Windows.Forms.Label lblMaTL;
    private System.Windows.Forms.TextBox txtMaTL;
    private System.Windows.Forms.Label lblTenTheLoai;
    private System.Windows.Forms.TextBox txtTenTheLoai;
    private System.Windows.Forms.Label lblSoLuongSach;
    private System.Windows.Forms.NumericUpDown numSoLuongSach;
    private System.Windows.Forms.Label lblNgayTao;
    private System.Windows.Forms.Label lblNgayTaoValue;
    private System.Windows.Forms.Label lblMoTa;
    private System.Windows.Forms.TextBox txtMoTa;
    private System.Windows.Forms.Button btnThem;
    private System.Windows.Forms.Button btnSua;
    private System.Windows.Forms.Button btnXoa;
    private System.Windows.Forms.Button btnLamMoi;
    private System.Windows.Forms.GroupBox grpTimKiem;
    private System.Windows.Forms.Label lblTimKiem;
    private System.Windows.Forms.TextBox txtTimKiem;
    private System.Windows.Forms.Button btnTimKiem;
    private System.Windows.Forms.Button btnHienTatCa;
    private System.Windows.Forms.GroupBox grpDanhSach;
    private System.Windows.Forms.DataGridView dgvTheLoai;
}
