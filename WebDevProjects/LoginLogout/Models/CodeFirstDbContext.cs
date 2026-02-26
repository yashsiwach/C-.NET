using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LoginLogout.Models;

public partial class CodeFirstDbContext : DbContext
{
    public CodeFirstDbContext()
    {
    }

    public CodeFirstDbContext(DbContextOptions<CodeFirstDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<User> Users { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Users__3214EC07FDA5EE2B");

            entity.HasIndex(e => e.Email, "UQ__Users__A9D105343645EEBA").IsUnique();

            entity.Property(e => e.Email).HasMaxLength(150);
            entity.Property(e => e.Gender).HasMaxLength(10);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Password).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
