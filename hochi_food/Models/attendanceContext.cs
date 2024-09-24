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

    public virtual DbSet<c_attendance_times> c_attendance_times { get; set; }

    public virtual DbSet<c_leave_types> c_leave_types { get; set; }

    public virtual DbSet<c_overtime_settings> c_overtime_settings { get; set; }

    public virtual DbSet<c_prohibited_periods> c_prohibited_periods { get; set; }

    public virtual DbSet<c_user_roles> c_user_roles { get; set; }

    public virtual DbSet<h_attendance_day> h_attendance_day { get; set; }

    public virtual DbSet<h_attendance_infor> h_attendance_infor { get; set; }

    public virtual DbSet<h_attendance_record> h_attendance_record { get; set; }

    public virtual DbSet<h_leave_record> h_leave_record { get; set; }

    public virtual DbSet<h_notifications> h_notifications { get; set; }

    public virtual DbSet<h_overtime_record> h_overtime_record { get; set; }

    public virtual DbSet<h_ppprovalrecords> h_ppprovalrecords { get; set; }

    public virtual DbSet<r_person_vacation> r_person_vacation { get; set; }

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

        modelBuilder.Entity<c_attendance_times>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("定義公司全體員工的考勤時間"));

            entity.Property(e => e.id).HasComment("唯一的識別碼，自動增量");
            entity.Property(e => e.created_at)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("紀錄創建時間")
                .HasColumnType("timestamp");
            entity.Property(e => e.lunch_end_time)
                .HasComment("午休結束時間")
                .HasColumnType("time");
            entity.Property(e => e.lunch_start_time)
                .HasComment("午休開始時間")
                .HasColumnType("time");
            entity.Property(e => e.updated_at)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("紀錄最後更新時間")
                .HasColumnType("timestamp");
            entity.Property(e => e.work_end_time)
                .HasComment("正常下班時間")
                .HasColumnType("time");
            entity.Property(e => e.work_start_time)
                .HasComment("定義正常的上班時間")
                .HasColumnType("time");
        });

        modelBuilder.Entity<c_leave_types>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.Property(e => e.id).HasComment("唯一的識別碼，自動增量");
            entity.Property(e => e.created_at)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("紀錄該紀錄的創建時間")
                .HasColumnType("timestamp");
            entity.Property(e => e.description)
                .HasMaxLength(255)
                .HasComment("對該請假類型的詳細描述");
            entity.Property(e => e.max_days).HasComment("每年可請的最大天數，便於系統自動計算剩餘可請假天數");
            entity.Property(e => e.type_name)
                .HasMaxLength(50)
                .HasComment("請假類型的名稱，例如「病假」、「事假」、「年假」等");
            entity.Property(e => e.updated_at)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("紀錄該紀錄的最後更新時間")
                .HasColumnType("timestamp");
        });

        modelBuilder.Entity<c_overtime_settings>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.Property(e => e.id).HasComment("唯一的識別碼，自動增量");
            entity.Property(e => e.created_at)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("紀錄該紀錄的創建時間")
                .HasColumnType("timestamp");
            entity.Property(e => e.description)
                .HasMaxLength(255)
                .HasComment("對該加班類型的詳細描述");
            entity.Property(e => e.overtime_type)
                .HasMaxLength(50)
                .HasComment("加班的類型，如「平日加班」、「假日加班」");
            entity.Property(e => e.rate)
                .HasPrecision(5)
                .HasComment("加班的計算比例，例如平日加班為1.5倍，假日加班為2倍");
            entity.Property(e => e.updated_at)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("紀錄該紀錄的最後更新時間")
                .HasColumnType("timestamp");
        });

        modelBuilder.Entity<c_prohibited_periods>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("設定禁止異動的期間"));

            entity.Property(e => e.id).HasComment("唯一的識別碼，自動增量，方便進行查詢和管理");
            entity.Property(e => e.created_at)
                .HasComment("紀錄該紀錄的創建時間，方便日後查詢和審計")
                .HasColumnType("datetime");
            entity.Property(e => e.end_date)
                .HasComment("設定禁止異動的結束日期，通常是在計算薪資或特定會計期間的結束")
                .HasColumnType("date");
            entity.Property(e => e.reason)
                .HasMaxLength(255)
                .HasComment("記錄禁止異動的原因，例如「月末薪資計算」、「年度報表準備」等");
            entity.Property(e => e.start_date)
                .HasComment("設定禁止異動的開始日期，通常是在計算薪資或特定會計期間的開始")
                .HasColumnType("date");
            entity.Property(e => e.updated_at)
                .HasComment("紀錄該紀錄的最後更新時間，以便追踪修改歷史")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<c_user_roles>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("這個表用來管理用戶的角色及其對應的訪問權限"));

            entity.Property(e => e.id).HasComment("唯一的識別碼，自動增量");
            entity.Property(e => e.created_at)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("紀錄該紀錄的創建時間")
                .HasColumnType("timestamp");
            entity.Property(e => e.permissions)
                .HasComment("記錄角色擁有的訪問權限，以 JSON 格式儲存方便解析")
                .HasColumnType("text");
            entity.Property(e => e.role_name)
                .HasMaxLength(50)
                .HasComment("角色的名稱，例如「HR」、「管理者」、「員工」");
            entity.Property(e => e.updated_at)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("紀錄該紀錄的最後更新時間")
                .HasColumnType("timestamp");
        });

        modelBuilder.Entity<h_attendance_day>(entity =>
        {
            entity.HasKey(e => new { e.attendance_day, e.user_id }).HasName("PRIMARY");

            entity.Property(e => e.attendance_day)
                .HasComment("出勤日")
                .HasColumnType("date");
            entity.Property(e => e.user_id)
                .HasMaxLength(45)
                .HasComment("同修 ID");
            entity.Property(e => e.morning_light_down).HasComment("晨光下");
            entity.Property(e => e.morning_light_up).HasComment("晨光上");
            entity.Property(e => e.morning_meeting).HasComment("晨會");
            entity.Property(e => e.user_name)
                .HasMaxLength(45)
                .HasComment("同修姓名");
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
            entity.Property(e => e.approved_by)
                .HasMaxLength(45)
                .HasComment("審核人");
            entity.Property(e => e.count_hours).HasComment("小時數(浮點)");
            entity.Property(e => e.endTime)
                .HasComment("結束時間")
                .HasColumnType("datetime");
            entity.Property(e => e.submitted_at)
                .HasComment("提交日期")
                .HasColumnType("datetime");
            entity.Property(e => e.userName)
                .HasMaxLength(45)
                .HasComment("姓名");
        });

        modelBuilder.Entity<h_notifications>(entity =>
        {
            entity.HasKey(e => e.notification_id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("出勤內部公告"));

            entity.Property(e => e.notification_id)
                .HasMaxLength(10)
                .HasComment("主鍵 (PK)");
            entity.Property(e => e.content)
                .HasMaxLength(1000)
                .HasComment("通知內容 (可使用 HTML 格式)");
            entity.Property(e => e.created_at)
                .HasComment("創建日期 (記錄通知發布的時間)")
                .HasColumnType("datetime");
            entity.Property(e => e.created_by)
                .HasMaxLength(45)
                .HasComment("外鍵 (FK) 連結至 Employees 表，表示發布通知的員工");
            entity.Property(e => e.expires_at)
                .HasComment("到期日期 (可選，用於設定通知的有效期限)")
                .HasColumnType("datetime");
            entity.Property(e => e.recipient_group)
                .HasMaxLength(45)
                .HasComment("受眾群組 (如：所有員工、特定部門等，可選)");
            entity.Property(e => e.status)
                .HasMaxLength(15)
                .HasComment("通知狀態 (如：啟用、停用)");
            entity.Property(e => e.title)
                .HasMaxLength(100)
                .HasComment("通知標題");
            entity.Property(e => e.updated_at)
                .HasComment("更新日期 (如果通知內容需要修改)")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<h_overtime_record>(entity =>
        {
            entity.HasKey(e => new { e.userID, e.startTime }).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("歷史加班紀錄"));

            entity.Property(e => e.userID)
                .HasMaxLength(45)
                .HasComment("ID");
            entity.Property(e => e.startTime)
                .HasComment("開始時間")
                .HasColumnType("datetime");
            entity.Property(e => e.approved_by)
                .HasMaxLength(45)
                .HasComment("審核人");
            entity.Property(e => e.count_hours).HasComment("小時數");
            entity.Property(e => e.endTime)
                .HasComment("結束時間")
                .HasColumnType("datetime");
            entity.Property(e => e.overtimeType)
                .HasMaxLength(45)
                .HasComment("加班類型");
            entity.Property(e => e.submitted_at)
                .HasComment("提交日期")
                .HasColumnType("datetime");
            entity.Property(e => e.userName)
                .HasMaxLength(45)
                .HasComment("姓名");
        });

        modelBuilder.Entity<h_ppprovalrecords>(entity =>
        {
            entity.HasKey(e => e.approval_id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("歷史簽核紀錄"));

            entity.Property(e => e.approval_id)
                .HasMaxLength(45)
                .HasComment("主鍵");
            entity.Property(e => e.approval_date)
                .HasComment("簽核日期")
                .HasColumnType("datetime");
            entity.Property(e => e.approved_by)
                .HasMaxLength(45)
                .HasComment("審核人");
            entity.Property(e => e.request_id)
                .HasMaxLength(45)
                .HasComment("請假或加班申請的 ID");
            entity.Property(e => e.request_type)
                .HasMaxLength(10)
                .HasComment("假或加班的類型");
            entity.Property(e => e.status)
                .HasMaxLength(10)
                .HasComment("簽核狀態");
        });

        modelBuilder.Entity<r_person_vacation>(entity =>
        {
            entity.HasKey(e => e.person_id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("休假即時表"));

            entity.Property(e => e.person_id)
                .HasMaxLength(45)
                .HasComment("ID");
            entity.Property(e => e.compensatory_leave_hours).HasComment("補休");
            entity.Property(e => e.person_name)
                .HasMaxLength(45)
                .HasComment("姓名");
            entity.Property(e => e.personal_leave_hours).HasComment("事假");
            entity.Property(e => e.special_vacation_hours).HasComment("特休時數");
            entity.Property(e => e.start_work)
                .HasComment("到職日")
                .HasColumnType("date");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
