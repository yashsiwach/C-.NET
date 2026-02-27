using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebAPICRUD.Models;

public partial class CRUDContext : DbContext
{
    public CRUDContext()
    {
    }

    public CRUDContext(DbContextOptions<CRUDContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Student> Students { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Department>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("department");

            entity.Property(e => e.Manager)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("employee");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Salary).HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Rollno).HasName("PK__student__FABA8B5BE2AFE2B7");

            entity.ToTable("student");

            entity.Property(e => e.Rollno)
                .ValueGeneratedNever()
                .HasColumnName("rollno");
            entity.Property(e => e.Firstname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("firstname");
            entity.Property(e => e.Marks).HasColumnName("marks");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
