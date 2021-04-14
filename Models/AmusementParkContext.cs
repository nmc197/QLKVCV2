using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace QuanLyKVC.Models
{
    public partial class AmusementParkContext : DbContext
    {
        public AmusementParkContext()
        {
        }

        public AmusementParkContext(DbContextOptions<AmusementParkContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Chitiethoadon> Chitiethoadons { get; set; }
        public virtual DbSet<Dichvu> Dichvus { get; set; }
        public virtual DbSet<Hoadon> Hoadons { get; set; }
        public virtual DbSet<Khachhang> Khachhangs { get; set; }
        public virtual DbSet<Khutrochoi> Khutrochois { get; set; }
        public virtual DbSet<Nguoidung> Nguoidungs { get; set; }
        public virtual DbSet<Nhanvien> Nhanviens { get; set; }
        public virtual DbSet<Phongban> Phongbans { get; set; }
        public virtual DbSet<Quyen> Quyens { get; set; }
        public virtual DbSet<Thietbi> Thietbis { get; set; }
        public virtual DbSet<Trochoi> Trochois { get; set; }
        public virtual DbSet<Ve> Ves { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-MS29M6R;Database=AmusementPark;UID=sa;PWD=123456;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Chitiethoadon>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CHITIETHOADON");

                entity.Property(e => e.MaDv)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("MaDV")
                    .IsFixedLength(true);

                entity.Property(e => e.MaHd)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("MaHD")
                    .IsFixedLength(true);

                entity.Property(e => e.SoLanSuDungDv).HasColumnName("SoLanSuDungDV");

                entity.HasOne(d => d.MaHdNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.MaHd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CHITIETHOADON_HOADON");
            });

            modelBuilder.Entity<Dichvu>(entity =>
            {
                entity.HasKey(e => e.MaDv);

                entity.ToTable("DICHVU");

                entity.Property(e => e.MaDv)
                    .HasMaxLength(10)
                    .HasColumnName("MaDV")
                    .IsFixedLength(true);

                entity.Property(e => e.MaKhu)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.TenDv)
                    .HasMaxLength(50)
                    .HasColumnName("TenDV");
            });

            modelBuilder.Entity<Hoadon>(entity =>
            {
                entity.HasKey(e => e.MaHd);

                entity.ToTable("HOADON");

                entity.Property(e => e.MaHd)
                    .HasMaxLength(10)
                    .HasColumnName("MaHD")
                    .IsFixedLength(true);

                entity.Property(e => e.NgayHd)
                    .HasColumnType("date")
                    .HasColumnName("NgayHD");
            });

            modelBuilder.Entity<Khachhang>(entity =>
            {
                entity.HasKey(e => e.MaKh);

                entity.ToTable("KHACHHANG");

                entity.Property(e => e.MaKh)
                    .HasMaxLength(10)
                    .HasColumnName("MaKH")
                    .IsFixedLength(true);

                entity.Property(e => e.GioTinhKh)
                    .HasMaxLength(50)
                    .HasColumnName("GioTinhKH");

                entity.Property(e => e.TenKh)
                    .HasMaxLength(50)
                    .HasColumnName("TenKH");

                entity.Property(e => e.TuoiKh).HasColumnName("TuoiKH");
            });

            modelBuilder.Entity<Khutrochoi>(entity =>
            {
                entity.HasKey(e => e.MaKhu);

                entity.ToTable("KHUTROCHOI");

                entity.Property(e => e.MaKhu)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.MaNvql)
                    .HasMaxLength(10)
                    .HasColumnName("MaNVQL")
                    .IsFixedLength(true);

                entity.Property(e => e.TenKhu).HasMaxLength(50);

                entity.HasOne(d => d.MaNvqlNavigation)
                    .WithMany(p => p.Khutrochois)
                    .HasForeignKey(d => d.MaNvql)
                    .HasConstraintName("FK_KHUTROCHOI_NHANVIEN");
            });

            modelBuilder.Entity<Nguoidung>(entity =>
            {
                entity.HasKey(e => e.MaNd);

                entity.ToTable("NGUOIDUNG");

                entity.Property(e => e.MaNd)
                    .HasMaxLength(10)
                    .HasColumnName("MaND")
                    .IsFixedLength(true);

                entity.Property(e => e.MaNv)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("MaNV")
                    .IsFixedLength(true);

                entity.Property(e => e.MaQuyen)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.MatKhau)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Ten).HasMaxLength(50);

                entity.Property(e => e.TenDangNhap)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.Nguoidungs)
                    .HasForeignKey(d => d.MaNv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NGUOIDUNG_NHANVIEN");

                entity.HasOne(d => d.MaQuyenNavigation)
                    .WithMany(p => p.Nguoidungs)
                    .HasForeignKey(d => d.MaQuyen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NGUOIDUNG_QUYEN");
            });

            modelBuilder.Entity<Nhanvien>(entity =>
            {
                entity.HasKey(e => e.MaNv);

                entity.ToTable("NHANVIEN");

                entity.Property(e => e.MaNv)
                    .HasMaxLength(10)
                    .HasColumnName("MaNV")
                    .IsFixedLength(true);

                entity.Property(e => e.GioiTinh)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.MaKhuPhuTrach)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.NgaySinh).HasColumnType("date");

                entity.Property(e => e.QueQuan).HasMaxLength(50);

                entity.Property(e => e.TenNv)
                    .HasMaxLength(50)
                    .HasColumnName("TenNV");

                entity.HasOne(d => d.MaKhuPhuTrachNavigation)
                    .WithMany(p => p.Nhanviens)
                    .HasForeignKey(d => d.MaKhuPhuTrach)
                    .HasConstraintName("FK_NHANVIEN_KHUTROCHOI");
            });

            modelBuilder.Entity<Phongban>(entity =>
            {
                entity.HasKey(e => e.MaPb);

                entity.ToTable("PHONGBAN");

                entity.Property(e => e.MaPb)
                    .HasMaxLength(10)
                    .HasColumnName("MaPB")
                    .IsFixedLength(true);

                entity.Property(e => e.DiaDiem).HasMaxLength(50);

                entity.Property(e => e.MaTp)
                    .HasMaxLength(10)
                    .HasColumnName("MaTP")
                    .IsFixedLength(true);

                entity.Property(e => e.NgayNc)
                    .HasColumnType("date")
                    .HasColumnName("NgayNC");

                entity.Property(e => e.TenPb)
                    .HasMaxLength(50)
                    .HasColumnName("TenPB");
            });

            modelBuilder.Entity<Quyen>(entity =>
            {
                entity.HasKey(e => e.MaQuyen);

                entity.ToTable("QUYEN");

                entity.Property(e => e.MaQuyen)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.KyHieuQuyen)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.MieuTa).HasMaxLength(50);

                entity.Property(e => e.TenQuyen).HasMaxLength(50);
            });

            modelBuilder.Entity<Thietbi>(entity =>
            {
                entity.HasKey(e => e.MaTb);

                entity.ToTable("THIETBI");

                entity.Property(e => e.MaTb)
                    .HasMaxLength(10)
                    .HasColumnName("MaTB")
                    .IsFixedLength(true);

                entity.Property(e => e.MaTroChoi)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.TenTb)
                    .HasMaxLength(50)
                    .HasColumnName("TenTB");

                entity.Property(e => e.TinhTrang).HasMaxLength(50);
            });

            modelBuilder.Entity<Trochoi>(entity =>
            {
                entity.HasKey(e => e.MaTroChoi);

                entity.ToTable("TROCHOI");

                entity.Property(e => e.MaTroChoi)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.MaKhu)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.MaNvphuTrach)
                    .HasMaxLength(10)
                    .HasColumnName("MaNVPhuTrach")
                    .IsFixedLength(true);

                entity.Property(e => e.TenTroChoi).HasMaxLength(50);

                entity.HasOne(d => d.MaKhuNavigation)
                    .WithMany(p => p.Trochois)
                    .HasForeignKey(d => d.MaKhu)
                    .HasConstraintName("FK_TROCHOI_KHUTROCHOI");

                entity.HasOne(d => d.MaNvphuTrachNavigation)
                    .WithMany(p => p.Trochois)
                    .HasForeignKey(d => d.MaNvphuTrach)
                    .HasConstraintName("FK_TROCHOI_NHANVIEN");
            });

            modelBuilder.Entity<Ve>(entity =>
            {
                entity.HasKey(e => e.MaVe);

                entity.ToTable("VE");

                entity.Property(e => e.MaVe)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.MaHd)
                    .HasMaxLength(10)
                    .HasColumnName("MaHD")
                    .IsFixedLength(true);

                entity.Property(e => e.MaKhu)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.NgayPhatHanh).HasColumnType("date");

                entity.HasOne(d => d.MaHdNavigation)
                    .WithMany(p => p.Ves)
                    .HasForeignKey(d => d.MaHd)
                    .HasConstraintName("FK_VE_HOADON");

                entity.HasOne(d => d.MaKhuNavigation)
                    .WithMany(p => p.Ves)
                    .HasForeignKey(d => d.MaKhu)
                    .HasConstraintName("FK_VE_KHUTROCHOI");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
