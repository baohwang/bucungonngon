using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DTO.Models;

public partial class QlnvLab6Context : DbContext
{
    public QlnvLab6Context()
    {
    }

    public QlnvLab6Context(DbContextOptions<QlnvLab6Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Nhanvien> Nhanviens { get; set; }

    public virtual DbSet<Phongban> Phongbans { get; set; }

    public virtual DbSet<Vaitro> Vaitros { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-QIE438C\\MAYAO;Database=QLNV_Lab6;Trusted_Connection=True;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Nhanvien>(entity =>
        {
            entity.HasKey(e => e.Manv).HasName("PK__NHANVIEN__603F51148747FAD8");

            entity.ToTable("NHANVIEN");

            entity.Property(e => e.Manv)
                .HasMaxLength(20)
                .HasColumnName("MANV");
            entity.Property(e => e.Cmnd)
                .HasMaxLength(20)
                .HasColumnName("CMND");
            entity.Property(e => e.Gioitinh)
                .HasMaxLength(3)
                .HasColumnName("GIOITINH");
            entity.Property(e => e.Hoten)
                .HasMaxLength(100)
                .HasColumnName("HOTEN");
            entity.Property(e => e.Luong).HasColumnName("LUONG");
            entity.Property(e => e.Mapb)
                .HasMaxLength(20)
                .HasColumnName("MAPB");
            entity.Property(e => e.Matruongphong)
                .HasMaxLength(20)
                .HasColumnName("MATRUONGPHONG");
            entity.Property(e => e.Mavt)
                .HasMaxLength(20)
                .HasColumnName("MAVT");
            entity.Property(e => e.Ngaysinh).HasColumnName("NGAYSINH");
            entity.Property(e => e.Ngayvaolamviec).HasColumnName("NGAYVAOLAMVIEC");

            entity.HasOne(d => d.MapbNavigation).WithMany(p => p.Nhanviens)
                .HasForeignKey(d => d.Mapb)
                .HasConstraintName("FK__NHANVIEN__MAPB__412EB0B6");

            entity.HasOne(d => d.MatruongphongNavigation).WithMany(p => p.InverseMatruongphongNavigation)
                .HasForeignKey(d => d.Matruongphong)
                .HasConstraintName("FK__NHANVIEN__MATRUO__3F466844");

            entity.HasOne(d => d.MavtNavigation).WithMany(p => p.Nhanviens)
                .HasForeignKey(d => d.Mavt)
                .HasConstraintName("FK__NHANVIEN__MAVT__403A8C7D");
        });

        modelBuilder.Entity<Phongban>(entity =>
        {
            entity.HasKey(e => e.Mapb).HasName("PK__PHONGBAN__603F61C29E197846");

            entity.ToTable("PHONGBAN");

            entity.Property(e => e.Mapb)
                .HasMaxLength(20)
                .HasColumnName("MAPB");
            entity.Property(e => e.Diadiem)
                .HasMaxLength(100)
                .HasColumnName("DIADIEM");
            entity.Property(e => e.Matruongphong)
                .HasMaxLength(20)
                .HasColumnName("MATRUONGPHONG");
            entity.Property(e => e.Ngaynhanchuc).HasColumnName("NGAYNHANCHUC");
            entity.Property(e => e.Tenpb)
                .HasMaxLength(50)
                .HasColumnName("TENPB");
        });

        modelBuilder.Entity<Vaitro>(entity =>
        {
            entity.HasKey(e => e.Mavt).HasName("PK__VAITRO__602282489348F5BF");

            entity.ToTable("VAITRO");

            entity.Property(e => e.Mavt)
                .HasMaxLength(20)
                .HasColumnName("MAVT");
            entity.Property(e => e.Tenvaitro)
                .HasMaxLength(50)
                .HasColumnName("TENVAITRO");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
