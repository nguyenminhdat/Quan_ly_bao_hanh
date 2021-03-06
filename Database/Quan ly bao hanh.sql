USE [master]
GO
/****** Object:  Database [QuanLyBaoHanh]    Script Date: 1/31/2020 10:57:17 AM ******/
CREATE DATABASE [QuanLyBaoHanh]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyBaoHanh', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\QuanLyBaoHanh.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyBaoHanh_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\QuanLyBaoHanh_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyBaoHanh].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyBaoHanh] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyBaoHanh] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyBaoHanh] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyBaoHanh] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyBaoHanh] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyBaoHanh] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyBaoHanh] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyBaoHanh] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyBaoHanh] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyBaoHanh] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyBaoHanh] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyBaoHanh] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyBaoHanh] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyBaoHanh] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyBaoHanh] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLyBaoHanh] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyBaoHanh] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyBaoHanh] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyBaoHanh] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyBaoHanh] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyBaoHanh] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyBaoHanh] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyBaoHanh] SET RECOVERY FULL 
GO
ALTER DATABASE [QuanLyBaoHanh] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyBaoHanh] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyBaoHanh] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyBaoHanh] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyBaoHanh] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QuanLyBaoHanh', N'ON'
GO
USE [QuanLyBaoHanh]
GO
/****** Object:  Table [dbo].[LoaiThietBi]    Script Date: 1/31/2020 10:57:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiThietBi](
	[MaLoai] [varchar](10) NOT NULL,
	[TenLoai] [nvarchar](250) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_BaoHanh]    Script Date: 1/31/2020 10:57:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_BaoHanh](
	[MaLoaiBH] [varchar](10) NOT NULL,
	[MaThietBi] [nvarchar](10) NULL,
	[MaKH] [varchar](10) NULL,
	[NgayBaoHanh] [datetime] NULL,
	[GhiChu] [nvarchar](250) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_ChucDanh]    Script Date: 1/31/2020 10:57:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ChucDanh](
	[MaChucDanh] [varchar](20) NOT NULL,
	[TenChucDanh] [nvarchar](250) NOT NULL,
	[GhiChu] [nvarchar](250) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChucDanh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_DichVu]    Script Date: 1/31/2020 10:57:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_DichVu](
	[MaDV] [varchar](20) NOT NULL,
	[TenDV] [nvarchar](250) NOT NULL,
	[GiaDichVu] [money] NOT NULL,
	[ThoiGianBH] [int] NOT NULL,
	[TinhTrang] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_KhachHang]    Script Date: 1/31/2020 10:57:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_KhachHang](
	[MaKH] [varchar](20) NOT NULL,
	[TenKhachHang] [nvarchar](250) NOT NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](250) NULL,
	[SDT] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_LoaiBaoHanh]    Script Date: 1/31/2020 10:57:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_LoaiBaoHanh](
	[MaLoaiBH] [varchar](10) NOT NULL,
	[TenLoaiBH] [nvarchar](250) NULL,
	[PhiBH] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoaiBH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_NhanVien]    Script Date: 1/31/2020 10:57:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_NhanVien](
	[TenDangNhap] [varchar](20) NOT NULL,
	[MatKhau] [varchar](20) NULL,
	[HoTenNV] [nvarchar](250) NOT NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](250) NULL,
	[SDT] [varchar](10) NULL,
	[MaChucDanh] [varchar](20) NULL,
 CONSTRAINT [PK_tbl_NhanVien] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThietBi]    Script Date: 1/31/2020 10:57:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThietBi](
	[MaThietBi] [varchar](10) NOT NULL,
	[MaLoai] [varchar](10) NULL,
	[TenThietBi] [nvarchar](250) NULL,
	[SoSeri] [varchar](20) NULL,
	[NgayMua] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaThietBi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tbl_NhanVien] ([TenDangNhap], [MatKhau], [HoTenNV], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [MaChucDanh]) VALUES (N'admin', N'admin', N'Nguyễn Văn A', N'Nam', CAST(N'1996-09-01' AS Date), N'', N'', N'CD0001')
USE [master]
GO
ALTER DATABASE [QuanLyBaoHanh] SET  READ_WRITE 
GO
