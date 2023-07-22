CREATE DATABASE QUANLYXEHONDA
GO
USE QUANLYXEHONDA
GO

--tao bang
CREATE TABLE LOAIXE(
MaLoaiXe VARCHAR(10) NOT NULL PRIMARY KEY,
TenLoaiXe NVARCHAR(255) NOT NULL
);

CREATE TABLE THONGTINXE(
MaXe VARCHAR(10) NOT NULL PRIMARY KEY,
MaLoaiXe VARCHAR(10) NOT NULL,
TenXe NVARCHAR(255) NOT NULL,
Gia FLOAT NOT NULL,
MauXe NVARCHAR(50) NOT NULL,
DongCo INT NOT NULL,
KhoiLuong FLOAT NOT NULL

FOREIGN KEY(MaLoaiXe)
REFERENCES LOAIXE(MaLoaiXe)
);

--insert
INSERT INTO LOAIXE 
	VALUES('Sport', N'Xe thể thao'),
			('Xeso', N'Xe số'),
			('Tayga', 'Xe tay ga')

INSERT INTO THONGTINXE
	VALUES('RB50023', 'Sport', 'Rebel 500 2023', 180000000, 'Đen', 471, 190),
			('TW2023TC', 'Sport', N'Africa Twin 2023 Tiêu Chuẩn', 500000000, 'Đen', 1084, 229),
			('TW2023SP', 'Sport', 'Africa Twin 2023 Adventure Sports', 1500000000, 'Đen', 250, 1084),
			('GW2022', 'Sport', N'Gold Wing phiên bản 2022', 540700000, 'Xanh', 390, 1833),
			('CB1000R ', 'Sport', 'CB1000R 2023', 324000000, 'Xanh', 213, 998),
			('FU125FI ', 'Xeso', 'Future 125 FI', 31090000, 'Xanh', 125, 104),
			('RSXFI ', 'Xeso', 'Wave RSX FI 110', 22140000, 'Đen', 110, 99),
			('ALPHA ', 'Xeso', 'Wave Alpha 110cc', 18190000, 'Đen', 110, 97),
			('SCUBC125 ', 'Xeso', 'Super Cub C125', 87890000, 'Đen', 125, 109),
			('BLADE2023 ', 'Xeso', 'Blade 2023', 19250000, 'Đen', 110, 99),
			('SHMODE ', 'Tayga', 'Sh mode 125cc', 58190000, 'Đen', 125, 116),
			('SH350I ', 'Tayga', 'SH350i', 150990000, 'Đen', 330, 172)
