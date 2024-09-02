using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace hochi_food.Models;

public partial class hochi_configContext : DbContext
{
    public hochi_configContext(DbContextOptions<hochi_configContext> options)
        : base(options)
    {
    }

    public virtual DbSet<c_fellow_hochi_learners> c_fellow_hochi_learners { get; set; }

    public virtual DbSet<c_ip_webarea> c_ip_webarea { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<c_fellow_hochi_learners>(entity =>
        {
            entity.HasKey(e => e.person_id).HasName("PRIMARY");

            entity.Property(e => e.person_id).HasMaxLength(45);
            entity.Property(e => e.person_area).HasMaxLength(45);
            entity.Property(e => e.person_calendar).HasMaxLength(150);
            entity.Property(e => e.person_name).HasMaxLength(45);
            entity.Property(e => e.person_password).HasMaxLength(45);
            entity.Property(e => e.person_subinv).HasMaxLength(45);
        });

        modelBuilder.Entity<c_ip_webarea>(entity =>
        {
            entity.HasKey(e => new { e.area, e.ipaddress }).HasName("PRIMARY");

            entity.Property(e => e.area).HasMaxLength(45);
            entity.Property(e => e.ipaddress).HasMaxLength(45);
            entity.Property(e => e.sub_inv).HasMaxLength(45);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
