# BÀI TẬP THỰC HÀNH CHƯƠNG 7 — THAO TÁC DATABASE VỚI ENTITY FRAMEWORK CORE

Dự án gồm **4 bài tập** được chia làm **4 thư mục độc lập**, đầy đủ CSDL SQL Server, Reverse-Engineer DbContext/Models (Database First) và Form WinForms CRUD + Tìm kiếm nâng cao:

---

## Danh Sách Bài Tập

### 1. `Cau1_QuanLyTheLoaiSach` — Nhà sách mini "Tri Thức Books"
- **CSDL**: `TriThucBooksDB` (Bảng `TheLoaiSach`: `MaTL`, `TenTheLoai` UNIQUE, `MoTa`, `SoLuongSach`, `NgayTao`).
- **File SQL**: `Cau1_QuanLyTheLoaiSach/Database_TriThucBooks.sql`
- **Tính năng nổi bật**:
  - Giao diện WinForms gồm các TextBox (Mã TL readonly, Tên TL, Mô tả Multiline), NumericUpDown số lượng, Label ngày tạo.
  - Tự động đổ dữ liệu lên control qua sự kiện `SelectionChanged` của `DataGridView`.
  - CRUD đầy đủ với EF Core (`Add()`, `Update()`, `Remove()`, `SaveChangesAsync()`).
  - Xử lý ngoại lệ `DbUpdateException` khi xóa thể loại có ràng buộc dữ liệu.
  - Validate dữ liệu: Không bỏ trống tên thể loại, kiểm tra không cho trùng tên thể loại khi thêm mới / cập nhật.
  - Tìm kiếm LINQ `Where` + `Contains` hiển thị tức thì trên DataGridView.

---

### 2. `Cau2_QuanLyHoiVien` — Phòng tập Gym "FitZone"
- **CSDL**: `FitZoneDB` (Bảng `HoiVien`: `MaHV`, `HoTen`, `GioiTinh`, `NgaySinh`, `SDT`, `Email`, `HangThanhVien`, `NgayDangKy`, `TrangThai`).
- **File SQL**: `Cau2_QuanLyHoiVien/Database_FitZone.sql`
- **Tính năng nổi bật**:
  - Đa dạng các loại controls: `RadioButton` (Nam/Nữ), `DateTimePicker` (Ngày sinh format dd/MM/yyyy), `ComboBox` (Basic/VIP/Premium), `CheckBox` (Đang hoạt động).
  - Tích chọn dòng trên `DataGridView` tự động map chính xác hai chiều toàn bộ các kiểu dữ liệu (`bool?`, `DateOnly?`, `DateTime?`, `string`).
  - Tìm kiếm kết hợp đồng thời 2 điều kiện qua LINQ `Where` và toán tử `&&`: Họ tên (`Contains`) và Hạng thành viên (`ComboBox`).
  - Validate chi tiết từng trường với thông báo cụ thể:
    - SĐT: Chỉ chứa chữ số và đủ 9-11 ký tự.
    - Email: Phải hợp lệ và chứa ký tự `@`.
    - Tuổi hội viên: Phải từ 15 tuổi trở lên tính đến thời điểm hiện tại.
  - Xác nhận hộp thoại Yes/No trước khi xóa.

---

### 3. `Cau3_QuanLyPhongHomestay` — Sunrise Homestay
- **CSDL**: `SunriseHomestayDB` (Bảng quan hệ 1-n: `LoaiPhong` và `Phong`).
- **File SQL**: `Cau3_QuanLyPhongHomestay/Database_SunriseHomestay.sql`
- **Tính năng nổi bật**:
  - Xây dựng **2 Form**:
    - `FormLoaiPhong`: Quản lý danh mục Loại phòng (CRUD đơn giản).
    - `Form1`: Quản lý Phòng ở (CRUD, Upload ảnh, Tìm kiếm đa điều kiện).
  - `ComboBox` chọn Loại phòng lấy DataSource qua LINQ từ bảng `LoaiPhong`.
  - Upload ảnh: Copy file ảnh vào thư mục `Images` của ứng dụng, chỉ lưu tên file ảnh trong CSDL.
  - Hiển thị ảnh:
    - Trên `PictureBox` khi chọn dòng (đọc an toàn qua `MemoryStream`, không khóa file).
    - Trên `DataGridView` dạng thumbnail qua `DataGridViewImageColumn` zoom đẹp mắt.
  - LINQ Eager Loading với `Include(x => x.MaLoaiNavigation)` để lấy kèm thông tin Tên loại phòng, Giá mỗi đêm.
  - Tìm kiếm kết hợp theo Loại phòng VÀ Tình trạng phòng qua LINQ `Where` + `Include`.

---

### 4. `Cau4_QuanLyLichKham` — Phòng khám tư "An Khang Clinic"
- **CSDL**: `AnKhangClinicDB` (Bảng quan hệ 1-n: `BacSi` và `LichKham`).
- **File SQL**: `Cau4_QuanLyLichKham/Database_AnKhangClinic.sql`
- **Tính năng nổi bật**:
  - Xây dựng **2 Form**:
    - `FormBacSi`: Quản lý Bác sĩ (CRUD).
    - `Form1`: Quản lý Lịch hẹn khám bệnh.
  - `ComboBox` Bác sĩ hiển thị kèm Chuyên khoa (`"BS. Nguyễn Văn An - Nội tổng quát"`).
  - `DateTimePicker` chọn Ngày khám và `DateTimePicker` riêng chọn Giờ khám (`Format = Custom, ShowUpDown = true`).
  - DataGridView hiển thị thông tin Bác sĩ + Chuyên khoa thông qua LINQ `Include(x => x.MaBsNavigation)`.
  - Tìm kiếm kết hợp theo khoảng thời gian (`dtpTuNgay` đến `dtpDenNgay`) VÀ Bác sĩ phụ trách.
  - Validate: Không cho đặt lịch vào ngày trong quá khứ (`< DateTime.Today`), kiểm tra đầy đủ Tên bệnh nhân, SĐT, Bác sĩ.

---

## Hướng dẫn chạy chương trình

1. CSDL SQL Server đã được cài đặt sẵn và kết nối tự động tới `Server=.;Database=...;Trusted_Connection=True;TrustServerCertificate=True;`.
2. Mở file solution `Buoi7.sln` hoặc `Buoi7_EFCore.slnx` bằng Visual Studio 2022.
3. Nhấp chuột phải vào từng project (ví dụ `Cau1_QuanLyTheLoaiSach`, `Cau2_QuanLyHoiVien`, `Cau3_QuanLyPhongHomestay`, `Cau4_QuanLyLichKham`) -> chọn **Set as Startup Project** -> nhấn **F5** để chạy.
4. Hoặc chạy qua dòng lệnh Terminal:
   ```powershell
   dotnet run --project Cau1_QuanLyTheLoaiSach
   dotnet run --project Cau2_QuanLyHoiVien
   dotnet run --project Cau3_QuanLyPhongHomestay
   dotnet run --project Cau4_QuanLyLichKham
   ```
