using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAL.Models
{
    public partial class QuanLyBanHangContext : DbContext
    {
        public QuanLyBanHangContext()
        {
        }

        public QuanLyBanHangContext(DbContextOptions<QuanLyBanHangContext> options)
            : base(options)
        {
        }

        public virtual DbSet<GioHang> GioHangs { get; set; } = null!;
        public virtual DbSet<HoaDon> HoaDons { get; set; } = null!;
        public virtual DbSet<KhachHang> KhachHangs { get; set; } = null!;
        public virtual DbSet<NguoiDung> NguoiDungs { get; set; } = null!;
        public virtual DbSet<SanPham> SanPhams { get; set; } = null!;
        public virtual DbSet<SanPhamChiTiet> SanPhamChiTiets { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-Q6N4J46;Database=QuanLyBanHang;User Id=sa;Password=123456;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GioHang>(entity =>
            {
                entity.HasKey(e => e.Idgh)
                    .HasName("PK__GioHang__9DB79DE3D60015EC");

                entity.ToTable("GioHang");

                entity.Property(e => e.Idgh).HasColumnName("idgh");

                entity.Property(e => e.Idnd).HasColumnName("idnd");

                entity.Property(e => e.Idspct).HasColumnName("idspct");

                entity.Property(e => e.Soluongmua).HasColumnName("soluongmua");

                entity.HasOne(d => d.IdndNavigation)
                    .WithMany(p => p.GioHangs)
                    .HasForeignKey(d => d.Idnd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GioHang__idnd__628FA481");

                entity.HasOne(d => d.IdspctNavigation)
                    .WithMany(p => p.GioHangs)
                    .HasForeignKey(d => d.Idspct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GioHang__idspct__619B8048");
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.HasKey(e => e.Idhd)
                    .HasName("PK__HoaDon__9DB78A0E9CF09714");

                entity.ToTable("HoaDon");

                entity.Property(e => e.Idhd).HasColumnName("idhd");

                entity.Property(e => e.Anh).HasColumnName("anh");

                entity.Property(e => e.Diachi)
                    .HasMaxLength(200)
                    .HasColumnName("diachi");

                entity.Property(e => e.Gia)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("gia");

                entity.Property(e => e.Idgh).HasColumnName("idgh");

                entity.Property(e => e.Idnguoidung).HasColumnName("idnguoidung");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sdt");

                entity.Property(e => e.Soluongmua).HasColumnName("soluongmua");

                entity.Property(e => e.Tennguoimua)
                    .HasMaxLength(50)
                    .HasColumnName("tennguoimua");

                entity.Property(e => e.Tensp)
                    .HasMaxLength(100)
                    .HasColumnName("tensp");

                entity.Property(e => e.Thoigian)
                    .HasColumnType("datetime")
                    .HasColumnName("thoigian")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tongtien)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("tongtien");

                entity.Property(e => e.Trangthai).HasColumnName("trangthai");

                entity.HasOne(d => d.IdghNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.Idgh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDon__idgh__66603565");

                entity.HasOne(d => d.IdnguoidungNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.Idnguoidung)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDon__idnguoid__6754599E");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KhachHang");

                entity.Property(e => e.Diachi)
                    .HasMaxLength(200)
                    .HasColumnName("diachi");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("email");

                entity.Property(e => e.Idkh)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("idkh");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sdt");

                entity.Property(e => e.Tenkh)
                    .HasMaxLength(50)
                    .HasColumnName("tenkh");

                entity.HasOne(d => d.IdkhNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Idkh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__KhachHang__idkh__59FA5E80");
            });

            modelBuilder.Entity<NguoiDung>(entity =>
            {
                entity.HasKey(e => e.Idnd)
                    .HasName("PK__NguoiDun__9DB745465761115D");

                entity.ToTable("NguoiDung");

                entity.Property(e => e.Idnd).HasColumnName("idnd");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.HasKey(e => e.Idsp)
                    .HasName("PK__SanPham__9DBB2CF20FAE4A7C");

                entity.ToTable("SanPham");

                entity.Property(e => e.Idsp).HasColumnName("idsp");

                entity.Property(e => e.Anh).HasColumnName("anh");

                entity.Property(e => e.Gia)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("gia");

                entity.Property(e => e.Tensp)
                    .HasMaxLength(100)
                    .HasColumnName("tensp");
            });

            modelBuilder.Entity<SanPhamChiTiet>(entity =>
            {
                entity.HasKey(e => e.Idspct)
                    .HasName("PK__SanPhamC__D628E03A984AD418");

                entity.ToTable("SanPhamChiTiet");

                entity.Property(e => e.Idspct).HasColumnName("idspct");

                entity.Property(e => e.Idsp).HasColumnName("idsp");

                entity.Property(e => e.Soluong).HasColumnName("soluong");

                entity.HasOne(d => d.IdspNavigation)
                    .WithMany(p => p.SanPhamChiTiets)
                    .HasForeignKey(d => d.Idsp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SanPhamChi__idsp__5EBF139D");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
