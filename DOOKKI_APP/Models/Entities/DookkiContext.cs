using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DOOKKI_APP.Models.Entities;

public partial class DookkiContext : DbContext
{
    public DookkiContext()
    {
    }

    public DookkiContext(DbContextOptions<DookkiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<CategoryTicket> CategoryTickets { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<DayWork> DayWorks { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Table> Tables { get; set; }

    public virtual DbSet<Ticket> Tickets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-1;Database=DOOKKI;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ACCOUNT__3214EC27C485DA38");

            entity.ToTable("ACCOUNT");

            entity.HasIndex(e => e.UserName, "UQ__ACCOUNT__C9F28456E0DA99A7").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Password).HasMaxLength(255);
            entity.Property(e => e.Role).HasMaxLength(20);
            entity.Property(e => e.UserName).HasMaxLength(255);
        });

        modelBuilder.Entity<Admin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Admin__3214EC277CE5B1FB");

            entity.ToTable("Admin");

            entity.HasIndex(e => e.Phone, "UQ__Admin__5C7E359ECEB9D9BD").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idaccount).HasColumnName("IDAccount");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Phone).HasMaxLength(12);

            entity.HasOne(d => d.IdaccountNavigation).WithMany(p => p.Admins)
                .HasForeignKey(d => d.Idaccount)
                .HasConstraintName("FK__Admin__IDAccount__3C69FB99");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Category__3214EC2759C95764");

            entity.ToTable("Category");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Name).HasMaxLength(255);
        });

        modelBuilder.Entity<CategoryTicket>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Category__3214EC27B841FB4E");

            entity.ToTable("CategoryTicket");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Customer__3214EC2722DC5F0F");

            entity.ToTable("Customer");

            entity.HasIndex(e => e.Phone, "UQ__Customer__5C7E359EB5CCB480").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.Idaccount).HasColumnName("IDAccount");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Marks).HasDefaultValue(0);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Phone).HasMaxLength(15);

            entity.HasOne(d => d.IdaccountNavigation).WithMany(p => p.Customers)
                .HasForeignKey(d => d.Idaccount)
                .HasConstraintName("FK__Customer__IDAcco__4222D4EF");
        });

        modelBuilder.Entity<DayWork>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DayWork__3214EC27D5416F1B");

            entity.ToTable("DayWork");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Day).HasColumnName("day");
            entity.Property(e => e.EmployeeId).HasColumnName("employeeID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.TimeWork).HasColumnName("timeWork");

            entity.HasOne(d => d.Employee).WithMany(p => p.DayWorks)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_DayWork_Employee");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Employee__3214EC2731DD6BFF");

            entity.ToTable("Employee");

            entity.HasIndex(e => e.Email, "UQ__Employee__AB6E6164880DA668").IsUnique();

            entity.HasIndex(e => e.Phone, "UQ__Employee__B43B145F39BF51F9").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AmountWage)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("amountWage");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Phone)
                .HasMaxLength(12)
                .HasColumnName("phone");
            entity.Property(e => e.Position)
                .HasMaxLength(255)
                .HasColumnName("position");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Order__3214EC27C6DB635E");

            entity.ToTable("Order");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CustomerId).HasColumnName("customerID");
            entity.Property(e => e.Discount)
                .HasDefaultValue(0)
                .HasColumnName("discount");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Status).HasDefaultValue(0);

            entity.HasOne(d => d.Customer).WithMany(p => p.Orders)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_Order_customerID");
        });

        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OrderDet__3214EC277369BB6A");

            entity.ToTable("OrderDetail");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.OrderId).HasColumnName("orderID");
            entity.Property(e => e.PaymentId).HasColumnName("paymentID");
            entity.Property(e => e.Quantily)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("quantily");
            entity.Property(e => e.TicketId).HasColumnName("ticketID");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK_OrderDetail_Order");

            entity.HasOne(d => d.Payment).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.PaymentId)
                .HasConstraintName("FK_OrderDetail_Payment");

            entity.HasOne(d => d.Ticket).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.TicketId)
                .HasConstraintName("FK_OrderDetail_Ticket");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Payment__3214EC27877F5F18");

            entity.ToTable("Payment");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("amount");
            entity.Property(e => e.Day).HasColumnName("day");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.PaymentMethodId).HasColumnName("paymentMethodID");

            entity.HasOne(d => d.PaymentMethod).WithMany(p => p.Payments)
                .HasForeignKey(d => d.PaymentMethodId)
                .HasConstraintName("FK_Payment_PaymentMethod");
        });

        modelBuilder.Entity<PaymentMethod>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PaymentM__3214EC27814F26A3");

            entity.ToTable("PaymentMethod");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Name).HasMaxLength(255);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Product__3214EC2787C2FA3A");

            entity.ToTable("Product");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CategoryId).HasColumnName("categoryID");
            entity.Property(e => e.Exp).HasColumnName("EXP");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Mfg).HasColumnName("MFG");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.UnitInStock).HasColumnName("unitInStock");

            entity.HasOne(d => d.Category).WithMany(p => p.Products)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_Product_Category");
        });

        modelBuilder.Entity<Table>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Table__3214EC2723445EE3");

            entity.ToTable("Table");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdOrder).HasColumnName("ID_Order");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Status).HasDefaultValue(true);

            entity.HasOne(d => d.IdOrderNavigation).WithMany(p => p.Tables)
                .HasForeignKey(d => d.IdOrder)
                .HasConstraintName("FK__Table__ID_Order__619B8048");
        });

        modelBuilder.Entity<Ticket>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Ticket__3214EC2794513463");

            entity.ToTable("Ticket");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdCategory).HasColumnName("ID_Category");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

            entity.HasOne(d => d.IdCategoryNavigation).WithMany(p => p.Tickets)
                .HasForeignKey(d => d.IdCategory)
                .HasConstraintName("FK__Ticket__ID_Categ__5812160E");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
