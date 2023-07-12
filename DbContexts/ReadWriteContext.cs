using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using TaskList.DbContexts.Models;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TaskList.DbContexts
{
    public partial class ReadWriteContext : DbContext
    {
        public ReadWriteContext()
        {
        }

        public ReadWriteContext(DbContextOptions<ReadWriteContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblItem> TblItem { get; set; }
        public virtual DbSet<TblPartner> TblPartner { get; set; }
        public virtual DbSet<TblPartnerType> TblPartnerType { get; set; }
        public virtual DbSet<TblPurchase> TblPurchase { get; set; }
        public virtual DbSet<TblPurchaseDetails> TblPurchaseDetails { get; set; }
        public virtual DbSet<TblSales> TblSales { get; set; }
        public virtual DbSet<TblSalesDetails> TblSalesDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-RF6ORRA\\SQLEXPRESS;Initial Catalog=Ecommerce;Persist Security Info=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True;Integrated Security=True;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblItem>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.ToTable("tblItem");

                entity.Property(e => e.IsActive)
                    .HasColumnName("isActive")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemName)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPartner>(entity =>
            {
                entity.HasKey(e => e.IntPartnerId);

                entity.ToTable("tblPartner");

                entity.Property(e => e.IntPartnerId).HasColumnName("intPartnerId");

                entity.Property(e => e.IsActive)
                    .HasColumnName("isActive")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PartnerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPartnerType>(entity =>
            {
                entity.HasKey(e => e.PartnerTypeId);

                entity.ToTable("tblPartnerType");

                entity.Property(e => e.IsActive)
                    .HasColumnName("isActive")
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.PartnerTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPurchase>(entity =>
            {
                entity.HasKey(e => e.PurchaseId);

                entity.ToTable("tblPurchase");

                entity.Property(e => e.IsActive)
                    .HasColumnName("isActive")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseDate).HasColumnType("date");
            });

            modelBuilder.Entity<TblPurchaseDetails>(entity =>
            {
                entity.HasKey(e => e.DetailsId)
                    .HasName("PK_isActive");

                entity.ToTable("tblPurchaseDetails");

                entity.Property(e => e.IsActive)
                    .HasColumnName("isActive")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblSales>(entity =>
            {
                entity.HasKey(e => e.SalesId);

                entity.ToTable("tblSales");

                entity.Property(e => e.IsActive)
                    .HasColumnName("isActive")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesDate).HasColumnType("date");
            });

            modelBuilder.Entity<TblSalesDetails>(entity =>
            {
                entity.HasKey(e => e.DetailsId);

                entity.ToTable("tblSalesDetails");

                entity.Property(e => e.IsActive)
                    .HasColumnName("isActive")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
