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

    public virtual DbSet<Assignment> Assignment { get; set; }

    public virtual DbSet<ContactEvent> ContactEvent { get; set; }

    public virtual DbSet<DocumentLinks> DocumentLinks { get; set; }

    public virtual DbSet<DuplicateQueue> DuplicateQueue { get; set; }

    public virtual DbSet<HApplication> HApplication { get; set; }

    public virtual DbSet<HApplicationItem> HApplicationItem { get; set; }

    public virtual DbSet<HApplicationItemCC> HApplicationItemCC { get; set; }

    public virtual DbSet<HBlessedPerson> HBlessedPerson { get; set; }

    public virtual DbSet<HCCPeriod> HCCPeriod { get; set; }

    public virtual DbSet<HCCPeriodDetail> HCCPeriodDetail { get; set; }

    public virtual DbSet<HCoApplicant> HCoApplicant { get; set; }

    public virtual DbSet<HPhaseWindow> HPhaseWindow { get; set; }

    public virtual DbSet<HQuotaPlan> HQuotaPlan { get; set; }

    public virtual DbSet<HRegistrationBlessingDetailsV> HRegistrationBlessingDetailsV { get; set; }

    public virtual DbSet<HierarchyStructure> HierarchyStructure { get; set; }

    public virtual DbSet<HochiOrders> HochiOrders { get; set; }

    public virtual DbSet<Interactions> Interactions { get; set; }

    public virtual DbSet<NewFriend> NewFriend { get; set; }

    public virtual DbSet<NewFriendAssignment> NewFriendAssignment { get; set; }

    public virtual DbSet<OrderExportLog> OrderExportLog { get; set; }

    public virtual DbSet<People> People { get; set; }

    public virtual DbSet<Person> Person { get; set; }

    public virtual DbSet<ProfitSharing> ProfitSharing { get; set; }

    public virtual DbSet<ReasonCatalog> ReasonCatalog { get; set; }

    public virtual DbSet<TableSchema> TableSchema { get; set; }

    public virtual DbSet<UserReports> UserReports { get; set; }

    public virtual DbSet<dim_group> dim_group { get; set; }

    public virtual DbSet<dim_member> dim_member { get; set; }

    public virtual DbSet<event_contact_log> event_contact_log { get; set; }

    public virtual DbSet<person_identity> person_identity { get; set; }

    public virtual DbSet<v_active_nf_90d> v_active_nf_90d { get; set; }

    public virtual DbSet<v_crm_people_search> v_crm_people_search { get; set; }

    public virtual DbSet<v_event_contact_log> v_event_contact_log { get; set; }

    public virtual DbSet<v_first_attend> v_first_attend { get; set; }

    public virtual DbSet<v_first_attend_30d> v_first_attend_30d { get; set; }

    public virtual DbSet<v_first_attend_90d> v_first_attend_90d { get; set; }

    public virtual DbSet<v_first_attend_per_edu> v_first_attend_per_edu { get; set; }

    public virtual DbSet<v_first_done> v_first_done { get; set; }

    public virtual DbSet<v_first_touch> v_first_touch { get; set; }

    public virtual DbSet<v_funnel_30d> v_funnel_30d { get; set; }

    public virtual DbSet<v_kpi_coverage90> v_kpi_coverage90 { get; set; }

    public virtual DbSet<v_kpi_coverage90_area> v_kpi_coverage90_area { get; set; }

    public virtual DbSet<v_kpi_coverage90_by_scope> v_kpi_coverage90_by_scope { get; set; }

    public virtual DbSet<v_kpi_growth_conversion> v_kpi_growth_conversion { get; set; }

    public virtual DbSet<v_person_nf_to_edu> v_person_nf_to_edu { get; set; }

    public virtual DbSet<v_today_tpe> v_today_tpe { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Assignment>(entity =>
        {
            entity.HasKey(e => e.AssignId).HasName("PK__Assignme__9FFF4CAF61DC0C5F");

            entity.HasIndex(e => new { e.AssigneeId, e.ActiveFlag }, "IX_Assignment_Assignee");

            entity.HasIndex(e => e.PersonId, "IX_Assignment_Person").HasFilter("([ActiveFlag]=(1))");

            entity.Property(e => e.ActiveFlag).HasDefaultValue(true);
            entity.Property(e => e.AssignedAt)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.CreatedAt)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.Role).HasMaxLength(20);
            entity.Property(e => e.UnassignedAt).HasPrecision(0);
        });

        modelBuilder.Entity<ContactEvent>(entity =>
        {
            entity.HasKey(e => e.EventId).HasName("PK__ContactE__7944C8107870241E");

            entity.HasIndex(e => new { e.PersonId, e.EventTime }, "IX_ContactEvent_PersonTime").IsDescending(false, true);

            entity.Property(e => e.Channel).HasMaxLength(20);
            entity.Property(e => e.CreatedAt)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.EventTime).HasPrecision(0);
            entity.Property(e => e.EventType).HasMaxLength(30);
            entity.Property(e => e.ResultCode).HasMaxLength(50);
        });

        modelBuilder.Entity<DocumentLinks>(entity =>
        {
            entity.HasKey(e => e.DocId).HasName("PK__Document__3EF188AD1BDA9E6B");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FileUrl).HasMaxLength(500);
            entity.Property(e => e.Tag).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(120);
        });

        modelBuilder.Entity<DuplicateQueue>(entity =>
        {
            entity.HasKey(e => e.QueueId).HasName("PK__Duplicat__8324E715BC44ADA2");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Reason).HasMaxLength(200);
            entity.Property(e => e.Score).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasDefaultValue("待處理");
        });

        modelBuilder.Entity<HApplication>(entity =>
        {
            entity.HasKey(e => e.HId).HasName("PK__HApplica__C7551547556A6D16");

            entity.HasIndex(e => new { e.HApplicantHID, e.HPhase, e.HSubmitAt }, "IX_HApplication_Key").IsDescending(false, false, true);

            entity.Property(e => e.HApplicantHID).HasMaxLength(50);
            entity.Property(e => e.HAudioUrl).HasMaxLength(300);
            entity.Property(e => e.HBatchKey).HasMaxLength(20);
            entity.Property(e => e.HCoApplicantsNote).HasMaxLength(500);
            entity.Property(e => e.HMandateStatus).HasMaxLength(20);
            entity.Property(e => e.HMandateType).HasMaxLength(20);
            entity.Property(e => e.HPhase).HasMaxLength(16);
            entity.Property(e => e.HSubmitAt).HasDefaultValueSql("(sysutcdatetime())");
        });

        modelBuilder.Entity<HApplicationItem>(entity =>
        {
            entity.HasKey(e => e.HId).HasName("PK__HApplica__C755154728F46893");

            entity.HasIndex(e => e.HApplicationId, "IX_HApplicationItem_AppId");

            entity.HasIndex(e => e.HApplicantHID, "IX_HApplicationItem_ApplicantHID");

            entity.HasIndex(e => new { e.HStatus, e.HAssignedYear }, "IX_HApplicationItem_Status");

            entity.HasIndex(e => new { e.HApplicationId, e.HBlessedPersonId }, "UX_HApplicationItem_PersonId")
                .IsUnique()
                .HasFilter("([HBlessedPersonId] IS NOT NULL)");

            entity.HasIndex(e => new { e.HApplicationId, e.HBlessedPersonName }, "UX_HApplicationItem_PersonName").IsUnique();

            entity.Property(e => e.HBlessedPersonName).HasMaxLength(100);
            entity.Property(e => e.HLastEditAt).HasColumnType("datetime");
            entity.Property(e => e.HLockedAt).HasColumnType("datetime");
            entity.Property(e => e.HStatus).HasMaxLength(20);

            entity.HasOne(d => d.HBlessedPerson).WithMany(p => p.HApplicationItem)
                .HasForeignKey(d => d.HBlessedPersonId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_HApplicationItem_HBlessedPerson");
        });

        modelBuilder.Entity<HApplicationItemCC>(entity =>
        {
            entity.HasKey(e => e.HId).HasName("PK__HApplica__C755154723EE3792");

            entity.HasIndex(e => e.HCCPeriodCode, "IX_HApplicationItemCC_Period");

            entity.HasIndex(e => new { e.HApplicationItemId, e.HCCPeriodCode }, "UX_HApplicationItemCC_Item_Period").IsUnique();

            entity.Property(e => e.HCCPeriodCode).HasMaxLength(50);
            entity.Property(e => e.HCreatedAt)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.HUpdatedAt).HasPrecision(0);

            entity.HasOne(d => d.HApplicationItem).WithMany(p => p.HApplicationItemCC)
                .HasForeignKey(d => d.HApplicationItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HApplicationItemCC_Item");
        });

        modelBuilder.Entity<HBlessedPerson>(entity =>
        {
            entity.HasKey(e => e.HId).HasName("PK__HBlessed__C7551547ADD68A9A");

            entity.HasIndex(e => new { e.HLegalName, e.HAppealName }, "IX_HBlessedPerson_Name");

            entity.Property(e => e.HAppealName).HasMaxLength(50);
            entity.Property(e => e.HAudioUrl).HasMaxLength(300);
            entity.Property(e => e.HCounty).HasMaxLength(50);
            entity.Property(e => e.HCreatedAt)
                .HasDefaultValueSql("(sysutcdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.HCreatedByHID).HasMaxLength(50);
            entity.Property(e => e.HLegalName).HasMaxLength(50);
            entity.Property(e => e.HUpdatedAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<HCoApplicant>(entity =>
        {
            entity.HasKey(e => e.HId).HasName("PK__HCoAppli__C755154768E737B8");

            entity.HasIndex(e => e.HApplicationId, "IX_HCoApplicant_AppId");

            entity.HasIndex(e => e.HApplicationId, "IX_HCoApplicant_ApplicationId");

            entity.Property(e => e.HCoApplicantName).HasMaxLength(50);
            entity.Property(e => e.HDharmaSeat).HasMaxLength(100);
            entity.Property(e => e.HPeriod).HasMaxLength(50);
        });

        modelBuilder.Entity<HPhaseWindow>(entity =>
        {
            entity.HasKey(e => e.HId).HasName("PK__HPhaseWi__C7551547DEF5FFF2");

            entity.HasIndex(e => new { e.HYear, e.HPhase, e.HIsOpen, e.HOpenFrom, e.HOpenTo }, "IX_HPhaseWindow_Key");

            entity.Property(e => e.HAutoCloseOnFull).HasDefaultValue(true);
            entity.Property(e => e.HCreatedAt).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.HPhase).HasMaxLength(16);
            entity.Property(e => e.HTitle).HasMaxLength(100);
            entity.Property(e => e.HUpdatedAt).HasDefaultValueSql("(sysutcdatetime())");

            entity.HasOne(d => d.HQuotaPlan).WithMany(p => p.HPhaseWindow)
                .HasPrincipalKey(p => new { p.HYear, p.HPhase })
                .HasForeignKey(d => new { d.HYear, d.HPhase })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HPhaseWindow_Quota");
        });

        modelBuilder.Entity<HQuotaPlan>(entity =>
        {
            entity.HasKey(e => e.HId).HasName("PK__HQuotaPl__C7551547A7E09A63");

            entity.HasIndex(e => new { e.HYear, e.HPhase }, "UQ_HQuotaPlan").IsUnique();

            entity.Property(e => e.HAutoCloseOnFull).HasDefaultValue(true);
            entity.Property(e => e.HLastUpdated).HasDefaultValueSql("(getutcdate())");
            entity.Property(e => e.HPhase).HasMaxLength(16);
        });

        modelBuilder.Entity<HRegistrationBlessingDetailsV>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("HRegistrationBlessingDetailsV");

            entity.Property(e => e.HAppealName).HasMaxLength(50);
            entity.Property(e => e.HApplicantHID).HasMaxLength(50);
            entity.Property(e => e.HAudioUrl).HasMaxLength(300);
            entity.Property(e => e.HCoApplicants).HasMaxLength(4000);
            entity.Property(e => e.HCounty).HasMaxLength(50);
            entity.Property(e => e.HLegalName).HasMaxLength(50);
            entity.Property(e => e.HMandateStatus).HasMaxLength(20);
            entity.Property(e => e.HMandateType).HasMaxLength(20);
            entity.Property(e => e.HPhase).HasMaxLength(16);
            entity.Property(e => e.HRelation).HasMaxLength(50);
            entity.Property(e => e.HStatus).HasMaxLength(20);
        });

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

        modelBuilder.Entity<HochiOrders>(entity =>
        {
            entity.HasKey(e => new { e.OrderID, e.OrderDate, e.ProductCode }).HasName("PK__HochiOrd__C3905BAFDB4BCBE1");

            entity.Property(e => e.OrderID).HasMaxLength(30);
            entity.Property(e => e.OrderDate).HasColumnType("datetime");
            entity.Property(e => e.ProductCode).HasMaxLength(30);
            entity.Property(e => e.AdditionalFee).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Address1).HasMaxLength(255);
            entity.Property(e => e.Address2).HasMaxLength(255);
            entity.Property(e => e.AdminNote).HasMaxLength(255);
            entity.Property(e => e.CheckoutPrice).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.CheckoutPriceType).HasMaxLength(20);
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.CreditUsed).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Currency).HasMaxLength(10);
            entity.Property(e => e.Discount).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.DistributionPoint).HasMaxLength(50);
            entity.Property(e => e.InvoiceAddress).HasMaxLength(255);
            entity.Property(e => e.IsPreOrder)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.OrderNote).HasMaxLength(255);
            entity.Property(e => e.OrderStatus).HasMaxLength(20);
            entity.Property(e => e.OrderTotal).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMethod).HasMaxLength(50);
            entity.Property(e => e.PaymentOrderID).HasMaxLength(30);
            entity.Property(e => e.PaymentStatus).HasMaxLength(20);
            entity.Property(e => e.PaymentTotal).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.PostalCode).HasMaxLength(10);
            entity.Property(e => e.ProductName).HasMaxLength(100);
            entity.Property(e => e.ProductOption).HasMaxLength(50);
            entity.Property(e => e.ProductPrice).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ProductType).HasMaxLength(20);
            entity.Property(e => e.RecipientName).HasMaxLength(50);
            entity.Property(e => e.RecipientPhone).HasMaxLength(20);
            entity.Property(e => e.ShippingFee).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ShippingMethod).HasMaxLength(50);
            entity.Property(e => e.ShippingStatus).HasMaxLength(20);
            entity.Property(e => e.SourceOrderID).HasMaxLength(30);
            entity.Property(e => e.StateOrRegion).HasMaxLength(50);
            entity.Property(e => e.StoreName).HasMaxLength(50);
            entity.Property(e => e.Subtotal).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.TaxID)
                .HasMaxLength(8)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Interactions>(entity =>
        {
            entity.HasKey(e => e.InteractionId).HasName("PK__Interact__922C0496E9AFBD8D");

            entity.HasIndex(e => new { e.Method, e.CreatedAt }, "IX_Interactions_Method_CreatedAt");

            entity.HasIndex(e => new { e.NewFriendId, e.CreatedAt }, "IX_Interactions_NewFriendId_CreatedAt");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IntentLevel).HasMaxLength(20);
            entity.Property(e => e.Memo).HasMaxLength(1000);
            entity.Property(e => e.Method).HasMaxLength(20);
            entity.Property(e => e.NextAction).HasMaxLength(100);
        });

        modelBuilder.Entity<NewFriend>(entity =>
        {
            entity.HasKey(e => e.NewFriendId).HasName("PK__NewFrien__BD7BF62ED0E580F1");

            entity.HasIndex(e => e.FullNameNorm, "IX_NewFriend_FullNameNorm");

            entity.HasIndex(e => e.MobilePhone, "IX_NewFriend_MobilePhone")
                .IsUnique()
                .HasFilter("([MobilePhone] IS NOT NULL)");

            entity.Property(e => e.Address).HasMaxLength(200);
            entity.Property(e => e.City).HasMaxLength(20);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.District).HasMaxLength(20);
            entity.Property(e => e.Email).HasMaxLength(120);
            entity.Property(e => e.FullName).HasMaxLength(50);
            entity.Property(e => e.FullNameNorm).HasMaxLength(50);
            entity.Property(e => e.LineUserId).HasMaxLength(64);
            entity.Property(e => e.MobilePhone).HasMaxLength(20);
            entity.Property(e => e.Stage)
                .HasMaxLength(20)
                .HasDefaultValue("潛在");
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<NewFriendAssignment>(entity =>
        {
            entity.HasKey(e => e.AssignmentId).HasName("PK__NewFrien__32499E77DDA9907A");

            entity.HasIndex(e => new { e.NewFriendId, e.FirstMetAt }, "IX_NewFriendAssignment_NewFriendId_FirstMetAt");

            entity.Property(e => e.Channel).HasMaxLength(30);
            entity.Property(e => e.FirstMetAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Note).HasMaxLength(500);
        });

        modelBuilder.Entity<OrderExportLog>(entity =>
        {
            entity.HasKey(e => e.ExportID).HasName("PK__OrderExp__E5C997A47B99247D");

            entity.Property(e => e.ExportTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FileName).HasMaxLength(255);
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.SourceSystem).HasMaxLength(50);
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

        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasKey(e => e.PersonId).HasName("PK__Person__AA2FFBE5704F8FF3");

            entity.HasIndex(e => new { e.GroupRegion, e.GroupArea, e.GroupName }, "IX_Person_GroupPath");

            entity.HasIndex(e => new { e.Name, e.BirthDate }, "IX_Person_NameBirth");

            entity.HasIndex(e => e.PhoneNorm, "IX_Person_PhoneNorm").HasFilter("([PhoneNorm] IS NOT NULL)");

            entity.Property(e => e.Address).HasMaxLength(200);
            entity.Property(e => e.City).HasMaxLength(30);
            entity.Property(e => e.CreatedAt)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.District).HasMaxLength(30);
            entity.Property(e => e.Email).HasMaxLength(120);
            entity.Property(e => e.Gender).HasMaxLength(10);
            entity.Property(e => e.GroupArea).HasMaxLength(30);
            entity.Property(e => e.GroupName).HasMaxLength(50);
            entity.Property(e => e.GroupRegion).HasMaxLength(30);
            entity.Property(e => e.LineId).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.PhoneNorm).HasMaxLength(20);
            entity.Property(e => e.Source).HasMaxLength(50);
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasDefaultValue("在名單");
            entity.Property(e => e.UpdatedAt).HasPrecision(0);
        });

        modelBuilder.Entity<ProfitSharing>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.DistributionPoint).HasMaxLength(50);
            entity.Property(e => e.ProfitSharingPoint).HasMaxLength(50);
        });

        modelBuilder.Entity<ReasonCatalog>(entity =>
        {
            entity.HasKey(e => e.ReasonCode).HasName("PK__ReasonCa__A6278DA235E68DF7");

            entity.ToTable("ReasonCatalog", "crm");

            entity.Property(e => e.ReasonCode).HasMaxLength(50);
            entity.Property(e => e.Category).HasMaxLength(30);
            entity.Property(e => e.CreatedAt)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.ReasonName).HasMaxLength(50);
            entity.Property(e => e.UpdatedAt).HasPrecision(0);
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

        modelBuilder.Entity<dim_group>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("dim_group");

            entity.Property(e => e.node_name).HasMaxLength(255);
            entity.Property(e => e.node_type)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.parent_type)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<dim_member>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("dim_member");

            entity.Property(e => e.area_name).HasMaxLength(255);
            entity.Property(e => e.birth_text).HasMaxLength(50);
            entity.Property(e => e.full_name).HasMaxLength(255);
            entity.Property(e => e.larea_name).HasMaxLength(255);
            entity.Property(e => e.line_user_id).HasMaxLength(150);
            entity.Property(e => e.mobile_norm).HasMaxLength(50);
        });

        modelBuilder.Entity<event_contact_log>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("event_contact_log");

            entity.Property(e => e.event_ts).HasColumnType("datetime");
            entity.Property(e => e.event_type)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.intent_level).HasMaxLength(20);
            entity.Property(e => e.memo).HasMaxLength(1000);
            entity.Property(e => e.method).HasMaxLength(30);
            entity.Property(e => e.next_action).HasMaxLength(100);
        });

        modelBuilder.Entity<person_identity>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("person_identity");

            entity.Property(e => e.created_at).HasColumnType("datetime");
            entity.Property(e => e.dupe_key).HasMaxLength(255);
            entity.Property(e => e.full_name).HasMaxLength(255);
            entity.Property(e => e.full_name_norm).HasMaxLength(50);
            entity.Property(e => e.line_user_id).HasMaxLength(150);
            entity.Property(e => e.mobile_norm).HasMaxLength(50);
            entity.Property(e => e.person_key)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.src_table)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.updated_at).HasColumnType("datetime");
        });

        modelBuilder.Entity<v_active_nf_90d>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_active_nf_90d");
        });

        modelBuilder.Entity<v_crm_people_search>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_crm_people_search");

            entity.Property(e => e.Address).HasMaxLength(200);
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.District).HasMaxLength(50);
            entity.Property(e => e.full_name).HasMaxLength(255);
            entity.Property(e => e.mobile_norm).HasMaxLength(4000);
            entity.Property(e => e.source_type)
                .HasMaxLength(3)
                .IsUnicode(false);
        });

        modelBuilder.Entity<v_event_contact_log>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_event_contact_log");

            entity.Property(e => e.EventAt).HasColumnType("datetime");
            entity.Property(e => e.EventType).HasMaxLength(11);
            entity.Property(e => e.IntentLevel).HasMaxLength(20);
            entity.Property(e => e.Memo).HasMaxLength(1000);
            entity.Property(e => e.Method).HasMaxLength(20);
            entity.Property(e => e.NextAction).HasMaxLength(100);
        });

        modelBuilder.Entity<v_first_attend>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_first_attend");

            entity.Property(e => e.FirstAttendAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<v_first_attend_30d>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_first_attend_30d");
        });

        modelBuilder.Entity<v_first_attend_90d>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_first_attend_90d");
        });

        modelBuilder.Entity<v_first_attend_per_edu>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_first_attend_per_edu");

            entity.Property(e => e.first_attend_at).HasColumnType("datetime");
        });

        modelBuilder.Entity<v_first_done>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_first_done");

            entity.Property(e => e.FirstDoneAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<v_first_touch>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_first_touch");

            entity.Property(e => e.FirstTouchAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<v_funnel_30d>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_funnel_30d");
        });

        modelBuilder.Entity<v_kpi_coverage90>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_kpi_coverage90");

            entity.Property(e => e.Coverage90).HasColumnType("decimal(9, 4)");
        });

        modelBuilder.Entity<v_kpi_coverage90_area>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_kpi_coverage90_area");

            entity.Property(e => e.area_name).HasMaxLength(255);
            entity.Property(e => e.coverage90).HasColumnType("decimal(9, 4)");
            entity.Property(e => e.larea_name).HasMaxLength(255);
        });

        modelBuilder.Entity<v_kpi_coverage90_by_scope>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_kpi_coverage90_by_scope");

            entity.Property(e => e.Coverage90).HasColumnType("decimal(9, 4)");
        });

        modelBuilder.Entity<v_kpi_growth_conversion>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_kpi_growth_conversion");

            entity.Property(e => e.first_attend_rate).HasColumnType("decimal(9, 4)");
            entity.Property(e => e.window_tag)
                .HasMaxLength(3)
                .IsUnicode(false);
        });

        modelBuilder.Entity<v_person_nf_to_edu>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_person_nf_to_edu");

            entity.Property(e => e.mobile_norm).HasMaxLength(4000);
        });

        modelBuilder.Entity<v_today_tpe>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_today_tpe");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
