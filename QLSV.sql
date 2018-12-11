USE [master]
GO
/****** Object:  Database [QLSV]    Script Date: 12/11/2018 10:54:39 ******/
CREATE DATABASE [QLSV] ON  PRIMARY 
( NAME = N'QLSV', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\QLSV.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLSV_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\QLSV_log.LDF' , SIZE = 504KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLSV] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLSV].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLSV] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [QLSV] SET ANSI_NULLS OFF
GO
ALTER DATABASE [QLSV] SET ANSI_PADDING OFF
GO
ALTER DATABASE [QLSV] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [QLSV] SET ARITHABORT OFF
GO
ALTER DATABASE [QLSV] SET AUTO_CLOSE ON
GO
ALTER DATABASE [QLSV] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [QLSV] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [QLSV] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [QLSV] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [QLSV] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [QLSV] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [QLSV] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [QLSV] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [QLSV] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [QLSV] SET  ENABLE_BROKER
GO
ALTER DATABASE [QLSV] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [QLSV] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [QLSV] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [QLSV] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [QLSV] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [QLSV] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [QLSV] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [QLSV] SET  READ_WRITE
GO
ALTER DATABASE [QLSV] SET RECOVERY SIMPLE
GO
ALTER DATABASE [QLSV] SET  MULTI_USER
GO
ALTER DATABASE [QLSV] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [QLSV] SET DB_CHAINING OFF
GO
USE [QLSV]
GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 12/11/2018 10:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[TaiKhoan] [char](30) NULL,
	[MatKhau] [char](30) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 12/11/2018 10:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MonHoc](
	[MaMH] [char](6) NOT NULL,
	[TenMH] [nvarchar](30) NULL,
	[SoTiet] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 12/11/2018 10:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Khoa](
	[MaKhoa] [char](6) NOT NULL,
	[TenKhoa] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhoa] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KetQua]    Script Date: 12/11/2018 10:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KetQua](
	[MaSV] [char](6) NOT NULL,
	[MaMH] [char](6) NOT NULL,
	[DiemThi] [int] NULL,
 CONSTRAINT [pk_chinh] PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC,
	[MaMH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[sp_layDSMonHoc]    Script Date: 12/11/2018 10:54:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_layDSMonHoc](@maMH char(6),@tenMH nvarchar(30),@soTiet int)
as
select * from MonHoc
GO
/****** Object:  StoredProcedure [dbo].[sp_layDSKhoa]    Script Date: 12/11/2018 10:54:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_layDSKhoa](@maKhoa char(6),@tenKhoa nvarchar(30))
as
select * from Khoa
GO
/****** Object:  StoredProcedure [dbo].[sp_layDSKetQua]    Script Date: 12/11/2018 10:54:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_layDSKetQua](@maSV char(6),@maMH char(6),@diemThi int)
as
select * from KetQua
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 12/11/2018 10:54:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SinhVien](
	[MaSV] [char](6) NOT NULL,
	[HoSV] [nvarchar](30) NULL,
	[TenSV] [nvarchar](15) NULL,
	[GioiTinh] [char](3) NULL,
	[NgaySinh] [date] NULL,
	[NoiSinh] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[Quan] [nvarchar](10) NULL,
	[MaKhoa] [char](6) NULL,
	[HocBong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[sp_suaMonHoc]    Script Date: 12/11/2018 10:54:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_suaMonHoc](@maMH char(6),@tenMH nvarchar(30),@soTiet int)
as
update MonHoc set MaMH = @maMH,TenMH = @tenMH, SoTiet = @soTiet
where MaMH = @maMH
GO
/****** Object:  StoredProcedure [dbo].[sp_suaKhoa]    Script Date: 12/11/2018 10:54:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_suaKhoa](@maKhoa char(6),@tenKhoa nvarchar(30))
as
update Khoa set MaKhoa = @maKhoa,TenKhoa = @tenKhoa
where MaKhoa = @maKhoa
GO
/****** Object:  StoredProcedure [dbo].[sp_suaKetQua]    Script Date: 12/11/2018 10:54:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_suaKetQua](@maSV char(6),@maMH char(6),@diemThi int)
as
update KetQua set MaSV =@maSV, MaMH = @maMH, DiemThi = @diemThi
where MaSV = @maSV and MaMH = @maMH
GO
/****** Object:  StoredProcedure [dbo].[sp_layUser]    Script Date: 12/11/2018 10:54:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_layUser](@taiKhoan char(30),@matKhau char(30))
as
select * from NguoiDung where TaiKhoan = @taiKhoan and MatKhau = @matKhau
GO
/****** Object:  StoredProcedure [dbo].[sp_themMonHoc]    Script Date: 12/11/2018 10:54:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_themMonHoc](@maMH char(6),@tenMH nvarchar(30),@soTiet int)
as
insert into MonHoc(MaMH,TenMH,SoTiet) values(@maMH,@tenMH,@soTiet)
GO
/****** Object:  StoredProcedure [dbo].[sp_themKhoa]    Script Date: 12/11/2018 10:54:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_themKhoa](@maKhoa char(6),@tenKhoa nvarchar(30))
as
insert into Khoa(MaKhoa,TenKhoa) values(@maKhoa,@tenKhoa)
GO
/****** Object:  StoredProcedure [dbo].[sp_themKetQua]    Script Date: 12/11/2018 10:54:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_themKetQua](@maSV char(6),@maMH char(6),@diemThi int)
as
insert into KetQua(MaSV,MaMH,DiemThi) values(@maSV,@maMH,@diemThi)
GO
/****** Object:  StoredProcedure [dbo].[sp_suaUser]    Script Date: 12/11/2018 10:54:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_suaUser](@taiKhoan char(30),@matKhau char(30))
as
update NguoiDung set TaiKhoan = @taiKhoan,MatKhau = @matKhau
where TaiKhoan = @taiKhoan
GO
/****** Object:  StoredProcedure [dbo].[sp_xoaMonHoc]    Script Date: 12/11/2018 10:54:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_xoaMonHoc](@maMH char(6),@tenMH nvarchar(30),@soTiet int)
as
delete from MonHoc where MaMH = @maMH
GO
/****** Object:  StoredProcedure [dbo].[sp_xoaKhoa]    Script Date: 12/11/2018 10:54:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_xoaKhoa](@maKhoa char(6),@tenKhoa nvarchar(30))
as
delete from Khoa where MaKhoa = @maKhoa
GO
/****** Object:  StoredProcedure [dbo].[sp_xoaKetQua]    Script Date: 12/11/2018 10:54:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_xoaKetQua](@maSV char(6),@maMH char(6),@diemThi int)
as
delete from KetQua where MaSV = @maSV and MaMH = @maMH
GO
/****** Object:  StoredProcedure [dbo].[sp_themUser]    Script Date: 12/11/2018 10:54:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_themUser](@taiKhoan char(30),@matKhau char(30))
as
insert into NguoiDung(TaiKhoan,MatKhau) values(@taiKhoan,@matKhau)
GO
/****** Object:  StoredProcedure [dbo].[sp_xoaUser]    Script Date: 12/11/2018 10:54:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_xoaUser](@taiKhoan char(30),@matKhau char(30))
as
delete from NguoiDung where TaiKhoan = @taiKhoan
GO
/****** Object:  StoredProcedure [dbo].[sp_xoaSinhVien]    Script Date: 12/11/2018 10:54:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_xoaSinhVien](
@maSV char(6),
@maKhoa char(6),
@hoSV nvarchar(30),
@tenSV nvarchar(15),
@gioiTinh char(3),
@ngaySinh date,
@noiSinh nvarchar(50),
@diaChi nvarchar(50),
@quan nvarchar(10),
@hocBong int
)
as
delete from SinhVien where MaSV = @maSV
GO
/****** Object:  StoredProcedure [dbo].[sp_themSinhVien]    Script Date: 12/11/2018 10:54:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_themSinhVien](
@maSV char(6),
@maKhoa char(6),
@hoSV nvarchar(30),
@tenSV nvarchar(15),
@gioiTinh char(3),
@ngaySinh date,
@noiSinh nvarchar(50),
@diaChi nvarchar(50),
@quan nvarchar(10),
@hocBong int
)
as
insert into SinhVien(MaSV,HoSV,TenSV,GioiTinh,NgaySinh,NoiSinh,DiaChi,Quan,HocBong,MaKhoa)
values (@maSV,@hoSV,@tenSV,@gioiTinh,@ngaySinh,@noiSinh,@diaChi,@quan,@hocBong,@maKhoa)
GO
/****** Object:  StoredProcedure [dbo].[sp_suaSinhVien]    Script Date: 12/11/2018 10:54:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_suaSinhVien](
@maSV char(6),
@maKhoa char(6),
@hoSV nvarchar(30),
@tenSV nvarchar(15),
@gioiTinh char(3),
@ngaySinh date,
@noiSinh nvarchar(50),
@diaChi nvarchar(50),
@quan nvarchar(10),
@hocBong int
)
as
update SinhVien set MaSV = @maSV,
HoSV = @hoSV,
TenSV = @tenSV,
GioiTinh = @gioiTinh,
NgaySinh = @ngaySinh,
NoiSinh = @noiSinh,
DiaChi = @diaChi,
Quan = @quan,
HocBong = @hocBong,
MaKhoa = @maKhoa
where MaSV = @maSV
GO
/****** Object:  StoredProcedure [dbo].[sp_layDSSinhVien]    Script Date: 12/11/2018 10:54:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_layDSSinhVien](
@maSV char(6),
@maKhoa char(6),
@hoSV nvarchar(30),
@tenSV nvarchar(15),
@gioiTinh char(3),
@ngaySinh date,
@noiSinh nvarchar(50),
@diaChi nvarchar(50),
@quan nvarchar(10),
@hocBong int)
as
select * from SinhVien
GO
/****** Object:  ForeignKey [FK__SinhVien__MaKhoa__164452B1]    Script Date: 12/11/2018 10:54:48 ******/
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD FOREIGN KEY([MaKhoa])
REFERENCES [dbo].[Khoa] ([MaKhoa])
GO
