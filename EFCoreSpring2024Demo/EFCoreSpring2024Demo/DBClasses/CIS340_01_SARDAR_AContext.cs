using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EFCoreSpring2024Demo.DBClasses
{
    public partial class CIS340_01_SARDAR_AContext : DbContext
    {
        public CIS340_01_SARDAR_AContext()
        {
        }

        public CIS340_01_SARDAR_AContext(DbContextOptions<CIS340_01_SARDAR_AContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admins { get; set; } = null!;
        public virtual DbSet<AdminCredential> AdminCredentials { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<CustomerCategory> CustomerCategories { get; set; } = null!;
        public virtual DbSet<CustomerCredential> CustomerCredentials { get; set; } = null!;
        public virtual DbSet<Invoice> Invoices { get; set; } = null!;
        public virtual DbSet<InvoiceLineItem> InvoiceLineItems { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<ProductCategory> ProductCategories { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=CNMTSRV1; database=CIS340_01_SARDAR_A;Integrated security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdminCredential>(entity =>
            {
                entity.HasOne(d => d.Admin)
                    .WithMany()
                    .HasForeignKey(d => d.AdminId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AdminCred__Passw__2D7CBDC4");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasOne(d => d.Admin)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.AdminId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Customers__Admin__314D4EA8");

                entity.HasOne(d => d.CustomerCategory)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.CustomerCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Customers__Custo__30592A6F");
            });

            modelBuilder.Entity<CustomerCredential>(entity =>
            {
                entity.HasOne(d => d.Customer)
                    .WithMany()
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CustomerC__Custo__3335971A");
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Invoices__Custom__38EE7070");
            });

            modelBuilder.Entity<InvoiceLineItem>(entity =>
            {
                entity.HasKey(e => new { e.InvoiceId, e.ProductCode })
                    .HasName("PK__InvoiceL__25624AF1C17BE8A3");

                entity.Property(e => e.ProductCode).IsFixedLength();

                entity.HasOne(d => d.CustomerCategory)
                    .WithMany(p => p.InvoiceLineItems)
                    .HasForeignKey(d => d.CustomerCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__InvoiceLi__Custo__3BCADD1B");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.InvoiceLineItems)
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__InvoiceLi__Invoi__3CBF0154");

                entity.HasOne(d => d.ProductCodeNavigation)
                    .WithMany(p => p.InvoiceLineItems)
                    .HasForeignKey(d => d.ProductCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__InvoiceLi__Produ__3DB3258D");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.ProductCode)
                    .HasName("PK__Products__2F4E024EF19C901D");

                entity.Property(e => e.ProductCode).IsFixedLength();

                entity.HasOne(d => d.ProductCategory)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ProductCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Products__Produc__361203C5");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
