CREATE DATABASE	Asrama_DT
ON
(	NAME = Asrama_DT_dat,
	 FILENAME = 'F:\SMT3\Pemrograman Lanjut\Praktikum\FP\DB\Asrama_DT_dat.mdf',
	 SIZE = 100,
	 MAXSIZE = 500,
	 FILEGROWTH = 10)
LOG ON
(NAME = Asrama_Daya_Taka_log,
	 FILENAME = 'F:\SMT3\Pemrograman Lanjut\Praktikum\FP\DB\Asrama_DT_log.ldf',
	 SIZE = 100,
	 MAXSIZE = 500,
	 FILEGROWTH = 10)

USE Asrama_DT


CREATE TABLE anggota(
nik char(16) primary key not null,
nama varchar(50) not null,
tmpt_lahir varchar(20) not null,
tgl_lahir datetime not null,
jk varchar(6) check(jk='Male' or jk='Female') not null,
alamat varchar(50) not null,
agama varchar(10) check(agama IN('Islam','Protestan','Katholik','Hindu','Budha','Konghuchu')) not null,
no_hp char(12),
email varchar(30),
gol_darah char(2),
no_kamar char(2) not null,
)

CREATE Table pengurus(
nik char(16) foreign key references Anggota(Nik),
jabatan varchar(20) not null,
id_Login char(5) primary key not null,
password varchar(10) not null
)

Create table keuangan(
no_keu int identity(1,1) primary key not null,
kd_keu AS 'R'+Right('000' + convert (varchar, no_keu), 4) persisted,
tgl datetime not null,
id_Login char(5) foreign key references pengurus(id_Login),
jml_masuk numeric,
jml_keluar numeric,
keterangan varchar(30) not null
)

create table inventaris(
no_inven int identity(1,1)  primary key,
kd_inven AS 'I'+Right('000' + convert (varchar, no_inven), 4) persisted,
nama_barang varchar(20) not null,
stock numeric not null
)

create table peminjaman(
no_peminjaman int identity(1,1) primary key not null,
kd_peminjaman AS 'L'+Right('000' + convert (varchar, no_peminjaman), 4) persisted,
id_Login char(5) foreign key references pengurus(id_Login) not null,
no_inven int foreign key references inventaris(no_inven) not null,
nama_peminjam varchar(50) not null,
tgl_pinjam datetime not null,
tgl_kembali datetime not null
)

insert into peminjaman values
('1','31599', 1, 'aju', '2018/5/12', '2018/5/15')

select * from peminjaman


insert into anggota values
('1234567890123456','Martha Presina','Kandhangan','1999/05/31','Male','Perbatasan kalsel kalteng','Islam','088880088880','Ata@gmail.com','AB','01')
insert into pengurus values
('12345','ata12345','Ketua','1234567890123456')

Select P.id_Login, A.nama, PWDENCRYPT(P.password)
from pengurus P join anggota A
	ON P.nik=A.nik

SELECT P.kd_peminjaman, A.nama, I.nama_barang, P.nama_peminjam, P.tgl_pinjam, P.tgl_kembali 
FROM peminjaman P JOIN pengurus ON pengurus.id_Login = P.id_Login JOIN anggota A 
ON pengurus.nik = A.nik JOIN inventaris I ON P.kd_inven = I.kd_inven

SELECT SUM(jml_masuk) AS tot_masuk,SUM(jml_keluar) AS tot_keluar, SUM(jml_masuk)-SUM(jml_keluar)as tot_saldo FROM keuangan

select* from inventaris
SELECT DISTINCT nik FROM anggota

DBCC CHECKIDENT ('keuangan', RESEED, 0)

select * from keuangan
select * from keuangan where MONTH(tgl)='01' AND  YEAR(tgl)='2019'

select * from pengurus