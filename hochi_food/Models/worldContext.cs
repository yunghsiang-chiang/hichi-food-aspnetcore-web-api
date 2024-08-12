using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace hochi_food.Models;

public partial class worldContext : DbContext
{
    public worldContext(DbContextOptions<worldContext> options)
        : base(options)
    {
    }

    public virtual DbSet<city> city { get; set; }

    public virtual DbSet<country> country { get; set; }

    public virtual DbSet<countrylanguage> countrylanguage { get; set; }

    public virtual DbSet<t_questionnaire_answers> t_questionnaire_answers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<city>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.HasIndex(e => e.CountryCode, "CountryCode");

            entity.Property(e => e.CountryCode)
                .HasMaxLength(3)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.District)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.Name)
                .HasMaxLength(35)
                .HasDefaultValueSql("''")
                .IsFixedLength();

            entity.HasOne(d => d.CountryCodeNavigation).WithMany(p => p.city)
                .HasForeignKey(d => d.CountryCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("city_ibfk_1");
        });

        modelBuilder.Entity<country>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PRIMARY");

            entity.Property(e => e.Code)
                .HasMaxLength(3)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.Code2)
                .HasMaxLength(2)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.Continent)
                .HasDefaultValueSql("'Asia'")
                .HasColumnType("enum('Asia','Europe','North America','Africa','Oceania','Antarctica','South America')");
            entity.Property(e => e.GNP).HasPrecision(10);
            entity.Property(e => e.GNPOld).HasPrecision(10);
            entity.Property(e => e.GovernmentForm)
                .HasMaxLength(45)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.HeadOfState)
                .HasMaxLength(60)
                .IsFixedLength();
            entity.Property(e => e.LifeExpectancy).HasPrecision(3, 1);
            entity.Property(e => e.LocalName)
                .HasMaxLength(45)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.Name)
                .HasMaxLength(52)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.Region)
                .HasMaxLength(26)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.SurfaceArea).HasPrecision(10);
        });

        modelBuilder.Entity<countrylanguage>(entity =>
        {
            entity.HasKey(e => new { e.CountryCode, e.Language }).HasName("PRIMARY");

            entity.HasIndex(e => e.CountryCode, "CountryCode");

            entity.Property(e => e.CountryCode)
                .HasMaxLength(3)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.Language)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.IsOfficial)
                .HasDefaultValueSql("'F'")
                .HasColumnType("enum('T','F')");
            entity.Property(e => e.Percentage).HasPrecision(4, 1);

            entity.HasOne(d => d.CountryCodeNavigation).WithMany(p => p.countrylanguage)
                .HasForeignKey(d => d.CountryCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("countryLanguage_ibfk_1");
        });

        modelBuilder.Entity<t_questionnaire_answers>(entity =>
        {
            entity.HasKey(e => new { e.問卷名稱, e.姓名, e.question, e.電子郵件地址 }).HasName("PRIMARY");

            entity.Property(e => e.問卷名稱).HasMaxLength(100);
            entity.Property(e => e.姓名).HasMaxLength(100);
            entity.Property(e => e.question)
                .HasMaxLength(100)
                .HasComment("問題");
            entity.Property(e => e.電子郵件地址).HasMaxLength(100);
            entity.Property(e => e.上課日期).HasColumnType("text");
            entity.Property(e => e.區屬).HasColumnType("text");
            entity.Property(e => e.回答).HasColumnType("text");
            entity.Property(e => e.時間戳記).HasColumnType("text");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
