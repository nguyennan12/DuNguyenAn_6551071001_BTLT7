-- =============================================
-- BÀI TẬP 2: QUẢN LÝ HỘI VIÊN - PHÒNG TẬP FITZONE
-- =============================================

CREATE DATABASE FitZoneDB;
GO

USE FitZoneDB;
GO

IF OBJECT_ID('HoiVien', 'U') IS NOT NULL DROP TABLE HoiVien;
CREATE TABLE HoiVien (
    MaHV INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    GioiTinh BIT, -- 1=Nam, 0=Nữ
    NgaySinh DATE,
    SDT VARCHAR(15),
    Email VARCHAR(100),
    HangThanhVien NVARCHAR(20), -- Basic, VIP, Premium
    NgayDangKy DATETIME DEFAULT GETDATE(),
    TrangThai BIT -- 1=Đang hoạt động, 0=Tạm ngưng
);
GO

-- Dữ liệu mẫu
INSERT INTO HoiVien (HoTen, GioiTinh, NgaySinh, SDT, Email, HangThanhVien, NgayDangKy, TrangThai) VALUES
(N'Nguyễn Văn Tuấn', 1, '1995-04-12', '0912345678', 'vantuan95@gmail.com', N'VIP', GETDATE(), 1),
(N'Trần Thị Mai', 0, '2000-08-20', '0987654321', 'maitran@gmail.com', N'Basic', GETDATE(), 1),
(N'Lê Hoàng Long', 1, '1998-11-05', '0903123456', 'hoanglong@gmail.com', N'Premium', GETDATE(), 1),
(N'Phạm Thu Hà', 0, '2002-01-15', '0934567890', 'thuha2k2@gmail.com', N'Basic', GETDATE(), 0);
GO
