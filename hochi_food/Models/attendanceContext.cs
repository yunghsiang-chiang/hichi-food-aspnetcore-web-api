﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace hochi_food.Models;

public partial class attendanceContext : DbContext
{
    public attendanceContext(DbContextOptions<attendanceContext> options)
        : base(options)
    {
    }

    public virtual DbSet<h_attendance_day> h_attendance_day { get; set; }

    public virtual DbSet<h_attendance_infor> h_attendance_infor { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<h_attendance_day>(entity =>
        {
            entity.HasKey(e => new { e.user_name, e.attendance_day, e.attendance_state }).HasName("PRIMARY");

            entity.Property(e => e.user_name)
                .HasMaxLength(45)
                .HasComment("同修姓名");
            entity.Property(e => e.attendance_day)
                .HasComment("出勤日")
                .HasColumnType("date");
            entity.Property(e => e.attendance_state)
                .HasMaxLength(25)
                .HasComment("出勤狀態");
            entity.Property(e => e.consecutive_hours).HasComment("連續小時");
            entity.Property(e => e.morning_light_down).HasComment("晨光下");
            entity.Property(e => e.morning_light_up).HasComment("晨光上");
            entity.Property(e => e.morning_meeting).HasComment("晨會");
        });

        modelBuilder.Entity<h_attendance_infor>(entity =>
        {
            entity.HasKey(e => new { e.user_name, e.attendance_state, e.create_time }).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("歷史出勤資訊"));

            entity.Property(e => e.user_name)
                .HasMaxLength(25)
                .HasComment("同修姓名");
            entity.Property(e => e.attendance_state)
                .HasMaxLength(45)
                .HasComment("出勤狀態 跟網頁上按鈕狀態有關  隨者按鈕 擴增而增加");
            entity.Property(e => e.create_time)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("狀態起始時間  網頁按下按鈕的時間")
                .HasColumnType("datetime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}