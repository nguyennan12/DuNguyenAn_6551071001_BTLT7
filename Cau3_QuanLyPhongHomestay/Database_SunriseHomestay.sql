-- =============================================
-- BÀI TẬP 3: QUẢN LÝ LOẠI PHÒNG & PHÒNG - SUNRISE HOMESTAY
-- =============================================

CREATE DATABASE SunriseHomestayDB;
GO

USE SunriseHomestayDB;
GO

IF OBJECT_ID('Phong', 'U') IS NOT NULL DROP TABLE Phong;
IF OBJECT_ID('LoaiPhong', 'U') IS NOT NULL DROP TABLE LoaiPhong;

CREATE TABLE LoaiPhong (
    MaLoai INT IDENTITY(1,1) PRIMARY KEY,
    TenLoai NVARCHAR(100) NOT NULL,
    GiaMoiDem DECIMAL(18,2),
    MoTa NVARCHAR(255)
);
GO

CREATE TABLE Phong (
    MaPhong INT IDENTITY(1,1) PRIMARY KEY,
    SoPhong VARCHAR(10) NOT NULL,
    TangSo INT,
    TinhTrang NVARCHAR(20), -- Trống / Đang ở / Đang dọn
    HinhAnh NVARCHAR(255),
    MaLoai INT FOREIGN KEY REFERENCES LoaiPhong(MaLoai)
);
GO

-- Dữ liệu mẫu
INSERT INTO LoaiPhong (TenLoai, GiaMoiDem, MoTa) VALUES
(N'Phòng đơn Standard', 350000, N'1 giường đơn, máy lạnh, ban công nhỏ'),
(N'Phòng đôi Superior', 550000, N'1 giường đôi lớn, view sân vườn'),
(N'Phòng VIP Gia đình', 950000, N'2 giường đôi, phòng khách riêng, view biển');

INSERT INTO Phong (SoPhong, TangSo, TinhTrang, HinhAnh, MaLoai) VALUES
('P101', 1, N'Trống', 'p101.jpg', 1),
('P102', 1, N'Đang ở', 'p102.jpg', 2),
('P201', 2, N'Đang dọn', 'p201.jpg', 2),
('P301', 3, N'Trống', 'p301.jpg', 3);
GO
