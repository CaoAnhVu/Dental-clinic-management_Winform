using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PKNK.DAL.Models
{
    public partial class PKNK_ContextDB : DbContext
    {
        public PKNK_ContextDB()
            : base("name=PKNK_ContextDB")
        {
        }

        public virtual DbSet<Auth> Auths { get; set; }
        public virtual DbSet<BacSi> BacSis { get; set; }
        public virtual DbSet<ChiPhiVatLieu> ChiPhiVatLieux { get; set; }
        public virtual DbSet<DichVu> DichVus { get; set; }
        public virtual DbSet<DoanhThuBanHang> DoanhThuBanHangs { get; set; }
        public virtual DbSet<DonThuoc> DonThuocs { get; set; }
        public virtual DbSet<DonXuatHang> DonXuatHangs { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<Luong> Luongs { get; set; }
        public virtual DbSet<ThongKeNam> ThongKeNams { get; set; }
        public virtual DbSet<ThongKeThang> ThongKeThangs { get; set; }
        public virtual DbSet<Thuoc> Thuocs { get; set; }
        public virtual DbSet<TTCanLamSang> TTCanLamSangs { get; set; }
        public virtual DbSet<TTLamSang> TTLamSangs { get; set; }
        public virtual DbSet<DonNhapHang> DonNhapHangs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BacSi>()
                .Property(e => e.MaBS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BacSi>()
                .HasMany(e => e.TTCanLamSangs)
                .WithRequired(e => e.BacSi)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BacSi>()
                .HasMany(e => e.TTLamSangs)
                .WithRequired(e => e.BacSi)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ChiPhiVatLieu>()
                .Property(e => e.Thang)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ChiPhiVatLieu>()
                .Property(e => e.MaDonXuat)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ChiPhiVatLieu>()
                .Property(e => e.ChiPhi)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ChiPhiVatLieu>()
                .HasOptional(e => e.ThongKeThang)
                .WithRequired(e => e.ChiPhiVatLieu);

            modelBuilder.Entity<DichVu>()
                .Property(e => e.MaDV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DichVu>()
                .Property(e => e.DonGia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DichVu>()
                .HasMany(e => e.HoaDons)
                .WithRequired(e => e.DichVu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DoanhThuBanHang>()
                .Property(e => e.Thang)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DoanhThuBanHang>()
                .Property(e => e.MaHD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DoanhThuBanHang>()
                .Property(e => e.TongDoanhThu)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DoanhThuBanHang>()
                .HasOptional(e => e.ThongKeThang)
                .WithRequired(e => e.DoanhThuBanHang1);

            modelBuilder.Entity<DonThuoc>()
                .Property(e => e.MaDonThuoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DonThuoc>()
                .Property(e => e.MaThuoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DonThuoc>()
                .Property(e => e.ThanhTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DonThuoc>()
                .HasMany(e => e.HoaDons)
                .WithRequired(e => e.DonThuoc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DonXuatHang>()
                .Property(e => e.MaDonXuat)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DonXuatHang>()
                .Property(e => e.MaDonNhap)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DonXuatHang>()
                .Property(e => e.DonGia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DonXuatHang>()
                .Property(e => e.ThanhTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DonXuatHang>()
                .HasMany(e => e.ChiPhiVatLieux)
                .WithRequired(e => e.DonXuatHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DonXuatHang>()
                .HasMany(e => e.DonNhapHangs)
                .WithRequired(e => e.DonXuatHang)
                .HasForeignKey(e => e.MaDonNhap)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaHD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaDV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaDonThuoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.TongTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HoaDon>()
                .HasMany(e => e.DoanhThuBanHangs)
                .WithRequired(e => e.HoaDon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.DonThuocs)
                .WithRequired(e => e.KhachHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.HoaDons)
                .WithRequired(e => e.KhachHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.TTCanLamSangs)
                .WithRequired(e => e.KhachHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.TTLamSangs)
                .WithRequired(e => e.KhachHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Luong>()
                .Property(e => e.Thang)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Luong>()
                .Property(e => e.LuongBS1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Luong>()
                .Property(e => e.LuongBS2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Luong>()
                .Property(e => e.TruTienBS1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Luong>()
                .Property(e => e.TruTienBS2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Luong>()
                .Property(e => e.LuongThucNhanBS1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Luong>()
                .Property(e => e.LuongThucNhanBS2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Luong>()
                .HasOptional(e => e.ThongKeThang)
                .WithRequired(e => e.Luong);

            modelBuilder.Entity<ThongKeNam>()
                .Property(e => e.Nam)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ThongKeNam>()
                .Property(e => e.Thang)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ThongKeNam>()
                .Property(e => e.DoanhThu)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ThongKeThang>()
                .Property(e => e.Thang)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ThongKeThang>()
                .Property(e => e.DoanhThu)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ThongKeThang>()
                .Property(e => e.LuongNV)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ThongKeThang>()
                .Property(e => e.DoanhThuBanHang)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ThongKeThang>()
                .Property(e => e.ChiPhi)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ThongKeThang>()
                .HasMany(e => e.ThongKeNams)
                .WithRequired(e => e.ThongKeThang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Thuoc>()
                .Property(e => e.MaThuoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Thuoc>()
                .Property(e => e.DonGia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Thuoc>()
                .HasMany(e => e.DonThuocs)
                .WithRequired(e => e.Thuoc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TTCanLamSang>()
                .Property(e => e.MaTTCanLamSang)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TTCanLamSang>()
                .Property(e => e.MaBS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TTCanLamSang>()
                .HasMany(e => e.TTLamSangs)
                .WithRequired(e => e.TTCanLamSang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TTLamSang>()
                .Property(e => e.MaTTLamSang)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TTLamSang>()
                .Property(e => e.MaBS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TTLamSang>()
                .Property(e => e.MaTTCanLamSang)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DonNhapHang>()
                .Property(e => e.MaDonNhap)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
