USE [master]
GO
/****** Object:  Database [C#Book]    Script Date: 22-Jul-2022 8:59:51 AM ******/
CREATE DATABASE [C#Book]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'C#Book', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\C#Book.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'C#Book_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\C#Book_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [C#Book] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [C#Book].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [C#Book] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [C#Book] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [C#Book] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [C#Book] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [C#Book] SET ARITHABORT OFF 
GO
ALTER DATABASE [C#Book] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [C#Book] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [C#Book] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [C#Book] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [C#Book] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [C#Book] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [C#Book] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [C#Book] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [C#Book] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [C#Book] SET  DISABLE_BROKER 
GO
ALTER DATABASE [C#Book] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [C#Book] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [C#Book] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [C#Book] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [C#Book] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [C#Book] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [C#Book] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [C#Book] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [C#Book] SET  MULTI_USER 
GO
ALTER DATABASE [C#Book] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [C#Book] SET DB_CHAINING OFF 
GO
ALTER DATABASE [C#Book] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [C#Book] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [C#Book] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [C#Book] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [C#Book] SET QUERY_STORE = OFF
GO
USE [C#Book]
GO
/****** Object:  Table [dbo].[CTHOADON]    Script Date: 22-Jul-2022 8:59:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHOADON](
	[MaHD] [nvarchar](50) NOT NULL,
	[MaSach] [nvarchar](50) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[Giaban] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 22-Jul-2022 8:59:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[MaHD] [nvarchar](50) NOT NULL,
	[MaKH] [nvarchar](50) NOT NULL,
	[MaNV] [nvarchar](50) NOT NULL,
	[NgayBan] [date] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 22-Jul-2022 8:59:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKH] [nvarchar](50) NOT NULL,
	[TenKH] [nvarchar](120) NOT NULL,
	[DienThoai] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](120) NOT NULL,
	[DiemTichLuy] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 22-Jul-2022 8:59:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [nvarchar](50) NOT NULL,
	[TenNV] [nvarchar](120) NOT NULL,
	[GioiTinh] [bit] NOT NULL,
	[DienThoai] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](120) NOT NULL,
	[NgaySinh] [date] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QUANLITAIKHOAN]    Script Date: 22-Jul-2022 8:59:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QUANLITAIKHOAN](
	[USERNAME] [nvarchar](120) NOT NULL,
	[PASSWORD] [nvarchar](120) NOT NULL,
	[MaNV] [nvarchar](50) NOT NULL,
	[Roles] [nvarchar](50) NOT NULL,
	[TinhTrang] [int] NOT NULL,
	[LichSuDN] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QUANTONKHO]    Script Date: 22-Jul-2022 8:59:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QUANTONKHO](
	[MaSach] [nvarchar](50) NOT NULL,
	[SoLuong] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SACH]    Script Date: 22-Jul-2022 8:59:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SACH](
	[MaSach] [nvarchar](50) NOT NULL,
	[TenSach] [nvarchar](120) NOT NULL,
	[TheLoai] [nvarchar](50) NOT NULL,
	[TacGia] [nvarchar](120) NOT NULL,
	[DonGia] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TACGIA]    Script Date: 22-Jul-2022 8:59:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TACGIA](
	[MaTG] [nvarchar](120) NOT NULL,
	[TenTG] [nvarchar](120) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THELOAI]    Script Date: 22-Jul-2022 8:59:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THELOAI](
	[MaTL] [nvarchar](50) NOT NULL,
	[TheLoai] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'170722100650', N'A124', 1, 20000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'170722100734', N'A123', 1, 25000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'170722100757', N'A123', 2, 50000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'200722131145', N'A123', 3, 75000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'200722131145', N'A124', 1, 20000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'200722131145', N'A125 ', 1, 17000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'200722131145', N'A126', 1, 45000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'200722131302', N'A124', 1, 20000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'200722131440', N'A124', 3, 60000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'220722070740', N'A124', 3, 60000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'220722070854', N'A124', 3, 60000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'220722070854', N'A128', 1, 36000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'220722071124', N'A123', 1, 25000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'220722071238', N'A126', 1, 45000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'220722074633', N'A127', 1, 36000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'220722075250', N'A126', 1, 45000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'220722075349', N'A126', 1, 45000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'220722080312', N'A128', 1, 36000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'220722081106', N'A202', 1, 25000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'220722085859', N'A126', 2, 90000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'150722092641', N'A123', 1, 18000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'150722092755', N'A123', 1, 18000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'150722092914', N'A123', 1, 18000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'150722093010', N'A124', 1, 25000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'150722093139', N'A126', 1, 45000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'150722093329', N'A126', 1, 45000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'150722093349', N'A126', 1, 45000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'150722093703', N'A123', 1, 18000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'150722093743', N'A124', 1, 25000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'150722093743', N'A126', 1, 45000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'150722093929', N'A123', 1, 18000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'150722094002', N'A123', 1, 18000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'150722094056', N'A123', 1, 18000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'150722094545', N'A123', 1, 18000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'150722094705', N'A123', 1, 18000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'150722095650', N'A124', 1, 25000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'150722104714', N'A123', 1, 18000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'150722104732', N'A126', 1, 45000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'150722105355', N'A124', 1, 25000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'170722093426', N'A201', 6, 180000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'170722093449', N'A201', 5, 150000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'220722070928', N'A126', 1, 45000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'150722105507', N'A124', 1, 25000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'150722105532', N'A201', 1, 30000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'220722071059', N'A124', 1, 20000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'220722074521', N'A126', 1, 45000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'220722074605', N'A125 ', 1, 17000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'110722095051', N'A128', 1, 200)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'150722102738', N'A129', 1, 120000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'220722072418', N'A123', 1, 25000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'130722140801', N'A126', 1, 2000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'130722150517', N'A200', 2, 90000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'130722150518', N'A127', 2, 72000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'130722150518', N'A123', 3, 54000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'150722095940', N'A126', 5, 225000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'150722100039', N'A125 ', 2, 34000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'150722100534', N'A127', 1, 36000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'150722100540', N'A128', 1, 36000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'150722100802', N'A200', 1, 45000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'150722100942', N'A201', 1, 30000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'150722101103', N'A201', 1, 30000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'150722104416', N'A123', 1, 18000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'150722104441', N'A124', 1, 25000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'150722104913', N'A123', 1, 18000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'150722105044', N'A123', 1, 18000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'150722105106', N'A129', 1, 120000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'200722131810', N'A124', 1, 20000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'220722074257', N'A126', 1, 45000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'200722143358', N'A123', 3, 75000)
GO
INSERT [dbo].[CTHOADON] ([MaHD], [MaSach], [SoLuong], [Giaban]) VALUES (N'220722074040', N'A123', 1, 25000)
GO
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayBan]) VALUES (N'150722093703', N'1', N'125', CAST(N'2022-07-15' AS Date))
GO
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayBan]) VALUES (N'150722093743', N'1', N'125', CAST(N'2022-07-15' AS Date))
GO
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayBan]) VALUES (N'150722094056', N'1', N'125', CAST(N'2022-07-15' AS Date))
GO
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayBan]) VALUES (N'150722094705', N'NhaSachABC', N'125', CAST(N'2022-07-15' AS Date))
GO
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayBan]) VALUES (N'150722095650', N'NhaSachABC', N'125', CAST(N'2022-07-15' AS Date))
GO
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayBan]) VALUES (N'150722095940', N'NhaSachABC', N'125', CAST(N'2022-07-15' AS Date))
GO
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayBan]) VALUES (N'150722100039', N'NhaSachABC', N'125', CAST(N'2022-07-15' AS Date))
GO
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayBan]) VALUES (N'150722100534', N'NhaSachABC', N'125', CAST(N'2022-07-15' AS Date))
GO
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayBan]) VALUES (N'150722100540', N'NhaSachABC', N'125', CAST(N'2022-07-15' AS Date))
GO
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayBan]) VALUES (N'150722100802', N'NhaSachABC', N'125', CAST(N'2022-07-15' AS Date))
GO
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayBan]) VALUES (N'150722100942', N'NhaSachABC', N'125', CAST(N'2022-07-15' AS Date))
GO
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayBan]) VALUES (N'150722101103', N'NhaSachABC', N'125', CAST(N'2022-07-15' AS Date))
GO
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayBan]) VALUES (N'150722102738', N'asc', N'125', CAST(N'2022-07-15' AS Date))
GO
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayBan]) VALUES (N'150722104416', N'', N'125', CAST(N'2022-07-15' AS Date))
GO
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayBan]) VALUES (N'150722104441', N'asc', N'125', CAST(N'2022-07-15' AS Date))
GO
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayBan]) VALUES (N'150722104714', N'', N'125', CAST(N'2022-07-15' AS Date))
GO
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayBan]) VALUES (N'150722104732', N'asc', N'125', CAST(N'2022-07-15' AS Date))
GO
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayBan]) VALUES (N'150722105507', N'NhaSachABC', N'125', CAST(N'2022-07-15' AS Date))
GO
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayBan]) VALUES (N'150722105532', N'NhaSachABC', N'125', CAST(N'2022-07-15' AS Date))
GO
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayBan]) VALUES (N'170722093426', N'', N'125', CAST(N'2022-07-17' AS Date))
GO
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayBan]) VALUES (N'170722093449', N'NhaSachABC', N'125', CAST(N'2022-07-17' AS Date))
GO
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayBan]) VALUES (N'170722100650', N'NhaSachABC', N'125', CAST(N'2022-07-17' AS Date))
GO
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayBan]) VALUES (N'170722100734', N'NhaSachABC', N'125', CAST(N'2022-07-17' AS Date))
GO
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayBan]) VALUES (N'170722100757', N'NhaSachABC', N'125', CAST(N'2022-07-17' AS Date))
GO
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayBan]) VALUES (N'150722104913', N'', N'125', CAST(N'2022-07-15' AS Date))
GO
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayBan]) VALUES (N'150722105044', N'', N'125', CAST(N'2022-07-15' AS Date))
GO
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayBan]) VALUES (N'150722105106', N'asc', N'125', CAST(N'2022-07-15' AS Date))
GO
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayBan]) VALUES (N'150722105355', N'NhaSachABC', N'125', CAST(N'2022-07-15' AS Date))
GO
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayBan]) VALUES (N'200722131145', N'NhaSachABC', N'125', CAST(N'2022-07-20' AS Date))
GO
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayBan]) VALUES (N'200722131302', N'NhaSachABC', N'125', CAST(N'2022-07-20' AS Date))
GO
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayBan]) VALUES (N'200722131440', N'', N'125', CAST(N'2022-07-20' AS Date))
GO
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayBan]) VALUES (N'220722070740', N'', N'125', CAST(N'2022-07-22' AS Date))
GO
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayBan]) VALUES (N'220722070854', N'', N'125', CAST(N'2022-07-22' AS Date))
GO
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayBan]) VALUES (N'220722071124', N'', N'125', CAST(N'2022-07-22' AS Date))
GO
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayBan]) VALUES (N'220722071238', N'', N'125', CAST(N'2022-07-22' AS Date))
GO
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayBan]) VALUES (N'220722074633', N'', N'125', CAST(N'2022-07-22' AS Date))
GO
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayBan]) VALUES (N'220722075250', N'', N'125', CAST(N'2022-07-22' AS Date))
GO
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayBan]) VALUES (N'220722075349', N'', N'125', CAST(N'2022-07-22' AS Date))
GO
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayBan]) VALUES (N'220722080312', N'', N'125', CAST(N'2022-07-22' AS Date))
GO
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayBan]) VALUES (N'220722081106', N'NhaSachABC', N'125', CAST(N'2022-07-22' AS Date))
GO
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayBan]) VALUES (N'220722085859', N'', N'125', CAST(N'2022-07-22' AS Date))
GO
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayBan]) VALUES (N'200722131810', N'NhaSachABC', N'125', CAST(N'2022-07-20' AS Date))
GO
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayBan]) VALUES (N'220722070928', N'', N'125', CAST(N'2022-07-22' AS Date))
GO
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayBan]) VALUES (N'220722071059', N'', N'125', CAST(N'2022-07-22' AS Date))
GO
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayBan]) VALUES (N'220722072418', N'', N'125', CAST(N'2022-07-22' AS Date))
GO
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayBan]) VALUES (N'220722074257', N'', N'125', CAST(N'2022-07-22' AS Date))
GO
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayBan]) VALUES (N'220722074521', N'', N'125', CAST(N'2022-07-22' AS Date))
GO
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayBan]) VALUES (N'220722074605', N'', N'125', CAST(N'2022-07-22' AS Date))
GO
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayBan]) VALUES (N'200722143359', N'NhaSachABC', N'125', CAST(N'2022-07-20' AS Date))
GO
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayBan]) VALUES (N'220722074040', N'', N'125', CAST(N'2022-07-22' AS Date))
GO
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [DienThoai], [Email], [DiemTichLuy]) VALUES (N'NhaSachABC', N'abc', N'234567890', N'hgs@gmail.com', 617)
GO
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [DienThoai], [Email], [DiemTichLuy]) VALUES (N'asc', N'ádfd', N'14576', N'sadf', 12)
GO
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [GioiTinh], [DienThoai], [DiaChi], [NgaySinh]) VALUES (N'123', N'Dương', 1, N'123456', N'Hải Phòng', CAST(N'2002-01-01' AS Date))
GO
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [GioiTinh], [DienThoai], [DiaChi], [NgaySinh]) VALUES (N'124', N'P', 0, N'1234568', N'không biết ', CAST(N'2002-01-01' AS Date))
GO
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [GioiTinh], [DienThoai], [DiaChi], [NgaySinh]) VALUES (N'125', N'đại', 1, N'123456', N'không biết ', CAST(N'2002-01-01' AS Date))
GO
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [GioiTinh], [DienThoai], [DiaChi], [NgaySinh]) VALUES (N'100', N'Admin', 1, N'123456789', N'HCM', CAST(N'2000-01-01' AS Date))
GO
INSERT [dbo].[QUANLITAIKHOAN] ([USERNAME], [PASSWORD], [MaNV], [Roles], [TinhTrang], [LichSuDN]) VALUES (N'admin', N'admin', N'100', N'1', 1, N'22-07-2022 	 08-54-21')
GO
INSERT [dbo].[QUANLITAIKHOAN] ([USERNAME], [PASSWORD], [MaNV], [Roles], [TinhTrang], [LichSuDN]) VALUES (N'a', N'123', N'125', N'0', 1, N'22-07-2022 	 08-58-36')
GO
INSERT [dbo].[QUANLITAIKHOAN] ([USERNAME], [PASSWORD], [MaNV], [Roles], [TinhTrang], [LichSuDN]) VALUES (N'c', N'4', N'123', N'0', 1, N'13-07-2022 	 15-01-53')
GO
INSERT [dbo].[QUANLITAIKHOAN] ([USERNAME], [PASSWORD], [MaNV], [Roles], [TinhTrang], [LichSuDN]) VALUES (N'd', N'2', N'124', N'0', 1, N'13-07-2022 	 14-07-47')
GO
INSERT [dbo].[QUANTONKHO] ([MaSach], [SoLuong]) VALUES (N'A124', 11)
GO
INSERT [dbo].[QUANTONKHO] ([MaSach], [SoLuong]) VALUES (N'A123', 15)
GO
INSERT [dbo].[QUANTONKHO] ([MaSach], [SoLuong]) VALUES (N'A126', 13)
GO
INSERT [dbo].[QUANTONKHO] ([MaSach], [SoLuong]) VALUES (N'A125 ', 13)
GO
INSERT [dbo].[QUANTONKHO] ([MaSach], [SoLuong]) VALUES (N'A127', 16)
GO
INSERT [dbo].[QUANTONKHO] ([MaSach], [SoLuong]) VALUES (N'A128', 18)
GO
INSERT [dbo].[QUANTONKHO] ([MaSach], [SoLuong]) VALUES (N'A129', 18)
GO
INSERT [dbo].[QUANTONKHO] ([MaSach], [SoLuong]) VALUES (N'A200', 15)
GO
INSERT [dbo].[QUANTONKHO] ([MaSach], [SoLuong]) VALUES (N'A201', 25)
GO
INSERT [dbo].[QUANTONKHO] ([MaSach], [SoLuong]) VALUES (N'A202', 24)
GO
INSERT [dbo].[QUANTONKHO] ([MaSach], [SoLuong]) VALUES (N'A203', 25)
GO
INSERT [dbo].[QUANTONKHO] ([MaSach], [SoLuong]) VALUES (N'12345', 1)
GO
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [DonGia]) VALUES (N'A201', N'Sóng', N'Thơ', N'Xuân Quỳnh', 30000)
GO
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [DonGia]) VALUES (N'A125 ', N'Chú Kim', N'Tiểu thuyết ', N'Ko biết ', 17000)
GO
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [DonGia]) VALUES (N'A126', N'Mắt Biếc', N'Truyện ngắn', N'Nguyễn Nhật Ánh', 45000)
GO
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [DonGia]) VALUES (N'A127', N'Chí Phèo ', N'Truyện ngắn ', N'Nam Cao', 36000)
GO
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [DonGia]) VALUES (N'A128', N'Lão Hạc', N'Truyên ngắn', N'Nam Cao', 36000)
GO
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [DonGia]) VALUES (N'A129', N'Mình đừng quên nhau', N'Truyện ngắn ', N'Hiên', 120000)
GO
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [DonGia]) VALUES (N'A202', N'Tắt đèn', N'Truyện ngắn ', N'Ngô Tất Tố', 25000)
GO
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [DonGia]) VALUES (N'A200', N'Số đỏ', N'Truyện ngắn ', N'Vũ Trọng Phụng', 45000)
GO
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [DonGia]) VALUES (N'A203', N'Lược sử thời gian', N'Khoa học ', N'Stephen Hawking', 30000)
GO
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [DonGia]) VALUES (N'A124', N'Cô giáo Thảo ', N'Tiểu thuyết', N'Không biết ', 20000)
GO
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [DonGia]) VALUES (N'A123', N'Conan', N'Manga', N'Aoyama Gosho', 20000)
GO
INSERT [dbo].[THELOAI] ([MaTL], [TheLoai]) VALUES (N'A1', N'Manga')
GO
INSERT [dbo].[THELOAI] ([MaTL], [TheLoai]) VALUES (N'A2', N'Tiểu thuyết')
GO
INSERT [dbo].[THELOAI] ([MaTL], [TheLoai]) VALUES (N'A3', N'Khoa học')
GO
INSERT [dbo].[THELOAI] ([MaTL], [TheLoai]) VALUES (N'A4', N'Thơ')
GO
INSERT [dbo].[THELOAI] ([MaTL], [TheLoai]) VALUES (N'A5', N'Truyện ngắn')
GO
/****** Object:  StoredProcedure [dbo].[SL]    Script Date: 22-Jul-2022 8:59:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Name
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[SL] 
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT   SACH.*, QUANTONKHO.SoLuong
FROM         SACH INNER JOIN
                         QUANTONKHO ON SACH.MaSach = QUANTONKHO.MaSach
END
GO
/****** Object:  StoredProcedure [dbo].[st_Thongke]    Script Date: 22-Jul-2022 8:59:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Name
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[st_Thongke] 
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT    Month(HOADON.NgayBan) as Month, year(HOADON.NgayBan) as Year, SUM(CTHOADON.SoLuong) AS Tong , sum(CTHOADON.Giaban) as Tien
	FROM            CTHOADON INNER JOIN
                         HOADON ON CTHOADON.MaHD = HOADON.MaHD
	group by MONTH(HOADON.NgayBan), year(HOADON.NgayBan)
						 
						 
 
END
GO
USE [master]
GO
ALTER DATABASE [C#Book] SET  READ_WRITE 
GO


--TRIGGER
CREATE TRIGGER [dbo].[Deleted1]
   ON  [dbo].[CTHOADON]
   AFTER INSERT
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
    if exists (select * from CTHOADON,inserted where CTHOADON.MaSach=inserted.MaSach)
		update QUANTONKHO set QUANTONKHO.[SoLuong] = QUANTONKHO.[SoLuong]-inserted.[SoLuong]
		from QUANTONKHO,inserted
		where QUANTONKHO.MaSach = inserted.MaSach
		
END