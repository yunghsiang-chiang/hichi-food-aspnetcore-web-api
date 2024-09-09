using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace hochi_food.Models;

public partial class attendanceContext : DbContext
{
    public attendanceContext(DbContextOptions<attendanceContext> options)
        : base(options)
    {
    }

    public virtual DbSet<c_attendance_calendar> c_attendance_calendar { get; set; }

    public virtual DbSet<h_attendance_day> h_attendance_day { get; set; }

    public virtual DbSet<h_attendance_infor> h_attendance_infor { get; set; }

    public virtual DbSet<h_attendance_record> h_attendance_record { get; set; }

    public virtual DbSet<h_leave_record> h_leave_record { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<c_attendance_calendar>(entity =>
        {
            entity.HasKey(e => new { e.calendar_year, e.calendar_month }).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("標記工作日"));

            entity.Property(e => e.calendar_year).HasComment("年");
            entity.Property(e => e.calendar_month).HasComment("月");
            entity.Property(e => e.attendance_days)
                .HasMaxLength(310)
                .HasComment("工作日");
        });

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

        modelBuilder.Entity<h_attendance_record>(entity =>
        {
            entity.HasKey(e => new { e.user_id, e.attendance_status, e.create_time }).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("出勤紀錄_詳細底層資料"));

            entity.Property(e => e.user_id)
                .HasMaxLength(15)
                .HasComment("ID 唯一碼");
            entity.Property(e => e.attendance_status)
                .HasMaxLength(45)
                .HasComment("狀態");
            entity.Property(e => e.create_time)
                .HasComment("時間")
                .HasColumnType("datetime");
            entity.Property(e => e.user_name)
                .HasMaxLength(45)
                .HasComment("姓名");
        });

        modelBuilder.Entity<h_leave_record>(entity =>
        {
            entity.HasKey(e => new { e.userId, e.startTime, e.leaveType }).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("請假紀錄"));

            entity.Property(e => e.userId)
                .HasMaxLength(45)
                .HasComment("使用者ID");
            entity.Property(e => e.startTime)
                .HasComment("起始時間")
                .HasColumnType("datetime");
            entity.Property(e => e.leaveType)
                .HasMaxLength(45)
                .HasComment("請假類型");
            entity.Property(e => e.count_hours).HasComment("小時數(浮點)");
            entity.Property(e => e.endTime)
                .HasComment("結束時間")
                .HasColumnType("datetime");
            entity.Property(e => e.userName)
                .HasMaxLength(45)
                .HasComment("姓名");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
