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

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<DayWork> DayWorks { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Ticket> Tickets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-1;Database=DOOKKI;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admin>(entity =>
        {
            entity.HasKey(e => e.AdminId).HasName("PK__Admin__AD0500864B16E9A1");

            entity.ToTable("Admin");

            entity.HasIndex(e => e.AdminUserName, "UQ__Admin__61899E043C15174F").IsUnique();

            entity.HasIndex(e => e.AdminPhone, "UQ__Admin__62E337FDD5425085").IsUnique();

            entity.Property(e => e.AdminId).HasColumnName("adminID");
            entity.Property(e => e.AdminName)
                .HasMaxLength(255)
                .HasColumnName("adminName");
            entity.Property(e => e.AdminPassword)
                .HasMaxLength(255)
                .HasColumnName("adminPassword");
            entity.Property(e => e.AdminPhone)
                .HasMaxLength(12)
                .HasColumnName("adminPhone");
            entity.Property(e => e.AdminUserName)
                .HasMaxLength(255)
                .HasColumnName("adminUserName");
            entity.Property(e => e.Roles)
                .HasMaxLength(100)
                .HasColumnName("roles");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__Category__23CAF1F8D8213F4F");

            entity.ToTable("Category");

            entity.Property(e => e.CategoryId).HasColumnName("categoryID");
            entity.Property(e => e.CategoryName)
                .HasMaxLength(255)
                .HasColumnName("categoryName");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__Customer__B611CB9DBDD3AB0B");

            entity.ToTable("Customer");

            entity.HasIndex(e => e.CustomerPhone, "UQ__Customer__311068C4591C97C0").IsUnique();

            entity.HasIndex(e => e.CustomerUserName, "UQ__Customer__EFF8927731CB1730").IsUnique();

            entity.HasIndex(e => e.CustomerEmail, "UQ__Customer__FFE82D722BB3A79E").IsUnique();

            entity.Property(e => e.CustomerId).HasColumnName("customerID");
            entity.Property(e => e.CustomerAddress)
                .HasMaxLength(255)
                .HasColumnName("customerAddress");
            entity.Property(e => e.CustomerEmail)
                .HasMaxLength(255)
                .HasColumnName("customerEmail");
            entity.Property(e => e.CustomerMark)
                .HasDefaultValue(0)
                .HasColumnName("customerMark");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(255)
                .HasColumnName("customerName");
            entity.Property(e => e.CustomerPassword)
                .HasMaxLength(255)
                .HasColumnName("customerPassword");
            entity.Property(e => e.CustomerPhone)
                .HasMaxLength(15)
                .HasColumnName("customerPhone");
            entity.Property(e => e.CustomerUserName)
                .HasMaxLength(255)
                .HasColumnName("customerUserName");
        });

        modelBuilder.Entity<DayWork>(entity =>
        {
            entity.HasKey(e => e.DayWorkId).HasName("PK__DayWork__20E29512597B0244");

            entity.ToTable("DayWork");

            entity.Property(e => e.DayWorkId).HasColumnName("dayWorkId");
            entity.Property(e => e.Day).HasColumnName("day");
            entity.Property(e => e.EmployeeId).HasColumnName("employeeID");
            entity.Property(e => e.TimeWork).HasColumnName("timeWork");

            entity.HasOne(d => d.Employee).WithMany(p => p.DayWorks)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_DayWork_Employee");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK__Employee__C134C9A13E9C97B6");

            entity.ToTable("Employee");

            entity.HasIndex(e => e.Email, "UQ__Employee__AB6E61641D183476").IsUnique();

            entity.HasIndex(e => e.Phone, "UQ__Employee__B43B145F960FB7A0").IsUnique();

            entity.Property(e => e.EmployeeId).HasColumnName("employeeID");
            entity.Property(e => e.AmountWage)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("amountWage");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.EmployeeName)
                .HasMaxLength(255)
                .HasColumnName("employeeName");
            entity.Property(e => e.Phone)
                .HasMaxLength(12)
                .HasColumnName("phone");
            entity.Property(e => e.Position)
                .HasMaxLength(255)
                .HasColumnName("position");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PK__Order__0809337DC1F03F63");

            entity.ToTable("Order");

            entity.Property(e => e.OrderId).HasColumnName("orderID");
            entity.Property(e => e.CustomerId).HasColumnName("customerID");
            entity.Property(e => e.Discount)
                .HasDefaultValue(0)
                .HasColumnName("discount");
            entity.Property(e => e.OrderTime).HasColumnName("orderTime");

            entity.HasOne(d => d.Customer).WithMany(p => p.Orders)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_Order_customerID");
        });

        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.HasKey(e => e.OrderDetailId).HasName("PK__OrderDet__E4FEDE2A788EF455");

            entity.ToTable("OrderDetail");

            entity.Property(e => e.OrderDetailId).HasColumnName("orderDetailID");
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
            entity.HasKey(e => e.PaymentId).HasName("PK__Payment__A0D9EFA683FFB499");

            entity.ToTable("Payment");

            entity.Property(e => e.PaymentId).HasColumnName("paymentID");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("amount");
            entity.Property(e => e.Day).HasColumnName("day");
            entity.Property(e => e.PaymentMethodId).HasColumnName("paymentMethodID");

            entity.HasOne(d => d.PaymentMethod).WithMany(p => p.Payments)
                .HasForeignKey(d => d.PaymentMethodId)
                .HasConstraintName("FK_Payment_PaymentMethod");
        });

        modelBuilder.Entity<PaymentMethod>(entity =>
        {
            entity.HasKey(e => e.PaymentMethodId).HasName("PK__PaymentM__46612FD86FA804F8");

            entity.ToTable("PaymentMethod");

            entity.Property(e => e.PaymentMethodId).HasColumnName("paymentMethodID");
            entity.Property(e => e.PaymentMethodName)
                .HasMaxLength(255)
                .HasColumnName("paymentMethodName");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__Product__2D10D14ADE741096");

            entity.ToTable("Product");

            entity.Property(e => e.ProductId).HasColumnName("productID");
            entity.Property(e => e.CategoryId).HasColumnName("categoryID");
            entity.Property(e => e.Exp).HasColumnName("EXP");
            entity.Property(e => e.Mfg).HasColumnName("MFG");
            entity.Property(e => e.ProductName)
                .HasMaxLength(255)
                .HasColumnName("productName");
            entity.Property(e => e.UnitInStock).HasColumnName("unitInStock");

            entity.HasOne(d => d.Category).WithMany(p => p.Products)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_Product_Category");
        });

        modelBuilder.Entity<Ticket>(entity =>
        {
            entity.HasKey(e => e.TicketId).HasName("PK__Ticket__3333C67012C7A4D4");

            entity.ToTable("Ticket");

            entity.HasIndex(e => e.TicketName, "UQ__Ticket__4800CA02EB09A7AD").IsUnique();

            entity.Property(e => e.TicketId).HasColumnName("ticketID");
            entity.Property(e => e.TicketName)
                .HasMaxLength(255)
                .HasColumnName("ticketName");
            entity.Property(e => e.TicketPrice)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("ticketPrice");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
