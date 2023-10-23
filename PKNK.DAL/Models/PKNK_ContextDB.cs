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
        public virtual DbSet<BaoHiem> BaoHiems { get; set; }
        public virtual DbSet<BenhNhan> BenhNhans { get; set; }
        public virtual DbSet<ChanDoan> ChanDoans { get; set; }
        public virtual DbSet<ChucDanh> ChucDanhs { get; set; }
        public virtual DbSet<DoanhThu> DoanhThus { get; set; }
        public virtual DbSet<DonXuatNhap> DonXuatNhaps { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<LoaiThuThuat> LoaiThuThuats { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<ThongTinL> ThongTinLS { get; set; }
        public virtual DbSet<Thuoc> Thuocs { get; set; }
        public virtual DbSet<ThuThuat> ThuThuats { get; set; }
        public virtual DbSet<TrangThai> TrangThais { get; set; }
        public virtual DbSet<TTCanLamSan> TTCanLamSans { get; set; }
        public virtual DbSet<DonThuoc> DonThuocs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BaoHiem>()
                .Property(e => e.MaBaoHiem)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BenhNhan>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<BenhNhan>()
                .Property(e => e.MaNV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BenhNhan>()
                .Property(e => e.TongTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BenhNhan>()
                .Property(e => e.DaThanhToan)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BenhNhan>()
                .Property(e => e.MaTrangThai)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BenhNhan>()
                .Property(e => e.MaBaoHiem)
                .IsUnicode(false);

            modelBuilder.Entity<BenhNhan>()
                .HasMany(e => e.BaoHiems)
                .WithRequired(e => e.BenhNhan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BenhNhan>()
                .HasMany(e => e.ChanDoans)
                .WithRequired(e => e.BenhNhan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ChanDoan>()
                .HasMany(e => e.DonThuocs)
                .WithRequired(e => e.ChanDoan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ChanDoan>()
                .HasMany(e => e.HoaDons)
                .WithRequired(e => e.ChanDoan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ChucDanh>()
                .Property(e => e.MaChucDanh)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ChucDanh>()
                .HasMany(e => e.NhanViens)
                .WithRequired(e => e.ChucDanh)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DoanhThu>()
                .Property(e => e.MaDoanhThu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DonXuatNhap>()
                .Property(e => e.DonGia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DonXuatNhap>()
                .Property(e => e.ThanhTien)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DonXuatNhap>()
                .Property(e => e.MaNhanVien)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.ThanhTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<LoaiThuThuat>()
                .Property(e => e.MaLoaiThuThuat)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LoaiThuThuat>()
                .HasMany(e => e.ThongTinLS)
                .WithRequired(e => e.LoaiThuThuat)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LoaiThuThuat>()
                .HasMany(e => e.ThuThuats)
                .WithRequired(e => e.LoaiThuThuat)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaNhanVien)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaChucDanh)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.SoDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.BenhNhans)
                .WithOptional(e => e.NhanVien)
                .HasForeignKey(e => e.MaNV);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.DonXuatNhaps)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.TTCanLamSans)
                .WithOptional(e => e.NhanVien)
                .HasForeignKey(e => e.MaNV);

            modelBuilder.Entity<ThongTinL>()
                .Property(e => e.ThanhTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ThongTinL>()
                .Property(e => e.MaNV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinL>()
                .Property(e => e.MaThuThuat)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinL>()
                .Property(e => e.MaLoaiThuThuat)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Thuoc>()
                .Property(e => e.MaThuoc)
                .IsUnicode(false);

            modelBuilder.Entity<Thuoc>()
                .Property(e => e.DonGia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Thuoc>()
                .HasMany(e => e.DonThuocs)
                .WithRequired(e => e.Thuoc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ThuThuat>()
                .Property(e => e.MaThuThuat)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ThuThuat>()
                .Property(e => e.MaLoaiThuThuat)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ThuThuat>()
                .Property(e => e.DonGia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TrangThai>()
                .Property(e => e.MaTrangThai)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TTCanLamSan>()
                .Property(e => e.MaPhieuKham)
                .IsFixedLength();

            modelBuilder.Entity<TTCanLamSan>()
                .Property(e => e.MaNV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DonThuoc>()
                .Property(e => e.MaThuoc)
                .IsUnicode(false);

            modelBuilder.Entity<DonThuoc>()
                .Property(e => e.ThanhTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DonThuoc>()
                .Property(e => e.DonGia)
                .HasPrecision(19, 4);
        }
    }
}
