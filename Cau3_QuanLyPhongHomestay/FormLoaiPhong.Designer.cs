namespace Cau3_QuanLyPhongHomestay;

partial class FormLoaiPhong
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
        this.lblMaLoai = new System.Windows.Forms.Label();
        this.txtMaLoai = new System.Windows.Forms.TextBox();
        this.lblTenLoai = new System.Windows.Forms.Label();
        this.txtTenLoai = new System.Windows.Forms.TextBox();
        this.lblGiaMoiDem = new System.Windows.Forms.Label();
        this.numGiaMoiDem = new System.Windows.Forms.NumericUpDown();
        this.lblMoTa = new System.Windows.Forms.Label();
        this.txtMoTa = new System.Windows.Forms.TextBox();
        this.btnThem = new System.Windows.Forms.Button();
        this.btnSua = new System.Windows.Forms.Button();
        this.btnXoa = new System.Windows.Forms.Button();
        this.btnLamMoi = new System.Windows.Forms.Button();
        this.grpDanhSach = new System.Windows.Forms.GroupBox();
        this.dgvLoaiPhong = new System.Windows.Forms.DataGridView();

        this.grpThongTin.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.numGiaMoiDem)).BeginInit();
        this.grpDanhSach.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiPhong)).BeginInit();
        this.SuspendLayout();

        // lblTieuDe
        this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
        this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblTieuDe.ForeColor = System.Drawing.Color.DarkOliveGreen;
        this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
        this.lblTieuDe.Name = "lblTieuDe";
        this.lblTieuDe.Size = new System.Drawing.Size(780, 45);
        this.lblTieuDe.TabIndex = 0;
        this.lblTieuDe.Text = "QUẢN LÝ DANH MỤC LOẠI PHÒNG";
        this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        // grpThongTin
        this.grpThongTin.Controls.Add(this.lblMaLoai);
        this.grpThongTin.Controls.Add(this.txtMaLoai);
        this.grpThongTin.Controls.Add(this.lblTenLoai);
        this.grpThongTin.Controls.Add(this.txtTenLoai);
        this.grpThongTin.Controls.Add(this.lblGiaMoiDem);
        this.grpThongTin.Controls.Add(this.numGiaMoiDem);
        this.grpThongTin.Controls.Add(this.lblMoTa);
        this.grpThongTin.Controls.Add(this.txtMoTa);
        this.grpThongTin.Controls.Add(this.btnThem);
        this.grpThongTin.Controls.Add(this.btnSua);
        this.grpThongTin.Controls.Add(this.btnXoa);
        this.grpThongTin.Controls.Add(this.btnLamMoi);
        this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.grpThongTin.Location = new System.Drawing.Point(12, 48);
        this.grpThongTin.Name = "grpThongTin";
        this.grpThongTin.Size = new System.Drawing.Size(756, 175);
        this.grpThongTin.TabIndex = 1;
        this.grpThongTin.TabStop = false;
        this.grpThongTin.Text = "Thông tin loại phòng";

        // lblMaLoai
        this.lblMaLoai.AutoSize = true;
        this.lblMaLoai.Location = new System.Drawing.Point(20, 30);
        this.lblMaLoai.Name = "lblMaLoai";
        this.lblMaLoai.Size = new System.Drawing.Size(56, 17);
        this.lblMaLoai.TabIndex = 0;
        this.lblMaLoai.Text = "Mã loại:";

        // txtMaLoai
        this.txtMaLoai.Location = new System.Drawing.Point(110, 27);
        this.txtMaLoai.Name = "txtMaLoai";
        this.txtMaLoai.ReadOnly = true;
        this.txtMaLoai.Size = new System.Drawing.Size(220, 24);
        this.txtMaLoai.TabIndex = 1;

        // lblTenLoai
        this.lblTenLoai.AutoSize = true;
        this.lblTenLoai.Location = new System.Drawing.Point(20, 68);
        this.lblTenLoai.Name = "lblTenLoai";
        this.lblTenLoai.Size = new System.Drawing.Size(57, 17);
        this.lblTenLoai.TabIndex = 2;
        this.lblTenLoai.Text = "Tên loại:";

        // txtTenLoai
        this.txtTenLoai.Location = new System.Drawing.Point(110, 65);
        this.txtTenLoai.Name = "txtTenLoai";
        this.txtTenLoai.Size = new System.Drawing.Size(220, 24);
        this.txtTenLoai.TabIndex = 3;

        // lblGiaMoiDem
        this.lblGiaMoiDem.AutoSize = true;
        this.lblGiaMoiDem.Location = new System.Drawing.Point(20, 106);
        this.lblGiaMoiDem.Name = "lblGiaMoiDem";
        this.lblGiaMoiDem.Size = new System.Drawing.Size(83, 17);
        this.lblGiaMoiDem.TabIndex = 4;
        this.lblGiaMoiDem.Text = "Giá/đêm (đ):";

        // numGiaMoiDem
        this.numGiaMoiDem.DecimalPlaces = 0;
        this.numGiaMoiDem.Increment = new decimal(new int[] { 50000, 0, 0, 0 });
        this.numGiaMoiDem.Location = new System.Drawing.Point(110, 104);
        this.numGiaMoiDem.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
        this.numGiaMoiDem.Name = "numGiaMoiDem";
        this.numGiaMoiDem.Size = new System.Drawing.Size(220, 24);
        this.numGiaMoiDem.TabIndex = 5;
        this.numGiaMoiDem.ThousandsSeparator = true;

        // lblMoTa
        this.lblMoTa.AutoSize = true;
        this.lblMoTa.Location = new System.Drawing.Point(360, 30);
        this.lblMoTa.Name = "lblMoTa";
        this.lblMoTa.Size = new System.Drawing.Size(46, 17);
        this.lblMoTa.TabIndex = 6;
        this.lblMoTa.Text = "Mô tả:";

        // txtMoTa
        this.txtMoTa.Location = new System.Drawing.Point(415, 27);
        this.txtMoTa.Multiline = true;
        this.txtMoTa.Name = "txtMoTa";
        this.txtMoTa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.txtMoTa.Size = new System.Drawing.Size(325, 62);
        this.txtMoTa.TabIndex = 7;

        // btnThem
        this.btnThem.BackColor = System.Drawing.Color.LightSkyBlue;
        this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnThem.Location = new System.Drawing.Point(360, 115);
        this.btnThem.Name = "btnThem";
        this.btnThem.Size = new System.Drawing.Size(85, 36);
        this.btnThem.TabIndex = 8;
        this.btnThem.Text = "Thêm";
        this.btnThem.UseVisualStyleBackColor = false;
        this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

        // btnSua
        this.btnSua.BackColor = System.Drawing.Color.Khaki;
        this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnSua.Location = new System.Drawing.Point(455, 115);
        this.btnSua.Name = "btnSua";
        this.btnSua.Size = new System.Drawing.Size(85, 36);
        this.btnSua.TabIndex = 9;
        this.btnSua.Text = "Sửa";
        this.btnSua.UseVisualStyleBackColor = false;
        this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

        // btnXoa
        this.btnXoa.BackColor = System.Drawing.Color.LightCoral;
        this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnXoa.Location = new System.Drawing.Point(550, 115);
        this.btnXoa.Name = "btnXoa";
        this.btnXoa.Size = new System.Drawing.Size(85, 36);
        this.btnXoa.TabIndex = 10;
        this.btnXoa.Text = "Xóa";
        this.btnXoa.UseVisualStyleBackColor = false;
        this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

        // btnLamMoi
        this.btnLamMoi.BackColor = System.Drawing.Color.LightGray;
        this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnLamMoi.Location = new System.Drawing.Point(645, 115);
        this.btnLamMoi.Name = "btnLamMoi";
        this.btnLamMoi.Size = new System.Drawing.Size(95, 36);
        this.btnLamMoi.TabIndex = 11;
        this.btnLamMoi.Text = "Làm mới";
        this.btnLamMoi.UseVisualStyleBackColor = false;
        this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

        // grpDanhSach
        this.grpDanhSach.Controls.Add(this.dgvLoaiPhong);
        this.grpDanhSach.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.grpDanhSach.Location = new System.Drawing.Point(12, 230);
        this.grpDanhSach.Name = "grpDanhSach";
        this.grpDanhSach.Size = new System.Drawing.Size(756, 230);
        this.grpDanhSach.TabIndex = 2;
        this.grpDanhSach.TabStop = false;
        this.grpDanhSach.Text = "Danh sách loại phòng";

        // dgvLoaiPhong
        this.dgvLoaiPhong.AllowUserToAddRows = false;
        this.dgvLoaiPhong.AllowUserToDeleteRows = false;
        this.dgvLoaiPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvLoaiPhong.BackgroundColor = System.Drawing.Color.White;
        this.dgvLoaiPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvLoaiPhong.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dgvLoaiPhong.Location = new System.Drawing.Point(3, 20);
        this.dgvLoaiPhong.MultiSelect = false;
        this.dgvLoaiPhong.Name = "dgvLoaiPhong";
        this.dgvLoaiPhong.ReadOnly = true;
        this.dgvLoaiPhong.RowHeadersWidth = 51;
        this.dgvLoaiPhong.RowTemplate.Height = 29;
        this.dgvLoaiPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvLoaiPhong.Size = new System.Drawing.Size(750, 207);
        this.dgvLoaiPhong.TabIndex = 0;
        this.dgvLoaiPhong.SelectionChanged += new System.EventHandler(this.dgvLoaiPhong_SelectionChanged);

        // FormLoaiPhong
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(780, 475);
        this.Controls.Add(this.grpDanhSach);
        this.Controls.Add(this.grpThongTin);
        this.Controls.Add(this.lblTieuDe);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "FormLoaiPhong";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "Quản lý Loại phòng - Sunrise Homestay";
        this.Load += new System.EventHandler(this.FormLoaiPhong_Load);
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLoaiPhong_FormClosing);

        this.grpThongTin.ResumeLayout(false);
        this.grpThongTin.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.numGiaMoiDem)).EndInit();
        this.grpDanhSach.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiPhong)).EndInit();
        this.ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Label lblTieuDe;
    private System.Windows.Forms.GroupBox grpThongTin;
    private System.Windows.Forms.Label lblMaLoai;
    private System.Windows.Forms.TextBox txtMaLoai;
    private System.Windows.Forms.Label lblTenLoai;
    private System.Windows.Forms.TextBox txtTenLoai;
    private System.Windows.Forms.Label lblGiaMoiDem;
    private System.Windows.Forms.NumericUpDown numGiaMoiDem;
    private System.Windows.Forms.Label lblMoTa;
    private System.Windows.Forms.TextBox txtMoTa;
    private System.Windows.Forms.Button btnThem;
    private System.Windows.Forms.Button btnSua;
    private System.Windows.Forms.Button btnXoa;
    private System.Windows.Forms.Button btnLamMoi;
    private System.Windows.Forms.GroupBox grpDanhSach;
    private System.Windows.Forms.DataGridView dgvLoaiPhong;
}
