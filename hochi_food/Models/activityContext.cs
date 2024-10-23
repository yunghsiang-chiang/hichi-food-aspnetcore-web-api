using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace hochi_food.Models;

public partial class activityContext : DbContext
{
    public activityContext(DbContextOptions<activityContext> options)
        : base(options)
    {
    }

    public virtual DbSet<color_preferences> color_preferences { get; set; }

    public virtual DbSet<exhibition> exhibition { get; set; }

    public virtual DbSet<feedback> feedback { get; set; }

    public virtual DbSet<participants> participants { get; set; }

    public virtual DbSet<social_check_in> social_check_in { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<color_preferences>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.HasIndex(e => e.participant_id, "participant_id");

            entity.Property(e => e.balloon)
                .HasDefaultValueSql("'否'")
                .HasColumnType("enum('是','否')");
            entity.Property(e => e.balloon_color1).HasColumnType("enum('金光系','銀光系','純光系','無')");
            entity.Property(e => e.balloon_color2).HasColumnType("enum('紅','橙','黃','綠','藍','靛','紫')");
            entity.Property(e => e.created_at)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.message_board)
                .HasDefaultValueSql("'否'")
                .HasColumnType("enum('是','否')");
            entity.Property(e => e.message_board_color1).HasColumnType("enum('金光系','銀光系','純光系','無')");
            entity.Property(e => e.message_board_color2).HasColumnType("enum('紅','橙','黃','綠','藍','靛','紫')");

            entity.HasOne(d => d.participant).WithMany(p => p.color_preferences)
                .HasForeignKey(d => d.participant_id)
                .HasConstraintName("color_preferences_ibfk_1");
        });

        modelBuilder.Entity<exhibition>(entity =>
        {
            entity.HasKey(e => new { e.userId, e.attendanceDate }).HasName("PRIMARY");

            entity.Property(e => e.userId).HasMaxLength(50);
            entity.Property(e => e.attendanceDate).HasColumnType("date");
            entity.Property(e => e.color).HasMaxLength(20);
            entity.Property(e => e.colorGroup).HasMaxLength(20);
        });

        modelBuilder.Entity<feedback>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.HasIndex(e => e.participant_id, "participant_id");

            entity.Property(e => e.color_choice).HasColumnType("enum('需要的','喜歡的','隨機的','其他')");
            entity.Property(e => e.color_choice_text).HasColumnType("text");
            entity.Property(e => e.created_at)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.feedback_text).HasColumnType("text");
            entity.Property(e => e.others).HasColumnType("text");
            entity.Property(e => e.promoter_observation).HasColumnType("text");
            entity.Property(e => e.satisfaction).HasColumnType("enum('水下下','水下','水上','水上上')");

            entity.HasOne(d => d.participant).WithMany(p => p.feedback)
                .HasForeignKey(d => d.participant_id)
                .HasConstraintName("feedback_ibfk_1");
        });

        modelBuilder.Entity<participants>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.Property(e => e.age_range).HasMaxLength(10);
            entity.Property(e => e.created_at)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.gender)
                .HasDefaultValueSql("'男'")
                .HasColumnType("enum('男','女')");
        });

        modelBuilder.Entity<social_check_in>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.HasIndex(e => e.participant_id, "participant_id");

            entity.Property(e => e.created_at)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.is_check_in)
                .HasDefaultValueSql("'否'")
                .HasColumnType("enum('是','否')");
            entity.Property(e => e.platform).HasColumnType("enum('LINE','FB','IG')");

            entity.HasOne(d => d.participant).WithMany(p => p.social_check_in)
                .HasForeignKey(d => d.participant_id)
                .HasConstraintName("social_check_in_ibfk_1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
