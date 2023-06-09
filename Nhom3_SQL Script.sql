USE [master]
GO

/*--------------------- NHÓM 3 : TẠO DATABASE CGV -------------------*/

CREATE DATABASE [CGV]
GO
ALTER DATABASE [CGV] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CGV].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CGV] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CGV] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CGV] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CGV] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CGV] SET ARITHABORT OFF 
GO
ALTER DATABASE [CGV] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CGV] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CGV] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CGV] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CGV] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CGV] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CGV] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CGV] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CGV] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CGV] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CGV] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CGV] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CGV] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CGV] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CGV] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CGV] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CGV] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CGV] SET RECOVERY FULL 
GO
ALTER DATABASE [CGV] SET  MULTI_USER 
GO
ALTER DATABASE [CGV] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CGV] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CGV] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CGV] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CGV] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CGV] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'CGV', N'ON'
GO
ALTER DATABASE [CGV] SET QUERY_STORE = OFF
GO
USE [CGV]
GO
/******  TẠO BẢNG : CỤM RẠP ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CumRap](
	[MaCum] [varchar](5) NOT NULL,
	[TenCum] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](100) NULL,
 CONSTRAINT [PK_CumRap] PRIMARY KEY CLUSTERED 
(
	[MaCum] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/******  TẠO BẢNG : KẾ HOẠCH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KeHoach](
	[MaPhim] [varchar](10) NOT NULL,
	[MaCum] [varchar](5) NOT NULL,
	[NgayKhoiChieu] [date] NOT NULL,
	[NgayKetThuc] [date] NOT NULL,
	[GhiChu] [nvarchar](100) NULL,
 CONSTRAINT [PK_KeHoach] PRIMARY KEY CLUSTERED 
(
	[MaPhim] ASC,
	[MaCum] ASC,
	[NgayKhoiChieu] ASC,
	[NgayKetThuc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/******  TẠO BẢNG : LỊCH CHIẾU  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichChieucms](
	[MaPhim] [varchar](10) NOT NULL,
	[MaRap] [varchar](5) NOT NULL,
	[NgayChieu] [date] NOT NULL,
	[ChuoiMaSuat] [nvarchar](max) NULL,
 CONSTRAINT [PK_LichChieucms] PRIMARY KEY CLUSTERED 
(
	[MaPhim] ASC,
	[MaRap] ASC,
	[NgayChieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/**********  TẠO BẢNG : PHIM ************/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phim](
	[MaPhim] [varchar](10) NOT NULL,
	[TenPhim] [nvarchar](50) NOT NULL,
	[MaTheLoaiChinh] [varchar](5) NOT NULL,
	[ThoiLuong] [int] NOT NULL,
	[CoLa3D] [bit] NOT NULL,
	[CoLongTieng] [bit] NOT NULL,
 CONSTRAINT [PK_Phim] PRIMARY KEY CLUSTERED 
(
	[MaPhim] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/*************  TẠO BẢNG : PHIM.THELOAIPHU ****************/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhimTheLoaiPhu](
	[MaPhim] [varchar](10) NOT NULL,
	[MaTheLoai] [varchar](5) NOT NULL,
 CONSTRAINT [PK_PhimTheLoaiPhu] PRIMARY KEY CLUSTERED 
(
	[MaPhim] ASC,
	[MaTheLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****************  TẠO BẢNG : RẠP ****************/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rap](
	[MaRap] [varchar](5) NOT NULL,
	[TongGhe] [int] NOT NULL,
	[MaCum] [varchar](5) NOT NULL,
 CONSTRAINT [PK_Rap] PRIMARY KEY CLUSTERED 
(
	[MaRap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/***************  TẠO BẢNG : SUẤT CHIẾU *****************/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SuatChieu](
	[MaSuat] [varchar](3) NOT NULL,
	[GioBatDau] [int] NOT NULL,
	[PhutBatDau] [int] NOT NULL,
 CONSTRAINT [PK_SuatChieu] PRIMARY KEY CLUSTERED 
(
	[MaSuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****************  TẠO BẢNG : TÀI KHOẢN *****************/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TenTaiKhoan] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](50) NOT NULL,
	[TenChuTaiKhoan] [nvarchar](50) NOT NULL,
	[MaCum] [varchar](5) NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[TenTaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****************  TẠO BẢNG : THỂ LOẠI *****************/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TheLoai](
	[MaTheLoai] [varchar](5) NOT NULL,
	[TenTheLoai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TheLoai] PRIMARY KEY CLUSTERED 
(
	[MaTheLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

---------------------- NHẬP LIỆU ------------------------------
/**************************************************************/

INSERT [dbo].[CumRap] ([MaCum], [TenCum], [DiaChi]) VALUES (N'CGVQ1', N'CGV Quận 1', N'Quận 1, TP.HCM')
INSERT [dbo].[CumRap] ([MaCum], [TenCum], [DiaChi]) VALUES (N'CGVQ2', N'CGV Quận 2', N'Quận 2, TP.HCM')
INSERT [dbo].[CumRap] ([MaCum], [TenCum], [DiaChi]) VALUES (N'CGVQ3', N'CGV Quận 3', N'Quận 3, TP.HCM')
INSERT [dbo].[CumRap] ([MaCum], [TenCum], [DiaChi]) VALUES (N'Null', N'Null', N'Null')
GO
INSERT [dbo].[KeHoach] ([MaPhim], [MaCum], [NgayKhoiChieu], [NgayKetThuc], [GhiChu]) VALUES (N'P1', N'CGVQ1', CAST(N'2023-05-06' AS Date), CAST(N'2023-06-10' AS Date), NULL)
INSERT [dbo].[KeHoach] ([MaPhim], [MaCum], [NgayKhoiChieu], [NgayKetThuc], [GhiChu]) VALUES (N'P1', N'CGVQ2', CAST(N'2023-05-06' AS Date), CAST(N'2023-06-10' AS Date), NULL)
INSERT [dbo].[KeHoach] ([MaPhim], [MaCum], [NgayKhoiChieu], [NgayKetThuc], [GhiChu]) VALUES (N'P10', N'CGVQ3', CAST(N'2023-04-22' AS Date), CAST(N'2023-05-22' AS Date), NULL)
INSERT [dbo].[KeHoach] ([MaPhim], [MaCum], [NgayKhoiChieu], [NgayKetThuc], [GhiChu]) VALUES (N'P11', N'CGVQ3', CAST(N'2023-04-08' AS Date), CAST(N'2023-05-08' AS Date), NULL)
INSERT [dbo].[KeHoach] ([MaPhim], [MaCum], [NgayKhoiChieu], [NgayKetThuc], [GhiChu]) VALUES (N'P2', N'CGVQ1', CAST(N'2023-07-02' AS Date), CAST(N'2023-08-05' AS Date), NULL)
INSERT [dbo].[KeHoach] ([MaPhim], [MaCum], [NgayKhoiChieu], [NgayKetThuc], [GhiChu]) VALUES (N'P2', N'CGVQ2', CAST(N'2023-07-02' AS Date), CAST(N'2023-08-05' AS Date), NULL)
INSERT [dbo].[KeHoach] ([MaPhim], [MaCum], [NgayKhoiChieu], [NgayKetThuc], [GhiChu]) VALUES (N'P2', N'CGVQ3', CAST(N'2023-07-02' AS Date), CAST(N'2023-08-05' AS Date), NULL)
INSERT [dbo].[KeHoach] ([MaPhim], [MaCum], [NgayKhoiChieu], [NgayKetThuc], [GhiChu]) VALUES (N'P3', N'CGVQ2', CAST(N'2023-07-16' AS Date), CAST(N'2023-08-16' AS Date), NULL)
INSERT [dbo].[KeHoach] ([MaPhim], [MaCum], [NgayKhoiChieu], [NgayKetThuc], [GhiChu]) VALUES (N'P3', N'CGVQ3', CAST(N'2023-07-16' AS Date), CAST(N'2023-08-16' AS Date), NULL)
INSERT [dbo].[KeHoach] ([MaPhim], [MaCum], [NgayKhoiChieu], [NgayKetThuc], [GhiChu]) VALUES (N'P4', N'CGVQ1', CAST(N'2023-06-15' AS Date), CAST(N'2023-07-15' AS Date), NULL)
INSERT [dbo].[KeHoach] ([MaPhim], [MaCum], [NgayKhoiChieu], [NgayKetThuc], [GhiChu]) VALUES (N'P4', N'CGVQ3', CAST(N'2023-06-15' AS Date), CAST(N'2023-07-15' AS Date), NULL)
INSERT [dbo].[KeHoach] ([MaPhim], [MaCum], [NgayKhoiChieu], [NgayKetThuc], [GhiChu]) VALUES (N'P5', N'CGVQ2', CAST(N'2023-08-06' AS Date), CAST(N'2023-09-08' AS Date), NULL)
INSERT [dbo].[KeHoach] ([MaPhim], [MaCum], [NgayKhoiChieu], [NgayKetThuc], [GhiChu]) VALUES (N'P5', N'CGVQ3', CAST(N'2023-08-06' AS Date), CAST(N'2023-09-08' AS Date), NULL)
INSERT [dbo].[KeHoach] ([MaPhim], [MaCum], [NgayKhoiChieu], [NgayKetThuc], [GhiChu]) VALUES (N'P6', N'CGVQ3', CAST(N'2023-08-17' AS Date), CAST(N'2023-09-20' AS Date), NULL)
INSERT [dbo].[KeHoach] ([MaPhim], [MaCum], [NgayKhoiChieu], [NgayKetThuc], [GhiChu]) VALUES (N'P7', N'CGVQ1', CAST(N'2023-05-13' AS Date), CAST(N'2023-06-15' AS Date), NULL)
INSERT [dbo].[KeHoach] ([MaPhim], [MaCum], [NgayKhoiChieu], [NgayKetThuc], [GhiChu]) VALUES (N'P7', N'CGVQ3', CAST(N'2023-05-13' AS Date), CAST(N'2023-06-15' AS Date), NULL)
INSERT [dbo].[KeHoach] ([MaPhim], [MaCum], [NgayKhoiChieu], [NgayKetThuc], [GhiChu]) VALUES (N'P8', N'CGVQ2', CAST(N'2023-05-20' AS Date), CAST(N'2023-06-20' AS Date), NULL)
INSERT [dbo].[KeHoach] ([MaPhim], [MaCum], [NgayKhoiChieu], [NgayKetThuc], [GhiChu]) VALUES (N'P9', N'CGVQ1', CAST(N'2023-05-06' AS Date), CAST(N'2023-06-10' AS Date), NULL)
GO
INSERT [dbo].[LichChieucms] ([MaPhim], [MaRap], [NgayChieu], [ChuoiMaSuat]) VALUES (N'P1', N'T01', CAST(N'2023-05-14' AS Date), N' CH1, SA1')
INSERT [dbo].[LichChieucms] ([MaPhim], [MaRap], [NgayChieu], [ChuoiMaSuat]) VALUES (N'P1', N'V01', CAST(N'2023-05-20' AS Date), N' CH2, SA1')
INSERT [dbo].[LichChieucms] ([MaPhim], [MaRap], [NgayChieu], [ChuoiMaSuat]) VALUES (N'P10', N'T03', CAST(N'2023-04-22' AS Date), N'SA1, TO1')
INSERT [dbo].[LichChieucms] ([MaPhim], [MaRap], [NgayChieu], [ChuoiMaSuat]) VALUES (N'P11', N'T03', CAST(N'2023-04-10' AS Date), N'TO1')
INSERT [dbo].[LichChieucms] ([MaPhim], [MaRap], [NgayChieu], [ChuoiMaSuat]) VALUES (N'P2', N'V02', CAST(N'2023-07-16' AS Date), N' SA2, TO2')
INSERT [dbo].[LichChieucms] ([MaPhim], [MaRap], [NgayChieu], [ChuoiMaSuat]) VALUES (N'P3', N'T02', CAST(N'2023-07-16' AS Date), N' CH1, SA2, TO2')
INSERT [dbo].[LichChieucms] ([MaPhim], [MaRap], [NgayChieu], [ChuoiMaSuat]) VALUES (N'P5', N'T03', CAST(N'2023-08-25' AS Date), N' CH3, SA1, TO1')
INSERT [dbo].[LichChieucms] ([MaPhim], [MaRap], [NgayChieu], [ChuoiMaSuat]) VALUES (N'P5', N'V03', CAST(N'2023-09-01' AS Date), N' CH3')
INSERT [dbo].[LichChieucms] ([MaPhim], [MaRap], [NgayChieu], [ChuoiMaSuat]) VALUES (N'P6', N'T03', CAST(N'2023-09-20' AS Date), N' CH3, TO1')
INSERT [dbo].[LichChieucms] ([MaPhim], [MaRap], [NgayChieu], [ChuoiMaSuat]) VALUES (N'P7', N'T01', CAST(N'2023-05-13' AS Date), N' CH2, SA3, TO1')
INSERT [dbo].[LichChieucms] ([MaPhim], [MaRap], [NgayChieu], [ChuoiMaSuat]) VALUES (N'P7', N'T01', CAST(N'2023-05-23' AS Date), N' SA1')
INSERT [dbo].[LichChieucms] ([MaPhim], [MaRap], [NgayChieu], [ChuoiMaSuat]) VALUES (N'P7', N'T03', CAST(N'2023-06-13' AS Date), N' TO2')
INSERT [dbo].[LichChieucms] ([MaPhim], [MaRap], [NgayChieu], [ChuoiMaSuat]) VALUES (N'P8', N'T02', CAST(N'2023-05-30' AS Date), N'CH2, SA1, TO2')
GO
INSERT [dbo].[Phim] ([MaPhim], [TenPhim], [MaTheLoaiChinh], [ThoiLuong], [CoLa3D], [CoLongTieng]) VALUES (N'P1', N'Phim 1', N'CT', 180, 1, 0)
INSERT [dbo].[Phim] ([MaPhim], [TenPhim], [MaTheLoaiChinh], [ThoiLuong], [CoLa3D], [CoLongTieng]) VALUES (N'P10', N'Phim 10', N'TC', 140, 0, 0)
INSERT [dbo].[Phim] ([MaPhim], [TenPhim], [MaTheLoaiChinh], [ThoiLuong], [CoLa3D], [CoLongTieng]) VALUES (N'P11', N'Phim 11', N'HA', 110, 1, 0)
INSERT [dbo].[Phim] ([MaPhim], [TenPhim], [MaTheLoaiChinh], [ThoiLuong], [CoLa3D], [CoLongTieng]) VALUES (N'P2', N'Phim 2', N'HD', 120, 1, 0)
INSERT [dbo].[Phim] ([MaPhim], [TenPhim], [MaTheLoaiChinh], [ThoiLuong], [CoLa3D], [CoLongTieng]) VALUES (N'P3', N'Phim 3', N'HA', 150, 0, 1)
INSERT [dbo].[Phim] ([MaPhim], [TenPhim], [MaTheLoaiChinh], [ThoiLuong], [CoLa3D], [CoLongTieng]) VALUES (N'P4', N'Phim 4', N'HH', 100, 1, 1)
INSERT [dbo].[Phim] ([MaPhim], [TenPhim], [MaTheLoaiChinh], [ThoiLuong], [CoLa3D], [CoLongTieng]) VALUES (N'P5', N'Phim 5', N'KD', 90, 0, 1)
INSERT [dbo].[Phim] ([MaPhim], [TenPhim], [MaTheLoaiChinh], [ThoiLuong], [CoLa3D], [CoLongTieng]) VALUES (N'P6', N'Phim 6', N'TL', 110, 0, 0)
INSERT [dbo].[Phim] ([MaPhim], [TenPhim], [MaTheLoaiChinh], [ThoiLuong], [CoLa3D], [CoLongTieng]) VALUES (N'P7', N'Phim 7', N'CN', 130, 0, 0)
INSERT [dbo].[Phim] ([MaPhim], [TenPhim], [MaTheLoaiChinh], [ThoiLuong], [CoLa3D], [CoLongTieng]) VALUES (N'P8', N'Phim 8', N'TC', 140, 0, 0)
INSERT [dbo].[Phim] ([MaPhim], [TenPhim], [MaTheLoaiChinh], [ThoiLuong], [CoLa3D], [CoLongTieng]) VALUES (N'P9', N'Phim 9', N'TC', 140, 0, 0)
GO
INSERT [dbo].[PhimTheLoaiPhu] ([MaPhim], [MaTheLoai]) VALUES (N'P1', N'HH')
INSERT [dbo].[PhimTheLoaiPhu] ([MaPhim], [MaTheLoai]) VALUES (N'P10', N'KD')
INSERT [dbo].[PhimTheLoaiPhu] ([MaPhim], [MaTheLoai]) VALUES (N'P11', N'HH')
INSERT [dbo].[PhimTheLoaiPhu] ([MaPhim], [MaTheLoai]) VALUES (N'P2', N'CN')
INSERT [dbo].[PhimTheLoaiPhu] ([MaPhim], [MaTheLoai]) VALUES (N'P3', N'CN')
INSERT [dbo].[PhimTheLoaiPhu] ([MaPhim], [MaTheLoai]) VALUES (N'P4', N'TC')
INSERT [dbo].[PhimTheLoaiPhu] ([MaPhim], [MaTheLoai]) VALUES (N'P5', N'TC')
INSERT [dbo].[PhimTheLoaiPhu] ([MaPhim], [MaTheLoai]) VALUES (N'P6', N'HA')
INSERT [dbo].[PhimTheLoaiPhu] ([MaPhim], [MaTheLoai]) VALUES (N'P7', N'TC')
INSERT [dbo].[PhimTheLoaiPhu] ([MaPhim], [MaTheLoai]) VALUES (N'P8', N'HA')
INSERT [dbo].[PhimTheLoaiPhu] ([MaPhim], [MaTheLoai]) VALUES (N'P9', N'HA')
GO
INSERT [dbo].[Rap] ([MaRap], [TongGhe], [MaCum]) VALUES (N'T01', 100, N'CGVQ1')
INSERT [dbo].[Rap] ([MaRap], [TongGhe], [MaCum]) VALUES (N'T02', 130, N'CGVQ2')
INSERT [dbo].[Rap] ([MaRap], [TongGhe], [MaCum]) VALUES (N'T03', 100, N'CGVQ3')
INSERT [dbo].[Rap] ([MaRap], [TongGhe], [MaCum]) VALUES (N'V01', 50, N'CGVQ1')
INSERT [dbo].[Rap] ([MaRap], [TongGhe], [MaCum]) VALUES (N'V02', 60, N'CGVQ2')
INSERT [dbo].[Rap] ([MaRap], [TongGhe], [MaCum]) VALUES (N'V03', 60, N'CGVQ3')
GO
INSERT [dbo].[SuatChieu] ([MaSuat], [GioBatDau], [PhutBatDau]) VALUES (N'CH1', 13, 30)
INSERT [dbo].[SuatChieu] ([MaSuat], [GioBatDau], [PhutBatDau]) VALUES (N'CH2', 15, 0)
INSERT [dbo].[SuatChieu] ([MaSuat], [GioBatDau], [PhutBatDau]) VALUES (N'CH3', 17, 30)
INSERT [dbo].[SuatChieu] ([MaSuat], [GioBatDau], [PhutBatDau]) VALUES (N'SA1', 6, 0)
INSERT [dbo].[SuatChieu] ([MaSuat], [GioBatDau], [PhutBatDau]) VALUES (N'SA2', 8, 0)
INSERT [dbo].[SuatChieu] ([MaSuat], [GioBatDau], [PhutBatDau]) VALUES (N'SA3', 10, 0)
INSERT [dbo].[SuatChieu] ([MaSuat], [GioBatDau], [PhutBatDau]) VALUES (N'SA4', 11, 0)
INSERT [dbo].[SuatChieu] ([MaSuat], [GioBatDau], [PhutBatDau]) VALUES (N'TO1', 19, 15)
INSERT [dbo].[SuatChieu] ([MaSuat], [GioBatDau], [PhutBatDau]) VALUES (N'TO2', 21, 30)
GO
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [MatKhau], [TenChuTaiKhoan], [MaCum]) VALUES (N'admin', N'admin', N'Diễm Quyên', NULL)
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [MatKhau], [TenChuTaiKhoan], [MaCum]) VALUES (N'nhanvienq1', N'nhanvienq1', N'Thanh Nhi', N'CGVQ1')
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [MatKhau], [TenChuTaiKhoan], [MaCum]) VALUES (N'nhanvienq2', N'nhanvienq2', N'Hạnh Nhi', N'CGVQ2')
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [MatKhau], [TenChuTaiKhoan], [MaCum]) VALUES (N'nhanvienq3', N'nhanvienq3', N'Mai Hiền', N'CGVQ3')
GO
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'CN', N'Ca nh?c')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'CT', N'C? trang')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'HA', N'Hài')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'HD', N'Hi?n d?i')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'HH', N'Ho?t hình')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'KD', N'Kinh d?')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'TC', N'Tình c?m')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'TL', N'Tâm lý')
GO

------------- TẠO FOREIGN KEY , CHECK CONSTRAINT ----------------------
/**********************************************************************/

ALTER TABLE [dbo].[KeHoach]  WITH CHECK ADD  CONSTRAINT [FK_KeHoach_CumRap] FOREIGN KEY([MaCum])
REFERENCES [dbo].[CumRap] ([MaCum])
GO
ALTER TABLE [dbo].[KeHoach] CHECK CONSTRAINT [FK_KeHoach_CumRap]
GO
ALTER TABLE [dbo].[KeHoach]  WITH CHECK ADD  CONSTRAINT [FK_KeHoach_Phim] FOREIGN KEY([MaPhim])
REFERENCES [dbo].[Phim] ([MaPhim])
GO
ALTER TABLE [dbo].[KeHoach] CHECK CONSTRAINT [FK_KeHoach_Phim]
GO
ALTER TABLE [dbo].[LichChieucms]  WITH CHECK ADD  CONSTRAINT [FK_LichChieucms_Phim] FOREIGN KEY([MaPhim])
REFERENCES [dbo].[Phim] ([MaPhim])
GO
ALTER TABLE [dbo].[LichChieucms] CHECK CONSTRAINT [FK_LichChieucms_Phim]
GO
ALTER TABLE [dbo].[LichChieucms]  WITH CHECK ADD  CONSTRAINT [FK_LichChieucms_Rap] FOREIGN KEY([MaRap])
REFERENCES [dbo].[Rap] ([MaRap])
GO
ALTER TABLE [dbo].[LichChieucms] CHECK CONSTRAINT [FK_LichChieucms_Rap]
GO
ALTER TABLE [dbo].[PhimTheLoaiPhu]  WITH CHECK ADD  CONSTRAINT [FK_PhimTheLoaiPhu_Phim] FOREIGN KEY([MaPhim])
REFERENCES [dbo].[Phim] ([MaPhim])
GO
ALTER TABLE [dbo].[PhimTheLoaiPhu] CHECK CONSTRAINT [FK_PhimTheLoaiPhu_Phim]
GO
ALTER TABLE [dbo].[PhimTheLoaiPhu]  WITH CHECK ADD  CONSTRAINT [FK_PhimTheLoaiPhu_TheLoai] FOREIGN KEY([MaTheLoai])
REFERENCES [dbo].[TheLoai] ([MaTheLoai])
GO
ALTER TABLE [dbo].[PhimTheLoaiPhu] CHECK CONSTRAINT [FK_PhimTheLoaiPhu_TheLoai]
GO
ALTER TABLE [dbo].[Rap]  WITH CHECK ADD  CONSTRAINT [FK_Rap_CumRap] FOREIGN KEY([MaCum])
REFERENCES [dbo].[CumRap] ([MaCum])
GO
ALTER TABLE [dbo].[Rap] CHECK CONSTRAINT [FK_Rap_CumRap]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_CumRap] FOREIGN KEY([MaCum])
REFERENCES [dbo].[CumRap] ([MaCum])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_CumRap]
GO
ALTER TABLE [dbo].[KeHoach]  WITH CHECK ADD  CONSTRAINT [CK_KeHoach] CHECK  (([NgayKhoiChieu]<[NgayKetThuc]))
GO
ALTER TABLE [dbo].[KeHoach] CHECK CONSTRAINT [CK_KeHoach]
GO
ALTER TABLE [dbo].[Rap]  WITH CHECK ADD  CONSTRAINT [CK_Rap] CHECK  (([TongGhe]>=(30) AND [TongGhe]<=(150)))
GO
ALTER TABLE [dbo].[Rap] CHECK CONSTRAINT [CK_Rap]
GO

-----------------TẠO STORED PROCEDURE ------------------------
/***********************************************************/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[sp_checksuatchieu] (@MaRap varchar(5),
											@NgayChieu date, 
											@MaPhim varchar(10), 
											@MaSuat varchar(3))
as
	declare @BangTam Table (
							MaPhim varchar(10),
							ThoiLuong int,
							MaRap varchar(5),
							NgayChieu date, 
							GioBatDau int,
							PhutBatDau int,
							MaSuat varchar(3))
begin 
-- xử lý chuỗi trước khi tách chuỗi 
	WITH LichChieuRe AS (SELECT MaPhim, MaRap, NgayChieu, REPLACE(ChuoiMaSuat, ' ', '') AS ChuoiMaSuat 
    FROM LichChieucms 
    WHERE MaRap = @MaRap AND NgayChieu = @NgayChieu) 
-- Tách chuỗi và tạo Bảng tạm trước khi bắt đầu điều kiện
	insert into @BangTam (MaPhim, ThoiLuong, MaRap, NgayChieu, GioBatDau, PhutBatDau, MaSuat)
	SELECT LichChieuRe.MaPhim, Phim.ThoiLuong, LichChieuRe.MaRap, LichChieuRe.NgayChieu, 
		   SuatChieu.GioBatDau, SuatChieu.PhutBatDau, MaSuat
	FROM LichChieuRe
	INNER JOIN Phim ON Phim.MaPhim = LichChieuRe.MaPhim
		CROSS APPLY STRING_SPLIT(LichChieuRe.ChuoiMaSuat, ',') AS bangMaSuat
	INNER JOIN SuatChieu ON SuatChieu.MaSuat = bangMaSuat.value
	-- khai báo biến
	declare @GioBatDau int, @PhutBatDau int, @ThoiLuong int
	select @GioBatDau = GioBatDau, @PhutBatDau = PhutBatDau from SuatChieu where MaSuat = @MaSuat
	select @ThoiLuong = ThoiLuong from Phim where MaPhim = @MaPhim
	-- Điều kiện: nếu tồn tại bảng ghi có thời điểm bắt đầu hoặc thời điểm kết thúc nằm trong khoảng thời gian chiếu 
	-- của lịch chiếu chèn vào thì sẽ báo lỗi. Nếu không có thì gọi procedure InsertUpdateChuoi để tiến hành chèn / cập nhật vào
	if exists (SELECT * FROM @BangTam
	WHERE ((GioBatDau + PhutBatDau/60) between (@GioBatDau + @PhutBatDau/60) and (@GioBatDau + @PhutBatDau/60 + @ThoiLuong/60))
or (GioBatDau + PhutBatDau/60 + ThoiLuong/60) between (@GioBatDau + @PhutBatDau/60) and (@GioBatDau + @PhutBatDau/60 + @ThoiLuong/60))
	begin 
	RAISERROR (N'Khoảng thời gian này đã có phim đang chiếu, vui lòng chọn suất chiếu khác!', 16,1)
	end
	else 
	begin
	exec sp_InsertUpdateChuoi @MaPhim, @MaRap, @NgayChieu, @MaSuat
	end
end
GO
/****** Object:  StoredProcedure [dbo].[sp_DangKyPhim]    Script Date: 08/04/2023 11:02:18 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--procedure cập nhật/chèn kế hoạch đăng kí phim 
CREATE procedure [dbo].[sp_DangKyPhim] (@MaPhim varchar(10),
									@MaCum varchar(5), -- Mã Cụm của cụm rạp thực hiện đăng ký phim
									@NgayKhoiChieu date,
									@NgayKetThuc date,
									@GhiChu nvarchar(100))  
as 
begin
--Nếu tồn tại kế hoạch của phim a vào ngày khởi chiếu, ngày kết thúc đó có mã cụm là mặc định thì update, còn không thì insert  
	if exists (select MaCum from KeHoach where MaPhim = @MaPhim and MaCum = 'Null' and NgayKhoiChieu = @NgayKhoiChieu and NgayKetThuc = @NgayKetThuc) 
		begin 
			update KeHoach
			SET MaCum = @MaCum 
			where MaPhim = @MaPhim and MaCum = 'Null' and NgayKhoiChieu = @NgayKhoiChieu and NgayKetThuc = @NgayKetThuc
		end
	else
		begin
			insert into KeHoach(MaPhim, MaCum, NgayKhoiChieu, NgayKetThuc, GhiChu) values
			(@MaPhim, @MaCum, @NgayKhoiChieu, @NgayKetThuc, @GhiChu)
		end

end
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteChuoi]    Script Date: 08/04/2023 11:02:18 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- sp_DeleteChuoi phục vụ cho button xoá lịch chiếu. Khi xoá một vài suất chiếu trong chuỗi suất chiếu 
--thì sẽ update lại chuỗi mã suất của lịch chiếu đó, nếu xoá hết chuỗi mã suất thì delete bản ghi. Trước 
--khi thực hiện lệnh thì kiểm tra dữ liệu trong chuỗi mã suất có hợp lệ hay không
CREATE procedure [dbo].[sp_DeleteChuoi](
								@MaPhim varchar(10), 
								@MaRap varchar(5), 
								@NgayChieu date,
								@ChuoiMaSuat nvarchar(max))
as
	declare @C table (MaSuat varchar (3))
	declare @ChuoiX nvarchar(100)
	SELECT @ChuoiX = REPLACE(@ChuoiMaSuat, ' ', '') --bỏ khoảng cách để đếm chiều dài chuỗi chính xác
begin
if (@ChuoiMaSuat not like '%[^a-zA-Z0-9, ]%' ESCAPE '\') -- Nếu @ChuoiMaSuat hợp lệ = true. 
								--@ChuoiMaSuat hợp lệ khi nằm trong các kí tự a-zA-Z0-9,\s
	begin 
		if LEN(@ChuoiX)= 0 --Chiều dài chuỗi sau khi bỏ dấu cách = 0 thì @ChuoiMaSuat = null 
			begin
			DELETE FROM LichChieucms WHERE MaPhim = @MaPhim AND MaRap = @MaRap AND NgayChieu = @NgayChieu
			end
		else 
			begin 
			insert into @C select value from string_split(@ChuoiX,',') --lấy mã suất trong chuỗi mới
			
			--tồn tại mã suất không nằm trong bảng suất chiếu thì không cho cập nhật
			if exists (select MaSuat from @C where MaSuat not in (select MaSuat from SuatChieu))
				begin 
					Raiserror(N'Không có suất chiếu này trong bảng suất chiếu!', 16, 1)
				end
			else
				begin
				UPDATE LichChieucms
				SET ChuoiMaSuat = replace(@ChuoiX,',',', ') -- định dạng lại chuỗi mới cho đẹp và cập nhật mã
				WHERE MaPhim = @MaPhim AND MaRap = @MaRap AND NgayChieu = @NgayChieu
				end 
			end
	end
else 
	begin
	Raiserror(N'Dữ liệu nhập vào không hợp lệ', 16, 1)
	end
end
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertUpdateChuoi]    Script Date: 08/04/2023 11:02:18 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/* sp này phục cho button thêm lịch chiếu, khi thêm mã suất mới vào lịch chiếu đã tồn tại thì sẽ 
ghép chuỗi và cập nhật cho lịch chiếu. Nếu không có thì chèn bản ghi mới
*/
CREATE procedure [dbo].[sp_InsertUpdateChuoi](
								@MaPhim varchar(10), 
								@MaRap varchar(5), 
								@NgayChieu date,
								@MaSuat varchar(3))
as
	declare @Chuoinew varchar(100)
begin
if exists (select ChuoiMaSuat from LichChieucms where MaPhim = @MaPhim and MaRap = @MaRap and NgayChieu = @NgayChieu)
	begin
	select @Chuoinew = concat_ws(', ', ChuoiMaSuat, @MaSuat)
	from LichChieucms 
	where MaPhim = @MaPhim and NgayChieu = @NgayChieu and MaRap = @MaRap
	update LichChieucms
	Set ChuoiMaSuat = @Chuoinew 
	where MaPhim = @MaPhim and NgayChieu = @NgayChieu and MaRap = @MaRap
	end
else 
	begin 
	insert into LichChieucms (MaPhim, MaRap, NgayChieu, ChuoiMaSuat)
	values (@MaPhim, @MaRap, @NgayChieu, @MaSuat)
	end 
end
GO
/****** Object:  StoredProcedure [dbo].[sp_LayMaSuat]    Script Date: 08/04/2023 11:02:18 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/* sp này để lọc ra những mã suất còn trống trong rạp đó, ngày đó 
*/

CREATE procedure [dbo].[sp_LayMaSuat] (
							@MaRap varchar(5),
							@NgayChieu date)
as 
	declare @T table (MaSuat varchar(3))
	DECLARE @C TABLE (Chuoi varchar(100));
begin 
	-- tách chuỗi để lấy giá trị mã suất đã tồn tại trong rạp đó, ngày đó
	insert into @C select REPLACE(ChuoiMaSuat, ' ', '') from LichChieucms where MaRap = @MaRap AND NgayChieu = @NgayChieu
	INSERT INTO @T (MaSuat) SELECT value FROM (SELECT STUFF((SELECT ',' + Chuoi FROM @C FOR XML PATH('')), 1, 1, '') AS Chuoi) AS t 
	CROSS APPLY STRING_SPLIT(Chuoi, ',');-- ghép các chuỗi suất chiếu thành một chuỗi, tách ra và chèn vào bảng tạm
	select MaSuat from SuatChieu where MaSuat not in (select MaSuat from @T ) -- so sánh với bảng tạm để lấy giá trị mã suất còn trống 
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Login]    Script Date: 08/04/2023 11:02:18 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

----------------------------------------------------------------------------------
-----Tạo procedure đăng nhập : tìm tên tài khoản và mật khẩu trong csdl
CREATE procedure [dbo].[sp_Login] (@TenTaiKhoan nvarchar(50),
                           @MatKhau nvarchar(50))
as
begin 
if exists (select * from TaiKhoan where TenTaiKhoan = @TenTaiKhoan AND MatKhau = @MatKhau)
	begin 
	    print N'Đăng nhập thành công'
	end
	else
	    raiserror(N'Tài khoản hoặc mật khẩu không tồn tại',16,1)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_SuaPhim]    Script Date: 08/04/2023 11:02:18 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--sp này dùng cho sửa phim.
CREATE procedure [dbo].[sp_SuaPhim](@MaPhim varchar(10),
								@TenPhim nvarchar (50),
								@MaTheLoaiChinh varchar(5), @MaTheLoai varchar(5),
								@ThoiLuong int,
								@CoLa3D bit,
								@CoLongTieng bit)
as 
begin
			update Phim 
			set TenPhim = @TenPhim, MaTheLoaiChinh = @MaTheLoaiChinh, ThoiLuong = @ThoiLuong,
				CoLa3D = @CoLa3D , CoLongTieng = @CoLongTieng
			where MaPhim = @MaPhim 	
			
			update PhimTheLoaiPhu
			set MaTheLoai = @MaTheLoai 
			where MaPhim = @MaPhim
end
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemPhim]    Script Date: 08/04/2023 11:02:18 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--sp này dùng cho thêm phim.
CREATE procedure [dbo].[sp_ThemPhim](@MaPhim varchar(10),
								@TenPhim nvarchar (50),
								@MaTheLoaiChinh varchar(5), @MaTheLoai varchar(5),
								@ThoiLuong int,
								@CoLa3D bit,
								@CoLongTieng bit)
as 
begin
			insert into Phim (MaPhim, TenPhim, MaTheLoaiChinh, ThoiLuong, CoLa3D, CoLongTieng) values
							(@MaPhim, @TenPhim, @MaTheLoaiChinh, @ThoiLuong, @CoLa3D, @CoLongTieng)
			insert into PhimTheLoaiPhu(MaPhim, MaTheLoai) values (@MaPhim, @MaTheLoai)

end
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateMatkhau]    Script Date: 08/04/2023 11:02:18 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---Tạo procedure update mật khẩu
CREATE procedure [dbo].[sp_UpdateMatkhau] (@TenTaiKhoan nvarchar(50),
                                 @MatKhauCu nvarchar(50),
                                 @MatKhauMoi nvarchar(50))

as
begin
	if exists (select * from TaiKhoan where TenTaiKhoan = @TenTaiKhoan and MatKhau = @MatKhauCu)
    begin
        update TaiKhoan set MatKhau = @MatKhauMoi where TenTaiKhoan = @TenTaiKhoan
        RAISERROR( N'Thay đổi mật khẩu thành công !!', 16,1)
    end
    else
        RAISERROR( N'Tài khoản hoặc mật khẩu sai!!' , 16,1)
end
GO

----------------------TẠO TRIGGER--------------------------------
/***************************************************************/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--ràng buộc: Chỉ được xoá kế hoạch trước tháng khởi chiếu trễ nhất 2 tuần
--ràng buộc : xoá kế hoạch chiếu <-- lịch chiếu trong kế hoạch cũng bị xoá 

	CREATE TRIGGER [dbo].[delete_kehoach]
ON [dbo].[KeHoach]
for DELETE
AS
declare @MaCum varchar(5),
        @NgayKhoiChieu date,
        @NgayKetThuc date,
		@NgayKCa date,
		@MaPhim varchar(10)
		select @MaPhim = MaPhim from deleted
		select @MaCum = MaCum from deleted
		select @NgayKhoiChieu = NgayKhoiChieu from deleted
		select @NgayKetThuc = NgayKetThuc from deleted
		
    if ((SELECT  DATEDIFF(day, GETDATE(), DATEADD(day, -DAY(@NgayKhoiChieu)+1, @NgayKhoiChieu))) > 14) 
		--Khoảng cách giữa ngày nhập và ngày khởi chiếu cũ phải lớn hơn 2 tuần 
	    begin
		delete from dbo.LichChieucms 
		where MaPhim = @MaPhim and (MaRap = any (select MaRap from dbo.Rap where MaCum = @MaCum)) --Truy vấn lịch chiếu với Mã Phim và Mã Rạp thuộc Cụm Rạp đã nhập
	    end 
	else 
		begin 
		RAISERROR (N'Chỉ được xoá kế hoạch trước tháng khởi chiếu trễ nhất 2 tuần', 16,1)
		ROLLBACK 
		end
GO
ALTER TABLE [dbo].[KeHoach] ENABLE TRIGGER [delete_kehoach]
GO
/****** Object:  Trigger [dbo].[insert_kehoach]    Script Date: 08/04/2023 11:02:18 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

----ràng buộc:Phải thêm kế hoạch trước tháng khởi chiếu ít nhất 2 tuần 
----ràng buộc :Trong một khoảng thời gian mỗi cụm rạp có không quá 2 phim
CREATE TRIGGER [dbo].[insert_kehoach]
on [dbo].[KeHoach]
instead of insert
as
begin
declare @MaPhim varchar(10),
        @MaCum varchar(5),
        @NgayKhoiChieu date,
		@GhiChu nvarchar(100),
        @NgayKetThuc date;
        SELECT @MaPhim = MaPhim from inserted;
        SELECT @MaCum = MaCum FROM inserted;
        SELECT @NgayKhoiChieu = NgayKhoiChieu FROM inserted;
        SELECT @NgayKetThuc = NgayKetThuc FROM inserted;
		-- để tránh dữ liệu từ bảng inserted tham gia vào quá trình so sánh trong câu lệnh if
		-- nên sử dụng instead of insert để so sánh sau đó sử dụng hàm insert into ...values để chèn giá trị từ bảng inserted vào.
    if (
       (SELECT  DATEDIFF(day, GETDATE(), DATEADD(day, -DAY(@NgayKhoiChieu)+1, @NgayKhoiChieu))) > 14 --khoảng cách từ ngày thêm lớn hơn ngày khởi chiếu của phim 2 tuần. 
	   )
	    BEGIN
	    IF EXISTS (
           SELECT Kh1.MaPhim
           FROM KEHOACH Kh1
           INNER JOIN KEHOACH Kh2 ON Kh1.MaCum = Kh2.MaCum AND KH1.MaCum = @MaCum  
            AND Kh1.MaPhim != Kh2.MaPhim and @MaPhim != Kh1.MaPhim
           WHERE (
		    ---Phim mới có NKC nằm trong NKC và NKT của phim 1, NKT nằm trong NKC và NKT của phim 2. Và NKC phim 2 nằm trong phim 1
			(kh1.NgayKhoiChieu<@NgayKhoiChieu and kh1.NgayKetThuc>@NgayKhoiChieu
			and kh2.NgayKhoiChieu<@NgayKetThuc and kh2.NgayKetThuc>@NgayKetThuc
			and Kh2.NgayKhoiChieu between Kh1.NgayKhoiChieu and Kh1.NgayKetThuc)
			---Phim mới có NKC nằm trong NKC và NKT của 2 bộ phim và NKC phim này nằm trong khoảng thời gian chiếu của phim kia
			or
		    (kh1.NgayKhoiChieu < @NgayKhoiChieu and Kh1.NgayKetThuc > @NgayKhoiChieu
			 and kh2.NgayKhoiChieu < @NgayKhoiChieu and kh2.NgayKetThuc > @NgayKhoiChieu
			 and (Kh2.NgayKhoiChieu between Kh1.NgayKhoiChieu and Kh1.NgayKetThuc
			    or Kh1.NgayKhoiChieu between Kh2.NgayKhoiChieu and Kh2.NgayKetThuc))
			---Phim mới có NKT nằm trong NKC và NKT của 2 bộ phim và NKC phim này nằm trong khoảng thời gian chiếu của phim kia
			or
			(Kh1.NgayKhoiChieu<@NgayKetThuc and Kh1.NgayKetThuc>@NgayKetThuc
			 and Kh2.NgayKhoiChieu <@NgayKetThuc and Kh2.NgayKetThuc>@NgayKetThuc
			 and (Kh2.NgayKhoiChieu between Kh1.NgayKhoiChieu and Kh1.NgayKetThuc
			     or Kh1.NgayKhoiChieu between Kh2.NgayKhoiChieu and Kh2.NgayKetThuc))
			)
           GROUP BY Kh1.MaPhim, Kh2.MaPhim
           HAVING COUNT(*) > 0 -- điều kiện này đếm số bản ghi thoả mãn điều kiện.
           )
           BEGIN
              RAISERROR(N'Không được thêm phim vào khoảng thời gian đã có 2 phim trùng nhau', 16, 1)
              ROLLBACK
           END
		   else
		   insert into KeHoach(MaPhim, MaCum, NgayKhoiChieu, NgayKetThuc,GhiChu) values (@MaPhim,@MaCum,@NgayKhoiChieu,@NgayKetThuc,@GhiChu)
	    END
      else
          BEGIN
              RAISERROR(N'Phải thêm kế hoạch trước tháng khởi chiếu ít nhất 2 tuần ', 16, 1)
              ROLLBACK
          END
end
GO
ALTER TABLE [dbo].[KeHoach] ENABLE TRIGGER [insert_kehoach]
GO
/****** Object:  Trigger [dbo].[delete_lichchieucms]    Script Date: 08/04/2023 11:02:18 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ràng buộc : chỉ được xoá lịch chiếu trước tuần có ngày chiếu 1 tuần 
CREATE trigger [dbo].[delete_lichchieucms]
on [dbo].[LichChieucms]
for delete
as
declare @MaPhim varchar(10),
        @MaRap varchar(5),
		@NgayChieu date
		select @MaPhim = MaPhim from deleted
		select @MaRap = MaRap from deleted
	    select @NgayChieu = NgayChieu from LichChieucms where MaPhim = @MaPhim and MaRap = @MaRap

 if (
	(select DATEDIFF(day, GETDATE(), (DATEADD(day, DATEDIFF(day, 0, @NgayChieu) / 7*7, 0)))) <= 7)
     begin
         RAISERROR(N'Chỉ được xóa lịch chiếu trước tuần có ngày chiếu 1 tuần', 16, 1)
         ROLLBACK
     end
GO
ALTER TABLE [dbo].[LichChieucms] ENABLE TRIGGER [delete_lichchieucms]
GO
/****** Object:  Trigger [dbo].[ins_LichChieucms]    Script Date: 08/04/2023 11:02:18 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ràng buộc ngày chiếu nằm trong khoảng thời gian kế hoạch chiếu 
CREATE TRIGGER [dbo].[ins_LichChieucms]
ON [dbo].[LichChieucms]
FOR INSERT 
AS
BEGIN
    DECLARE @MaPhim VARCHAR(10),
            @NgayChieu DATE,
		    @MaCum varchar(5),
		    @MaRap varchar(5),
            @NgayKhoiChieu DATE,
            @NgayKetThuc DATE,
			@KiemTra int

    SELECT @MaPhim = MaPhim FROM inserted
    SELECT @NgayChieu = NgayChieu FROM inserted
	SELECT @MaRap = MaRap FROM inserted
 
    --Trường hợp 1: Ngày chiếu không nằm trong Ngày khởi chiếu và Ngày kết thúc
    IF (@NgayChieu < any (select NgayKhoiChieu from KeHoach A, inserted i where A.MaPhim = i.MaPhim) 
	    OR @NgayChieu > any (select NgayKetThuc from KeHoach A, inserted i where A.MaPhim = i.MaPhim))
    BEGIN
        RAISERROR(N'Ngày chiếu phải nằm trong thời gian từ ngày khởi chiếu đến ngày kết thúc của kế hoạch!', 16, 1)
        ROLLBACK TRANSACTION
    END
	
	--Trường hợp 2: Ngày chiếu nằm trong Ngày khởi chiếu và Ngày kết thúc
	ELSE
	BEGIN
	 SELECT @KiemTra = COUNT(*) FROM KeHoach WHERE MaPhim = @MaPhim 
	 ---2.1: Phim không tồn tại trong cụm nào hết
	 IF @KiemTra = 0
     BEGIN
        RAISERROR(N'Phim chưa có kế hoạch chiếu tại bất kỳ cụm rạp nào!', 16, 1)
        ROLLBACK TRANSACTION
     END
	 ---2.2: Nếu phim có tồn tại trong cụm nào đó
	 ELSE
     BEGIN
        SELECT @MaCum = MaCum FROM Rap WHERE MaRap = @MaRap
		------2.2.1: Kiểm tra cụm rạp có tồn tại không? ---> Cái này nghĩ không cần
  --      IF @MaCum IS NULL
  --      BEGIN
  --          RAISERROR(N'Cụm rạp không tồn tại!', 16, 1)
  --          ROLLBACK TRANSACTION
  --      END
        
		----2.2.2: Kiểm tra phim nằm trong cụm nào đó
		If @MaCum is not null
        BEGIN
            SELECT @KiemTra = COUNT(*) FROM KeHoach k
                INNER JOIN Rap r ON k.MaCum = r.MaCum
                WHERE k.MaPhim = @MaPhim AND r.MaRap = @MaRap
                    --AND @NgayChieu >= k.NgayKhoiChieu AND @NgayChieu <= k.NgayKetThuc
            IF @KiemTra = 0
            BEGIN
                RAISERROR(N'Phim chưa có kế hoạch chiếu tại cụm rạp này!', 16, 1)
                ROLLBACK TRANSACTION
            END
        END
    END
END
END
GO
ALTER TABLE [dbo].[LichChieucms] ENABLE TRIGGER [ins_LichChieucms]
GO
/****** Object:  Trigger [dbo].[insert_lichchieu]    Script Date: 08/04/2023 11:02:18 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ràng buộc : chỉ được lên lịch chiếu cho tháng có lịch chiếu trễ nhất 1 tuấn
CREATE trigger [dbo].[insert_lichchieu]
on [dbo].[LichChieucms]
for insert
as
declare @MaPhim varchar(10),
        @MaRap varchar(5),
		@NgayChieu date
		--@KiemTra int
		select @MaPhim = MaPhim from inserted
		select @MaRap = MaRap from inserted
	    select @NgayChieu = NgayChieu from inserted
	

 if ((select datediff(day,(select convert(date,GETDATE())),(select DATEFROMPARTS(YEAR(@NgayChieu), MONTH(@NgayChieu), 1)))) < 7) 
 --tính khoảng cách từ ngày nhập đến ngày đầu tiên của tháng có ngày chiếu
     begin
         RAISERROR(N'Chỉ được lên lịch chiếu phim cho tháng mới 1 tuần trước đó', 16, 1)
         ROLLBACK
     end
GO
ALTER TABLE [dbo].[LichChieucms] ENABLE TRIGGER [insert_lichchieu]
GO
/****** Object:  Trigger [dbo].[update_lichchieucms]    Script Date: 08/04/2023 11:02:18 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  Trigger [dbo].[update_lichchieucms]    Script Date: 04/04/2023 5:44:32 CH ******/
--SET ANSI_NULLS ON
--GO
--SET QUOTED_IDENTIFIER ON
--GO
----ràng buộc : chỉ được sửa lịch chiếu trước tuần có ngày chiếu trễ nhất 1 tuần 

CREATE trigger [dbo].[update_lichchieucms]
on [dbo].[LichChieucms]
for update
as
declare @MaPhim varchar(10),
        @MaRap varchar(5),
		@NgayChieu date
		select @MaPhim = MaPhim from inserted
		select @MaRap = MaRap from inserted
	    select @NgayChieu = NgayChieu from LichChieucms where MaPhim = @MaPhim and MaRap = @MaRap

 if (
	(select DATEDIFF(day, GETDATE(), (DATEADD(day, DATEDIFF(day, 0, @NgayChieu) / 7*7, 0)))) < 7)
	 begin
         RAISERROR(N'Chỉ được sửa lịch chiếu trước tuần có lịch chiếu 1 tuần', 16, 1)
         ROLLBACK
     end
GO
ALTER TABLE [dbo].[LichChieucms] ENABLE TRIGGER [update_lichchieucms]
GO
/****** Object:  Trigger [dbo].[Delete_MaSuat]    Script Date: 08/04/2023 11:02:18 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Ràng buộc : Không được xoá các mã suất đang có lịch chiếu.

CREATE trigger [dbo].[Delete_MaSuat]
on [dbo].[SuatChieu]
for delete
as 
	declare @MaSuat varchar(3)
	declare @BangTam table (MaPhim varchar(10), MaRap varchar(5), NgayChieu date , MaSuat varchar(3))
	select @MaSuat = MaSuat from deleted
begin  
	-- xử lý chuỗi và tách chuỗi trước khi thực hiện câu điều kiện.
	WITH LichChieuRe AS (SELECT MaPhim, MaRap, NgayChieu, REPLACE(ChuoiMaSuat, ' ', '') AS ChuoiMaSuat 
	FROM LichChieucms )  

	insert into @BangTam (MaPhim, MaRap, NgayChieu, MaSuat)
	SELECT MaPhim, MaRap, NgayChieu, value as MaSuat
	FROM LichChieuRe
	CROSS APPLY STRING_SPLIT(ChuoiMaSuat, ',') 
	-- điều kiện: nếu Mã suất bị xoá tồn tại trong Bảng Tạm, cảnh báo và trả về dữ liệu ban đầu.
	if exists (select * from @BangTam 
				where MaSuat = @MaSuat)
				begin 
				raiserror (N' Suất chiếu này đang có lịch chiếu, không được xoá !',16,1)
				rollback tran
				end 
				
end
GO
ALTER TABLE [dbo].[SuatChieu] ENABLE TRIGGER [Delete_MaSuat]
GO
USE [master]
GO
ALTER DATABASE [CGV] SET  READ_WRITE 
GO
