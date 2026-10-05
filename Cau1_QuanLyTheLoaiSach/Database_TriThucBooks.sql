-- =============================================
-- BÀI TẬP 1: QUẢN LÝ THỂ LOẠI SÁCH - NHÀ SÁCH TRI THỨC BOOKS
-- =============================================

CREATE DATABASE TriThucBooksDB;
GO

USE TriThucBooksDB;
GO

IF OBJECT_ID('TheLoaiSach', 'U') IS NOT NULL DROP TABLE TheLoaiSach;
CREATE TABLE TheLoaiSach (
    MaTL INT IDENTITY(1,1) PRIMARY KEY,
    TenTheLoai NVARCHAR(100) NOT NULL UNIQUE,
    MoTa NVARCHAR(255) NULL,
    SoLuongSach INT DEFAULT 0,
    NgayTao DATETIME DEFAULT GETDATE()
);
GO

-- Dữ liệu mẫu
INSERT INTO TheLoaiSach (TenTheLoai, MoTa, SoLuongSach, NgayTao) VALUES
(N'Tiểu thuyết', N'Các tác phẩm văn học hư cấu và phi hư cấu', 120, GETDATE()),
(N'Kỹ năng sống', N'Sách phát triển bản thân, tư duy và kỹ năng mềm', 85, GETDATE()),
(N'Thiếu nhi', N'Truyện tranh, cổ tích và sách cho trẻ nhỏ', 200, GETDATE()),
(N'Sách giáo khoa', N'Sách phục vụ chương trình học các cấp', 350, GETDATE()),
(N'Công nghệ thông tin', N'Sách lập trình, cơ sở dữ liệu, mạng máy tính', 45, GETDATE());
GO
