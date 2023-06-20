using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Product_Management.Models
{
    public partial class DBSupermarket1Context : DbContext
    {
        public DBSupermarket1Context()
        {
        }

        public DBSupermarket1Context(DbContextOptions<DBSupermarket1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<ImportGood> ImportGoods { get; set; } = null!;
        public virtual DbSet<Invoice> Invoices { get; set; } = null!;
        public virtual DbSet<Loss> Losses { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<Profit> Profits { get; set; } = null!;
        public virtual DbSet<Supplier> Suppliers { get; set; } = null!;
        public virtual DbSet<TransactionDetail> TransactionDetails { get; set; } = null!;
        public virtual DbSet<Userr> Userrs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-IRP03E2\\THUONG;Database=DBSupermarket1;User Id=sa;Password=123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Position)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ImportGood>(entity =>
            {
                entity.HasKey(e => e.ImportId)
                    .HasName("PK__ImportGo__8697678A640FAB64");

                entity.Property(e => e.ImportId).HasColumnName("ImportID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.HasKey(e => e.TransactionId)
                    .HasName("PK__Invoice__55433A4BDA7933B9");

                entity.ToTable("Invoice");

                entity.HasIndex(e => e.Date, "UQ__Invoice__77387D072109B592")
                    .IsUnique();

                entity.Property(e => e.TransactionId)
                    .ValueGeneratedNever()
                    .HasColumnName("TransactionID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            });

            modelBuilder.Entity<Loss>(entity =>
            {
                entity.ToTable("Loss");

                entity.Property(e => e.LossId)
                    .ValueGeneratedNever()
                    .HasColumnName("LossID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Reason)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Profit>(entity =>
            {
                entity.HasKey(e => e.Date)
                    .HasName("PK__Profit__77387D06418F2F7F");

                entity.ToTable("Profit");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Profit1).HasColumnName("Profit");
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.ToTable("Supplier");

                entity.Property(e => e.SupplierId)
                    .ValueGeneratedNever()
                    .HasColumnName("SupplierID");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TransactionDetail>(entity =>
            {
                entity.HasKey(e => new { e.TransactionId, e.ProductId, e.Price })
                    .HasName("PK__Transact__97637F98FAB2EA19");

                entity.Property(e => e.TransactionId).HasColumnName("TransactionID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");
            });

            modelBuilder.Entity<Userr>(entity =>
            {
                entity.ToTable("Userr");

                entity.HasIndex(e => e.Email, "UQ__Userr__AB6E6164263C4A4D")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("created_at");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Role).HasColumnName("role");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
