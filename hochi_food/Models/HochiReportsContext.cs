using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace hochi_food.Models;

public partial class HochiReportsContext : DbContext
{
    public HochiReportsContext(DbContextOptions<HochiReportsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<HierarchyStructure> HierarchyStructure { get; set; }

    public virtual DbSet<People> People { get; set; }

    public virtual DbSet<TableSchema> TableSchema { get; set; }

    public virtual DbSet<UserReports> UserReports { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<HierarchyStructure>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__Hierarch__3213E83F87B2503B");

            entity.Property(e => e.category)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.description).HasColumnType("text");
            entity.Property(e => e.name)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.region_structure).HasColumnType("text");
            entity.Property(e => e.supervision_system).HasColumnType("text");

            entity.HasOne(d => d.parent).WithMany(p => p.Inverseparent)
                .HasForeignKey(d => d.parent_id)
                .HasConstraintName("FK_Hierarchy_Parent");
        });

        modelBuilder.Entity<People>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__People__3213E83F6ACE8D4A");

            entity.Property(e => e.full_name).HasMaxLength(255);
            entity.Property(e => e.role_description).HasMaxLength(255);

            entity.HasOne(d => d.hierarchy).WithMany(p => p.People)
                .HasForeignKey(d => d.hierarchy_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_People_Hierarchy");
        });

        modelBuilder.Entity<TableSchema>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__TableSch__3213E83F259ECBBB");

            entity.Property(e => e.allowed_functions).HasMaxLength(200);
            entity.Property(e => e.column_name).HasMaxLength(100);
            entity.Property(e => e.column_type).HasMaxLength(50);
            entity.Property(e => e.table_name).HasMaxLength(100);
        });

        modelBuilder.Entity<UserReports>(entity =>
        {
            entity.HasKey(e => e.report_id).HasName("PK__UserRepo__779B7C5809DF6BB3");

            entity.Property(e => e.category_field).HasMaxLength(100);
            entity.Property(e => e.chart_type).HasMaxLength(50);
            entity.Property(e => e.created_at)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.is_public).HasDefaultValue(false);
            entity.Property(e => e.report_name).HasMaxLength(100);
            entity.Property(e => e.share_code).HasMaxLength(50);
            entity.Property(e => e.stack_field).HasMaxLength(100);
            entity.Property(e => e.table_name).HasMaxLength(100);
            entity.Property(e => e.user_id).HasMaxLength(50);
            entity.Property(e => e.x_axis).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
