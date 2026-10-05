-- =============================================
-- BÀI TẬP 4: QUẢN LÝ LỊCH KHÁM BỆNH - AN KHANG CLINIC
-- =============================================

CREATE DATABASE AnKhangClinicDB;
GO

USE AnKhangClinicDB;
GO

IF OBJECT_ID('LichKham', 'U') IS NOT NULL DROP TABLE LichKham;
IF OBJECT_ID('BacSi', 'U') IS NOT NULL DROP TABLE BacSi;

CREATE TABLE BacSi (
    MaBS INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    ChuyenKhoa NVARCHAR(100),
    SDT VARCHAR(15)
);
GO

CREATE TABLE LichKham (
    MaLich INT IDENTITY(1,1) PRIMARY KEY,
    TenBenhNhan NVARCHAR(100) NOT NULL,
    SDT VARCHAR(15),
    NgayKham DATE,
    GioKham NVARCHAR(10),
    MaBS INT FOREIGN KEY REFERENCES BacSi(MaBS),
    TrangThai NVARCHAR(20) -- Chờ khám / Đã khám / Đã hủy
);
GO

-- Dữ liệu mẫu
INSERT INTO BacSi (HoTen, ChuyenKhoa, SDT) VALUES
(N'BS. Nguyễn Văn An', N'Nội tổng quát', '0911223344'),
(N'BS. Trần Thị Bích', N'Nhi khoa', '0922334455'),
(N'BS. Lê Hoàng Nam', N'Tai Mũi Họng', '0933445566'),
(N'BS. Phạm Minh Đức', N'Tim mạch', '0944556677');

INSERT INTO LichKham (TenBenhNhan, SDT, NgayKham, GioKham, MaBS, TrangThai) VALUES
(N'Hoàng Văn Cường', '0988776655', CAST(GETDATE() AS DATE), '08:30', 1, N'Chờ khám'),
(N'Nguyễn Thúy Hằng', '0977665544', CAST(GETDATE() AS DATE), '09:15', 2, N'Chờ khám'),
(N'Đỗ Tuấn Kiệt', '0966554433', DATEADD(DAY, 1, CAST(GETDATE() AS DATE)), '14:00', 3, N'Chờ khám');
GO
