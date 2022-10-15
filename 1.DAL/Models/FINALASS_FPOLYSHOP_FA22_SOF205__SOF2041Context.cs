using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace _1.DAL.Models
{
    public partial class FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context : DbContext
    {
        public FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context()
        {
        }

        public FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context(DbContextOptions<FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context> options)
            : base(options)
        {
        }

        public virtual DbSet<ChiTietSp> ChiTietSps { get; set; } = null!;
        public virtual DbSet<ChucVu> ChucVus { get; set; } = null!;
        public virtual DbSet<CuaHang> CuaHangs { get; set; } = null!;
        public virtual DbSet<DongSp> DongSps { get; set; } = null!;
        public virtual DbSet<GioHang> GioHangs { get; set; } = null!;
        public virtual DbSet<GioHangChiTiet> GioHangChiTiets { get; set; } = null!;
        public virtual DbSet<HoaDon> HoaDons { get; set; } = null!;
        public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; } = null!;
        public virtual DbSet<KhachHang> KhachHangs { get; set; } = null!;
        public virtual DbSet<MauSac> MauSacs { get; set; } = null!;
        public virtual DbSet<NhanVien> NhanViens { get; set; } = null!;
        public virtual DbSet<Nsx> Nsxes { get; set; } = null!;
        public virtual DbSet<SanPham> SanPhams { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=TI-PC\\THANGNM;Initial Catalog=FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041;Persist Security Info=True;User ID=thangnm;Password=123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietSp>(entity =>
            {
                entity.ToTable("ChiTietSP");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.GiaBan)
                    .HasColumnType("decimal(20, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GiaNhap)
                    .HasColumnType("decimal(20, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdDongSp).HasColumnName("IdDongSP");

                entity.Property(e => e.IdSp).HasColumnName("IdSP");

                entity.Property(e => e.MoTa).HasMaxLength(50);

                entity.Property(e => e.NamBh).HasColumnName("NamBH");

                entity.HasOne(d => d.IdDongSpNavigation)
                    .WithMany(p => p.ChiTietSps)
                    .HasForeignKey(d => d.IdDongSp)
                    .HasConstraintName("FK__ChiTietSP__IdDon__04E4BC85");

                entity.HasOne(d => d.IdMauSacNavigation)
                    .WithMany(p => p.ChiTietSps)
                    .HasForeignKey(d => d.IdMauSac)
                    .HasConstraintName("FK__ChiTietSP__IdMau__03F0984C");

                entity.HasOne(d => d.IdNsxNavigation)
                    .WithMany(p => p.ChiTietSps)
                    .HasForeignKey(d => d.IdNsx)
                    .HasConstraintName("FK__ChiTietSP__IdNsx__02FC7413");

                entity.HasOne(d => d.IdSpNavigation)
                    .WithMany(p => p.ChiTietSps)
                    .HasForeignKey(d => d.IdSp)
                    .HasConstraintName("FK__ChiTietSP__IdSP__02084FDA");
            });

            modelBuilder.Entity<ChucVu>(entity =>
            {
                entity.ToTable("ChucVu");

                entity.HasIndex(e => e.Ma, "UQ__ChucVu__3214CC9ED6CD9430")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ten).HasMaxLength(50);
            });

            modelBuilder.Entity<CuaHang>(entity =>
            {
                entity.ToTable("CuaHang");

                entity.HasIndex(e => e.Ma, "UQ__CuaHang__3214CC9E448AC23A")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DiaChi).HasMaxLength(100);

                entity.Property(e => e.Ma)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QuocGia).HasMaxLength(50);

                entity.Property(e => e.Ten).HasMaxLength(50);

                entity.Property(e => e.ThanhPho).HasMaxLength(50);
            });

            modelBuilder.Entity<DongSp>(entity =>
            {
                entity.ToTable("DongSP");

                entity.HasIndex(e => e.Ma, "UQ__DongSP__3214CC9EB348D00B")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ten).HasMaxLength(30);
            });

            modelBuilder.Entity<GioHang>(entity =>
            {
                entity.ToTable("GioHang");

                entity.HasIndex(e => e.Ma, "UQ__GioHang__3214CC9E49D7A31B")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DiaChi).HasMaxLength(100);

                entity.Property(e => e.IdKh).HasColumnName("IdKH");

                entity.Property(e => e.IdNv).HasColumnName("IdNV");

                entity.Property(e => e.Ma)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NgayTao).HasColumnType("date");

                entity.Property(e => e.NgayThanhToan).HasColumnType("date");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TenNguoiNhan).HasMaxLength(50);

                entity.Property(e => e.TinhTrang).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdKhNavigation)
                    .WithMany(p => p.GioHangs)
                    .HasForeignKey(d => d.IdKh)
                    .HasConstraintName("FK__GioHang__IdKH__00200768");
            });

            modelBuilder.Entity<GioHangChiTiet>(entity =>
            {
                entity.HasKey(e => new { e.IdGioHang, e.IdChiTietSp })
                    .HasName("PK_GioHangCT");

                entity.ToTable("GioHangChiTiet");

                entity.Property(e => e.IdChiTietSp).HasColumnName("IdChiTietSP");

                entity.Property(e => e.DonGia)
                    .HasColumnType("decimal(20, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DonGiaKhiGiam)
                    .HasColumnType("decimal(20, 0)")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdChiTietSpNavigation)
                    .WithMany(p => p.GioHangChiTiets)
                    .HasForeignKey(d => d.IdChiTietSp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK2_IdChiTietSP");

                entity.HasOne(d => d.IdGioHangNavigation)
                    .WithMany(p => p.GioHangChiTiets)
                    .HasForeignKey(d => d.IdGioHang)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK1_IdGioHang");
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.ToTable("HoaDon");

                entity.HasIndex(e => e.Ma, "UQ__HoaDon__3214CC9E475053AC")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DiaChi).HasMaxLength(100);

                entity.Property(e => e.IdKh).HasColumnName("IdKH");

                entity.Property(e => e.IdNv).HasColumnName("IdNV");

                entity.Property(e => e.Ma)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NgayNhan).HasColumnType("date");

                entity.Property(e => e.NgayShip).HasColumnType("date");

                entity.Property(e => e.NgayTao).HasColumnType("date");

                entity.Property(e => e.NgayThanhToan).HasColumnType("date");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TenNguoiNhan).HasMaxLength(50);

                entity.Property(e => e.TinhTrang).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdKhNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.IdKh)
                    .HasConstraintName("FK__HoaDon__IdKH__7F2BE32F");

                entity.HasOne(d => d.IdNvNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.IdNv)
                    .HasConstraintName("FK__HoaDon__IdNV__01142BA1");
            });

            modelBuilder.Entity<HoaDonChiTiet>(entity =>
            {
                entity.HasKey(e => new { e.IdHoaDon, e.IdChiTietSp })
                    .HasName("PK_HoaDonCT");

                entity.ToTable("HoaDonChiTiet");

                entity.Property(e => e.IdChiTietSp).HasColumnName("IdChiTietSP");

                entity.Property(e => e.DonGia)
                    .HasColumnType("decimal(20, 0)")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdChiTietSpNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.IdChiTietSp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK2");

                entity.HasOne(d => d.IdHoaDonNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.IdHoaDon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK1");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.ToTable("KhachHang");

                entity.HasIndex(e => e.Ma, "UQ__KhachHan__3214CC9E2373EB61")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DiaChi).HasMaxLength(100);

                entity.Property(e => e.Ho).HasMaxLength(30);

                entity.Property(e => e.Ma)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MatKhau).IsUnicode(false);

                entity.Property(e => e.NgaySinh).HasColumnType("date");

                entity.Property(e => e.QuocGia).HasMaxLength(50);

                entity.Property(e => e.Sdt)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ten).HasMaxLength(30);

                entity.Property(e => e.TenDem).HasMaxLength(30);

                entity.Property(e => e.ThanhPho).HasMaxLength(50);
            });

            modelBuilder.Entity<MauSac>(entity =>
            {
                entity.ToTable("MauSac");

                entity.HasIndex(e => e.Ma, "UQ__MauSac__3214CC9EFC59134A")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ten).HasMaxLength(30);
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.ToTable("NhanVien");

                entity.HasIndex(e => e.Ma, "UQ__NhanVien__3214CC9EE5602783")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DiaChi).HasMaxLength(100);

                entity.Property(e => e.GioiTinh).HasMaxLength(10);

                entity.Property(e => e.Ho).HasMaxLength(30);

                entity.Property(e => e.IdCh).HasColumnName("IdCH");

                entity.Property(e => e.IdCv).HasColumnName("IdCV");

                entity.Property(e => e.IdGuiBc).HasColumnName("IdGuiBC");

                entity.Property(e => e.Ma)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MatKhau).IsUnicode(false);

                entity.Property(e => e.NgaySinh).HasColumnType("date");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ten).HasMaxLength(30);

                entity.Property(e => e.TenDem).HasMaxLength(30);

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdChNavigation)
                    .WithMany(p => p.NhanViens)
                    .HasForeignKey(d => d.IdCh)
                    .HasConstraintName("FK__NhanVien__IdCH__7C4F7684");

                entity.HasOne(d => d.IdCvNavigation)
                    .WithMany(p => p.NhanViens)
                    .HasForeignKey(d => d.IdCv)
                    .HasConstraintName("FK__NhanVien__IdCV__7D439ABD");

                entity.HasOne(d => d.IdGuiBcNavigation)
                    .WithMany(p => p.InverseIdGuiBcNavigation)
                    .HasForeignKey(d => d.IdGuiBc)
                    .HasConstraintName("FK__NhanVien__IdGuiB__7E37BEF6");
            });

            modelBuilder.Entity<Nsx>(entity =>
            {
                entity.ToTable("NSX");

                entity.HasIndex(e => e.Ma, "UQ__NSX__3214CC9E57567959")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ten).HasMaxLength(30);
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.ToTable("SanPham");

                entity.HasIndex(e => e.Ma, "UQ__SanPham__3214CC9E3793B01E")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ten).HasMaxLength(30);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
