create database QuanLyBoSua
go
use QuanLyBoSua
go

create table NhanVien(
    MaNv nvarchar(100),
	TenNv nvarchar(100),
	eMail nvarchar(200),
	gioiTinh nvarchar(100),
	NgaySinh date,
	ngayVaoLam date,
	anh ntext,
	primary key (MaNv)
)
go

insert into NhanVien values('admin',N'Suni Hạ Linh','trananhvu14785@gmail.com',N'Nữ',N'1989-10-15',N'2016-08-22',null)
insert into NhanVien values('nv001',N'Trần Anh Huy','trananhvu14785@gmail.com',N'Nam',N'1989-12-21',N'2016-08-22',null)
select MaNv,TenNv,convert(nvarchar(30), NgaySinh, 20)as ngaySinh,gioiTinh,convert(nvarchar(30), ngayVaoLam, 20)as ngayVaoLam,eMail,anh from NhanVien where maNv like N'%Trần%'
Create table loaiTK(
  id int identity(1,1),
  TenLoaiTK nvarchar(300),
  primary key(id)
)

insert into loaiTK(TenLoaiTK) values(N'Admin')
insert into loaiTK(TenLoaiTK) values(N'Nhân Viên')

create table account(
  tenDn nvarchar(100),
  matKhau nvarchar(100),
  loaiTk int,
  maNv nvarchar(100),
  primary key(tenDn),
  foreign key(maNv) references Nhanvien(maNv)ON DELETE CASCADE ,
  foreign key(loaiTk) references loaiTK(id)
)
go
select * from PhanViec
insert into account values('admin','123','1',null)

create table ChuongTrai(
   MaChuong int identity(1,1),
   tenChuong nvarchar(100),
   TongSoCho int,
   soChoConTrong int,
   MaNv nvarchar(100),
   primary key(MaChuong),
   foreign key (MaNv) references NhanVien(MaNv)ON DELETE CASCADE 
)
insert into ChuongTrai(tenChuong,tongSoCho,soChoConTrong,maNv) values(N'Chuồng 1','15','15',N'NV001')
insert into ChuongTrai(tenChuong,tongSoCho,soChoConTrong,maNv) values(N'Chuồng 2','15','15',N'NV001')
insert into ChuongTrai(tenChuong,tongSoCho,soChoConTrong,maNv) values(N'Chuồng 3','15','15',N'NV001')
insert into ChuongTrai(tenChuong,tongSoCho,soChoConTrong,maNv) values(N'Chuồng 4','15','15',N'NV001')
insert into ChuongTrai(tenChuong,tongSoCho,soChoConTrong,maNv) values(N'Chuồng 5','15','15',N'NV001')
insert into ChuongTrai(tenChuong,tongSoCho,soChoConTrong,maNv) values(N'Chuồng 6','15','15',N'NV001')
insert into ChuongTrai(tenChuong,tongSoCho,soChoConTrong,maNv) values(N'Chuồng 7','15','15',N'NV001')
insert into ChuongTrai(tenChuong,tongSoCho,soChoConTrong,maNv) values(N'Chuồng 8','15','15',N'NV001')
insert into ChuongTrai(tenChuong,tongSoCho,soChoConTrong,maNv) values(N'Chuồng 9','15','15',N'NV001')
insert into ChuongTrai(tenChuong,tongSoCho,soChoConTrong,maNv) values(N'Chuồng 10','15','15',N'NV001')
insert into ChuongTrai(tenChuong,tongSoCho,soChoConTrong,maNv) values(N'Chuồng 11','15','15',N'NV001')
insert into ChuongTrai(tenChuong,tongSoCho,soChoConTrong,maNv) values(N'Chuồng 12','15','15',N'NV001')
insert into ChuongTrai(tenChuong,tongSoCho,soChoConTrong,maNv) values(N'Chuồng 13','15','15',N'NV001')
insert into ChuongTrai(tenChuong,tongSoCho,soChoConTrong,maNv) values(N'Chuồng 14','15','15',N'NV001')
insert into ChuongTrai(tenChuong,tongSoCho,soChoConTrong,maNv) values(N'Chuồng 15','15','15',N'NV001')
insert into ChuongTrai(tenChuong,tongSoCho,soChoConTrong,maNv) values(N'Chuồng 16','15','15',N'NV001')
insert into ChuongTrai(tenChuong,tongSoCho,soChoConTrong,maNv) values(N'Chuồng 17','15','15',N'NV001')
insert into ChuongTrai(tenChuong,tongSoCho,soChoConTrong,maNv) values(N'Chuồng 18','15','15',N'NV001')
insert into ChuongTrai(tenChuong,tongSoCho,soChoConTrong,maNv) values(N'Chuồng 19','15','15',N'NV001')
insert into ChuongTrai(tenChuong,tongSoCho,soChoConTrong,maNv) values(null,null,null,null)

update ChuongTrai set soChoConTrong='0' where MaChuong='1'

create table categoryBo(
  idCategory int identity(1,1),
  CategoryName nvarchar(100)
  primary key(idCategory)
)
go
create table danBo(
  maBo nvarchar(100),
  GioiTinh nvarchar(100),
  TrongLuong float,
  idCategory int,
  MaChuong int,
  ngayNhapChuong date,
  ngayXuatChuong date
  primary key (maBo),
  foreign key(idcategory) references CategoryBo(idcategory),
  foreign key (MaChuong) references ChuongTrai(MaChuong)ON DELETE CASCADE 
)
insert into DanBo values('DB033',N'Đực','151.5','3','5',GETDATE(),null)

Create table NhaCungCap(
  maNCC int identity(1,1),
  tenNCC nvarchar(100),
  diaChi nvarchar(300),
  soDt nvarchar(100),
  primary key(maNCC)
)
					 
insert into NhaCungCap(tenNCC,diaChi,soDt) values(N'Bò giống Benrifarm',N'01 Lê văn việt Q9 HCM','0129301293')
insert into NhaCungCap(tenNCC,diaChi,soDt) values(N'Trang trại quốc tế',N'97 Nguyễn thị thập Q7 HCM','82731231')
insert into NhaCungCap(tenNCC,diaChi,soDt) values(N'Công ty dược phẩm HCM',N'30 Võ văn ngân thủ đức','09876541')
Create table HDNhapBo(
  maHD int identity(1,1),
  maNCC int,
  maNv nvarchar(100),
  ngayLap dateTime,
  tongTien money,
  trangThai bit,
  linkQr ntext,
  primary key(maHD),
  foreign key(maNv) references NhanVien(maNv)ON DELETE CASCADE ,
  foreign key(maNCC) references NhaCungCap(maNcc)
)
go
alter table HDNhapBo
add linkQr ntext
update HDNhapBo set linkQr='E:\ThucTapChuyenMon\QR\HDNhapBo\6.jpg' where maHD='6'
update HDNhapBo set linkQr='E:\ThucTapChuyenMon\QR\HDNhapBo\8.jpg' where maHD='8'
update HDNhapBo set linkQr='E:\ThucTapChuyenMon\QR\HDNhapBo\9.jpg' where maHD='9'
update HDNhapBo set linkQr='E:\ThucTapChuyenMon\QR\HDNhapBo\10.jpg' where maHD='10'
update HDNhapBo set linkQr='E:\ThucTapChuyenMon\QR\HDNhapBo\12.jpg' where maHD='12'
update HDNhapBo set linkQr='E:\ThucTapChuyenMon\QR\HDNhapBo\14.jpg' where maHD='14'
update HDNhapBo set linkQr='E:\ThucTapChuyenMon\QR\HDNhapBo\15.jpg' where maHD='15'

select * from HDNhapBo where trangThai='False'
select convert(nvarchar(30), ngayLap, 23)as ngayLap,sum(tongTien)as tongTien from HDNhapBo group by convert(nvarchar(30), ngayLap, 23)

Create table CTHDNhapBo(
  maHD int,
  maBo nvarchar(100),
  giaBoNhap money,
  LoaiNhap nvarchar(50),
  primary key(maHD,maBo),
  foreign key(maHD) references HDNhapBo(maHD)ON DELETE CASCADE ,
  foreign key(maBo) references DanBo(maBo) 
)
update ChuongTrai set soChoConTrong=7 where tenChuong=N'Chuồng 7'
 create table ThucAn(
  MaThucAn nvarchar(100),
  TenThucAn nvarchar(100),
  primary key(MaThucAn)
)
go

insert into ThucAn values('01',N'Rơm khô')
insert into ThucAn values('02',N'Cám gạo')
insert into ThucAn values('03',N'Cám hỗn hợp')
insert into ThucAn values('04',N'Ngũ cốc')	
insert into ThucAn values('05',N'Ngọn mía')	

create table KhauPhanAn(
   maKhauPhanAn int identity(1,1),
   IdBo nvarchar(100),
   MaThucAn nvarchar(100),
   SoLuong int,
   ngayAn date,
   primary key(maKhauPhanAn),
   foreign key (IdBo) references DanBo(maBo)ON DELETE CASCADE ,
   foreign key (MaThucAn) references ThucAn(MaThucAn)
)

Create table PhoiGiong(
  maPhoiGiong int identity(1,1),
  maBo nvarchar(100),
  ngayPhoi datetime,
  maNv nvarchar(100)
  primary key(maPhoiGiong),
  foreign key(maBo) references DanBo(maBo) On Delete Cascade
)



create table ThuocVacXin(
   MaThuoc int identity(1,1),
   TenThuoc nvarchar(100),
   DonViTinh nvarchar(20),
   SLCon float,
   primary key(MaThuoc) 
)
go
insert into ThuocVacXin(TenThuoc,DonViTinh,SLCon) values(N'Baytril 0.5% Oral Sol',N'Chai','0')

Create table HoaDonNhapThuoc(
 maHd int identity(1,1),
 maNcc int,
 ngayLap date,
 maNv nvarchar(100),
 tongTien Money,
 primary key(maHd),
 trangThai bit,
 linkQr ntext
 foreign key (maNv) references nhanVien(maNv)ON DELETE CASCADE ,
  foreign key (maNcc) references NhaCungCap(maNcc)ON DELETE CASCADE 
)
go
update HoaDonNhapThuoc set linkQr='C:\Users\Admin\Documents\QuanLyBoSua\QuanLyBoSua\QR\HdNhapThuoc\1.jpg' where mahd='1'


select * from HoaDonNhapThuoc
Create table CTHDNhapThuoc(
  maHd int,
  maThuoc int,
  donViTinh nvarchar(100),
  slNhap float,
  donGiaNhap money,
  primary key(maHd,maThuoc),
  foreign key(maHd) references HoaDonNhapThuoc(maHd),
  foreign key(maThuoc) references ThuocVacXin(maThuoc)On Delete Cascade
)
go
Create table TiemThuoc(
  maTiem int identity(1,1),
  IdBo nvarchar(100),
  MaThuoc int,
  NgayTiem Date,
  lieuLuongTiem nvarchar(100),
  MaNv nvarchar(100),
  primary key(maTiem),
  foreign key (IdBo) references DanBo(maBo)ON DELETE CASCADE ,
  foreign key (MaThuoc) references ThuocVacXIn(MaThuoc)ON DELETE CASCADE ,
  foreign key (MaNv) references NhanVien(MaNv)
)
go


/*create table CongViec(
   MaCv nvarchar (100),
   TenCv nvarchar(100),
   primary key(MaCv)
)
go*/
create table PhanViec(
  MaNv nvarchar(100),
  tenCv nvarchar(100),
  primary key(MaNv,tenCv),
  foreign key(MaNv) references NhanVien(MaNv)ON DELETE CASCADE  
)
go
select * from nhanVien
select * from account
create table khoSua(
 maKho nvarchar(100),
 SoLuongSua float
 primary key(maKho)
)
go
insert into khoSua values('kho1','0')
select * from khoSua
create table ChoSua(
  maChoSua int identity(1,1),
  IDBo nvarchar(100),
  NgayLaySua Datetime,
  SoluongSUa float,
  MaNv nvarchar(100),
  maKho nvarchar(100),
  primary key (maChoSua),
  foreign key (IDBo) references DanBo(maBo)ON DELETE CASCADE ,
  foreign key(MaNv) references nhanVien(MaNv) ,
  foreign key(maKho) references KhoSua(maKho)
)
go

Create table KhachHang(
 maKH int identity(1,1),
 tenKH nvarchar(20),
 eMail ntext,
 soDT ntext
 primary key(maKH)
)

insert into KhachHang(tenKH,eMail,soDt) values(N'Cao Tiến Trinh','trananhvu14785@gmail.com','123123123')
insert into KhachHang(tenKH,eMail,soDt) values(N'Phùng Thanh Độ','trananhvu14785@gmail.com','34343433')
insert into KhachHang(tenKH,eMail,soDt) values(N'Suni Hạ Ling','trananhvu14785@gmail.com','90866123')

Create table HDBanSua(
  maHD int identity(1,1),
  ngayMua datetime,
  maNv nvarchar(100),
  maKH int,
  SlSuaBan float,
  tienSua1lit money,
  thanhTien Money,
  trangThai bit,
  linkQr ntext
  primary key(maHD),
  foreign key(maNv) references NhanVien(maNv)ON DELETE CASCADE ,
  foreign key(maKh) references KhachHang(makh)ON DELETE CASCADE
)
select * from HDBanSua

select convert(nvarchar(30), ngayMua, 23)as ngayLap,sum(thanhTien)as tongTien from HDBanBo where ngayMua between N'2020-05-12' and N'2020-05-26' group by convert(nvarchar(30), ngayMua, 23)
Create table HDBanBo(
	maHD int identity(1,1),
	ngayMua datetime,
	maNv nvarchar(100),
	maKH int,
	thanhTien money,
	primary key(maHD),
	trangThai bit,
	linkQr ntext
	foreign key(maNv) references NhanVien(maNv)ON DELETE CASCADE ,
	foreign key(maKh) references KhachHang(makh)ON DELETE CASCADE
)
select * from HDBanBo


Create table CTHDBanBo(
   maHd int ,
   maBo nvarchar(100),
   giaBan money
   primary key(maHd,maBo),
   foreign key(maHd) references HDBanBo(maHd),
   foreign key(maBo) references DanBo(maBo)
)
Select (sum(HB.tongTien)+SUM(HT.tongTien))as N'Vốn',(SUM(HD.thanhTien)+SUM(HS.thanhTien))as N'DoanhThu',
((SUM(HD.thanhTien)+SUM(HS.thanhTien))-(sum(HB.tongTien)+SUM(HT.tongTien))) as N'Lợi Nhuận'
from HDNhapBo HB,HoaDonNhapThuoc HT,HDBanBo HD,HDBanSua HS
select sum(thanhtien) from HDBanSua
select sum(thanhtien) from HDBanBo
select * from HDBan
create proc loinhuan


Create proc pr_HdBanBo
as begin
 select H.maHd,K.tenKH,H.ngayMua,H.maNV,H.thanhTien from HDBanBo H,KhachHang K where H.maKH=K.maKh
end
Create proc pr_HDnhapThuoc
as begin
 Select H.maHd,N.tenNCC,H.maNv,H.ngayLap,H.tongTien from HoaDonNhapThuoc H,NhaCungCap N where H.maNcc=N.maNCC
end

create proc pr_HDNhapBo
as begin
 Select H.maHD,N.tenNCC,H.maNv,H.ngayLap,H.tongTien from HDNhapBo H,NhaCungCap N where H.maNCC=N.maNCC
end

-----------Nhap Dua Lieu--------.
Create trigger tg_CTHDBanBo_in on CTHDBanBo for insert
as begin
 Declare @maBo nvarchar(100),@maHd int,@giaBan money,@maChuong int
 Select @maBo=maBo,@mahd=maHd,@giaBan=giaBan from inserted
 Select @maChuong=maChuong from DanBo where maBo=@maBo
 update ChuongTrai set soChoConTrong=soChoConTrong+1 where MaChuong=@maChuong
 update HDBanBo set thanhTien=thanhTien+@giaBan where maHD=@maHd
 update DanBo set ngayXuatChuong=getdate() where maBo=@maBo
end


Create trigger tg_CTHDBanBo_up on CTHDBanBo for update
as begin
Declare @maBoMoi nvarchar(100),@maBoCu nvarchar(100),@giaBanMoi money,@giaBanCu money,
@maHd int,@maChuongMoi int,@maChuongCu int
 select @maBoCu=maBo,@giaBanCu=giaBan from deleted
select @maBoMoi=maBo,@giaBanMoi=giaBan ,@maHd=maHd from inserted
  select  @maChuongCu=machuong from DanBo where maBo=@maBoCu
 select @maChuongMoi=machuong from DanBo where maBo=@maBoMoi
 update HDBanBo set thanhTien=thanhTien+@giaBanMoi-@giaBanCu where maHD=@maHd
 if(@maBoCu !=@maBoMoi)begin
   update DanBo set ngayXuatChuong = null where maBo=@maBoCu
   update DanBo set ngayXuatChuong=getdate() where maBo=@maBoMoi
   if(@maChuongCu!=@maChuongMoi) begin
     update ChuongTrai set soChoConTrong=soChoConTrong-1 where MaChuong=@maChuongCu
	 update ChuongTrai set soChoConTrong=soChoConTrong+1 where MaChuong=@maChuongMoi
   end
 end
end
select * from KhachHang
Create trigger tg_CTHDBanBo on CTHDBanBo for delete
as begin
 Declare @maHd int,@maBo nvarchar(100),@giaBan money,@maChuong int
 select @maHd=maHd,@maBo=maBo,@giaBan=giaBan from deleted
 select @maChuong=maChuong from DanBo where maBo=@maBo
 update HDBanBo set thanhTien=thanhTien-@giaBan where maHD=@maHd
 update DanBo set ngayXuatChuong=null where maBo=@maBo
 update ChuongTrai set soChoConTrong=soChoConTrong-1 where MaChuong=@maChuong

end




Create trigger tg_HDbanSua_in on HDBanSua for insert
as begin
 Declare @maHd int,@slSua float,@giaBan money
 select @mahd=mahd,@slSua=slSuaBan,@giaBan=tiensua1lit from inserted
 
 update khoSua set SoLuongSua=SoLuongSua-@slSua
end

Create trigger tg_HDBanSUa_up on HDBanSua for update
as begin
 Declare @maHd int,@slSuaCu float,@slSuaMoi float,@giaBanCu money,@giaBanMoi money
 select @slSuaCu=slSuaban,@giaBanCu=tiensua1lit from deleted
 select @maHd=maHd,@slSuaMoi=slSuaBan,@giaBanMoi=tiensua1lit from inserted

 update khoSua set SoLuongSua=SoLuongSua-@slSuaMoi+@slSuaCu
 end
end
drop trigger tg_HDBanSUa_up
select * from HDBanSua

Create trigger tg_HDBanSua_dele on HDBanSua for delete
as begin
  Declare @slSuaBan float
  select @slSuaBan=slSuaBan from deleted
 
  update khoSua set SoLuongSua=SoLuongSua+@slSuaBan

end
drop trigger tg_HDBanSua_dele
update khoSua set SoLuongSua= 70
delete HDBanSua where maHD=2
select * from HDBanSua
select * from khoSua

insert into account values (N'nhom6','123','Admin',null)
select * from account where loaiTk=N'Admin'



insert into ThucAn values(N'TA01',N'Cỏ Tự Nhiên')
insert into ThucAn values(N'TA02',N'Ngọn Mía')
insert into khoSua values(N'KHo001','0')

select * from khoSua
select * from KhauPhanAn
select maKhauPhanAn,IdBo,tenThucAn,SoLuong,ngayAn from KhauPhanAn K, ThucAn T where T.mathucAn=K.maThucAn
insert into NhanVien values (N'NV001',N'Bùi Tiến Dũng',N'Nam',N'1994-08-25',N'2012-12-12')
insert into NhanVien values (N'NV002',N'Nguyễn Văn Toàn',N'Nam',N'1990-03-18',N'2012-12-12')
insert into NhanVien values (N'NV003',N'Nguyễn Đình Hoàng',N'Nam',N'1999-12-17',N'2012-12-12')
insert into NhanVien values (N'NV004',N'Bùi Vân Anh',N'Nam',N'1994-02-27',N'2012-12-12')
insert into NhanVien values (N'NV005',N'Hoàng Văn Chương',N'Nam',N'1990-11-18',N'2012-12-12')
select * from khosua
Create trigger tg_ChoSua_in on ChoSua for insert
as begin
  Declare @soLuongLay float
  Select @soLuongLay=soLuongSua from inserted
  update khoSua set soLuongSua=soLuongSua+@soLuongLay
end
Create trigger tg_chosua_up on chosua for Update
as begin
 Declare @slcu float,@slMoi float
 select @slcu=soluongSua from deleted
 select @slMoi=soluongSua from inserted
 update khoSua set SoLuongSua=SoLuongSua+@slMoi-@slcu
end

Create trigger tg_chosua_dele on Chosua for delete
as begin
 Declare @sl float
 select @sl=soLuongSua from deleted
 update khoSua set SoLuongSua=SoLuongSua-@sl
end

Create trigger tg_CTHDNHAPBO_update on CTHDNhapBo for update
as begin
 Declare @maHd int,@giaNhapCu money,@giaNhapMoi money
 Select @mahd=maHd,@giaNhapMoi=giaBonhap from inserted
 Select @giaNhapCu=giaBoNhap from deleted
 Update HDNhapBo set tongTien=tongTien+@giaNhapMoi-@giaNhapCu where maHD=@maHd
end

Create trigger tg_CthdNhapBo_dele on CTHDNhapBo for delete
as begin
 Declare @maHd int,@giaBoNhap money
 select @mahd=maHd,@giaBoNhap=giaBonhap from deleted
 update HDNhapBo set tongTien=tongTien-@giaBoNhap where maHD=@maHd
end

Create trigger tg_DanBo on DanBo for insert 
as begin
 Declare @maChuong nvarchar(100), @soChoTrong int
 select @maChuong=machuong from inserted
 select @soChoTrong=sochocontrong from ChuongTrai where MaChuong=@maChuong
 if @soChoTrong =0 begin
  print N'Chuồng đã đầy!'
  rollback
 end
 else begin
   update ChuongTrai set soChoConTrong=soChoConTrong-1 where MaChuong=@maChuong
 end
end
Create trigger tg_DanBo_up on DanBo for update
as begin
 declare @ngayXuatChuong date, @maChuongCu nvarchar(100), @maChuongMoi nvarchar(100)
 select  @maChuongMoi=MaChuong from inserted
 select @maChuongCu=machuong from deleted
 print @maChuongMoi
 print @maChuongCu
 if @maChuongCu<>@maChuongMoi and @maChuongMoi is not null begin
  update ChuongTrai set soChoConTrong=soChoConTrong+1 where MaChuong=@maChuongCu
  update ChuongTrai set soChoConTrong=soChoConTrong-1 where MaChuong=@maChuongMoi
 end 
 if @maChuongCu is null and @maChuongMoi is not null begin
   update ChuongTrai set soChoConTrong=soChoConTrong-1 where MaChuong=@maChuongMoi
 end
end
update ChuongTrai set soChoConTrong=5 where tenChuong=N'Chuồng 4'
Create trigger tg_DanBo_dele on DanBo for delete
as begin
 Declare @maChuong int
 Select @maChuong=maChuong from deleted
 update chuongTrai set soChoConTrong=soChoConTrong+1 where maChuong=@maChuong
end
delete DanBo where maBo='DB021'

Create trigger tg_danBo_update on DanBo for Update
as begin 
  Declare @maChuong int,@machuongCu int
  select @machuongCu=MaChuong from deleted
  Select @maChuong=maCHuong from inserted
  if @maChuong is null begin
     Update ChuongTrai set soChoConTrong=soChoConTrong+1 where MaChuong=@machuongCu
	 print N'đã sửa'
	 end
end

select * from DanBo
Create trigger tg_chuongTrai on ChuongTrai for update
as begin
 declare @soChoMoi int,@maChuong nvarchar(100),@soChoCu int
 select @soChoCu=tongsocho from deleted
 select @soChoMoi=tongSoCho,@maChuong=MaChuong from inserted
 update ChuongTrai set soChoConTrong=soChoConTrong+@soChoMoi-@soChoCu where MaChuong=@maChuong
end



Create trigger tg_hdbanSua on HDBanSua for insert
as begin
 Declare @slmua float
 select @slmua=SlSuaBan from inserted
 update KhoSua Set SoluongSua=SoluongSua-@slmua 
end


insert into categoryBo(CategoryName) values (N'Bê 1 ngày-1 tháng tuổi')
insert into categoryBo(CategoryName) values (N'Bê 1 tháng-4 tháng tuổi')

insert into categoryBo(CategoryName) values (N'Bò đang mang thai')
insert into categoryBo(CategoryName) values (N'Bò đực 4-8 tháng ')
insert into categoryBo(CategoryName)values (N'Bò đực trên 8 tháng')
insert into categoryBo(CategoryName)values (N'Bò đang cho sữa')
insert into categoryBo(CategoryName)values (N'Bò cái 4-8 tháng')
insert into categoryBo(CategoryName) values (N'Bò cái tren 8 tháng')

create trigger tg_tiemPhong on TiemThuoc for update
as begin
declare @lieuLuongCu float,@mathuoc int,@lieuLuongMoi float
select @lieuLuongCu=lieuLuongTiem from deleted
select @mathuoc=mathuoc,@lieuLuongMoi=lieuLuongTiem from inserted
update ThuocVacXin set SLCon=SLCon-@lieuLuongMoi+@lieuLuongCu where mathuoc=@maThuoc
end



----- Query ---------
Create trigger tg_CTHDNB on CTHDNhapBo for insert
as begin
 declare @maHd nvarchar(100), @giaNhap money
 select @maHd=maHd, @giaNhap=giabonhap from inserted
 update HDNhapBo set tongTien=tongTien+@giaNhap where maHd=@maHd
end
----


Create trigger tg_CTHDNhapThuoc_in on CTHDNhapThuoc for insert
as begin
 declare @mahd nvarchar(100), @slNhap float, @maThuoc int,@donGiaNhap money
 select @mahd=mahd,@slNhap=slNhap, @maThuoc=mathuoc, @donGiaNhap=donGiaNhap from inserted
  update HoaDonNhapThuoc set tongTien=tongTien+@donGiaNhap*@slNhap where maHd=@mahd
  update thuocVacXin set SLcon=SlCon+@slNhap where maThuoc=@maThuoc	
end

Create trigger tg_CTHDNhapThuoc_up on CTHDNhapThuoc for Update
as begin
declare @mahd nvarchar(100), @slNhap float, @maThuoc int,@donGiaNhap money,
@slNhapMoi int,@donGiaNhapMoi money,@maThuocMoi int
 Select @mahd=maHd,@slNhap=slNhap,@maThuoc=maThuoc,@donGiaNhap=dongiaNhap from deleted
 Select @slNhapMoi=slNhap,@donGiaNhapMoi=donGiaNhap,@maThuocMoi=maThuoc from inserted
 update HoaDonNhapThuoc set tongTien=tongTien+(@slNhapMoi*@donGiaNhapMoi)-(@slNhap*@donGiaNhap) where maHd=@mahd
 if(@maThuoc <> @maThuocMoi)begin
   update ThuocVacXin set SLCon=SLCon-@slNhap where MaThuoc=@maThuoc
   update ThuocVacXin set SLCon=SLCon+@slNhapMoi where MaThuoc=@maThuocMoi
 end
 else if(@maThuoc=@maThuocMoi) begin 
   update ThuocVacXin set SLCon=SLCon+@slNhapMoi-@slNhap where MaThuoc=@maThuoc
 end
end

Create trigger tg_CTHDNhapThuoc_dele on CTHDNhapThuoc for delete
as begin
Declare @maHd int,@mathuoc int,@slNhap int,@donGiaNhap money
Select @mahd=maHd,@mathuoc=maThuoc,@slNhap=slNhap,@donGiaNhap=donGiaNhap from deleted
update HoaDonNhapThuoc set tongTien=tongTien-(@slNhap*@donGiaNhap) where maHd=@maHd
update ThuocVacXin set SLCon=SLCon-@slNhap where MaThuoc=@mathuoc
end

create proc getHdBanSua
as begin
 select H.maHD,H.maNv,H.ngayMua,K.tenKH,H.SlSuaBan,H.tienSua1lit,H.thanhTien
 from HDBanSua H,KhachHang K
 where H.maKH=K.maKH and H.ngayMua between N'2020-04-30' and N'2020-05-25'
end

Create proc LayNgay
as begin
 select getdate()as tuNgay,getdate() as denNgay
end
create proc getTien
as begin 
select sum(thanhTien) as thanhTien from HDBanSua
end










