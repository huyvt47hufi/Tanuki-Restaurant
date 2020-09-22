USE [master]
GO
/****** Object:  Database [QLNhaHang]    Script Date: 21/11/2019 12:46:15 ******/
CREATE DATABASE [QLNhaHang]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLNhaHang', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\QLNhaHang.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLNhaHang_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\QLNhaHang_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [QLNhaHang] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLNhaHang].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLNhaHang] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLNhaHang] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLNhaHang] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLNhaHang] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLNhaHang] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLNhaHang] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLNhaHang] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLNhaHang] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLNhaHang] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLNhaHang] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLNhaHang] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLNhaHang] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLNhaHang] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLNhaHang] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLNhaHang] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLNhaHang] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLNhaHang] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLNhaHang] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLNhaHang] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLNhaHang] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLNhaHang] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLNhaHang] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLNhaHang] SET RECOVERY FULL 
GO
ALTER DATABASE [QLNhaHang] SET  MULTI_USER 
GO
ALTER DATABASE [QLNhaHang] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLNhaHang] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLNhaHang] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLNhaHang] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLNhaHang] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLNhaHang', N'ON'
GO
ALTER DATABASE [QLNhaHang] SET QUERY_STORE = OFF
GO
USE [QLNhaHang]
GO
/****** Object:  Table [dbo].[ChamCong]    Script Date: 21/11/2019 12:46:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChamCong](
	[MaNV] [char](10) NOT NULL,
	[Ngay] [date] NULL,
	[TGVao] [time](7) NULL,
	[TGVe] [time](7) NULL,
	[TongGioLam] [time](7) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 21/11/2019 12:46:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[MaChucVu] [char](10) NOT NULL,
	[TenChucVu] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChucVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DichVu]    Script Date: 21/11/2019 12:46:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DichVu](
	[MaDichVu] [char](10) NOT NULL,
	[TenDichVu] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDichVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 21/11/2019 12:46:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHoaDon] [char](30) NOT NULL,
	[MaKH] [char](10) NULL,
	[TongTien] [money] NULL,
	[NgayXuatHD] [date] NOT NULL,
	[MaDichVu] [char](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 21/11/2019 12:46:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [char](10) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[SDT] [char](10) NULL,
	[Email] [char](50) NULL,
	[GioiTinh] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiMon]    Script Date: 21/11/2019 12:46:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiMon](
	[MaLoai] [char](10) NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Menu]    Script Date: 21/11/2019 12:46:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menu](
	[MaMon] [char](10) NOT NULL,
	[HinhAnh] [nvarchar](50) NULL,
	[MaLoai] [char](10) NULL,
	[TenMon] [nvarchar](50) NULL,
	[MoTa] [varchar](100) NULL,
	[Gia] [money] NULL,
	[TinhTrangMon] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 21/11/2019 12:46:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [char](10) NOT NULL,
	[MaChucVu] [char](10) NOT NULL,
	[HinhNV] [nvarchar](50) NULL,
	[HoTenNV] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[NgayVaoLam] [date] NULL,
	[SoDienThoai] [char](10) NULL,
	[LuongCoBan] [money] NULL,
	[TongThoiGian] [int] NULL,
	[PhuCap] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuOrder]    Script Date: 21/11/2019 12:46:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuOrder](
	[MaPhieu] [char](10) NOT NULL,
	[MaKH] [char](10) NULL,
	[MaNV] [char](10) NULL,
	[MaMon] [char](10) NULL,
	[SoLuong] [int] NULL,
	[TongTien] [money] NULL,
	[MaHoaDon] [char](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 21/11/2019 12:46:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TenTK] [char](50) NOT NULL,
	[MatKhau] [char](50) NOT NULL,
	[MaNV] [char](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[TenTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChamCong] ([MaNV], [Ngay], [TGVao], [TGVe], [TongGioLam]) VALUES (N'NV02      ', CAST(N'2019-11-20' AS Date), CAST(N'00:08:27' AS Time), CAST(N'00:08:35' AS Time), CAST(N'00:00:00' AS Time))
INSERT [dbo].[ChamCong] ([MaNV], [Ngay], [TGVao], [TGVe], [TongGioLam]) VALUES (N'NV03      ', CAST(N'2019-11-20' AS Date), CAST(N'00:08:55' AS Time), CAST(N'00:14:45' AS Time), CAST(N'00:00:00' AS Time))
INSERT [dbo].[ChamCong] ([MaNV], [Ngay], [TGVao], [TGVe], [TongGioLam]) VALUES (N'NV01      ', CAST(N'2019-11-19' AS Date), CAST(N'19:30:00' AS Time), CAST(N'20:02:00' AS Time), CAST(N'00:00:00' AS Time))
INSERT [dbo].[ChamCong] ([MaNV], [Ngay], [TGVao], [TGVe], [TongGioLam]) VALUES (N'NV01      ', CAST(N'1900-01-01' AS Date), CAST(N'00:00:00' AS Time), CAST(N'00:00:00' AS Time), CAST(N'00:00:00' AS Time))
INSERT [dbo].[ChamCong] ([MaNV], [Ngay], [TGVao], [TGVe], [TongGioLam]) VALUES (N'NV02      ', CAST(N'1900-01-01' AS Date), CAST(N'00:00:00' AS Time), CAST(N'00:00:00' AS Time), CAST(N'00:00:00' AS Time))
INSERT [dbo].[ChamCong] ([MaNV], [Ngay], [TGVao], [TGVe], [TongGioLam]) VALUES (N'NV03      ', CAST(N'1900-01-01' AS Date), CAST(N'00:00:00' AS Time), CAST(N'00:00:00' AS Time), CAST(N'00:00:00' AS Time))
INSERT [dbo].[ChamCong] ([MaNV], [Ngay], [TGVao], [TGVe], [TongGioLam]) VALUES (N'NV04      ', CAST(N'1900-01-01' AS Date), CAST(N'00:00:00' AS Time), CAST(N'00:00:00' AS Time), CAST(N'00:00:00' AS Time))
INSERT [dbo].[ChamCong] ([MaNV], [Ngay], [TGVao], [TGVe], [TongGioLam]) VALUES (N'NV05      ', CAST(N'1900-01-01' AS Date), CAST(N'00:00:00' AS Time), CAST(N'00:00:00' AS Time), CAST(N'00:00:00' AS Time))
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu]) VALUES (N'NV        ', N'NhanVien')
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu]) VALUES (N'QL        ', N'Quản lí')
INSERT [dbo].[DichVu] ([MaDichVu], [TenDichVu]) VALUES (N'EI        ', N'Quất tại chỗ')
INSERT [dbo].[DichVu] ([MaDichVu], [TenDichVu]) VALUES (N'TA        ', N'Take a way')
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaKH], [TongTien], [NgayXuatHD], [MaDichVu]) VALUES (N'HD1                           ', N'KH01      ', 220000.0000, CAST(N'2019-11-21' AS Date), N'TA        ')
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaKH], [TongTien], [NgayXuatHD], [MaDichVu]) VALUES (N'HD2                           ', N'kh01      ', 440000.0000, CAST(N'2019-11-21' AS Date), N'TA        ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [Email], [GioiTinh]) VALUES (N'KH01      ', N'Khách hàng 1', N'0961507834', N'khachhang1@gmail.com                              ', N'Nữ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [Email], [GioiTinh]) VALUES (N'KH02      ', N'Khách hàng 2', N'0961507834', N'khachhang2@gmail.com                              ', N'Nữ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [Email], [GioiTinh]) VALUES (N'KH03      ', N'Khách hàng 3', N'0961507834', N'khachhang3@gmail.com                              ', N'Nữ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [Email], [GioiTinh]) VALUES (N'KH04      ', N'Khách hàng 4', N'0961507834', N'khachhang4@gmail.com                              ', N'Nữ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [Email], [GioiTinh]) VALUES (N'KH05      ', N'Khách hàng 5', N'0961507834', N'khachhang5@gmail.com                              ', N'Nữ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [Email], [GioiTinh]) VALUES (N'KH06      ', N'Khách hàng 6', N'0961507834', N'khachhang6@gmail.com                              ', N'Nam')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [Email], [GioiTinh]) VALUES (N'KH07      ', N'Khách hàng 7', N'0961507834', N'khachhang7@gmail.com                              ', N'Nam')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [Email], [GioiTinh]) VALUES (N'KH08      ', N'Khách hàng 8', N'0961507834', N'khachhang8@gmail.com                              ', N'Nam')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [Email], [GioiTinh]) VALUES (N'KH09      ', N'Khách hàng 9', N'0961507834', N'khachhang9@gmail.com                              ', N'Nam')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [Email], [GioiTinh]) VALUES (N'KH10      ', N'Khách hàng 10', N'0961507834', N'khachhang10@gmail.com                             ', N'Nam')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [Email], [GioiTinh]) VALUES (N'KH11      ', N'Khách hàng 11', N'0123456789', N'khachhang11@gmail.com                             ', N'Nam')
INSERT [dbo].[LoaiMon] ([MaLoai], [TenLoai]) VALUES (N'F         ', N'Đồ ăn')
INSERT [dbo].[LoaiMon] ([MaLoai], [TenLoai]) VALUES (N'N         ', N'Nước')
INSERT [dbo].[LoaiMon] ([MaLoai], [TenLoai]) VALUES (N'TM        ', N'Tráng Miệng')
INSERT [dbo].[Menu] ([MaMon], [HinhAnh], [MaLoai], [TenMon], [MoTa], [Gia], [TinhTrangMon]) VALUES (N'M01       ', N'kem.jpg', N'TM        ', N'Kem', N'null', 20000.0000, N'Còn')
INSERT [dbo].[Menu] ([MaMon], [HinhAnh], [MaLoai], [TenMon], [MoTa], [Gia], [TinhTrangMon]) VALUES (N'M02       ', N'duatuyet.jpg', N'TM        ', N'Dừa tuyết', N'null', 200000.0000, N'Còn')
INSERT [dbo].[Menu] ([MaMon], [HinhAnh], [MaLoai], [TenMon], [MoTa], [Gia], [TinhTrangMon]) VALUES (N'M03       ', N'banhtuyetthiensu.jpg', N'TM        ', N'Bánh tuyết thiên sứ', N'null', 500000.0000, N'Còn')
INSERT [dbo].[Menu] ([MaMon], [HinhAnh], [MaLoai], [TenMon], [MoTa], [Gia], [TinhTrangMon]) VALUES (N'M04       ', N'traicay1.jpg', N'TM        ', N'Trái cây tổng hợp', N'null', 500000.0000, N'Còn')
INSERT [dbo].[Menu] ([MaMon], [HinhAnh], [MaLoai], [TenMon], [MoTa], [Gia], [TinhTrangMon]) VALUES (N'M05       ', N'fanta.jpg', N'N         ', N'Fanta', N'null', 1000.0000, N'Còn')
INSERT [dbo].[Menu] ([MaMon], [HinhAnh], [MaLoai], [TenMon], [MoTa], [Gia], [TinhTrangMon]) VALUES (N'M06       ', N'suonnuongbbq.jpg', N'F         ', N'Sường nướng sốt BBQ', N'null', 1000.0000, N'Còn')
INSERT [dbo].[Menu] ([MaMon], [HinhAnh], [MaLoai], [TenMon], [MoTa], [Gia], [TinhTrangMon]) VALUES (N'M07       ', N'lauech.jpg', N'F         ', N'Lẩu ếch', N'null', 1000.0000, N'Còn')
INSERT [dbo].[Menu] ([MaMon], [HinhAnh], [MaLoai], [TenMon], [MoTa], [Gia], [TinhTrangMon]) VALUES (N'M08       ', N'baongunuong.jpg', N'F         ', N'Bào ngư nướng', N'null', 1000.0000, N'Còn')
INSERT [dbo].[Menu] ([MaMon], [HinhAnh], [MaLoai], [TenMon], [MoTa], [Gia], [TinhTrangMon]) VALUES (N'M09       ', N'tomnuong.jpg', N'F         ', N'Tôm nướng', N'null', 1000.0000, N'Còn')
INSERT [dbo].[Menu] ([MaMon], [HinhAnh], [MaLoai], [TenMon], [MoTa], [Gia], [TinhTrangMon]) VALUES (N'M10       ', N'tomchienxu.jpg', N'F         ', N'Tôm chiên xù', N'null', 1000.0000, N'Còn')
INSERT [dbo].[Menu] ([MaMon], [HinhAnh], [MaLoai], [TenMon], [MoTa], [Gia], [TinhTrangMon]) VALUES (N'M11       ', N'tomnhoiphomai.jpg', N'F         ', N'Tôm nhồi phomai', N'null', 1000.0000, N'Còn')
INSERT [dbo].[Menu] ([MaMon], [HinhAnh], [MaLoai], [TenMon], [MoTa], [Gia], [TinhTrangMon]) VALUES (N'M12       ', N'nuocmia.jpg', N'N         ', N'Nước mía', N'null', 1000.0000, N'Còn')
INSERT [dbo].[Menu] ([MaMon], [HinhAnh], [MaLoai], [TenMon], [MoTa], [Gia], [TinhTrangMon]) VALUES (N'M13       ', N'rongxanh.jpg', N'F         ', N'Rồng xanh ngậm tỏi', N'null', 1000.0000, N'Còn')
INSERT [dbo].[Menu] ([MaMon], [HinhAnh], [MaLoai], [TenMon], [MoTa], [Gia], [TinhTrangMon]) VALUES (N'M14       ', N'duongtang.jpg', N'F         ', N'Đường tăng vượt đại dương', N'null', 1000.0000, N'Còn')
INSERT [dbo].[Menu] ([MaMon], [HinhAnh], [MaLoai], [TenMon], [MoTa], [Gia], [TinhTrangMon]) VALUES (N'M15       ', N'tomhapbia.jpg', N'F         ', N'Tôm hấp bia', N'null', 1000.0000, N'Còn')
INSERT [dbo].[Menu] ([MaMon], [HinhAnh], [MaLoai], [TenMon], [MoTa], [Gia], [TinhTrangMon]) VALUES (N'M16       ', N'changanuong.jpg', N'F         ', N'Chân gà nướng', N'null', 1000.0000, N'Còn')
INSERT [dbo].[Menu] ([MaMon], [HinhAnh], [MaLoai], [TenMon], [MoTa], [Gia], [TinhTrangMon]) VALUES (N'M17       ', N'codubai.jpg', N'TM        ', N'Cỏ Dubai', N'null', 1000.0000, N'Còn')
INSERT [dbo].[Menu] ([MaMon], [HinhAnh], [MaLoai], [TenMon], [MoTa], [Gia], [TinhTrangMon]) VALUES (N'M18       ', N'sushi.jpg', N'F         ', N'Sushi', N'null', 1000.0000, N'Còn')
INSERT [dbo].[NhanVien] ([MaNV], [MaChucVu], [HinhNV], [HoTenNV], [GioiTinh], [NgaySinh], [NgayVaoLam], [SoDienThoai], [LuongCoBan], [TongThoiGian], [PhuCap]) VALUES (N'NV01      ', N'QL        ', N'ql.jpg', N'Quản lí', N'Nam', CAST(N'1999-07-04' AS Date), CAST(N'2019-11-01' AS Date), N'0961507834', 25000.0000, 300, 1000000.0000)
INSERT [dbo].[NhanVien] ([MaNV], [MaChucVu], [HinhNV], [HoTenNV], [GioiTinh], [NgaySinh], [NgayVaoLam], [SoDienThoai], [LuongCoBan], [TongThoiGian], [PhuCap]) VALUES (N'NV02      ', N'NV        ', N'nv1.jpg', N'Nhân viên 01', N'Nữ', CAST(N'1999-01-01' AS Date), CAST(N'2019-11-02' AS Date), N'0964567892', 20000.0000, 200, 100000.0000)
INSERT [dbo].[NhanVien] ([MaNV], [MaChucVu], [HinhNV], [HoTenNV], [GioiTinh], [NgaySinh], [NgayVaoLam], [SoDienThoai], [LuongCoBan], [TongThoiGian], [PhuCap]) VALUES (N'NV03      ', N'NV        ', N'nv2.jpg', N'Nhân viên 02', N'Nữ', CAST(N'1999-02-02' AS Date), CAST(N'2019-11-03' AS Date), N'0965148274', 20000.0000, 150, 100000.0000)
INSERT [dbo].[NhanVien] ([MaNV], [MaChucVu], [HinhNV], [HoTenNV], [GioiTinh], [NgaySinh], [NgayVaoLam], [SoDienThoai], [LuongCoBan], [TongThoiGian], [PhuCap]) VALUES (N'NV04      ', N'NV        ', N'nv3.jpg', N'Nhân viên 03', N'Nữ', CAST(N'1999-03-03' AS Date), CAST(N'2019-11-04' AS Date), N'0962839472', 20000.0000, 130, 100000.0000)
INSERT [dbo].[NhanVien] ([MaNV], [MaChucVu], [HinhNV], [HoTenNV], [GioiTinh], [NgaySinh], [NgayVaoLam], [SoDienThoai], [LuongCoBan], [TongThoiGian], [PhuCap]) VALUES (N'NV05      ', N'NV        ', N'nv4.jpg', N'Nhân viên 04', N'Nữ', CAST(N'1999-04-04' AS Date), CAST(N'2019-11-05' AS Date), N'0968374957', 20000.0000, 135, 100000.0000)
INSERT [dbo].[NhanVien] ([MaNV], [MaChucVu], [HinhNV], [HoTenNV], [GioiTinh], [NgaySinh], [NgayVaoLam], [SoDienThoai], [LuongCoBan], [TongThoiGian], [PhuCap]) VALUES (N'NV06      ', N'NV        ', N'nv5.jpg', N'Nhân viên 05', N'Nữ', CAST(N'1999-04-04' AS Date), CAST(N'2019-11-06' AS Date), N'0968374957', 20000.0000, 135, 100000.0000)
INSERT [dbo].[NhanVien] ([MaNV], [MaChucVu], [HinhNV], [HoTenNV], [GioiTinh], [NgaySinh], [NgayVaoLam], [SoDienThoai], [LuongCoBan], [TongThoiGian], [PhuCap]) VALUES (N'NV07      ', N'NV        ', N'nv6.jpg', N'Nhân viên 06', N'Nam', CAST(N'1999-04-04' AS Date), CAST(N'2019-11-07' AS Date), N'0968374957', 20000.0000, 135, 100000.0000)
INSERT [dbo].[NhanVien] ([MaNV], [MaChucVu], [HinhNV], [HoTenNV], [GioiTinh], [NgaySinh], [NgayVaoLam], [SoDienThoai], [LuongCoBan], [TongThoiGian], [PhuCap]) VALUES (N'NV08      ', N'NV        ', N'nv7.jpg', N'Nhân viên 07', N'Nam', CAST(N'1999-04-04' AS Date), CAST(N'2019-11-08' AS Date), N'0968374957', 20000.0000, 135, 100000.0000)
INSERT [dbo].[NhanVien] ([MaNV], [MaChucVu], [HinhNV], [HoTenNV], [GioiTinh], [NgaySinh], [NgayVaoLam], [SoDienThoai], [LuongCoBan], [TongThoiGian], [PhuCap]) VALUES (N'NV09      ', N'NV        ', N'nv8.jpg', N'Nhân viên 08', N'Nam', CAST(N'1999-04-04' AS Date), CAST(N'2019-11-09' AS Date), N'0968374957', 20000.0000, 135, 100000.0000)
INSERT [dbo].[NhanVien] ([MaNV], [MaChucVu], [HinhNV], [HoTenNV], [GioiTinh], [NgaySinh], [NgayVaoLam], [SoDienThoai], [LuongCoBan], [TongThoiGian], [PhuCap]) VALUES (N'NV10      ', N'NV        ', N'nv9.jpg', N'Nhân viên 09', N'Nam', CAST(N'1999-04-04' AS Date), CAST(N'2019-11-10' AS Date), N'0968374957', 20000.0000, 135, 100000.0000)
INSERT [dbo].[PhieuOrder] ([MaPhieu], [MaKH], [MaNV], [MaMon], [SoLuong], [TongTien], [MaHoaDon]) VALUES (N'1         ', N'NV01      ', NULL, N'M01       ', 1, 20000.0000, N'HD1                           ')
INSERT [dbo].[PhieuOrder] ([MaPhieu], [MaKH], [MaNV], [MaMon], [SoLuong], [TongTien], [MaHoaDon]) VALUES (N'2         ', N'NV01      ', NULL, N'M02       ', 1, 200000.0000, N'HD1                           ')
INSERT [dbo].[PhieuOrder] ([MaPhieu], [MaKH], [MaNV], [MaMon], [SoLuong], [TongTien], [MaHoaDon]) VALUES (N'3         ', N'NV01      ', NULL, N'M01       ', 2, 40000.0000, N'HD2                           ')
INSERT [dbo].[PhieuOrder] ([MaPhieu], [MaKH], [MaNV], [MaMon], [SoLuong], [TongTien], [MaHoaDon]) VALUES (N'4         ', N'NV01      ', NULL, N'M02       ', 2, 400000.0000, N'HD2                           ')
INSERT [dbo].[TaiKhoan] ([TenTK], [MatKhau], [MaNV]) VALUES (N'nhanvien1                                         ', N'nhanvien1                                         ', N'NV02      ')
INSERT [dbo].[TaiKhoan] ([TenTK], [MatKhau], [MaNV]) VALUES (N'nhanvien2                                         ', N'nhanvien2                                         ', N'NV03      ')
INSERT [dbo].[TaiKhoan] ([TenTK], [MatKhau], [MaNV]) VALUES (N'nhanvien3                                         ', N'nhanvien3                                         ', N'NV04      ')
INSERT [dbo].[TaiKhoan] ([TenTK], [MatKhau], [MaNV]) VALUES (N'nhanvien4                                         ', N'nhanvien4                                         ', N'NV05      ')
INSERT [dbo].[TaiKhoan] ([TenTK], [MatKhau], [MaNV]) VALUES (N'quanli                                            ', N'quanli                                            ', N'NV01      ')
ALTER TABLE [dbo].[ChamCong]  WITH CHECK ADD  CONSTRAINT [FK_NhanVienChamCong] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[ChamCong] CHECK CONSTRAINT [FK_NhanVienChamCong]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_DichVuHoaDon] FOREIGN KEY([MaDichVu])
REFERENCES [dbo].[DichVu] ([MaDichVu])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_DichVuHoaDon]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_KhachHangHoaDon] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_KhachHangHoaDon]
GO
ALTER TABLE [dbo].[Menu]  WITH CHECK ADD  CONSTRAINT [FK_LoaiMonMenu] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LoaiMon] ([MaLoai])
GO
ALTER TABLE [dbo].[Menu] CHECK CONSTRAINT [FK_LoaiMonMenu]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_ChucVuNhanVien] FOREIGN KEY([MaChucVu])
REFERENCES [dbo].[ChucVu] ([MaChucVu])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_ChucVuNhanVien]
GO
ALTER TABLE [dbo].[PhieuOrder]  WITH CHECK ADD  CONSTRAINT [FK_MenuPhieuOder] FOREIGN KEY([MaMon])
REFERENCES [dbo].[Menu] ([MaMon])
GO
ALTER TABLE [dbo].[PhieuOrder] CHECK CONSTRAINT [FK_MenuPhieuOder]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_NhanVienTaiKhoan] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_NhanVienTaiKhoan]
GO
USE [master]
GO
ALTER DATABASE [QLNhaHang] SET  READ_WRITE 
GO
