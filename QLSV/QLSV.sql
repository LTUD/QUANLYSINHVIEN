USE [master]
GO
/****** Object:  Database [QuanLySinhVien]    Script Date: 12/09/2018 09:27:38 ******/
CREATE DATABASE [QuanLySinhVien] ON  PRIMARY 
( NAME = N'QuanLySinhVien', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\QuanLySinhVien.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLySinhVien_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\QuanLySinhVien_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLySinhVien] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLySinhVien].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLySinhVien] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [QuanLySinhVien] SET ANSI_NULLS OFF
GO
ALTER DATABASE [QuanLySinhVien] SET ANSI_PADDING OFF
GO
ALTER DATABASE [QuanLySinhVien] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [QuanLySinhVien] SET ARITHABORT OFF
GO
ALTER DATABASE [QuanLySinhVien] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [QuanLySinhVien] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [QuanLySinhVien] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [QuanLySinhVien] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [QuanLySinhVien] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [QuanLySinhVien] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [QuanLySinhVien] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [QuanLySinhVien] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [QuanLySinhVien] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [QuanLySinhVien] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [QuanLySinhVien] SET  ENABLE_BROKER
GO
ALTER DATABASE [QuanLySinhVien] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [QuanLySinhVien] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [QuanLySinhVien] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [QuanLySinhVien] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [QuanLySinhVien] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [QuanLySinhVien] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [QuanLySinhVien] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [QuanLySinhVien] SET  READ_WRITE
GO
ALTER DATABASE [QuanLySinhVien] SET RECOVERY FULL
GO
ALTER DATABASE [QuanLySinhVien] SET  MULTI_USER
GO
ALTER DATABASE [QuanLySinhVien] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [QuanLySinhVien] SET DB_CHAINING OFF
GO
USE [QuanLySinhVien]
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 12/09/2018 09:27:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MonHoc](
	[MaMH] [char](10) NOT NULL,
	[TenMH] [nchar](30) NOT NULL,
	[SoTiet] [int] NOT NULL,
 CONSTRAINT [PK_MonHoc] PRIMARY KEY CLUSTERED 
(
	[MaMH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 12/09/2018 09:27:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Khoa](
	[MaKhoa] [char](10) NOT NULL,
	[TenKhoa] [nchar](20) NOT NULL,
 CONSTRAINT [PK_Khoa] PRIMARY KEY CLUSTERED 
(
	[MaKhoa] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KetQua]    Script Date: 12/09/2018 09:27:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KetQua](
	[MaSV] [char](10) NOT NULL,
	[MaMH] [char](10) NOT NULL,
	[HoTenSV] [nchar](30) NOT NULL,
	[TenKhoa] [nchar](20) NOT NULL,
	[LanThi] [int] NOT NULL,
	[Diem] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_KetQua] PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[sp_xoaMonHoc]    Script Date: 12/09/2018 09:27:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_xoaMonHoc](@maMonHoc nchar(10), @tenMonHoc nvarchar(30), @soTiet int)
as 
delete MonHoc where MaMH = @maMonHoc
GO
/****** Object:  StoredProcedure [dbo].[sp_xoaKhoa]    Script Date: 12/09/2018 09:27:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_xoaKhoa](@maKhoa nchar(10), @tenKhoa nvarchar(30))
as
delete Khoa where MaKhoa = MaKhoa
GO
/****** Object:  StoredProcedure [dbo].[sp_layDSMonHoc]    Script Date: 12/09/2018 09:27:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_layDSMonHoc](@maMonHoc nchar(10), @tenMonHoc nvarchar(30), @soTiet int)
as
select * from MonHoc
GO
/****** Object:  StoredProcedure [dbo].[sp_layDSKhoa]    Script Date: 12/09/2018 09:27:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_layDSKhoa](@maKhoa nchar(10), @tenKhoa nvarchar(30))
as 
select * from Khoa
GO
/****** Object:  StoredProcedure [dbo].[sp_suaMonHoc]    Script Date: 12/09/2018 09:27:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_suaMonHoc](@maMonHoc nchar(10), @tenMonHoc nvarchar(30), @soTiet int)
as 
update MonHoc set TenMH = @tenMonHoc, SoTiet = @soTiet
where MaMH = @maMonHoc
GO
/****** Object:  StoredProcedure [dbo].[sp_suaKhoa]    Script Date: 12/09/2018 09:27:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_suaKhoa](@maKhoa nchar(10), @tenKhoa nvarchar(30))
as
update Khoa set TenKhoa = @tenKhoa
where MaKhoa = @maKhoa
GO
/****** Object:  StoredProcedure [dbo].[sp_themMonHoc]    Script Date: 12/09/2018 09:27:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_themMonHoc](@maMonHoc nchar(10), @tenMonHoc nvarchar(30), @soTiet int)
as 
insert into MonHoc(MaMH,TenMH,SoTiet) values (@maMonHoc, @tenMonHoc, @soTiet)
GO
/****** Object:  StoredProcedure [dbo].[sp_themKhoa]    Script Date: 12/09/2018 09:27:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_themKhoa](@maKhoa nchar(10), @tenKhoa nvarchar(30))
as
insert into Khoa(MaKhoa, TenKhoa) values(@maKhoa, @tenKhoa)
GO
/****** Object:  StoredProcedure [dbo].[sp_themKetQua]    Script Date: 12/09/2018 09:27:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_themKetQua](
@maSV nchar(10), @maMH nchar(10), @lanThi int, @diem float)
as
insert into KetQua(MaSV, MaMH, LanThi, Diem) values(@maSV, @maMH, @lanThi, @diem)
GO
/****** Object:  StoredProcedure [dbo].[sp_suaKetQua]    Script Date: 12/09/2018 09:27:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_suaKetQua](
@maSV nchar(10), @maMH nchar(10), @lanThi int, @diem float)
as 
update KetQua set LanThi = @lanThi, Diem = @diem
where MaSV = @maSV and MaMH = @maMH
GO
/****** Object:  StoredProcedure [dbo].[sp_layDSKetQua]    Script Date: 12/09/2018 09:27:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_layDSKetQua](@maSV nchar(10), @maMH nchar(10), @tenKhoa nvarchar(30), @lanThi int, @diem float)
as
select * from KetQua
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 12/09/2018 09:27:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SinhVien](
	[MaSV] [char](10) NOT NULL,
	[HoTenSV] [nchar](30) NOT NULL,
	[GioiTinh] [nchar](5) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[DiaChi] [nchar](30) NOT NULL,
	[MaKhoa] [char](10) NOT NULL,
 CONSTRAINT [PK_SinhVien] PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[sp_xoaKetQua]    Script Date: 12/09/2018 09:27:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_xoaKetQua](
@maSV nchar(10), @maMH nchar(10), @tenKhoa nvarchar(30), @lanThi int, @diem float)
as
delete KetQua where MaSV = @maSV and MaMH = @maMH
GO
/****** Object:  StoredProcedure [dbo].[sp_xoaSinhVien]    Script Date: 12/09/2018 09:27:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_xoaSinhVien](@maSV nchar(10),@hoSV nvarchar(30), @tenSV nvarchar(15), @gioiTinh nchar(3), @ngaySinh date, @noiSinh nvarchar(50), @diaChi nvarchar(50), @quan nvarchar(10), @maKhoa nchar(10), @hocBong int)
as 
delete SinhVien where MaSV = @maSV
GO
/****** Object:  ForeignKey [FK_KetQua_MonHoc]    Script Date: 12/09/2018 09:27:42 ******/
ALTER TABLE [dbo].[KetQua]  WITH CHECK ADD  CONSTRAINT [FK_KetQua_MonHoc] FOREIGN KEY([MaMH])
REFERENCES [dbo].[MonHoc] ([MaMH])
GO
ALTER TABLE [dbo].[KetQua] CHECK CONSTRAINT [FK_KetQua_MonHoc]
GO
/****** Object:  ForeignKey [FK__SinhVien__MaKhoa__21B6055D]    Script Date: 12/09/2018 09:27:47 ******/
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD FOREIGN KEY([MaKhoa])
REFERENCES [dbo].[Khoa] ([MaKhoa])
GO
/****** Object:  ForeignKey [FK_SinhVien_KetQua]    Script Date: 12/09/2018 09:27:47 ******/
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD  CONSTRAINT [FK_SinhVien_KetQua] FOREIGN KEY([MaSV])
REFERENCES [dbo].[KetQua] ([MaSV])
GO
ALTER TABLE [dbo].[SinhVien] CHECK CONSTRAINT [FK_SinhVien_KetQua]
GO
/****** Object:  ForeignKey [FK_SinhVien_Khoa]    Script Date: 12/09/2018 09:27:47 ******/
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD  CONSTRAINT [FK_SinhVien_Khoa] FOREIGN KEY([MaKhoa])
REFERENCES [dbo].[Khoa] ([MaKhoa])
GO
ALTER TABLE [dbo].[SinhVien] CHECK CONSTRAINT [FK_SinhVien_Khoa]
GO
