use master
go
if exists (select * from sysdatabases where name='QUANLYBANTHUOC')
	drop database QUANLYBANTHUOC
go
create database QUANLYBANTHUOC
on primary
(
	name= QUANLYBANTHUOCdat,
	filename='D:\QUANLYBANTHUOCdat.mdf',
	size=10, 
	maxsize=100,
	filegrowth=10
)
log on
(
	name=QUANLYBANTHUOClog,
	filename='D:\QUANLYBANTHUOClog.ldf',
	size=1,
	filegrowth=5
)
GO
use QUANLYBANTHUOC
CREATE TABLE CHUCVU
(
	MACHUCVU VARCHAR(20) PRIMARY KEY,
	MOTA NVARCHAR(100)
)
GO
CREATE TABLE NHANVIEN
(
	MANHANVIEN VARCHAR(20) PRIMARY KEY,
	HOTEN NVARCHAR(100) NOT NULL,
	DIACHI NVARCHAR(100) NOT NULL,
	GIOITINH BIT,
	SDT VARCHAR(15),
	EMAIL NVARCHAR(50),
	DANTOC	NVARCHAR(50),
	TONGIAO NVARCHAR(50),
	CMTND VARCHAR(20),
	NGAYCAP VARCHAR(10),
	NOICAP VARCHAR(50),
	NGAYBATDAUVAOLAM VARCHAR(10),
	MUCLUONG FLOAT,
	GHICHU NVARCHAR(100),
	MACHUCVU VARCHAR(20) FOREIGN KEY REFERENCES CHUCVU(MACHUCVU),
	TAIKHOAN NVARCHAR(50) NOT NULL,
	MATKHAU NVARCHAR(100) NOT NULL
)
GO
CREATE TABLE CHUCNANG
(
	MACHUCNANG VARCHAR(100) PRIMARY KEY,
	MOTA NVARCHAR(100)
)
GO
CREATE TABLE PHANQUYEN
(
	MAPHANQUYEN VARCHAR(20),
	MACHUCVU VARCHAR(20) FOREIGN KEY REFERENCES CHUCVU(MACHUCVU),
	MACHUCNANG VARCHAR(100) FOREIGN KEY REFERENCES CHUCNANG(MACHUCNANG),
	XEM BIT NOT NULL,
	THEM BIT NOT NULL,
	SUA BIT NOT NULL,
	XOA BIT NOT NULL
)
GO
CREATE TABLE DONVITINH
(
	MADONVI VARCHAR(10) PRIMARY KEY,
	MOTA NVARCHAR(50) NOT NULL
)
GO
CREATE TABLE THONGTINNHATHUOC
(
	TENCUAHANG NVARCHAR(50) PRIMARY KEY,
	NGUOICHIUTRACHNHIEM NVARCHAR(50),
	MASOTHUE NVARCHAR(50),
	DIACHI NVARCHAR(50),
	EMAIL VARCHAR(30),
	SDT VARCHAR(20),
	FAX VARCHAR(20)
)
GO
CREATE TABLE NHACUNGCAP
(
	MANHACUNGCAP VARCHAR(10) PRIMARY KEY,
	TENNHACUNGCAP NVARCHAR(50),
	DIACHI NVARCHAR(50),
	SDT VARCHAR(20),
	EMAIL NVARCHAR(30),
	MASOTHUE VARCHAR(20),
	FAX VARCHAR(20),
	GHICHU NVARCHAR(50)
)
GO
CREATE TABLE LOAITHUOC
(
	MALOAITHUOC VARCHAR(10) PRIMARY KEY,
	MOTA NVARCHAR(50),
)
GO
CREATE TABLE THUOC
(
	MATHUOC VARCHAR(20) PRIMARY KEY,
	TENTHUOC NVARCHAR(50),
	MALOAITHUOC VARCHAR(10) FOREIGN KEY REFERENCES LOAITHUOC(MALOAITHUOC),
	DONVITINH VARCHAR(10) FOREIGN KEY REFERENCES DONVITINH(MADONVI),
	DONVIQUYDOICAP_1 VARCHAR(10) FOREIGN KEY REFERENCES DONVITINH(MADONVI),
	TYLEQUYDOICAP_1 INT,
	DONVIQUYDOI_CAP2 VARCHAR(10)FOREIGN KEY REFERENCES DONVITINH(MADONVI),
	TYLEQUYDOICAP_2 INT,
	MANHACUNGCAP VARCHAR(10)FOREIGN KEY REFERENCES NHACUNGCAP(MANHACUNGCAP),
	CONGDUNG NVARCHAR(100),
	CACHSUDUNG NVARCHAR(100),
	XUATXU NVARCHAR(100),
	NHIETDOBAOQUAN NVARCHAR(10),
	DOAMBAOQUAN NVARCHAR(10)
)
GO

CREATE TABLE KHOTHUOC
(
	MAKHOTHUOC VARCHAR(20) PRIMARY KEY,
	MATHUOC VARCHAR(20) FOREIGN KEY REFERENCES THUOC(MATHUOC),
	MALOTHUOC VARCHAR(20),
	SOLUONG_DVQD1 INT,
	DONGIA_DVQD1 FLOAT,
	SOLUONG_DVQD2 INT,
	DONGIA_DVQD2 FLOAT,
	NGAYHETHANSD VARCHAR(15),
	THEODOIGIA VARCHAR(500),
	GIACAONHAT FLOAT,
	GIATHAPNHAT FLOAT,
	GIAHIENTAI FLOAT,
	NGAYCAPNHATGIA VARCHAR(15)
)
GO
CREATE TABLE PHIEUNHAP
(
	MAPHIEUNHAP VARCHAR(50) PRIMARY KEY,
	MANHANVIEN VARCHAR(20) FOREIGN KEY REFERENCES NHANVIEN(MANHANVIEN),
	NGAYLAPPHIEU VARCHAR(15),
	NGAYSUALANCUOI VARCHAR(15),
	NVSUALANCUOI VARCHAR(20)FOREIGN KEY REFERENCES NHANVIEN(MANHANVIEN),
	GHICHU NVARCHAR (100)
)
GO
CREATE TABLE CTPHIEUNHAP
(
	MACHITIETNHAP VARCHAR (50) PRIMARY KEY,
	MAPHIEUNHAP VARCHAR(50) FOREIGN KEY REFERENCES PHIEUNHAP(MAPHIEUNHAP),
	MATHUOC VARCHAR(20) FOREIGN KEY REFERENCES THUOC(MATHUOC), 
	MASOLO VARCHAR(20),
	SOLUONGTINH_DVQD1 INT,
	DONGIA_DVQD1 FLOAT,
	SOLUONGTINH_DVQD2 INT,
	DONGIA_DVQD2 FLOAT,
	HANSUDUNG VARCHAR(15),
	NGAYSUALANCUOI VARCHAR(15),
	GHICHU NVARCHAR(100)
)
GO
CREATE TABLE PHIEUXUAT
(
	MAPHIEUXUAT VARCHAR (50) PRIMARY KEY,
	MANHANVIEN VARCHAR(20) FOREIGN KEY REFERENCES NHANVIEN(MANHANVIEN),
	NGAYLAPPHIEU VARCHAR(15),
	NGAYSUALANCUOI VARCHAR(15),
	NVSUALANCUOI VARCHAR(20) FOREIGN KEY REFERENCES NHANVIEN(MANHANVIEN),
	TONGTIEN FLOAT,
	GHICHU NVARCHAR(100)
)
GO
CREATE TABLE CTPHIEUXUAT
(
	MACHITIETXUAT VARCHAR (50) PRIMARY KEY,
	MAPHIEUXUAT VARCHAR (50) FOREIGN KEY REFERENCES PHIEUXUAT(MAPHIEUXUAT), 
	MATHUOC VARCHAR(20) FOREIGN KEY REFERENCES THUOC(MATHUOC), 
	MASOLO VARCHAR(20),
	SOLUONGTINH_DVQD1 INT,
	DONGIA_DVQD1 FLOAT,
	SOLUONGTINH_DVQD2 INT,
	DONGIA_DVQD2 FLOAT,
	THANHTIEN FLOAT,
	NGAYSUALANCUOI VARCHAR(15),
	GHICHU NVARCHAR(100)
)



