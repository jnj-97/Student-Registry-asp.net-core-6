using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Education.Models;

public partial class EducationContext : DbContext
{
    public EducationContext()
    {
    }

    public EducationContext(DbContextOptions<EducationContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-PJ8S7J8S\\MSSQLSERVER01;Initial Catalog=Education;Integrated Security=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(500)
                .IsFixedLength()
                .HasColumnName("address");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("email");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("name");
            entity.Property(e => e.Phone)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("phone");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
