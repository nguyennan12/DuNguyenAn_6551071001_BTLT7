namespace Cau4_QuanLyLichKham;

partial class FormBacSi
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
        this.lblMaBS = new System.Windows.Forms.Label();
        this.txtMaBS = new System.Windows.Forms.TextBox();
        this.lblHoTen = new System.Windows.Forms.Label();
        this.txtHoTen = new System.Windows.Forms.TextBox();
        this.lblChuyenKhoa = new System.Windows.Forms.Label();
        this.txtChuyenKhoa = new System.Windows.Forms.TextBox();
        this.lblSDT = new System.Windows.Forms.Label();
        this.txtSDT = new System.Windows.Forms.TextBox();
        this.btnThem = new System.Windows.Forms.Button();
        this.btnSua = new System.Windows.Forms.Button();
        this.btnXoa = new System.Windows.Forms.Button();
        this.btnLamMoi = new System.Windows.Forms.Button();
        this.grpDanhSach = new System.Windows.Forms.GroupBox();
        this.dgvBacSi = new System.Windows.Forms.DataGridView();

        this.grpThongTin.SuspendLayout();
        this.grpDanhSach.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvBacSi)).BeginInit();
        this.SuspendLayout();

        // lblTieuDe
        this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
        this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblTieuDe.ForeColor = System.Drawing.Color.MidnightBlue;
        this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
        this.lblTieuDe.Name = "lblTieuDe";
        this.lblTieuDe.Size = new System.Drawing.Size(760, 45);
        this.lblTieuDe.TabIndex = 0;
        this.lblTieuDe.Text = "QUẢN LÝ DANH SÁCH BÁC SĨ";
        this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        // grpThongTin
        this.grpThongTin.Controls.Add(this.lblMaBS);
        this.grpThongTin.Controls.Add(this.txtMaBS);
        this.grpThongTin.Controls.Add(this.lblHoTen);
        this.grpThongTin.Controls.Add(this.txtHoTen);
        this.grpThongTin.Controls.Add(this.lblChuyenKhoa);
        this.grpThongTin.Controls.Add(this.txtChuyenKhoa);
        this.grpThongTin.Controls.Add(this.lblSDT);
        this.grpThongTin.Controls.Add(this.txtSDT);
        this.grpThongTin.Controls.Add(this.btnThem);
        this.grpThongTin.Controls.Add(this.btnSua);
        this.grpThongTin.Controls.Add(this.btnXoa);
        this.grpThongTin.Controls.Add(this.btnLamMoi);
        this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.grpThongTin.Location = new System.Drawing.Point(12, 48);
        this.grpThongTin.Name = "grpThongTin";
        this.grpThongTin.Size = new System.Drawing.Size(736, 160);
        this.grpThongTin.TabIndex = 1;
        this.grpThongTin.TabStop = false;
        this.grpThongTin.Text = "Thông tin bác sĩ";

        // lblMaBS
        this.lblMaBS.AutoSize = true;
        this.lblMaBS.Location = new System.Drawing.Point(20, 30);
        this.lblMaBS.Name = "lblMaBS";
        this.lblMaBS.Size = new System.Drawing.Size(68, 17);
        this.lblMaBS.TabIndex = 0;
        this.lblMaBS.Text = "Mã bác sĩ:";

        // txtMaBS
        this.txtMaBS.Location = new System.Drawing.Point(115, 27);
        this.txtMaBS.Name = "txtMaBS";
        this.txtMaBS.ReadOnly = true;
        this.txtMaBS.Size = new System.Drawing.Size(220, 24);
        this.txtMaBS.TabIndex = 1;

        // lblHoTen
        this.lblHoTen.AutoSize = true;
        this.lblHoTen.Location = new System.Drawing.Point(365, 30);
        this.lblHoTen.Name = "lblHoTen";
        this.lblHoTen.Size = new System.Drawing.Size(66, 17);
        this.lblHoTen.TabIndex = 2;
        this.lblHoTen.Text = "Họ và tên:";

        // txtHoTen
        this.txtHoTen.Location = new System.Drawing.Point(460, 27);
        this.txtHoTen.Name = "txtHoTen";
        this.txtHoTen.Size = new System.Drawing.Size(250, 24);
        this.txtHoTen.TabIndex = 3;

        // lblChuyenKhoa
        this.lblChuyenKhoa.AutoSize = true;
        this.lblChuyenKhoa.Location = new System.Drawing.Point(20, 68);
        this.lblChuyenKhoa.Name = "lblChuyenKhoa";
        this.lblChuyenKhoa.Size = new System.Drawing.Size(86, 17);
        this.lblChuyenKhoa.TabIndex = 4;
        this.lblChuyenKhoa.Text = "Chuyên khoa:";

        // txtChuyenKhoa
        this.txtChuyenKhoa.Location = new System.Drawing.Point(115, 65);
        this.txtChuyenKhoa.Name = "txtChuyenKhoa";
        this.txtChuyenKhoa.Size = new System.Drawing.Size(220, 24);
        this.txtChuyenKhoa.TabIndex = 5;

        // lblSDT
        this.lblSDT.AutoSize = true;
        this.lblSDT.Location = new System.Drawing.Point(365, 68);
        this.lblSDT.Name = "lblSDT";
        this.lblSDT.Size = new System.Drawing.Size(88, 17);
        this.lblSDT.TabIndex = 6;
        this.lblSDT.Text = "Số điện thoại:";

        // txtSDT
        this.txtSDT.Location = new System.Drawing.Point(460, 65);
        this.txtSDT.Name = "txtSDT";
        this.txtSDT.Size = new System.Drawing.Size(250, 24);
        this.txtSDT.TabIndex = 7;

        // btnThem
        this.btnThem.BackColor = System.Drawing.Color.LightSkyBlue;
        this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnThem.Location = new System.Drawing.Point(115, 108);
        this.btnThem.Name = "btnThem";
        this.btnThem.Size = new System.Drawing.Size(90, 36);
        this.btnThem.TabIndex = 8;
        this.btnThem.Text = "Thêm";
        this.btnThem.UseVisualStyleBackColor = false;
        this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

        // btnSua
        this.btnSua.BackColor = System.Drawing.Color.Khaki;
        this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnSua.Location = new System.Drawing.Point(220, 108);
        this.btnSua.Name = "btnSua";
        this.btnSua.Size = new System.Drawing.Size(90, 36);
        this.btnSua.TabIndex = 9;
        this.btnSua.Text = "Sửa";
        this.btnSua.UseVisualStyleBackColor = false;
        this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

        // btnXoa
        this.btnXoa.BackColor = System.Drawing.Color.LightCoral;
        this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnXoa.Location = new System.Drawing.Point(325, 108);
        this.btnXoa.Name = "btnXoa";
        this.btnXoa.Size = new System.Drawing.Size(90, 36);
        this.btnXoa.TabIndex = 10;
        this.btnXoa.Text = "Xóa";
        this.btnXoa.UseVisualStyleBackColor = false;
        this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

        // btnLamMoi
        this.btnLamMoi.BackColor = System.Drawing.Color.LightGray;
        this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnLamMoi.Location = new System.Drawing.Point(430, 108);
        this.btnLamMoi.Name = "btnLamMoi";
        this.btnLamMoi.Size = new System.Drawing.Size(95, 36);
        this.btnLamMoi.TabIndex = 11;
        this.btnLamMoi.Text = "Làm mới";
        this.btnLamMoi.UseVisualStyleBackColor = false;
        this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

        // grpDanhSach
        this.grpDanhSach.Controls.Add(this.dgvBacSi);
        this.grpDanhSach.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.grpDanhSach.Location = new System.Drawing.Point(12, 218);
        this.grpDanhSach.Name = "grpDanhSach";
        this.grpDanhSach.Size = new System.Drawing.Size(736, 240);
        this.grpDanhSach.TabIndex = 2;
        this.grpDanhSach.TabStop = false;
        this.grpDanhSach.Text = "Danh sách bác sĩ";

        // dgvBacSi
        this.dgvBacSi.AllowUserToAddRows = false;
        this.dgvBacSi.AllowUserToDeleteRows = false;
        this.dgvBacSi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvBacSi.BackgroundColor = System.Drawing.Color.White;
        this.dgvBacSi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvBacSi.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dgvBacSi.Location = new System.Drawing.Point(3, 20);
        this.dgvBacSi.MultiSelect = false;
        this.dgvBacSi.Name = "dgvBacSi";
        this.dgvBacSi.ReadOnly = true;
        this.dgvBacSi.RowHeadersWidth = 51;
        this.dgvBacSi.RowTemplate.Height = 29;
        this.dgvBacSi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvBacSi.Size = new System.Drawing.Size(730, 217);
        this.dgvBacSi.TabIndex = 0;
        this.dgvBacSi.SelectionChanged += new System.EventHandler(this.dgvBacSi_SelectionChanged);

        // FormBacSi
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(760, 470);
        this.Controls.Add(this.grpDanhSach);
        this.Controls.Add(this.grpThongTin);
        this.Controls.Add(this.lblTieuDe);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "FormBacSi";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "Quản lý Bác sĩ - An Khang Clinic";
        this.Load += new System.EventHandler(this.FormBacSi_Load);
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBacSi_FormClosing);

        this.grpThongTin.ResumeLayout(false);
        this.grpThongTin.PerformLayout();
        this.grpDanhSach.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dgvBacSi)).EndInit();
        this.ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Label lblTieuDe;
    private System.Windows.Forms.GroupBox grpThongTin;
    private System.Windows.Forms.Label lblMaBS;
    private System.Windows.Forms.TextBox txtMaBS;
    private System.Windows.Forms.Label lblHoTen;
    private System.Windows.Forms.TextBox txtHoTen;
    private System.Windows.Forms.Label lblChuyenKhoa;
    private System.Windows.Forms.TextBox txtChuyenKhoa;
    private System.Windows.Forms.Label lblSDT;
    private System.Windows.Forms.TextBox txtSDT;
    private System.Windows.Forms.Button btnThem;
    private System.Windows.Forms.Button btnSua;
    private System.Windows.Forms.Button btnXoa;
    private System.Windows.Forms.Button btnLamMoi;
    private System.Windows.Forms.GroupBox grpDanhSach;
    private System.Windows.Forms.DataGridView dgvBacSi;
}
