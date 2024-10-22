using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace hochi_food.Models;

public partial class heipContext : DbContext
{
    public heipContext(DbContextOptions<heipContext> options)
        : base(options)
    {
    }

    public virtual DbSet<_class> _class { get; set; }

    public virtual DbSet<alms> alms { get; set; }

    public virtual DbSet<avzone> avzone { get; set; }

    public virtual DbSet<avzonereply> avzonereply { get; set; }

    public virtual DbSet<bank> bank { get; set; }

    public virtual DbSet<blessedseal> blessedseal { get; set; }

    public virtual DbSet<blessedsealreply> blessedsealreply { get; set; }

    public virtual DbSet<blood> blood { get; set; }

    public virtual DbSet<bloodconnection> bloodconnection { get; set; }

    public virtual DbSet<broadcast> broadcast { get; set; }

    public virtual DbSet<buycdrecord> buycdrecord { get; set; }

    public virtual DbSet<centeraudio> centeraudio { get; set; }

    public virtual DbSet<classfee> classfee { get; set; }

    public virtual DbSet<classhouse> classhouse { get; set; }

    public virtual DbSet<classmember> classmember { get; set; }

    public virtual DbSet<classvacancy> classvacancy { get; set; }

    public virtual DbSet<codetype> codetype { get; set; }

    public virtual DbSet<codevalue> codevalue { get; set; }

    public virtual DbSet<course> course { get; set; }

    public virtual DbSet<course_his> course_his { get; set; }

    public virtual DbSet<courseapply> courseapply { get; set; }

    public virtual DbSet<courseatendence> courseatendence { get; set; }

    public virtual DbSet<coursedetail> coursedetail { get; set; }

    public virtual DbSet<coursefee> coursefee { get; set; }

    public virtual DbSet<coursemember> coursemember { get; set; }

    public virtual DbSet<coursepermit> coursepermit { get; set; }

    public virtual DbSet<coursezoom> coursezoom { get; set; }

    public virtual DbSet<dbsheet> dbsheet { get; set; }

    public virtual DbSet<dharmadailynews> dharmadailynews { get; set; }

    public virtual DbSet<dharmanews> dharmanews { get; set; }

    public virtual DbSet<donate> donate { get; set; }

    public virtual DbSet<donation> donation { get; set; }

    public virtual DbSet<donationrecord> donationrecord { get; set; }

    public virtual DbSet<donationrecord_2> donationrecord_2 { get; set; }

    public virtual DbSet<edu_psn_class> edu_psn_class { get; set; }

    public virtual DbSet<eipprogress> eipprogress { get; set; }

    public virtual DbSet<entourage> entourage { get; set; }

    public virtual DbSet<entouragereply> entouragereply { get; set; }

    public virtual DbSet<exhibition> exhibition { get; set; }

    public virtual DbSet<expense> expense { get; set; }

    public virtual DbSet<faq> faq { get; set; }

    public virtual DbSet<faqreply> faqreply { get; set; }

    public virtual DbSet<formquestions> formquestions { get; set; }

    public virtual DbSet<formquestionsdetail> formquestionsdetail { get; set; }

    public virtual DbSet<formquestionsitem> formquestionsitem { get; set; }

    public virtual DbSet<formquestiontscontent> formquestiontscontent { get; set; }

    public virtual DbSet<forms> forms { get; set; }

    public virtual DbSet<funcbase> funcbase { get; set; }

    public virtual DbSet<growthmatrix> growthmatrix { get; set; }

    public virtual DbSet<growthmatrixreply> growthmatrixreply { get; set; }

    public virtual DbSet<growthrecord> growthrecord { get; set; }

    public virtual DbSet<growthrecord_copy1> growthrecord_copy1 { get; set; }

    public virtual DbSet<growthrecordopen> growthrecordopen { get; set; }

    public virtual DbSet<growthrecordreply> growthrecordreply { get; set; }

    public virtual DbSet<growthrecordsummary> growthrecordsummary { get; set; }

    public virtual DbSet<grpfunc> grpfunc { get; set; }

    public virtual DbSet<grpuser> grpuser { get; set; }

    public virtual DbSet<hbquestion> hbquestion { get; set; }

    public virtual DbSet<hbquestionitem> hbquestionitem { get; set; }

    public virtual DbSet<hundredbase> hundredbase { get; set; }

    public virtual DbSet<hundredbasecontent> hundredbasecontent { get; set; }

    public virtual DbSet<hundredbasedetail> hundredbasedetail { get; set; }

    public virtual DbSet<issue> issue { get; set; }

    public virtual DbSet<laoshi> laoshi { get; set; }

    public virtual DbSet<laoshireply> laoshireply { get; set; }

    public virtual DbSet<localarea> localarea { get; set; }

    public virtual DbSet<localfee> localfee { get; set; }

    public virtual DbSet<mailfrom> mailfrom { get; set; }

    public virtual DbSet<mailto> mailto { get; set; }

    public virtual DbSet<mailtrash> mailtrash { get; set; }

    public virtual DbSet<managespread> managespread { get; set; }

    public virtual DbSet<managespreadreply> managespreadreply { get; set; }

    public virtual DbSet<mandate> mandate { get; set; }

    public virtual DbSet<mandatefile> mandatefile { get; set; }

    public virtual DbSet<mandatesupport> mandatesupport { get; set; }

    public virtual DbSet<meeting> meeting { get; set; }

    public virtual DbSet<meetingdetail> meetingdetail { get; set; }

    public virtual DbSet<memorialday> memorialday { get; set; }

    public virtual DbSet<memorialdayreply> memorialdayreply { get; set; }

    public virtual DbSet<morning> morning { get; set; }

    public virtual DbSet<new_psn> new_psn { get; set; }

    public virtual DbSet<newsmsg> newsmsg { get; set; }

    public virtual DbSet<parctice> parctice { get; set; }

    public virtual DbSet<parcticesummary> parcticesummary { get; set; }

    public virtual DbSet<partner> partner { get; set; }

    public virtual DbSet<partnerrecord> partnerrecord { get; set; }

    public virtual DbSet<personalguidelines> personalguidelines { get; set; }

    public virtual DbSet<photovideo> photovideo { get; set; }

    public virtual DbSet<photovideoreply> photovideoreply { get; set; }

    public virtual DbSet<points> points { get; set; }

    public virtual DbSet<pointsmonthrpt> pointsmonthrpt { get; set; }

    public virtual DbSet<practicetime> practicetime { get; set; }

    public virtual DbSet<progress> progress { get; set; }

    public virtual DbSet<psn_active_sc> psn_active_sc { get; set; }

    public virtual DbSet<psn_class_his> psn_class_his { get; set; }

    public virtual DbSet<psn_sc> psn_sc { get; set; }

    public virtual DbSet<psn_sick> psn_sick { get; set; }

    public virtual DbSet<readmessage> readmessage { get; set; }

    public virtual DbSet<readmessagecount> readmessagecount { get; set; }

    public virtual DbSet<report> report { get; set; }

    public virtual DbSet<reportcoursemn> reportcoursemn { get; set; }

    public virtual DbSet<reportreply> reportreply { get; set; }

    public virtual DbSet<rule> rule { get; set; }

    public virtual DbSet<sc_active> sc_active { get; set; }

    public virtual DbSet<sc_active_rec> sc_active_rec { get; set; }

    public virtual DbSet<sc_patient_rec> sc_patient_rec { get; set; }

    public virtual DbSet<sc_place> sc_place { get; set; }

    public virtual DbSet<sc_service_rec> sc_service_rec { get; set; }

    public virtual DbSet<sc_static> sc_static { get; set; }

    public virtual DbSet<sc_time> sc_time { get; set; }

    public virtual DbSet<sop> sop { get; set; }

    public virtual DbSet<sopfile> sopfile { get; set; }

    public virtual DbSet<sopreply> sopreply { get; set; }

    public virtual DbSet<syslog> syslog { get; set; }

    public virtual DbSet<sysparam> sysparam { get; set; }

    public virtual DbSet<sysuser> sysuser { get; set; }

    public virtual DbSet<sysuserbase> sysuserbase { get; set; }

    public virtual DbSet<sysuserhistory> sysuserhistory { get; set; }

    public virtual DbSet<teamapply> teamapply { get; set; }

    public virtual DbSet<teamapplyflow> teamapplyflow { get; set; }

    public virtual DbSet<teamapplymember> teamapplymember { get; set; }

    public virtual DbSet<teamoperation> teamoperation { get; set; }

    public virtual DbSet<teamoperationmember> teamoperationmember { get; set; }

    public virtual DbSet<teamtrans> teamtrans { get; set; }

    public virtual DbSet<totalfee> totalfee { get; set; }

    public virtual DbSet<view_readmessage> view_readmessage { get; set; }

    public virtual DbSet<vow> vow { get; set; }

    public virtual DbSet<vowdharma> vowdharma { get; set; }

    public virtual DbSet<vowverify> vowverify { get; set; }

    public virtual DbSet<words> words { get; set; }

    public virtual DbSet<x_calendar> x_calendar { get; set; }

    public virtual DbSet<x_coursesignin> x_coursesignin { get; set; }

    public virtual DbSet<x_courseuser> x_courseuser { get; set; }

    public virtual DbSet<x_donation> x_donation { get; set; }

    public virtual DbSet<x_duty> x_duty { get; set; }

    public virtual DbSet<x_dutylog> x_dutylog { get; set; }

    public virtual DbSet<x_epaper> x_epaper { get; set; }

    public virtual DbSet<x_epaper_st> x_epaper_st { get; set; }

    public virtual DbSet<x_epaperlog> x_epaperlog { get; set; }

    public virtual DbSet<x_mailfrom> x_mailfrom { get; set; }

    public virtual DbSet<x_mailreply> x_mailreply { get; set; }

    public virtual DbSet<x_mailto> x_mailto { get; set; }

    public virtual DbSet<x_training> x_training { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<_class>(entity =>
        {
            entity.HasKey(e => e.c_id).HasName("PRIMARY");

            entity.ToTable("class");

            entity.Property(e => e.c_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.c_area).HasMaxLength(600);
            entity.Property(e => e.c_begdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.c_category).HasColumnType("tinyint(11)");
            entity.Property(e => e.c_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.c_cname).HasMaxLength(40);
            entity.Property(e => e.c_desc).HasMaxLength(2000);
            entity.Property(e => e.c_diffdays)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.c_enddate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.c_grstatus)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(11)");
            entity.Property(e => e.c_ishouse).HasColumnType("tinyint(4)");
            entity.Property(e => e.c_iskeep)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(255)");
            entity.Property(e => e.c_name).HasMaxLength(200);
            entity.Property(e => e.c_sbegdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.c_senddate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.c_shortname)
                .HasMaxLength(200)
                .HasDefaultValueSql("''");
            entity.Property(e => e.c_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(11)");
            entity.Property(e => e.c_type)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(11)");
            entity.Property(e => e.c_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.c_uname).HasMaxLength(40);
            entity.Property(e => e.c_week).HasColumnType("tinyint(11) unsigned zerofill");
            entity.Property(e => e.c_weektime)
                .HasMaxLength(9)
                .IsFixedLength();
            entity.Property(e => e.old_class_id).HasMaxLength(12);
        });

        modelBuilder.Entity<alms>(entity =>
        {
            entity.HasKey(e => e.a_id).HasName("PRIMARY");

            entity.Property(e => e.a_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.a_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.a_cid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.a_cname).HasMaxLength(40);
            entity.Property(e => e.a_content).HasMaxLength(400);
            entity.Property(e => e.a_donateitem)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.a_money).HasColumnType("int(11)");
            entity.Property(e => e.a_object).HasMaxLength(40);
            entity.Property(e => e.a_rel).HasMaxLength(40);
            entity.Property(e => e.a_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(11)");
            entity.Property(e => e.a_type)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.a_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.a_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.a_uname).HasMaxLength(40);
        });

        modelBuilder.Entity<avzone>(entity =>
        {
            entity.HasKey(e => e.av_id).HasName("PRIMARY");

            entity.Property(e => e.av_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.av_begdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.av_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.av_cname).HasMaxLength(20);
            entity.Property(e => e.av_desc).HasMaxLength(200);
            entity.Property(e => e.av_enddate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.av_imp)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.av_impuser).HasColumnType("int(11)");
            entity.Property(e => e.av_len).HasMaxLength(10);
            entity.Property(e => e.av_link).HasMaxLength(255);
            entity.Property(e => e.av_pdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.av_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.av_title).HasMaxLength(200);
            entity.Property(e => e.av_type)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.av_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.av_uname).HasMaxLength(20);
        });

        modelBuilder.Entity<avzonereply>(entity =>
        {
            entity.HasKey(e => e.ar_id).HasName("PRIMARY");

            entity.Property(e => e.ar_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ar_avid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ar_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.ar_cname).HasMaxLength(40);
            entity.Property(e => e.ar_content).HasColumnType("text");
            entity.Property(e => e.ar_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.ar_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.ar_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ar_uname).HasMaxLength(40);
        });

        modelBuilder.Entity<bank>(entity =>
        {
            entity.HasKey(e => e.SEQ_NO).HasName("PRIMARY");

            entity.Property(e => e.SEQ_NO).HasColumnType("int(11)");
            entity.Property(e => e.AREA)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CK_FLAG)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.D_FLAG)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.MEMO).HasMaxLength(51);
            entity.Property(e => e.PAY).HasColumnType("int(11)");
            entity.Property(e => e.PAY_BANK).HasMaxLength(10);
            entity.Property(e => e.PAY_DATE)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.PAY_TIME)
                .HasMaxLength(6)
                .IsFixedLength();
            entity.Property(e => e.PAY_TYPE)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.PAY_TYPE_DESC).HasMaxLength(10);
            entity.Property(e => e.RECEPT_BANK)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.RECEPT_ID)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SYS_CODE)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.TXT_DATE)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.TXT_ID).HasMaxLength(12);
            entity.Property(e => e.TXT_TIME)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.status).HasColumnType("int(11)");
        });

        modelBuilder.Entity<blessedseal>(entity =>
        {
            entity.HasKey(e => e.bs_id).HasName("PRIMARY");

            entity.Property(e => e.bs_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.bs_apply)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(255)");
            entity.Property(e => e.bs_applydate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.bs_category).HasColumnType("tinyint(4)");
            entity.Property(e => e.bs_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.bs_cid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.bs_cname).HasMaxLength(40);
            entity.Property(e => e.bs_content).HasColumnType("text");
            entity.Property(e => e.bs_file1).HasMaxLength(30);
            entity.Property(e => e.bs_file2).HasMaxLength(30);
            entity.Property(e => e.bs_file3).HasMaxLength(30);
            entity.Property(e => e.bs_imp).HasColumnType("int(11)");
            entity.Property(e => e.bs_impuser).HasColumnType("int(11)");
            entity.Property(e => e.bs_iscurrent)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(255)");
            entity.Property(e => e.bs_no)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.bs_recorddate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.bs_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.bs_title).HasMaxLength(400);
            entity.Property(e => e.bs_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.bs_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.bs_uname).HasMaxLength(40);
            entity.Property(e => e.bs_url).HasMaxLength(200);
        });

        modelBuilder.Entity<blessedsealreply>(entity =>
        {
            entity.HasKey(e => e.bsr_id).HasName("PRIMARY");

            entity.Property(e => e.bsr_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.bsr_bsid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.bsr_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.bsr_cname).HasMaxLength(40);
            entity.Property(e => e.bsr_content).HasColumnType("text");
            entity.Property(e => e.bsr_file1).HasMaxLength(30);
            entity.Property(e => e.bsr_file2).HasMaxLength(30);
            entity.Property(e => e.bsr_file3).HasMaxLength(30);
            entity.Property(e => e.bsr_no).HasMaxLength(10);
            entity.Property(e => e.bsr_parent)
                .HasMaxLength(10)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.bsr_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.bsr_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.bsr_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.bsr_uname).HasMaxLength(40);
        });

        modelBuilder.Entity<blood>(entity =>
        {
            entity.HasKey(e => e.b_id).HasName("PRIMARY");

            entity.HasIndex(e => e.b_cid, "cid");

            entity.HasIndex(e => e.b_uid, "uid");

            entity.Property(e => e.b_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.b_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.b_cid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.b_cname).HasMaxLength(40);
            entity.Property(e => e.b_no)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.b_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.b_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.b_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.b_uname).HasMaxLength(40);
        });

        modelBuilder.Entity<bloodconnection>(entity =>
        {
            entity.HasKey(e => e.bc_id).HasName("PRIMARY");

            entity.HasIndex(e => e.bc_cid, "cid");

            entity.HasIndex(e => e.bc_uid, "uid");

            entity.Property(e => e.bc_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.bc_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.bc_cid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.bc_cname).HasMaxLength(40);
            entity.Property(e => e.bc_cno)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.bc_cuid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.bc_name).HasMaxLength(40);
            entity.Property(e => e.bc_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.bc_time).HasMaxLength(6);
            entity.Property(e => e.bc_times)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.bc_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.bc_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.bc_uname).HasMaxLength(40);
        });

        modelBuilder.Entity<broadcast>(entity =>
        {
            entity.HasKey(e => e.b_id).HasName("PRIMARY");

            entity.HasIndex(e => e.b_cdate, "idx_cdate");

            entity.HasIndex(e => e.b_istop, "idx_istop");

            entity.Property(e => e.b_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.b_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.b_cname).HasMaxLength(100);
            entity.Property(e => e.b_content).HasColumnType("text");
            entity.Property(e => e.b_file1).HasMaxLength(20);
            entity.Property(e => e.b_file1desc).HasMaxLength(200);
            entity.Property(e => e.b_file2).HasMaxLength(20);
            entity.Property(e => e.b_file2desc).HasMaxLength(200);
            entity.Property(e => e.b_file3).HasMaxLength(20);
            entity.Property(e => e.b_file3desc).HasMaxLength(200);
            entity.Property(e => e.b_file4).HasMaxLength(20);
            entity.Property(e => e.b_file4desc).HasMaxLength(200);
            entity.Property(e => e.b_file5).HasMaxLength(20);
            entity.Property(e => e.b_file5desc).HasMaxLength(200);
            entity.Property(e => e.b_imp).HasColumnType("int(200)");
            entity.Property(e => e.b_istop)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.b_no)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.b_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.b_subunitname).HasMaxLength(100);
            entity.Property(e => e.b_title).HasMaxLength(200);
            entity.Property(e => e.b_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.b_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.b_uname).HasMaxLength(40);
            entity.Property(e => e.b_unitname).HasMaxLength(100);
        });

        modelBuilder.Entity<buycdrecord>(entity =>
        {
            entity.HasKey(e => e.bcr_id).HasName("PRIMARY");

            entity.Property(e => e.bcr_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.bcr_applydate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.bcr_cddate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.bcr_cname).HasMaxLength(40);
            entity.Property(e => e.bcr_points)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.bcr_uid)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<centeraudio>(entity =>
        {
            entity.HasKey(e => e.ca_id).HasName("PRIMARY");

            entity.Property(e => e.ca_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ca_category)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.ca_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.ca_cname).HasMaxLength(20);
            entity.Property(e => e.ca_desc).HasMaxLength(200);
            entity.Property(e => e.ca_link).HasMaxLength(255);
            entity.Property(e => e.ca_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.ca_title).HasMaxLength(200);
            entity.Property(e => e.ca_type)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.ca_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.ca_uname).HasMaxLength(20);
        });

        modelBuilder.Entity<classfee>(entity =>
        {
            entity.HasKey(e => e.cf_id).HasName("PRIMARY");

            entity.Property(e => e.cf_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.cf_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.cf_cid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.cf_cname).HasMaxLength(40);
            entity.Property(e => e.cf_desc).HasMaxLength(100);
            entity.Property(e => e.cf_fee).HasColumnType("int(255)");
            entity.Property(e => e.cf_item).HasMaxLength(100);
            entity.Property(e => e.cf_status).HasColumnType("tinyint(4)");
            entity.Property(e => e.cf_type).HasColumnType("int(4)");
            entity.Property(e => e.cf_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.cf_uname).HasMaxLength(40);
        });

        modelBuilder.Entity<classhouse>(entity =>
        {
            entity.HasKey(e => e.ch_id).HasName("PRIMARY");

            entity.Property(e => e.ch_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ch_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.ch_cid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ch_cname).HasMaxLength(20);
            entity.Property(e => e.ch_sdate)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.ch_status).HasColumnType("tinyint(4)");
            entity.Property(e => e.ch_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.ch_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ch_uname).HasMaxLength(20);
        });

        modelBuilder.Entity<classmember>(entity =>
        {
            entity.HasKey(e => e.cm_id).HasName("PRIMARY");

            entity.Property(e => e.cm_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.cm_area)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.cm_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.cm_cid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.cm_cname).HasMaxLength(20);
            entity.Property(e => e.cm_desc).HasMaxLength(255);
            entity.Property(e => e.cm_fee).HasMaxLength(10);
            entity.Property(e => e.cm_house).HasMaxLength(50);
            entity.Property(e => e.cm_status).HasColumnType("tinyint(4)");
            entity.Property(e => e.cm_type)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.cm_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.cm_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.cm_uname).HasMaxLength(20);
        });

        modelBuilder.Entity<classvacancy>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.va_SC)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.va_TT)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.va_VT)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.va_classnote)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.va_clean).HasMaxLength(255);
            entity.Property(e => e.va_food).HasMaxLength(255);
            entity.Property(e => e.va_guide).HasMaxLength(255);
            entity.Property(e => e.va_id)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<codetype>(entity =>
        {
            entity.HasKey(e => e.CT_ID).HasName("PRIMARY");

            entity.Property(e => e.CT_ID)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CT_CONTENT).HasMaxLength(20);
            entity.Property(e => e.CT_NAME).HasMaxLength(10);
            entity.Property(e => e.CT_STATUS)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
        });

        modelBuilder.Entity<codevalue>(entity =>
        {
            entity.HasKey(e => e.CV_ID).HasName("PRIMARY");

            entity.Property(e => e.CV_ID)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CV_CDATE)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.CV_CONTENT1).HasMaxLength(100);
            entity.Property(e => e.CV_CONTENT2).HasMaxLength(200);
            entity.Property(e => e.CV_CTID)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CV_NAME).HasMaxLength(20);
            entity.Property(e => e.CV_ORDER).HasColumnType("int(11)");
            entity.Property(e => e.CV_PARENT)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CV_STATUS)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.CV_UDATE)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.CV_UNAME).HasMaxLength(20);
        });

        modelBuilder.Entity<course>(entity =>
        {
            entity.HasKey(e => e.c_id).HasName("PRIMARY");

            entity.Property(e => e.c_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.c_area).HasMaxLength(600);
            entity.Property(e => e.c_begdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.c_category).HasColumnType("tinyint(11)");
            entity.Property(e => e.c_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.c_cname).HasMaxLength(40);
            entity.Property(e => e.c_desc).HasMaxLength(2000);
            entity.Property(e => e.c_diffdays)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.c_enddate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.c_grstatus)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(11)");
            entity.Property(e => e.c_ishouse).HasColumnType("tinyint(4)");
            entity.Property(e => e.c_iskeep)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(255)");
            entity.Property(e => e.c_name).HasMaxLength(200);
            entity.Property(e => e.c_sbegdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.c_senddate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.c_shortname)
                .HasMaxLength(200)
                .HasDefaultValueSql("''");
            entity.Property(e => e.c_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(11)");
            entity.Property(e => e.c_type)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(11)");
            entity.Property(e => e.c_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.c_uname).HasMaxLength(40);
            entity.Property(e => e.c_week).HasColumnType("tinyint(11) unsigned zerofill");
            entity.Property(e => e.c_weektime)
                .HasMaxLength(9)
                .IsFixedLength();
        });

        modelBuilder.Entity<course_his>(entity =>
        {
            entity.HasKey(e => e.c_id).HasName("PRIMARY");

            entity.Property(e => e.c_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.c_name).HasMaxLength(200);
            entity.Property(e => e.c_status).HasColumnType("tinyint(11)");
        });

        modelBuilder.Entity<courseapply>(entity =>
        {
            entity.HasKey(e => e.ca_id).HasName("PRIMARY");

            entity.Property(e => e.ca_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ca_aid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ca_areaname).HasMaxLength(20);
            entity.Property(e => e.ca_category)
                .IsRequired()
                .HasDefaultValueSql("'1'");
            entity.Property(e => e.ca_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.ca_classarea).HasMaxLength(100);
            entity.Property(e => e.ca_cname).HasMaxLength(20);
            entity.Property(e => e.ca_coursebegdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.ca_courseenddate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.ca_coursename).HasMaxLength(100);
            entity.Property(e => e.ca_file1).HasMaxLength(20);
            entity.Property(e => e.ca_file2).HasMaxLength(20);
            entity.Property(e => e.ca_mname).HasMaxLength(20);
            entity.Property(e => e.ca_section).HasMaxLength(10);
            entity.Property(e => e.ca_status).HasColumnType("tinyint(4)");
            entity.Property(e => e.ca_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.ca_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ca_uname).HasMaxLength(20);
        });

        modelBuilder.Entity<courseatendence>(entity =>
        {
            entity.HasKey(e => e.ca_id).HasName("PRIMARY");

            entity.Property(e => e.ca_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ca_begdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.ca_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.ca_cid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ca_cname).HasMaxLength(40);
            entity.Property(e => e.ca_desc).HasMaxLength(200);
            entity.Property(e => e.ca_duty)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.ca_enddate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.ca_iskeep)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(255)");
            entity.Property(e => e.ca_onlydate)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.ca_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.ca_type)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.ca_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.ca_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ca_uname).HasMaxLength(40);
        });

        modelBuilder.Entity<coursedetail>(entity =>
        {
            entity.HasKey(e => e.cd_id).HasName("PRIMARY");

            entity.Property(e => e.cd_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.cd_category).HasMaxLength(80);
            entity.Property(e => e.cd_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.cd_cid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.cd_cname).HasMaxLength(20);
            entity.Property(e => e.cd_coursedate)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.cd_desc).HasMaxLength(200);
            entity.Property(e => e.cd_link).HasMaxLength(255);
            entity.Property(e => e.cd_order)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.cd_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.cd_title).HasMaxLength(200);
            entity.Property(e => e.cd_type)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.cd_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.cd_uname).HasMaxLength(20);
            entity.Property(e => e.cd_week)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.cd_weekname).HasMaxLength(40);
        });

        modelBuilder.Entity<coursefee>(entity =>
        {
            entity.HasKey(e => e.cf_id).HasName("PRIMARY");

            entity.Property(e => e.cf_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.cf_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.cf_cid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.cf_cname).HasMaxLength(40);
            entity.Property(e => e.cf_desc).HasMaxLength(100);
            entity.Property(e => e.cf_fee).HasColumnType("int(255)");
            entity.Property(e => e.cf_item).HasMaxLength(100);
            entity.Property(e => e.cf_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.cf_type)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.cf_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.cf_uname).HasMaxLength(40);
        });

        modelBuilder.Entity<coursemember>(entity =>
        {
            entity.HasKey(e => e.cm_id).HasName("PRIMARY");

            entity.HasIndex(e => e.cm_cid, "cid");

            entity.HasIndex(e => e.cm_uid, "uid");

            entity.Property(e => e.cm_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.cm_DaysData)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.cm_area)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.cm_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.cm_cid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.cm_cname).HasMaxLength(20);
            entity.Property(e => e.cm_ctype).HasColumnType("tinyint(4)");
            entity.Property(e => e.cm_desc).HasMaxLength(200);
            entity.Property(e => e.cm_fee).HasMaxLength(10);
            entity.Property(e => e.cm_idData)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.cm_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.cm_type)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.cm_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.cm_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.cm_uname).HasMaxLength(20);
        });

        modelBuilder.Entity<coursepermit>(entity =>
        {
            entity.HasKey(e => e.cp_id).HasName("PRIMARY");

            entity.Property(e => e.cp_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.cp_begdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.cp_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.cp_cid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.cp_cname).HasMaxLength(40);
            entity.Property(e => e.cp_enddate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.cp_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.cp_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.cp_uname).HasMaxLength(40);
        });

        modelBuilder.Entity<coursezoom>(entity =>
        {
            entity.HasKey(e => e.cz_id).HasName("PRIMARY");

            entity.Property(e => e.cz_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.cz_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.cz_cid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.cz_cname).HasMaxLength(40);
            entity.Property(e => e.cz_date)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.cz_desc).HasMaxLength(200);
            entity.Property(e => e.cz_line1).HasMaxLength(40);
            entity.Property(e => e.cz_line2).HasMaxLength(40);
            entity.Property(e => e.cz_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(255)");
            entity.Property(e => e.cz_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.cz_uname).HasMaxLength(40);
        });

        modelBuilder.Entity<dbsheet>(entity =>
        {
            entity.HasKey(e => new { e.DONATE_KIND, e.this_year }).HasName("PRIMARY");

            entity.Property(e => e.DONATE_KIND)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.this_year)
                .HasMaxLength(4)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.A_balance).HasColumnType("int(11)");
            entity.Property(e => e.balance).HasColumnType("int(11)");
            entity.Property(e => e.balance0).HasColumnType("int(8)");
            entity.Property(e => e.donate).HasColumnType("int(11)");
            entity.Property(e => e.expense).HasColumnType("int(11)");
            entity.Property(e => e.memo).HasMaxLength(60);
            entity.Property(e => e.status).HasColumnType("int(11)");
        });

        modelBuilder.Entity<dharmadailynews>(entity =>
        {
            entity.HasKey(e => e.ddn_id).HasName("PRIMARY");

            entity.Property(e => e.ddn_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ddn_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.ddn_cname).HasMaxLength(40);
            entity.Property(e => e.ddn_content).HasColumnType("text");
            entity.Property(e => e.ddn_couldurl).HasMaxLength(400);
            entity.Property(e => e.ddn_date)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.ddn_desc).HasMaxLength(1000);
            entity.Property(e => e.ddn_file1).HasMaxLength(20);
            entity.Property(e => e.ddn_pdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.ddn_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.ddn_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.ddn_uname).HasMaxLength(40);
        });

        modelBuilder.Entity<dharmanews>(entity =>
        {
            entity.HasKey(e => e.dn_id).HasName("PRIMARY");

            entity.Property(e => e.dn_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.dn_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.dn_cname).HasMaxLength(40);
            entity.Property(e => e.dn_content).HasMaxLength(4000);
            entity.Property(e => e.dn_imp).HasColumnType("int(11)");
            entity.Property(e => e.dn_len)
                .HasMaxLength(10)
                .HasDefaultValueSql("''");
            entity.Property(e => e.dn_link)
                .HasMaxLength(200)
                .HasDefaultValueSql("''");
            entity.Property(e => e.dn_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.dn_title).HasMaxLength(200);
            entity.Property(e => e.dn_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.dn_uname).HasMaxLength(40);
        });

        modelBuilder.Entity<donate>(entity =>
        {
            entity.HasKey(e => new { e.PSN_ID, e.GIVE_SEQ_NO }).HasName("PRIMARY");

            entity.Property(e => e.PSN_ID).HasMaxLength(12);
            entity.Property(e => e.GIVE_SEQ_NO).HasColumnType("int(11)");
            entity.Property(e => e.AREA)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.AREA_RECEPT_NO).HasMaxLength(12);
            entity.Property(e => e.ATM_NO)
                .HasMaxLength(5)
                .IsFixedLength();
            entity.Property(e => e.A_RECEPT_NO).HasMaxLength(12);
            entity.Property(e => e.CLASS_ID).HasMaxLength(12);
            entity.Property(e => e.DONATE_CLASS).HasMaxLength(3);
            entity.Property(e => e.DONATE_KIND)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.F_FLAG)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.GIVE).HasColumnType("int(11)");
            entity.Property(e => e.GIVE_BANK).HasMaxLength(20);
            entity.Property(e => e.GIVE_DATE)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.GIVE_TYPE)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.G_FLAG)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.NAME).HasMaxLength(40);
            entity.Property(e => e.P_FLAG)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.PsnId_from)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.RECEIVE_DATE)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.RECEPT_NO).HasMaxLength(8);
            entity.Property(e => e.SEQ_NO).HasColumnType("int(11)");
            entity.Property(e => e.STATE)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.TITLE).HasMaxLength(100);
            entity.Property(e => e.TXT_DATE)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.TXT_ID).HasMaxLength(12);
            entity.Property(e => e.TXT_NAME).HasMaxLength(40);
            entity.Property(e => e.memo).HasMaxLength(400);
            entity.Property(e => e.status).HasColumnType("int(11)");
        });

        modelBuilder.Entity<donation>(entity =>
        {
            entity.HasKey(e => e.DT_ID).HasName("PRIMARY");

            entity.Property(e => e.DT_ID)
                .HasMaxLength(10)
                .HasDefaultValueSql("''");
            entity.Property(e => e.AREA).HasMaxLength(10);
            entity.Property(e => e.CONTENT).HasMaxLength(2000);
            entity.Property(e => e.DATE)
                .HasMaxLength(8)
                .HasDefaultValueSql("''");
            entity.Property(e => e.DONATE_KIND).HasMaxLength(10);
            entity.Property(e => e.DONATION_1).HasMaxLength(1000);
            entity.Property(e => e.DONATION_2).HasMaxLength(1000);
            entity.Property(e => e.DONATION_3).HasMaxLength(1000);
            entity.Property(e => e.DONATION_CLASS)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.ELEMENT_1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("smallint(6)");
            entity.Property(e => e.ELEMENT_2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("smallint(6)");
            entity.Property(e => e.ELEMENT_3)
                .HasDefaultValueSql("'0'")
                .HasColumnType("smallint(6)");
            entity.Property(e => e.ELEMENT_4)
                .HasDefaultValueSql("'0'")
                .HasColumnType("smallint(6)");
            entity.Property(e => e.ELEMENT_5)
                .HasDefaultValueSql("'0'")
                .HasColumnType("smallint(6)");
            entity.Property(e => e.ELEMENT_6)
                .HasDefaultValueSql("'0'")
                .HasColumnType("smallint(6)");
            entity.Property(e => e.ELEMENT_7)
                .HasDefaultValueSql("'0'")
                .HasColumnType("smallint(6)");
            entity.Property(e => e.GIVE)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.KINSFOLK).HasMaxLength(40);
            entity.Property(e => e.OTHER_DONATE_KIND).HasMaxLength(20);
            entity.Property(e => e.OTHER_GIVE)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.PSN_ID).HasMaxLength(12);
            entity.Property(e => e.QTY)
                .HasDefaultValueSql("'0'")
                .HasColumnType("smallint(6)");
            entity.Property(e => e.RELATION).HasMaxLength(10);
            entity.Property(e => e.SEQ_NO).HasColumnType("int(11)");
            entity.Property(e => e.STATE)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.TXT_DATE)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.stage)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.status).HasColumnType("int(11)");
        });

        modelBuilder.Entity<donationrecord>(entity =>
        {
            entity.HasKey(e => e.d_id).HasName("PRIMARY");

            entity.Property(e => e.d_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.d_actual)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.d_datetime)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.d_unit).HasColumnType("int(10)");
            entity.Property(e => e.d_wish)
                .HasMaxLength(20)
                .IsFixedLength();
        });

        modelBuilder.Entity<donationrecord_2>(entity =>
        {
            entity.HasKey(e => e.dd_id).HasName("PRIMARY");

            entity.Property(e => e.dd_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.dd_1)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.dd_2)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.dd_3)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.dd_4)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.dd_5)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.dd_6)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.dd_actual)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.dd_datetime)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.dd_final)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.dd_four)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.dd_type)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.dd_unfour)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.dd_unit).HasColumnType("int(10)");
            entity.Property(e => e.dd_wish)
                .HasMaxLength(20)
                .IsFixedLength();
        });

        modelBuilder.Entity<edu_psn_class>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.age).HasColumnType("int(4)");
            entity.Property(e => e.area_name).HasMaxLength(20);
            entity.Property(e => e.sex_name)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.u_name).HasMaxLength(40);
            entity.Property(e => e.u_period)
                .HasMaxLength(4)
                .IsFixedLength();
        });

        modelBuilder.Entity<eipprogress>(entity =>
        {
            entity.HasKey(e => e.ep_id).HasName("PRIMARY");

            entity.Property(e => e.ep_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ep_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.ep_cname).HasMaxLength(40);
            entity.Property(e => e.ep_content).HasMaxLength(4000);
            entity.Property(e => e.ep_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.ep_title).HasMaxLength(200);
            entity.Property(e => e.ep_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.ep_uname).HasMaxLength(40);
        });

        modelBuilder.Entity<entourage>(entity =>
        {
            entity.HasKey(e => e.e_id).HasName("PRIMARY");

            entity.HasIndex(e => e.e_uid, "uid");

            entity.Property(e => e.e_id).IsFixedLength();
            entity.Property(e => e.e_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.e_cname).HasMaxLength(40);
            entity.Property(e => e.e_content).HasColumnType("text");
            entity.Property(e => e.e_file1).HasMaxLength(20);
            entity.Property(e => e.e_file2).HasMaxLength(20);
            entity.Property(e => e.e_file3).HasMaxLength(20);
            entity.Property(e => e.e_imp).HasColumnType("int(11)");
            entity.Property(e => e.e_no)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.e_recorddate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.e_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.e_title).HasMaxLength(200);
            entity.Property(e => e.e_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.e_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.e_uname).HasMaxLength(40);
        });

        modelBuilder.Entity<entouragereply>(entity =>
        {
            entity.HasKey(e => e.er_id).HasName("PRIMARY");

            entity.Property(e => e.er_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.er_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.er_cname).HasMaxLength(40);
            entity.Property(e => e.er_content).HasColumnType("text");
            entity.Property(e => e.er_eid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.er_file1).HasMaxLength(20);
            entity.Property(e => e.er_file2).HasMaxLength(20);
            entity.Property(e => e.er_file3).HasMaxLength(20);
            entity.Property(e => e.er_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.er_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.er_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.er_uname).HasMaxLength(40);
        });

        modelBuilder.Entity<exhibition>(entity =>
        {
            entity.HasKey(e => new { e.userId, e.attendanceDate }).HasName("PRIMARY");

            entity.Property(e => e.userId).HasMaxLength(50);
            entity.Property(e => e.attendanceDate).HasColumnType("date");
            entity.Property(e => e.color).HasMaxLength(20);
            entity.Property(e => e.colorGroup).HasMaxLength(20);
        });

        modelBuilder.Entity<expense>(entity =>
        {
            entity.HasKey(e => new { e.SPEND_DATE, e.SPEND_SEQ_NO }).HasName("PRIMARY");

            entity.Property(e => e.SPEND_DATE)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.SPEND_SEQ_NO).HasColumnType("int(11)");
            entity.Property(e => e.DESCRIPT).HasMaxLength(1000);
            entity.Property(e => e.DONATE_KIND)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.FEE_CODE)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.FRAME)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.PAY_KIND)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.SPEND).HasColumnType("int(11)");
            entity.Property(e => e.TXT_DATE)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.TXT_ID).HasMaxLength(12);
            entity.Property(e => e.TXT_NAME).HasMaxLength(40);
            entity.Property(e => e.status).HasColumnType("int(11)");
        });

        modelBuilder.Entity<faq>(entity =>
        {
            entity.HasKey(e => e.faq_id).HasName("PRIMARY");

            entity.Property(e => e.faq_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.faq_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.faq_cname).HasMaxLength(40);
            entity.Property(e => e.faq_content).HasColumnType("text");
            entity.Property(e => e.faq_file1).HasMaxLength(30);
            entity.Property(e => e.faq_file2).HasMaxLength(30);
            entity.Property(e => e.faq_file3).HasMaxLength(30);
            entity.Property(e => e.faq_imp).HasColumnType("int(11)");
            entity.Property(e => e.faq_impuser).HasColumnType("int(11)");
            entity.Property(e => e.faq_isclosed).HasColumnType("tinyint(11)");
            entity.Property(e => e.faq_level)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.faq_no)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(4)");
            entity.Property(e => e.faq_referral).HasMaxLength(400);
            entity.Property(e => e.faq_sid)
                .HasMaxLength(10)
                .HasDefaultValueSql("'0'")
                .IsFixedLength();
            entity.Property(e => e.faq_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.faq_title).HasMaxLength(400);
            entity.Property(e => e.faq_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.faq_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.faq_uname).HasMaxLength(40);
            entity.Property(e => e.faq_url).HasMaxLength(200);
        });

        modelBuilder.Entity<faqreply>(entity =>
        {
            entity.HasKey(e => e.faqr_id).HasName("PRIMARY");

            entity.Property(e => e.faqr_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.faqr_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.faqr_cname).HasMaxLength(40);
            entity.Property(e => e.faqr_content).HasColumnType("text");
            entity.Property(e => e.faqr_faqid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.faqr_file1).HasMaxLength(30);
            entity.Property(e => e.faqr_file2).HasMaxLength(30);
            entity.Property(e => e.faqr_file3).HasMaxLength(30);
            entity.Property(e => e.faqr_parent)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.faqr_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(11)");
            entity.Property(e => e.faqr_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.faqr_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.faqr_uname).HasMaxLength(40);
        });

        modelBuilder.Entity<formquestions>(entity =>
        {
            entity.HasKey(e => e.fq_id).HasName("PRIMARY");

            entity.HasIndex(e => e.fq_cid, "cid");

            entity.Property(e => e.fq_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.fq_begdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.fq_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.fq_cid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.fq_cname).HasMaxLength(40);
            entity.Property(e => e.fq_desc).HasMaxLength(400);
            entity.Property(e => e.fq_enddate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.fq_foreword).HasMaxLength(400);
            entity.Property(e => e.fq_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.fq_title).HasMaxLength(200);
            entity.Property(e => e.fq_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.fq_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.fq_uname).HasMaxLength(40);
        });

        modelBuilder.Entity<formquestionsdetail>(entity =>
        {
            entity.HasKey(e => e.fqd_id).HasName("PRIMARY");

            entity.HasIndex(e => e.fqd_fqid, "fqid");

            entity.HasIndex(e => e.fqd_uid, "uid");

            entity.Property(e => e.fqd_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.fqd_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.fqd_cname).HasMaxLength(40);
            entity.Property(e => e.fqd_fqid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.fqd_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.fqd_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.fqd_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.fqd_uname).HasMaxLength(40);
        });

        modelBuilder.Entity<formquestionsitem>(entity =>
        {
            entity.HasKey(e => e.fqi_id).HasName("PRIMARY");

            entity.HasIndex(e => e.fqi_fqid, "fqid");

            entity.Property(e => e.fqi_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.fqi_desc).HasMaxLength(200);
            entity.Property(e => e.fqi_fqid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.fqi_name).HasMaxLength(200);
            entity.Property(e => e.fqi_no)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.fqi_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.fqi_type).HasColumnType("tinyint(4)");
            entity.Property(e => e.fqi_value).HasMaxLength(200);
        });

        modelBuilder.Entity<formquestiontscontent>(entity =>
        {
            entity.HasKey(e => e.fqc_id).HasName("PRIMARY");

            entity.HasIndex(e => e.fqc_fqdid, "fqdid");

            entity.HasIndex(e => e.fqc_fqiid, "fqiid");

            entity.Property(e => e.fqc_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.fqc_content).HasMaxLength(6000);
            entity.Property(e => e.fqc_fqdid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.fqc_fqiid)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<forms>(entity =>
        {
            entity.HasKey(e => e.f_id).HasName("PRIMARY");

            entity.Property(e => e.f_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.f_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.f_cname).HasMaxLength(20);
            entity.Property(e => e.f_desc).HasMaxLength(200);
            entity.Property(e => e.f_filename).HasMaxLength(20);
            entity.Property(e => e.f_no).HasMaxLength(20);
            entity.Property(e => e.f_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.f_title).HasMaxLength(100);
            entity.Property(e => e.f_type)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.f_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.f_uname).HasMaxLength(20);
            entity.Property(e => e.f_unit)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.f_version).HasMaxLength(20);
        });

        modelBuilder.Entity<funcbase>(entity =>
        {
            entity.HasKey(e => e.F_ID).HasName("PRIMARY");

            entity.HasIndex(e => e.F_ORDER, "idx_order");

            entity.HasIndex(e => e.F_PARENT, "idx_parent");

            entity.HasIndex(e => e.F_STATUS, "idx_status");

            entity.Property(e => e.F_ID)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.F_BGCOLOR).HasMaxLength(20);
            entity.Property(e => e.F_CDATE)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.F_CLASS).HasMaxLength(20);
            entity.Property(e => e.F_CNAME).HasMaxLength(20);
            entity.Property(e => e.F_ICON).HasMaxLength(20);
            entity.Property(e => e.F_LINK).HasMaxLength(200);
            entity.Property(e => e.F_NAME).HasMaxLength(80);
            entity.Property(e => e.F_NEW)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.F_NOTE).HasMaxLength(200);
            entity.Property(e => e.F_ORDER).HasColumnType("int(11)");
            entity.Property(e => e.F_PARENT)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.F_STATUS).HasColumnType("int(11)");
            entity.Property(e => e.F_TARGET)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.F_UDATE)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.F_UNAME).HasMaxLength(20);
        });

        modelBuilder.Entity<growthmatrix>(entity =>
        {
            entity.HasKey(e => e.gm_id).HasName("PRIMARY");

            entity.HasIndex(e => e.gm_status, "gm_status");

            entity.Property(e => e.gm_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.gm_category)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.gm_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.gm_cname).HasMaxLength(40);
            entity.Property(e => e.gm_content).HasColumnType("text");
            entity.Property(e => e.gm_file1).HasMaxLength(20);
            entity.Property(e => e.gm_file2).HasMaxLength(20);
            entity.Property(e => e.gm_file3).HasMaxLength(20);
            entity.Property(e => e.gm_imp).HasColumnType("int(11)");
            entity.Property(e => e.gm_impuser)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.gm_recorddate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.gm_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.gm_title).HasMaxLength(200);
            entity.Property(e => e.gm_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.gm_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.gm_uname).HasMaxLength(40);
        });

        modelBuilder.Entity<growthmatrixreply>(entity =>
        {
            entity.HasKey(e => new { e.gmr_id, e.gmr_lid, e.gmr_uid }).HasName("PRIMARY");

            entity.Property(e => e.gmr_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.gmr_lid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.gmr_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.gmr_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.gmr_cname).HasMaxLength(40);
            entity.Property(e => e.gmr_content).HasColumnType("text");
            entity.Property(e => e.gmr_file1).HasMaxLength(20);
            entity.Property(e => e.gmr_file2).HasMaxLength(20);
            entity.Property(e => e.gmr_file3).HasMaxLength(20);
            entity.Property(e => e.gmr_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.gmr_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.gmr_uname).HasMaxLength(40);
        });

        modelBuilder.Entity<growthrecord>(entity =>
        {
            entity.HasKey(e => e.gr_id).HasName("PRIMARY");

            entity.HasIndex(e => e.gr_cid, "cid");

            entity.HasIndex(e => e.gr_type, "idx_type");

            entity.HasIndex(e => e.gr_recorddate, "rdate");

            entity.HasIndex(e => e.gr_status, "status");

            entity.HasIndex(e => e.gr_uid, "uid");

            entity.Property(e => e.gr_id)
                .HasMaxLength(10)
                .HasDefaultValueSql("'0'")
                .IsFixedLength();
            entity.Property(e => e.gr_category).HasColumnType("tinyint(4)");
            entity.Property(e => e.gr_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.gr_cid)
                .HasMaxLength(10)
                .HasDefaultValueSql("'1'")
                .IsFixedLength();
            entity.Property(e => e.gr_cname).HasMaxLength(40);
            entity.Property(e => e.gr_content1).HasColumnType("text");
            entity.Property(e => e.gr_content2).HasColumnType("text");
            entity.Property(e => e.gr_dharma)
                .HasMaxLength(10)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.gr_dharmaname)
                .HasMaxLength(40)
                .HasDefaultValueSql("''");
            entity.Property(e => e.gr_file1).HasMaxLength(40);
            entity.Property(e => e.gr_file2).HasMaxLength(40);
            entity.Property(e => e.gr_file3).HasMaxLength(40);
            entity.Property(e => e.gr_grid).HasColumnType("tinyint(4)");
            entity.Property(e => e.gr_grid2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.gr_imp).HasColumnType("int(11)");
            entity.Property(e => e.gr_impuser).HasColumnType("tinyint(4)");
            entity.Property(e => e.gr_label).HasMaxLength(200);
            entity.Property(e => e.gr_lid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.gr_lrid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.gr_no)
                .HasMaxLength(10)
                .HasDefaultValueSql("'1'");
            entity.Property(e => e.gr_recorddate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.gr_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.gr_title).HasMaxLength(200);
            entity.Property(e => e.gr_type).HasColumnType("int(11)");
            entity.Property(e => e.gr_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.gr_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.gr_uname).HasMaxLength(40);
        });

        modelBuilder.Entity<growthrecord_copy1>(entity =>
        {
            entity.HasKey(e => e.gr_id).HasName("PRIMARY");

            entity.HasIndex(e => e.gr_cid, "cid");

            entity.HasIndex(e => e.gr_type, "idx_type");

            entity.HasIndex(e => e.gr_recorddate, "rdate");

            entity.HasIndex(e => e.gr_status, "status");

            entity.HasIndex(e => e.gr_uid, "uid");

            entity.Property(e => e.gr_id)
                .HasMaxLength(10)
                .HasDefaultValueSql("'0'")
                .IsFixedLength();
            entity.Property(e => e.gr_category).HasColumnType("tinyint(4)");
            entity.Property(e => e.gr_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.gr_cid)
                .HasMaxLength(10)
                .HasDefaultValueSql("'1'")
                .IsFixedLength();
            entity.Property(e => e.gr_cname).HasMaxLength(40);
            entity.Property(e => e.gr_content1).HasColumnType("text");
            entity.Property(e => e.gr_content2).HasColumnType("text");
            entity.Property(e => e.gr_dharma)
                .HasMaxLength(10)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.gr_dharmaname)
                .HasMaxLength(40)
                .HasDefaultValueSql("''");
            entity.Property(e => e.gr_file1).HasMaxLength(40);
            entity.Property(e => e.gr_file2).HasMaxLength(40);
            entity.Property(e => e.gr_file3).HasMaxLength(40);
            entity.Property(e => e.gr_grid).HasColumnType("tinyint(4)");
            entity.Property(e => e.gr_grid2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.gr_imp).HasColumnType("int(11)");
            entity.Property(e => e.gr_impuser).HasColumnType("tinyint(4)");
            entity.Property(e => e.gr_label).HasMaxLength(200);
            entity.Property(e => e.gr_lid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.gr_lrid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.gr_no)
                .HasMaxLength(10)
                .HasDefaultValueSql("'1'");
            entity.Property(e => e.gr_recorddate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.gr_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.gr_title).HasMaxLength(200);
            entity.Property(e => e.gr_type).HasColumnType("int(11)");
            entity.Property(e => e.gr_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.gr_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.gr_uname).HasMaxLength(40);
        });

        modelBuilder.Entity<growthrecordopen>(entity =>
        {
            entity.HasKey(e => e.gro_id).HasName("PRIMARY");

            entity.Property(e => e.gro_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.gro_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.gro_cname).HasMaxLength(40);
            entity.Property(e => e.gro_grid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.gro_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.gro_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.gro_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.gro_uname).HasMaxLength(40);
        });

        modelBuilder.Entity<growthrecordreply>(entity =>
        {
            entity.HasKey(e => e.grr_id).HasName("PRIMARY");

            entity.HasIndex(e => e.grr_grid, "grid");

            entity.HasIndex(e => e.grr_id, "grrid");

            entity.HasIndex(e => e.grr_status, "grstatus");

            entity.HasIndex(e => e.grr_uid, "gruid");

            entity.Property(e => e.grr_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.grr_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.grr_cname).HasMaxLength(40);
            entity.Property(e => e.grr_content).HasColumnType("text");
            entity.Property(e => e.grr_file1).HasMaxLength(30);
            entity.Property(e => e.grr_file2).HasMaxLength(30);
            entity.Property(e => e.grr_file3).HasMaxLength(30);
            entity.Property(e => e.grr_grid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.grr_lrid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.grr_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.grr_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.grr_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.grr_uname).HasMaxLength(40);
        });

        modelBuilder.Entity<growthrecordsummary>(entity =>
        {
            entity.HasKey(e => e.grs_id).HasName("PRIMARY");

            entity.Property(e => e.grs_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.grs_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.grs_cname).HasMaxLength(40);
            entity.Property(e => e.grs_content).HasMaxLength(4000);
            entity.Property(e => e.grs_recorddate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.grs_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.grs_suid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.grs_type)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.grs_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.grs_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.grs_uname).HasMaxLength(40);
        });

        modelBuilder.Entity<grpfunc>(entity =>
        {
            entity.HasKey(e => e.GF_ID).HasName("PRIMARY");

            entity.HasIndex(e => e.GF_FID, "idx_fid");

            entity.HasIndex(e => e.GF_GID, "idx_gid");

            entity.Property(e => e.GF_ID)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.GF_ADD).HasColumnType("tinyint(4)");
            entity.Property(e => e.GF_DEL).HasColumnType("tinyint(4)");
            entity.Property(e => e.GF_FID)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.GF_GID)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.GF_LIST).HasColumnType("tinyint(4)");
            entity.Property(e => e.GF_MOD).HasColumnType("tinyint(4)");
        });

        modelBuilder.Entity<grpuser>(entity =>
        {
            entity.HasKey(e => e.gu_id).HasName("PRIMARY");

            entity.HasIndex(e => new { e.gu_gid, e.gu_uid, e.gu_status }, "idx_gu");

            entity.Property(e => e.gu_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.gu_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.gu_cname).HasMaxLength(40);
            entity.Property(e => e.gu_gid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.gu_status).HasColumnType("tinyint(11)");
            entity.Property(e => e.gu_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.gu_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.gu_uname).HasMaxLength(40);
        });

        modelBuilder.Entity<hbquestion>(entity =>
        {
            entity.HasKey(e => e.hbq_id).HasName("PRIMARY");

            entity.Property(e => e.hbq_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.hbq_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.hbq_cname).HasMaxLength(40);
            entity.Property(e => e.hbq_desc).HasMaxLength(400);
            entity.Property(e => e.hbq_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.hbq_title).HasMaxLength(200);
            entity.Property(e => e.hbq_type).HasColumnType("tinyint(4)");
            entity.Property(e => e.hbq_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.hbq_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.hbq_uname).HasMaxLength(40);
        });

        modelBuilder.Entity<hbquestionitem>(entity =>
        {
            entity.HasKey(e => e.hbqi_id).HasName("PRIMARY");

            entity.Property(e => e.hbqi_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.hbqi_desc).HasMaxLength(200);
            entity.Property(e => e.hbqi_hbqid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.hbqi_ismust)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.hbqi_no)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.hbqi_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.hbqi_subno).HasColumnType("tinyint(4)");
            entity.Property(e => e.hbqi_title).HasMaxLength(200);
            entity.Property(e => e.hbqi_type)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.hbqi_value).HasMaxLength(800);
        });

        modelBuilder.Entity<hundredbase>(entity =>
        {
            entity.HasKey(e => e.hb_id).HasName("PRIMARY");

            entity.HasIndex(e => e.hb_uid, "uid");

            entity.Property(e => e.hb_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.hb_begdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.hb_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.hb_cname).HasMaxLength(40);
            entity.Property(e => e.hb_enddate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.hb_expdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.hb_hbqid)
                .HasMaxLength(10)
                .HasDefaultValueSql("'0'")
                .IsFixedLength();
            entity.Property(e => e.hb_notes).HasMaxLength(200);
            entity.Property(e => e.hb_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.hb_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.hb_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.hb_uname).HasMaxLength(40);
        });

        modelBuilder.Entity<hundredbasecontent>(entity =>
        {
            entity.HasKey(e => e.hbc_id).HasName("PRIMARY");

            entity.Property(e => e.hbc_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.hbc_content).HasMaxLength(1000);
            entity.Property(e => e.hbc_hbdid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.hbc_hbqiid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.hbc_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
        });

        modelBuilder.Entity<hundredbasedetail>(entity =>
        {
            entity.HasKey(e => e.hbd_id).HasName("PRIMARY");

            entity.Property(e => e.hbd_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.hbd_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.hbd_cname).HasMaxLength(40);
            entity.Property(e => e.hbd_content).HasColumnType("text");
            entity.Property(e => e.hbd_hbid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.hbd_hbqid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.hbd_no)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.hbd_recorddate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.hbd_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.hbd_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.hbd_uname).HasMaxLength(40);
        });

        modelBuilder.Entity<issue>(entity =>
        {
            entity.HasKey(e => e.i_id).HasName("PRIMARY");

            entity.HasIndex(e => e.i_uid, "uid");

            entity.Property(e => e.i_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.i_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.i_cname).HasMaxLength(40);
            entity.Property(e => e.i_content).HasColumnType("text");
            entity.Property(e => e.i_email).HasMaxLength(200);
            entity.Property(e => e.i_rcontent).HasMaxLength(200);
            entity.Property(e => e.i_rdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.i_rname).HasMaxLength(40);
            entity.Property(e => e.i_status).HasColumnType("int(11)");
            entity.Property(e => e.i_title).HasMaxLength(100);
            entity.Property(e => e.i_type).HasColumnType("int(11)");
            entity.Property(e => e.i_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.i_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.i_uname).HasMaxLength(40);
        });

        modelBuilder.Entity<laoshi>(entity =>
        {
            entity.HasKey(e => e.l_id).HasName("PRIMARY");

            entity.HasIndex(e => e.l_category, "idx_category");

            entity.HasIndex(e => e.l_no, "idx_no");

            entity.HasIndex(e => e.l_recorddate, "idx_recorddate");

            entity.HasIndex(e => e.l_status, "idx_status");

            entity.Property(e => e.l_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.l_apply)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(255)");
            entity.Property(e => e.l_attcat).HasMaxLength(20);
            entity.Property(e => e.l_category).HasColumnType("tinyint(4)");
            entity.Property(e => e.l_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.l_class).HasMaxLength(100);
            entity.Property(e => e.l_classlevel).HasColumnType("tinyint(4)");
            entity.Property(e => e.l_cname).HasMaxLength(40);
            entity.Property(e => e.l_content).HasColumnType("text");
            entity.Property(e => e.l_contentcat).HasMaxLength(20);
            entity.Property(e => e.l_dharmacat).HasMaxLength(20);
            entity.Property(e => e.l_file1).HasMaxLength(30);
            entity.Property(e => e.l_file2).HasMaxLength(30);
            entity.Property(e => e.l_file3).HasMaxLength(30);
            entity.Property(e => e.l_filelength).HasMaxLength(10);
            entity.Property(e => e.l_imp).HasColumnType("int(11)");
            entity.Property(e => e.l_impuser).HasColumnType("int(11)");
            entity.Property(e => e.l_iscurrent)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.l_isgr)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(255)");
            entity.Property(e => e.l_no)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(4)");
            entity.Property(e => e.l_place).HasMaxLength(100);
            entity.Property(e => e.l_question)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(255)");
            entity.Property(e => e.l_recorddate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.l_reply)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(255)");
            entity.Property(e => e.l_rq).HasColumnType("int(11)");
            entity.Property(e => e.l_share)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(255)");
            entity.Property(e => e.l_speakdate).HasMaxLength(20);
            entity.Property(e => e.l_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.l_subno).HasMaxLength(10);
            entity.Property(e => e.l_thank)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(255)");
            entity.Property(e => e.l_title).HasMaxLength(400);
            entity.Property(e => e.l_titleabstract).HasMaxLength(100);
            entity.Property(e => e.l_titlecat).HasMaxLength(20);
            entity.Property(e => e.l_today)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(255)");
            entity.Property(e => e.l_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.l_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.l_uname).HasMaxLength(40);
            entity.Property(e => e.l_url).HasMaxLength(200);
        });

        modelBuilder.Entity<laoshireply>(entity =>
        {
            entity.HasKey(e => e.lr_id).HasName("PRIMARY");

            entity.HasIndex(e => e.lr_lid, "lid");

            entity.HasIndex(e => e.lr_uid, "uid");

            entity.Property(e => e.lr_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.lr_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.lr_cname).HasMaxLength(40);
            entity.Property(e => e.lr_content).HasColumnType("text");
            entity.Property(e => e.lr_copynote).HasMaxLength(400);
            entity.Property(e => e.lr_file1).HasMaxLength(30);
            entity.Property(e => e.lr_file2).HasMaxLength(30);
            entity.Property(e => e.lr_file3).HasMaxLength(30);
            entity.Property(e => e.lr_isshowdaily).HasColumnType("tinyint(4)");
            entity.Property(e => e.lr_lid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.lr_no).HasMaxLength(10);
            entity.Property(e => e.lr_parent)
                .HasMaxLength(10)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.lr_q).HasColumnType("tinyint(4)");
            entity.Property(e => e.lr_qno)
                .HasMaxLength(10)
                .HasDefaultValueSql("''");
            entity.Property(e => e.lr_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(11)");
            entity.Property(e => e.lr_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.lr_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.lr_uname).HasMaxLength(40);
            entity.Property(e => e.lr_yqno)
                .HasMaxLength(10)
                .HasDefaultValueSql("''");
        });

        modelBuilder.Entity<localarea>(entity =>
        {
            entity.HasKey(e => new { e.area, e.this_year, e.DONATE_KIND }).HasName("PRIMARY");

            entity.Property(e => e.area)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.this_year)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.DONATE_KIND)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.in_01).HasColumnType("int(11)");
            entity.Property(e => e.in_02).HasColumnType("int(11)");
            entity.Property(e => e.in_03).HasColumnType("int(11)");
            entity.Property(e => e.in_04).HasColumnType("int(11)");
            entity.Property(e => e.in_05).HasColumnType("int(11)");
            entity.Property(e => e.in_06).HasColumnType("int(11)");
            entity.Property(e => e.in_07).HasColumnType("int(11)");
            entity.Property(e => e.in_08).HasColumnType("int(11)");
            entity.Property(e => e.in_09).HasColumnType("int(11)");
            entity.Property(e => e.in_10).HasColumnType("int(11)");
            entity.Property(e => e.in_11).HasColumnType("int(11)");
            entity.Property(e => e.in_12).HasColumnType("int(11)");
            entity.Property(e => e.seq_no).HasColumnType("smallint(6)");
            entity.Property(e => e.status).HasColumnType("int(11)");
        });

        modelBuilder.Entity<localfee>(entity =>
        {
            entity.HasKey(e => new { e.area, e.this_year, e.FEE_CODE }).HasName("PRIMARY");

            entity.Property(e => e.area)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.this_year)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.FEE_CODE)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.out_01).HasColumnType("int(11)");
            entity.Property(e => e.out_02).HasColumnType("int(11)");
            entity.Property(e => e.out_03).HasColumnType("int(11)");
            entity.Property(e => e.out_04).HasColumnType("int(11)");
            entity.Property(e => e.out_05).HasColumnType("int(11)");
            entity.Property(e => e.out_06).HasColumnType("int(11)");
            entity.Property(e => e.out_07).HasColumnType("int(11)");
            entity.Property(e => e.out_08).HasColumnType("int(11)");
            entity.Property(e => e.out_09).HasColumnType("int(11)");
            entity.Property(e => e.out_10).HasColumnType("int(11)");
            entity.Property(e => e.out_11).HasColumnType("int(11)");
            entity.Property(e => e.out_12).HasColumnType("int(11)");
            entity.Property(e => e.seq_no).HasColumnType("smallint(6)");
            entity.Property(e => e.status).HasColumnType("int(11)");
        });

        modelBuilder.Entity<mailfrom>(entity =>
        {
            entity.HasKey(e => e.mf_id).HasName("PRIMARY");

            entity.Property(e => e.mf_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.mf_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.mf_content).HasMaxLength(2000);
            entity.Property(e => e.mf_file1).HasMaxLength(20);
            entity.Property(e => e.mf_file1desc).HasMaxLength(200);
            entity.Property(e => e.mf_file2).HasMaxLength(20);
            entity.Property(e => e.mf_file2desc).HasMaxLength(200);
            entity.Property(e => e.mf_file3).HasMaxLength(20);
            entity.Property(e => e.mf_file3desc).HasMaxLength(200);
            entity.Property(e => e.mf_status).HasDefaultValueSql("'1'");
            entity.Property(e => e.mf_subject).HasMaxLength(200);
            entity.Property(e => e.mf_to).HasMaxLength(1000);
            entity.Property(e => e.mf_uid)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<mailto>(entity =>
        {
            entity.HasKey(e => e.mt_id).HasName("PRIMARY");

            entity.Property(e => e.mt_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.mt_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.mt_from).HasMaxLength(200);
            entity.Property(e => e.mt_mfid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.mt_status)
                .IsRequired()
                .HasDefaultValueSql("'1'");
            entity.Property(e => e.mt_subject).HasMaxLength(200);
            entity.Property(e => e.mt_uid)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<mailtrash>(entity =>
        {
            entity.HasKey(e => e.mtr_id).HasName("PRIMARY");

            entity.Property(e => e.mtr_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.mtr_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.mtr_ddate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.mtr_from).HasMaxLength(200);
            entity.Property(e => e.mtr_mfid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.mtr_mtid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.mtr_subject).HasMaxLength(200);
            entity.Property(e => e.mtr_type)
                .IsRequired()
                .HasDefaultValueSql("'1'");
            entity.Property(e => e.mtr_uid)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<managespread>(entity =>
        {
            entity.HasKey(e => e.ms_id).HasName("PRIMARY");

            entity.HasIndex(e => new { e.ms_recorddate, e.ms_category, e.ms_status }, "idx2");

            entity.Property(e => e.ms_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ms_category).HasColumnType("smallint(6)");
            entity.Property(e => e.ms_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.ms_cid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ms_cname).HasMaxLength(40);
            entity.Property(e => e.ms_content).HasColumnType("text");
            entity.Property(e => e.ms_file1).HasMaxLength(30);
            entity.Property(e => e.ms_file2).HasMaxLength(30);
            entity.Property(e => e.ms_file3).HasMaxLength(30);
            entity.Property(e => e.ms_imp).HasColumnType("int(11)");
            entity.Property(e => e.ms_impuser).HasColumnType("int(11)");
            entity.Property(e => e.ms_iscurrent)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(255)");
            entity.Property(e => e.ms_no)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.ms_q).HasColumnType("int(11)");
            entity.Property(e => e.ms_recorddate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.ms_reply).HasColumnType("int(11)");
            entity.Property(e => e.ms_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.ms_title).HasMaxLength(400);
            entity.Property(e => e.ms_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.ms_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ms_uname).HasMaxLength(40);
            entity.Property(e => e.ms_url).HasMaxLength(200);
        });

        modelBuilder.Entity<managespreadreply>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.msr_bsid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.msr_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.msr_cname).HasMaxLength(40);
            entity.Property(e => e.msr_content).HasColumnType("text");
            entity.Property(e => e.msr_file1).HasMaxLength(30);
            entity.Property(e => e.msr_file2).HasMaxLength(30);
            entity.Property(e => e.msr_file3).HasMaxLength(30);
            entity.Property(e => e.msr_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.msr_no).HasMaxLength(10);
            entity.Property(e => e.msr_parent)
                .HasMaxLength(10)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.msr_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.msr_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.msr_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.msr_uname).HasMaxLength(40);
        });

        modelBuilder.Entity<mandate>(entity =>
        {
            entity.HasKey(e => e.m_id).HasName("PRIMARY");

            entity.Property(e => e.m_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.m_aid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.m_begdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.m_category)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(4)");
            entity.Property(e => e.m_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.m_cname).HasMaxLength(20);
            entity.Property(e => e.m_content).HasMaxLength(2000);
            entity.Property(e => e.m_enddate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.m_filename).HasMaxLength(100);
            entity.Property(e => e.m_name).HasMaxLength(20);
            entity.Property(e => e.m_order)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.m_psnid).HasMaxLength(12);
            entity.Property(e => e.m_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.m_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.m_uname).HasMaxLength(20);
        });

        modelBuilder.Entity<mandatefile>(entity =>
        {
            entity.HasKey(e => e.mf_id).HasName("PRIMARY");

            entity.Property(e => e.mf_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.mf_category).HasMaxLength(2);
            entity.Property(e => e.mf_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.mf_cname).HasMaxLength(20);
            entity.Property(e => e.mf_filename).HasMaxLength(20);
            entity.Property(e => e.mf_mid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.mf_note).HasMaxLength(200);
            entity.Property(e => e.mf_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.mf_uname).HasMaxLength(20);
        });

        modelBuilder.Entity<mandatesupport>(entity =>
        {
            entity.HasKey(e => e.ms_id).HasName("PRIMARY");

            entity.Property(e => e.ms_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ms_category)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ms_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.ms_cname).HasMaxLength(20);
            entity.Property(e => e.ms_mid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ms_note).HasMaxLength(200);
            entity.Property(e => e.ms_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.ms_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ms_uname).HasMaxLength(20);
        });

        modelBuilder.Entity<meeting>(entity =>
        {
            entity.HasKey(e => e.m_id).HasName("PRIMARY");

            entity.HasIndex(e => e.m_category, "category");

            entity.Property(e => e.m_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.m_category)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.m_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.m_cname).HasMaxLength(40);
            entity.Property(e => e.m_content).HasMaxLength(2000);
            entity.Property(e => e.m_date)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.m_file1).HasMaxLength(20);
            entity.Property(e => e.m_file2).HasMaxLength(20);
            entity.Property(e => e.m_file3).HasMaxLength(20);
            entity.Property(e => e.m_manager).HasMaxLength(80);
            entity.Property(e => e.m_no).HasMaxLength(4);
            entity.Property(e => e.m_notes).HasMaxLength(400);
            entity.Property(e => e.m_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.m_title).HasMaxLength(200);
            entity.Property(e => e.m_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.m_uname).HasMaxLength(40);
        });

        modelBuilder.Entity<meetingdetail>(entity =>
        {
            entity.HasKey(e => e.md_id).HasName("PRIMARY");

            entity.Property(e => e.md_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.md_category)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.md_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.md_cname).HasMaxLength(40);
            entity.Property(e => e.md_content).HasMaxLength(2000);
            entity.Property(e => e.md_file1).HasMaxLength(20);
            entity.Property(e => e.md_file1desc).HasMaxLength(100);
            entity.Property(e => e.md_file2).HasMaxLength(20);
            entity.Property(e => e.md_file2desc).HasMaxLength(100);
            entity.Property(e => e.md_file3).HasMaxLength(20);
            entity.Property(e => e.md_file3desc).HasMaxLength(100);
            entity.Property(e => e.md_mid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.md_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.md_title).HasMaxLength(200);
            entity.Property(e => e.md_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.md_uname).HasMaxLength(40);
        });

        modelBuilder.Entity<memorialday>(entity =>
        {
            entity.HasKey(e => e.md_id).HasName("PRIMARY");

            entity.Property(e => e.md_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.md_category)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.md_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.md_cname).HasMaxLength(40);
            entity.Property(e => e.md_content).HasColumnType("text");
            entity.Property(e => e.md_file1).HasMaxLength(30);
            entity.Property(e => e.md_file2).HasMaxLength(30);
            entity.Property(e => e.md_file3).HasMaxLength(30);
            entity.Property(e => e.md_file4).HasMaxLength(30);
            entity.Property(e => e.md_file5).HasMaxLength(30);
            entity.Property(e => e.md_imp)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.md_impuser)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.md_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.md_title).HasMaxLength(255);
            entity.Property(e => e.md_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.md_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.md_uname).HasMaxLength(40);
            entity.Property(e => e.md_y)
                .HasDefaultValueSql("'2017'")
                .HasColumnType("smallint(255)");
        });

        modelBuilder.Entity<memorialdayreply>(entity =>
        {
            entity.HasKey(e => e.mdr_id).HasName("PRIMARY");

            entity.Property(e => e.mdr_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.mdr_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.mdr_cname).HasMaxLength(40);
            entity.Property(e => e.mdr_content).HasColumnType("text");
            entity.Property(e => e.mdr_file1).HasMaxLength(30);
            entity.Property(e => e.mdr_file2).HasMaxLength(30);
            entity.Property(e => e.mdr_file3).HasMaxLength(30);
            entity.Property(e => e.mdr_file4).HasMaxLength(30);
            entity.Property(e => e.mdr_file5).HasMaxLength(30);
            entity.Property(e => e.mdr_mdid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.mdr_parent)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.mdr_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.mdr_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.mdr_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.mdr_uname).HasMaxLength(40);
        });

        modelBuilder.Entity<morning>(entity =>
        {
            entity.HasKey(e => e.mm_id).HasName("PRIMARY");

            entity.Property(e => e.mm_id).HasColumnType("bigint(20)");
            entity.Property(e => e.mm_impdate).HasMaxLength(14);
            entity.Property(e => e.mm_ip).HasMaxLength(40);
            entity.Property(e => e.mm_note).HasMaxLength(40);
            entity.Property(e => e.mm_type).HasColumnType("int(11)");
            entity.Property(e => e.mm_uid).HasMaxLength(20);
            entity.Property(e => e.mm_uname).HasMaxLength(40);
        });

        modelBuilder.Entity<new_psn>(entity =>
        {
            entity.HasKey(e => e.NP_ID).HasName("PRIMARY");

            entity.Property(e => e.NP_ID).HasMaxLength(10);
            entity.Property(e => e.ADDRESS_2).HasMaxLength(60);
            entity.Property(e => e.AREA)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CELL_TEL)
                .HasMaxLength(15)
                .IsFixedLength();
            entity.Property(e => e.COUNTRY).HasMaxLength(12);
            entity.Property(e => e.NAME).HasMaxLength(40);
            entity.Property(e => e.NP_LID).HasMaxLength(12);
            entity.Property(e => e.SEX)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SPONSOR).HasMaxLength(40);
            entity.Property(e => e.TXT_DATE)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.TXT_ID).HasMaxLength(12);
            entity.Property(e => e.TXT_MARK)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.T_From)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.status).HasColumnType("int(11)");
        });

        modelBuilder.Entity<newsmsg>(entity =>
        {
            entity.HasKey(e => e.nm_id).HasName("PRIMARY");

            entity.Property(e => e.nm_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.nm_content).HasColumnType("text");
            entity.Property(e => e.nm_cuser).HasMaxLength(40);
            entity.Property(e => e.nm_settime)
                .HasMaxLength(14)
                .IsFixedLength();
        });

        modelBuilder.Entity<parctice>(entity =>
        {
            entity.HasKey(e => e.p_id).HasName("PRIMARY");

            entity.Property(e => e.p_id)
                .HasMaxLength(10)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.p_category)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.p_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.p_cname).HasMaxLength(40);
            entity.Property(e => e.p_content).HasColumnType("text");
            entity.Property(e => e.p_imp).HasColumnType("int(11)");
            entity.Property(e => e.p_impuser).HasColumnType("int(11)");
            entity.Property(e => e.p_progress).HasMaxLength(400);
            entity.Property(e => e.p_recorddate)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.p_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.p_type)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.p_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.p_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.p_uname).HasMaxLength(40);
        });

        modelBuilder.Entity<parcticesummary>(entity =>
        {
            entity.HasKey(e => e.ps_id).HasName("PRIMARY");

            entity.Property(e => e.ps_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ps_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.ps_cname).HasMaxLength(40);
            entity.Property(e => e.ps_content).HasMaxLength(2000);
            entity.Property(e => e.ps_pid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ps_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.ps_type)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.ps_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.ps_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ps_uname).HasMaxLength(40);
        });

        modelBuilder.Entity<partner>(entity =>
        {
            entity.HasKey(e => e.p_id).HasName("PRIMARY");

            entity.Property(e => e.p_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.p_aid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.p_as).HasMaxLength(40);
            entity.Property(e => e.p_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.p_cname).HasMaxLength(40);
            entity.Property(e => e.p_effdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.p_effreason).HasMaxLength(2000);
            entity.Property(e => e.p_expdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.p_expreason).HasMaxLength(2000);
            entity.Property(e => e.p_level1).HasColumnType("tinyint(4)");
            entity.Property(e => e.p_level2).HasColumnType("tinyint(4)");
            entity.Property(e => e.p_no)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.p_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.p_tid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.p_ts).HasMaxLength(40);
            entity.Property(e => e.p_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.p_uid1)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.p_uid2)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.p_uname).HasMaxLength(40);
            entity.Property(e => e.p_uname1).HasMaxLength(40);
            entity.Property(e => e.p_uname2).HasMaxLength(40);
        });

        modelBuilder.Entity<partnerrecord>(entity =>
        {
            entity.HasKey(e => e.pr_id).HasName("PRIMARY");

            entity.Property(e => e.pr_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.pr_as).HasMaxLength(2000);
            entity.Property(e => e.pr_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.pr_cname).HasMaxLength(40);
            entity.Property(e => e.pr_laoshi).HasMaxLength(2000);
            entity.Property(e => e.pr_pid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.pr_record1).HasMaxLength(2000);
            entity.Property(e => e.pr_record2).HasMaxLength(2000);
            entity.Property(e => e.pr_recorddate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.pr_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.pr_support1)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.pr_support2)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.pr_ts).HasMaxLength(2000);
            entity.Property(e => e.pr_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.pr_uname).HasMaxLength(40);
        });

        modelBuilder.Entity<personalguidelines>(entity =>
        {
            entity.HasKey(e => e.pl_id).HasName("PRIMARY");

            entity.Property(e => e.pl_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.pl_applydate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.pl_begdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.pl_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.pl_cname).HasMaxLength(40);
            entity.Property(e => e.pl_desc).HasMaxLength(200);
            entity.Property(e => e.pl_enddate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.pl_fee).HasColumnType("int(11)");
            entity.Property(e => e.pl_file).HasMaxLength(20);
            entity.Property(e => e.pl_filedate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.pl_fileuname).HasMaxLength(20);
            entity.Property(e => e.pl_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.pl_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.pl_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.pl_uname).HasMaxLength(40);
        });

        modelBuilder.Entity<photovideo>(entity =>
        {
            entity.HasKey(e => e.pv_id).HasName("PRIMARY");

            entity.Property(e => e.pv_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.pv_apply)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(255)");
            entity.Property(e => e.pv_applydate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.pv_category).HasColumnType("tinyint(4)");
            entity.Property(e => e.pv_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.pv_cid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.pv_cname).HasMaxLength(40);
            entity.Property(e => e.pv_content).HasColumnType("text");
            entity.Property(e => e.pv_file1).HasMaxLength(30);
            entity.Property(e => e.pv_file2).HasMaxLength(30);
            entity.Property(e => e.pv_file3).HasMaxLength(30);
            entity.Property(e => e.pv_imp).HasColumnType("int(11)");
            entity.Property(e => e.pv_impuser).HasColumnType("int(11)");
            entity.Property(e => e.pv_iscurrent)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(255)");
            entity.Property(e => e.pv_no)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.pv_recorddate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.pv_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.pv_title).HasMaxLength(400);
            entity.Property(e => e.pv_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.pv_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.pv_uname).HasMaxLength(40);
            entity.Property(e => e.pv_url).HasMaxLength(200);
        });

        modelBuilder.Entity<photovideoreply>(entity =>
        {
            entity.HasKey(e => e.pvr_id).HasName("PRIMARY");

            entity.Property(e => e.pvr_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.pvr_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.pvr_cname).HasMaxLength(40);
            entity.Property(e => e.pvr_content).HasColumnType("text");
            entity.Property(e => e.pvr_file1).HasMaxLength(30);
            entity.Property(e => e.pvr_file2).HasMaxLength(30);
            entity.Property(e => e.pvr_file3).HasMaxLength(30);
            entity.Property(e => e.pvr_no).HasMaxLength(10);
            entity.Property(e => e.pvr_parent)
                .HasMaxLength(10)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.pvr_pvid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.pvr_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.pvr_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.pvr_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.pvr_uname).HasMaxLength(40);
        });

        modelBuilder.Entity<points>(entity =>
        {
            entity.HasKey(e => e.p_id).HasName("PRIMARY");

            entity.Property(e => e.p_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.p_category)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.p_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.p_cname).HasMaxLength(40);
            entity.Property(e => e.p_desc).HasMaxLength(200);
            entity.Property(e => e.p_effdate)
                .HasMaxLength(0)
                .IsFixedLength();
            entity.Property(e => e.p_fee).HasColumnType("int(11)");
            entity.Property(e => e.p_func).HasMaxLength(20);
            entity.Property(e => e.p_funcid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.p_info).HasMaxLength(1000);
            entity.Property(e => e.p_invoiceno)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.p_linkpay).HasMaxLength(1000);
            entity.Property(e => e.p_paydate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.p_paytype).HasColumnType("tinyint(4)");
            entity.Property(e => e.p_points).HasColumnType("int(255)");
            entity.Property(e => e.p_status).HasColumnType("tinyint(4)");
            entity.Property(e => e.p_subtotal)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(255)");
            entity.Property(e => e.p_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.p_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.p_uname).HasMaxLength(40);
        });

        modelBuilder.Entity<pointsmonthrpt>(entity =>
        {
            entity.HasKey(e => new { e.pm_id, e.pm_ym, e.pm_uid }).HasName("PRIMARY");

            entity.HasIndex(e => e.pm_id, "pmid");

            entity.Property(e => e.pm_id)
                .HasMaxLength(10)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.pm_ym)
                .HasMaxLength(6)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.pm_uid)
                .HasMaxLength(10)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.pm_cdate)
                .HasMaxLength(14)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.pm_cname)
                .HasMaxLength(20)
                .HasDefaultValueSql("''");
            entity.Property(e => e.pm_eff).HasColumnType("int(11)");
            entity.Property(e => e.pm_lastbuydate)
                .HasMaxLength(14)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.pm_pre).HasColumnType("int(11)");
            entity.Property(e => e.pm_remain).HasColumnType("int(11)");
            entity.Property(e => e.pm_remainfee).HasColumnType("int(11)");
            entity.Property(e => e.pm_this).HasColumnType("int(11)");
            entity.Property(e => e.pm_udate)
                .HasMaxLength(14)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.pm_uname)
                .HasMaxLength(20)
                .HasDefaultValueSql("''");
            entity.Property(e => e.pm_use).HasColumnType("int(11)");
        });

        modelBuilder.Entity<practicetime>(entity =>
        {
            entity.HasKey(e => e.pr_id).HasName("PRIMARY");

            entity.Property(e => e.pr_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.pr_StartTime)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.pr_settime)
                .HasMaxLength(14)
                .IsFixedLength();
        });

        modelBuilder.Entity<progress>(entity =>
        {
            entity.HasKey(e => e.p_id).HasName("PRIMARY");

            entity.Property(e => e.p_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.p_category)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.p_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.p_cname).HasMaxLength(40);
            entity.Property(e => e.p_content).HasColumnType("text");
            entity.Property(e => e.p_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.p_title).HasMaxLength(400);
            entity.Property(e => e.p_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.p_uname).HasMaxLength(40);
        });

        modelBuilder.Entity<psn_active_sc>(entity =>
        {
            entity.HasKey(e => new { e.SC_ID, e.DATE, e.PSN_ID }).HasName("PRIMARY");

            entity.Property(e => e.SC_ID)
                .HasMaxLength(10)
                .HasDefaultValueSql("''");
            entity.Property(e => e.DATE)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.PSN_ID)
                .HasMaxLength(12)
                .HasDefaultValueSql("''");
            entity.Property(e => e.ARRIVE_TIME)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.LEFT_TIME)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.MEMO).HasMaxLength(30);
            entity.Property(e => e.QTY).HasColumnType("int(4)");
            entity.Property(e => e.pas_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.pas_cname).HasMaxLength(40);
            entity.Property(e => e.pas_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.pas_uname).HasMaxLength(40);
            entity.Property(e => e.status).HasColumnType("int(11)");
        });

        modelBuilder.Entity<psn_class_his>(entity =>
        {
            entity.HasKey(e => e.PSN_ID).HasName("PRIMARY");

            entity.Property(e => e.PSN_ID)
                .HasMaxLength(10)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.CNT).HasColumnType("smallint(2)");
        });

        modelBuilder.Entity<psn_sc>(entity =>
        {
            entity.HasKey(e => new { e.SC_ID_no, e.DATE, e.PSN_ID, e.ARRIVE_TIME, e.LEFT_TIME, e.status }).HasName("PRIMARY");

            entity.Property(e => e.SC_ID_no)
                .HasMaxLength(12)
                .HasDefaultValueSql("''");
            entity.Property(e => e.DATE)
                .HasMaxLength(8)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.PSN_ID)
                .HasMaxLength(12)
                .HasDefaultValueSql("''");
            entity.Property(e => e.ARRIVE_TIME)
                .HasMaxLength(4)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.LEFT_TIME)
                .HasMaxLength(4)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.status).HasColumnType("int(11)");
            entity.Property(e => e.MEMO).HasMaxLength(30);
            entity.Property(e => e.QTY).HasColumnType("int(4)");
            entity.Property(e => e.ps_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.ps_cname).HasMaxLength(40);
            entity.Property(e => e.ps_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.ps_uname).HasMaxLength(40);
        });

        modelBuilder.Entity<psn_sick>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.DATE)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.PSN_ID).HasMaxLength(12);
            entity.Property(e => e.SC_ID_no).HasMaxLength(12);
            entity.Property(e => e.ps_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.ps_cname).HasMaxLength(40);
            entity.Property(e => e.ps_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.ps_uname).HasMaxLength(40);
            entity.Property(e => e.sick_name).HasMaxLength(30);
            entity.Property(e => e.sick_sex)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.sick_type)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.sick_years).HasColumnType("smallint(3)");
            entity.Property(e => e.status).HasColumnType("int(2)");
        });

        modelBuilder.Entity<readmessage>(entity =>
        {
            entity.HasKey(e => e.rm_id).HasName("PRIMARY");

            entity.HasIndex(e => e.rm_cdate, "idx_date");

            entity.HasIndex(e => new { e.rm_funcname, e.rm_funcid, e.rm_uid }, "idx_rm");

            entity.Property(e => e.rm_id).HasColumnType("bigint(20)");
            entity.Property(e => e.rm_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.rm_cname).HasMaxLength(40);
            entity.Property(e => e.rm_funcid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.rm_funcname).HasMaxLength(100);
            entity.Property(e => e.rm_uid)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<readmessagecount>(entity =>
        {
            entity.HasKey(e => e.rmc_id).HasName("PRIMARY");

            entity.HasIndex(e => e.rmc_funcid, "idx_funcid");

            entity.HasIndex(e => e.rmc_funcname, "idx_funcname");

            entity.HasIndex(e => e.rmc_uid, "idx_uid");

            entity.Property(e => e.rmc_id).HasColumnType("bigint(20)");
            entity.Property(e => e.rmc_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.rmc_count)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.rmc_funcid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.rmc_funcname).HasMaxLength(100);
            entity.Property(e => e.rmc_uid)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<report>(entity =>
        {
            entity.HasKey(e => e.r_id).HasName("PRIMARY");

            entity.HasIndex(e => e.r_category2, "category");

            entity.HasIndex(e => e.r_uid, "uid");

            entity.Property(e => e.r_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.r_category1)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.r_category2)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.r_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.r_cname).HasMaxLength(40);
            entity.Property(e => e.r_content).HasColumnType("text");
            entity.Property(e => e.r_file1).HasMaxLength(30);
            entity.Property(e => e.r_file2).HasMaxLength(30);
            entity.Property(e => e.r_file3).HasMaxLength(30);
            entity.Property(e => e.r_imp).HasColumnType("int(11)");
            entity.Property(e => e.r_impuser).HasColumnType("int(11)");
            entity.Property(e => e.r_no).HasMaxLength(10);
            entity.Property(e => e.r_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.r_title).HasMaxLength(200);
            entity.Property(e => e.r_type)
                .HasDefaultValueSql("'3'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.r_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.r_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.r_uname).HasMaxLength(40);
        });

        modelBuilder.Entity<reportcoursemn>(entity =>
        {
            entity.HasKey(e => e.rc_id).HasName("PRIMARY");

            entity.HasIndex(e => new { e.rc_uid, e.rc_y, e.rc_type, e.rc_status }, "uid");

            entity.Property(e => e.rc_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.rc_1)
                .HasDefaultValueSql("'-1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.rc_10)
                .HasDefaultValueSql("'-1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.rc_11)
                .HasDefaultValueSql("'-1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.rc_12)
                .HasDefaultValueSql("'-1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.rc_2)
                .HasDefaultValueSql("'-1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.rc_3)
                .HasDefaultValueSql("'-1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.rc_4)
                .HasDefaultValueSql("'-1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.rc_5)
                .HasDefaultValueSql("'-1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.rc_6)
                .HasDefaultValueSql("'-1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.rc_7)
                .HasDefaultValueSql("'-1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.rc_8)
                .HasDefaultValueSql("'-1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.rc_9)
                .HasDefaultValueSql("'-1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.rc_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.rc_cname).HasMaxLength(40);
            entity.Property(e => e.rc_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.rc_type)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.rc_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.rc_uid)
                .HasMaxLength(10)
                .HasDefaultValueSql("'0'")
                .IsFixedLength();
            entity.Property(e => e.rc_uname).HasMaxLength(40);
            entity.Property(e => e.rc_y).HasColumnType("int(11)");
        });

        modelBuilder.Entity<reportreply>(entity =>
        {
            entity.HasKey(e => e.rr_id).HasName("PRIMARY");

            entity.HasIndex(e => e.rr_rid, "rid");

            entity.HasIndex(e => e.rr_uid, "uid");

            entity.Property(e => e.rr_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.rr_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.rr_cname).HasMaxLength(40);
            entity.Property(e => e.rr_content).HasColumnType("text");
            entity.Property(e => e.rr_file1).HasMaxLength(30);
            entity.Property(e => e.rr_file2).HasMaxLength(30);
            entity.Property(e => e.rr_file3).HasMaxLength(30);
            entity.Property(e => e.rr_no).HasMaxLength(10);
            entity.Property(e => e.rr_parent)
                .HasMaxLength(10)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.rr_rid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.rr_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.rr_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.rr_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.rr_uname).HasMaxLength(40);
        });

        modelBuilder.Entity<rule>(entity =>
        {
            entity.HasKey(e => e.r_id).HasName("PRIMARY");

            entity.HasIndex(e => e.r_uid, "uid");

            entity.Property(e => e.r_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.r_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.r_cname).HasMaxLength(100);
            entity.Property(e => e.r_content).HasColumnType("text");
            entity.Property(e => e.r_desc).HasMaxLength(200);
            entity.Property(e => e.r_imp).HasColumnType("int(200)");
            entity.Property(e => e.r_no)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.r_parent)
                .HasMaxLength(10)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.r_pdate)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.r_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.r_title).HasMaxLength(200);
            entity.Property(e => e.r_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.r_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.r_uname).HasMaxLength(40);
            entity.Property(e => e.r_unitname).HasMaxLength(100);
            entity.Property(e => e.r_version).HasMaxLength(20);
        });

        modelBuilder.Entity<sc_active>(entity =>
        {
            entity.HasKey(e => e.SC_ID).HasName("PRIMARY");

            entity.Property(e => e.SC_ID).HasMaxLength(10);
            entity.Property(e => e.ADDRESS).HasMaxLength(60);
            entity.Property(e => e.AREA).HasMaxLength(10);
            entity.Property(e => e.CLOTHES).HasMaxLength(20);
            entity.Property(e => e.CONTENT).HasMaxLength(300);
            entity.Property(e => e.END_DATE)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.LEADER_ID).HasMaxLength(12);
            entity.Property(e => e.MEMO).HasMaxLength(60);
            entity.Property(e => e.NEED).HasMaxLength(200);
            entity.Property(e => e.SC_NAME).HasMaxLength(50);
            entity.Property(e => e.SC_TEL).HasMaxLength(20);
            entity.Property(e => e.SC_TYPE)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.START_DATE)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.TIME_DESCRIPT).HasMaxLength(60);
            entity.Property(e => e.TXT_DATE)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.TXT_NAME).HasMaxLength(40);
            entity.Property(e => e.old_SC_ID).HasMaxLength(10);
            entity.Property(e => e.status).HasColumnType("int(11)");
        });

        modelBuilder.Entity<sc_active_rec>(entity =>
        {
            entity.HasKey(e => new { e.SC_ID, e.DATE }).HasName("PRIMARY");

            entity.Property(e => e.SC_ID).HasMaxLength(12);
            entity.Property(e => e.DATE)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.CONTENT).HasMaxLength(4000);
            entity.Property(e => e.END_TIME)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.INPROVE).HasMaxLength(2000);
            entity.Property(e => e.LEADER_NAME).HasMaxLength(60);
            entity.Property(e => e.REPLY).HasMaxLength(2000);
            entity.Property(e => e.REQUEST).HasMaxLength(2000);
            entity.Property(e => e.START_TIME)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.TXT_NAME).HasMaxLength(40);
            entity.Property(e => e.sar_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.sar_cname).HasMaxLength(40);
            entity.Property(e => e.sar_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.sar_uname).HasMaxLength(40);
            entity.Property(e => e.status).HasColumnType("int(11)");
        });

        modelBuilder.Entity<sc_patient_rec>(entity =>
        {
            entity.HasKey(e => e.LC_ID).HasName("PRIMARY");

            entity.Property(e => e.LC_ID).HasMaxLength(10);
            entity.Property(e => e.APPLY_ID).HasMaxLength(12);
            entity.Property(e => e.AREA).HasMaxLength(10);
            entity.Property(e => e.CARE_KIND)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.CARE_PLACE).HasMaxLength(40);
            entity.Property(e => e.CONTENT).HasColumnType("text");
            entity.Property(e => e.CONTENT_1).HasColumnType("text");
            entity.Property(e => e.DATE)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.DISEASE).HasMaxLength(200);
            entity.Property(e => e.DISEASE_KIND)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.END_TIME)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.FORMULA).HasColumnType("text");
            entity.Property(e => e.LC_CONTENT).HasColumnType("text");
            entity.Property(e => e.PATIENT).HasMaxLength(20);
            entity.Property(e => e.PATIENT_ID).HasMaxLength(10);
            entity.Property(e => e.RELATION).HasMaxLength(40);
            entity.Property(e => e.RELATION_KIND).HasMaxLength(10);
            entity.Property(e => e.SC_ID_no).HasMaxLength(12);
            entity.Property(e => e.SEX)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.START_TIME)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.STEP_1).HasMaxLength(2);
            entity.Property(e => e.STEP_10)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.STEP_11)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.STEP_2).HasMaxLength(2);
            entity.Property(e => e.STEP_3)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.STEP_4)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.STEP_5)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.STEP_6)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.STEP_7)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.STEP_8)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.STEP_9)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SUSTAIN_NAME).HasMaxLength(200);
            entity.Property(e => e.TXT_NAME).HasMaxLength(20);
            entity.Property(e => e.age).HasMaxLength(2);
            entity.Property(e => e.master).HasColumnType("text");
            entity.Property(e => e.memo).HasMaxLength(100);
            entity.Property(e => e.no).HasColumnType("int(11)");
            entity.Property(e => e.question).HasColumnType("text");
            entity.Property(e => e.spr_file1).HasMaxLength(20);
            entity.Property(e => e.spr_file2).HasMaxLength(20);
            entity.Property(e => e.status).HasColumnType("int(11)");
        });

        modelBuilder.Entity<sc_place>(entity =>
        {
            entity.HasKey(e => e.SC_ID).HasName("PRIMARY");

            entity.Property(e => e.SC_ID).HasMaxLength(10);
            entity.Property(e => e.ADDRESS).HasMaxLength(60);
            entity.Property(e => e.AREA).HasMaxLength(10);
            entity.Property(e => e.LEADER_ID).HasMaxLength(12);
            entity.Property(e => e.MEMO).HasMaxLength(60);
            entity.Property(e => e.SC_NAME).HasMaxLength(50);
            entity.Property(e => e.SC_TEL).HasMaxLength(20);
            entity.Property(e => e.SC_TYPE)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.START_DATE)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.TXT_DATE)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.TXT_NAME).HasMaxLength(40);
            entity.Property(e => e.old_SC_ID).HasMaxLength(10);
            entity.Property(e => e.status).HasColumnType("int(11)");
        });

        modelBuilder.Entity<sc_service_rec>(entity =>
        {
            entity.HasKey(e => new { e.SC_ID_no, e.DATE }).HasName("PRIMARY");

            entity.Property(e => e.SC_ID_no)
                .HasMaxLength(12)
                .HasDefaultValueSql("''");
            entity.Property(e => e.DATE)
                .HasMaxLength(8)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.CONTENT).HasMaxLength(4000);
            entity.Property(e => e.END_TIME)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.INPROVE).HasMaxLength(2000);
            entity.Property(e => e.LEADER_NAME).HasMaxLength(60);
            entity.Property(e => e.REPLY).HasMaxLength(2000);
            entity.Property(e => e.REQUEST).HasMaxLength(2000);
            entity.Property(e => e.START_TIME)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.TXT_NAME).HasMaxLength(40);
            entity.Property(e => e.ssr_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.ssr_cname).HasMaxLength(40);
            entity.Property(e => e.ssr_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.ssr_uname).HasMaxLength(40);
            entity.Property(e => e.status).HasColumnType("int(11)");
        });

        modelBuilder.Entity<sc_static>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.QTY).HasColumnType("int(4)");
            entity.Property(e => e.Total_Times).HasColumnType("double(5,2)");
            entity.Property(e => e.status).HasColumnType("smallint(2)");
            entity.Property(e => e.u_name).HasMaxLength(40);
            entity.Property(e => e.u_period)
                .HasMaxLength(4)
                .IsFixedLength();
        });

        modelBuilder.Entity<sc_time>(entity =>
        {
            entity.HasKey(e => e.SC_ID_no).HasName("PRIMARY");

            entity.Property(e => e.SC_ID_no).HasMaxLength(12);
            entity.Property(e => e.END_TIME)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.KIND)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.LEADER_ID).HasMaxLength(12);
            entity.Property(e => e.LEADER_ID_1).HasMaxLength(12);
            entity.Property(e => e.PLACE).HasMaxLength(60);
            entity.Property(e => e.RECORDER_ID).HasMaxLength(12);
            entity.Property(e => e.SC_ID).HasMaxLength(10);
            entity.Property(e => e.START_TIME)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.TXT_DATE)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.TXT_NAME).HasMaxLength(40);
            entity.Property(e => e.WEEKDAY)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.status).HasColumnType("int(11)");
        });

        modelBuilder.Entity<sop>(entity =>
        {
            entity.HasKey(e => e.s_id).HasName("PRIMARY");

            entity.Property(e => e.s_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.s_category).HasColumnType("tinyint(255)");
            entity.Property(e => e.s_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.s_cname).HasMaxLength(40);
            entity.Property(e => e.s_content).HasColumnType("text");
            entity.Property(e => e.s_imp).HasColumnType("int(255)");
            entity.Property(e => e.s_impuser).HasColumnType("int(255)");
            entity.Property(e => e.s_no)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.s_pdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.s_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(255)");
            entity.Property(e => e.s_title).HasMaxLength(400);
            entity.Property(e => e.s_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.s_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.s_uname).HasMaxLength(40);
        });

        modelBuilder.Entity<sopfile>(entity =>
        {
            entity.HasKey(e => e.sf_id).HasName("PRIMARY");

            entity.Property(e => e.sf_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.sf_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.sf_cname).HasMaxLength(40);
            entity.Property(e => e.sf_desc).HasMaxLength(100);
            entity.Property(e => e.sf_name).HasMaxLength(20);
            entity.Property(e => e.sf_order)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.sf_sid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.sf_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(255)");
            entity.Property(e => e.sf_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.sf_uname).HasMaxLength(40);
        });

        modelBuilder.Entity<sopreply>(entity =>
        {
            entity.HasKey(e => e.sr_id).HasName("PRIMARY");

            entity.Property(e => e.sr_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.sr_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.sr_cname).HasMaxLength(40);
            entity.Property(e => e.sr_content).HasColumnType("text");
            entity.Property(e => e.sr_sid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.sr_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.sr_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.sr_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.sr_uname).HasMaxLength(40);
        });

        modelBuilder.Entity<syslog>(entity =>
        {
            entity.HasKey(e => e.L_ID).HasName("PRIMARY");

            entity.Property(e => e.L_ID).HasColumnType("bigint(20)");
            entity.Property(e => e.L_Action).HasMaxLength(40);
            entity.Property(e => e.L_DATE)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.L_IP).HasMaxLength(20);
            entity.Property(e => e.L_NOTE).HasColumnType("text");
            entity.Property(e => e.L_UID)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.L_UNAME).HasMaxLength(40);
        });

        modelBuilder.Entity<sysparam>(entity =>
        {
            entity.HasKey(e => e.sp_id).HasName("PRIMARY");

            entity.HasIndex(e => e.sp_id, "spid");

            entity.Property(e => e.sp_id)
                .HasMaxLength(10)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.sp_cdate)
                .HasMaxLength(14)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.sp_cname)
                .HasMaxLength(20)
                .HasDefaultValueSql("''");
            entity.Property(e => e.sp_desc)
                .HasMaxLength(100)
                .HasDefaultValueSql("''");
            entity.Property(e => e.sp_title)
                .HasMaxLength(20)
                .HasDefaultValueSql("''");
            entity.Property(e => e.sp_udate)
                .HasMaxLength(14)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.sp_uname)
                .HasMaxLength(20)
                .HasDefaultValueSql("''");
            entity.Property(e => e.sp_unit)
                .HasMaxLength(20)
                .HasDefaultValueSql("''");
            entity.Property(e => e.sp_value)
                .HasMaxLength(10)
                .HasDefaultValueSql("''");
        });

        modelBuilder.Entity<sysuser>(entity =>
        {
            entity.HasKey(e => e.U_ID).HasName("PRIMARY");

            entity.HasIndex(e => e.U_AID, "aid");

            entity.HasIndex(e => e.U_RID, "rid");

            entity.HasIndex(e => e.U_TID, "tid");

            entity.Property(e => e.U_ID)
                .HasMaxLength(10)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.U_AID)
                .HasMaxLength(10)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.U_AS).HasMaxLength(20);
            entity.Property(e => e.U_BACKLIGHTDATE)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.U_BIRTHDAY)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.U_CARDDATE)
                .HasMaxLength(8)
                .HasDefaultValueSql("'0'")
                .IsFixedLength();
            entity.Property(e => e.U_CName)
                .HasMaxLength(20)
                .HasDefaultValueSql("''");
            entity.Property(e => e.U_COMPANY).HasMaxLength(100);
            entity.Property(e => e.U_COMPANYTITLE).HasMaxLength(60);
            entity.Property(e => e.U_Cdate)
                .HasMaxLength(14)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.U_Cellphone)
                .HasMaxLength(40)
                .HasDefaultValueSql("''");
            entity.Property(e => e.U_EDU)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(10)");
            entity.Property(e => e.U_Email)
                .HasMaxLength(254)
                .HasDefaultValueSql("''");
            entity.Property(e => e.U_FB).HasMaxLength(400);
            entity.Property(e => e.U_Htel)
                .HasMaxLength(100)
                .HasDefaultValueSql("''");
            entity.Property(e => e.U_INFO).HasMaxLength(200);
            entity.Property(e => e.U_ISTAXTOGOV)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.U_IsWmentor)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.U_IsWmsgnr)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.U_LID).HasMaxLength(12);
            entity.Property(e => e.U_Line)
                .HasMaxLength(40)
                .HasDefaultValueSql("''");
            entity.Property(e => e.U_MARRY).HasColumnType("tinyint(10)");
            entity.Property(e => e.U_NO).HasMaxLength(13);
            entity.Property(e => e.U_NOTES).HasMaxLength(400);
            entity.Property(e => e.U_Name)
                .HasMaxLength(40)
                .HasDefaultValueSql("''");
            entity.Property(e => e.U_OCCID)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.U_OCCOTHER).HasMaxLength(200);
            entity.Property(e => e.U_Otel)
                .HasMaxLength(100)
                .HasDefaultValueSql("''");
            entity.Property(e => e.U_PERIOD)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.U_PROFID)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.U_RID)
                .HasMaxLength(10)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.U_SEX).HasColumnType("tinyint(4)");
            entity.Property(e => e.U_Skype)
                .HasMaxLength(40)
                .HasDefaultValueSql("''");
            entity.Property(e => e.U_TDS).HasMaxLength(20);
            entity.Property(e => e.U_TID)
                .HasMaxLength(10)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.U_TWOHUNDER)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.U_UName)
                .HasMaxLength(20)
                .HasDefaultValueSql("''");
            entity.Property(e => e.U_Udate)
                .HasMaxLength(14)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.U_timeWmentor)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.u_blood).HasMaxLength(2);
            entity.Property(e => e.u_bsnumber).HasColumnType("tinyint(4)");
            entity.Property(e => e.u_bsranking).HasColumnType("tinyint(4)");
            entity.Property(e => e.u_country)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.u_disease).HasMaxLength(200);
            entity.Property(e => e.u_emergency).HasMaxLength(40);
            entity.Property(e => e.u_enname).HasMaxLength(100);
            entity.Property(e => e.u_haddr).HasMaxLength(100);
            entity.Property(e => e.u_hcity).HasMaxLength(20);
            entity.Property(e => e.u_htown).HasMaxLength(20);
            entity.Property(e => e.u_hzipcode).HasMaxLength(10);
            entity.Property(e => e.u_maddr)
                .HasMaxLength(200)
                .HasDefaultValueSql("''");
            entity.Property(e => e.u_mcity).HasMaxLength(20);
            entity.Property(e => e.u_mtown).HasMaxLength(20);
            entity.Property(e => e.u_mzipcode).HasMaxLength(10);
            entity.Property(e => e.u_oemail).HasMaxLength(254);
            entity.Property(e => e.u_religion).HasMaxLength(20);
            entity.Property(e => e.u_wechat).HasMaxLength(40);
            entity.Property(e => e.u_whatsapp).HasMaxLength(40);
        });

        modelBuilder.Entity<sysuserbase>(entity =>
        {
            entity.HasKey(e => e.UB_ID).HasName("PRIMARY");

            entity.HasIndex(e => e.UB_Account, "idx_account");

            entity.HasIndex(e => e.UB_ID, "idx_id");

            entity.HasIndex(e => e.UB_Type, "idx_type");

            entity.Property(e => e.UB_ID)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.UB_Account)
                .HasMaxLength(200)
                .HasDefaultValueSql("''");
            entity.Property(e => e.UB_CName)
                .HasMaxLength(20)
                .HasDefaultValueSql("''");
            entity.Property(e => e.UB_Cdate)
                .HasMaxLength(14)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.UB_EffDate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.UB_ExpDate)
                .HasMaxLength(14)
                .HasDefaultValueSql("'9999'")
                .IsFixedLength();
            entity.Property(e => e.UB_GUID).HasMaxLength(100);
            entity.Property(e => e.UB_Name).HasMaxLength(40);
            entity.Property(e => e.UB_Type)
                .HasMaxLength(1)
                .HasDefaultValueSql("'U'")
                .IsFixedLength();
            entity.Property(e => e.UB_UName)
                .HasMaxLength(20)
                .HasDefaultValueSql("''");
            entity.Property(e => e.UB_Udate)
                .HasMaxLength(14)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.UB_pwd)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        modelBuilder.Entity<sysuserhistory>(entity =>
        {
            entity.HasKey(e => e.uh_id).HasName("PRIMARY");

            entity.Property(e => e.uh_id).HasColumnType("bigint(20) unsigned");
            entity.Property(e => e.uh_begdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.uh_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.uh_cname).HasMaxLength(40);
            entity.Property(e => e.uh_content1).HasMaxLength(200);
            entity.Property(e => e.uh_content2).HasMaxLength(200);
            entity.Property(e => e.uh_enddate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.uh_notes).HasMaxLength(200);
            entity.Property(e => e.uh_type)
                .HasMaxLength(1)
                .HasDefaultValueSql("'C'")
                .IsFixedLength();
            entity.Property(e => e.uh_udate)
                .HasMaxLength(14)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.uh_uid)
                .HasMaxLength(10)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.uh_uname)
                .HasMaxLength(40)
                .HasDefaultValueSql("''");
        });

        modelBuilder.Entity<teamapply>(entity =>
        {
            entity.HasKey(e => e.ta_id).HasName("PRIMARY");

            entity.Property(e => e.ta_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ta_aid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ta_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.ta_cname).HasMaxLength(40);
            entity.Property(e => e.ta_name).HasMaxLength(40);
            entity.Property(e => e.ta_note).HasMaxLength(200);
            entity.Property(e => e.ta_progress)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.ta_progressother).HasMaxLength(1100);
            entity.Property(e => e.ta_status).HasColumnType("int(11)");
            entity.Property(e => e.ta_superior).HasMaxLength(40);
            entity.Property(e => e.ta_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.ta_uname).HasMaxLength(40);
        });

        modelBuilder.Entity<teamapplyflow>(entity =>
        {
            entity.HasKey(e => e.taf_id).HasName("PRIMARY");

            entity.Property(e => e.taf_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.taf_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.taf_cname).HasMaxLength(40);
            entity.Property(e => e.taf_isallow)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.taf_note).HasMaxLength(200);
            entity.Property(e => e.taf_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.taf_taid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.taf_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.taf_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.taf_uname).HasMaxLength(40);
        });

        modelBuilder.Entity<teamapplymember>(entity =>
        {
            entity.HasKey(e => e.tam_id).HasName("PRIMARY");

            entity.Property(e => e.tam_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.tam_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.tam_cname).HasMaxLength(40);
            entity.Property(e => e.tam_did)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.tam_f1)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.tam_f10)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.tam_f10desc).HasMaxLength(400);
            entity.Property(e => e.tam_f11)
                .HasMaxLength(10)
                .HasDefaultValueSql("'1'");
            entity.Property(e => e.tam_f11desc).HasMaxLength(400);
            entity.Property(e => e.tam_f121).HasMaxLength(20);
            entity.Property(e => e.tam_f122).HasMaxLength(20);
            entity.Property(e => e.tam_f2)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.tam_f3)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.tam_f4)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.tam_f5)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.tam_f6)
                .HasDefaultValueSql("'7'")
                .HasColumnType("int(11)");
            entity.Property(e => e.tam_f61).HasMaxLength(400);
            entity.Property(e => e.tam_f62).HasMaxLength(400);
            entity.Property(e => e.tam_f63).HasMaxLength(400);
            entity.Property(e => e.tam_f7)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.tam_f8)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.tam_f91).HasMaxLength(100);
            entity.Property(e => e.tam_f92).HasMaxLength(100);
            entity.Property(e => e.tam_f93).HasMaxLength(100);
            entity.Property(e => e.tam_no)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.tam_note).HasMaxLength(200);
            entity.Property(e => e.tam_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.tam_taid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.tam_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.tam_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.tam_uname).HasMaxLength(40);
        });

        modelBuilder.Entity<teamoperation>(entity =>
        {
            entity.HasKey(e => e.to_id).HasName("PRIMARY");

            entity.Property(e => e.to_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.to_aid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.to_begdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.to_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.to_cname).HasMaxLength(40);
            entity.Property(e => e.to_content).HasMaxLength(4000);
            entity.Property(e => e.to_dharma).HasMaxLength(200);
            entity.Property(e => e.to_enddate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.to_file1).HasMaxLength(20);
            entity.Property(e => e.to_imp)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.to_iscombine)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.to_member).HasMaxLength(200);
            entity.Property(e => e.to_no)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.to_rdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.to_reply).HasMaxLength(4000);
            entity.Property(e => e.to_rname).HasMaxLength(20);
            entity.Property(e => e.to_ruid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.to_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.to_subject).HasMaxLength(200);
            entity.Property(e => e.to_taid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.to_team).HasMaxLength(100);
            entity.Property(e => e.to_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.to_uname).HasMaxLength(40);
        });

        modelBuilder.Entity<teamoperationmember>(entity =>
        {
            entity.HasKey(e => e.tom_id).HasName("PRIMARY");

            entity.Property(e => e.tom_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.tom_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.tom_cname).HasMaxLength(40);
            entity.Property(e => e.tom_no)
                .HasComment("體系序號")
                .HasColumnType("int(11)");
            entity.Property(e => e.tom_system)
                .HasMaxLength(100)
                .HasDefaultValueSql("'0'");
            entity.Property(e => e.tom_toid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.tom_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.tom_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.tom_uname).HasMaxLength(40);
            entity.Property(e => e.tom_usrname).HasMaxLength(40);
        });

        modelBuilder.Entity<teamtrans>(entity =>
        {
            entity.HasKey(e => e.tt_id).HasName("PRIMARY");

            entity.Property(e => e.tt_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.tt_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.tt_cname).HasMaxLength(40);
            entity.Property(e => e.tt_content).HasMaxLength(2000);
            entity.Property(e => e.tt_reason).HasMaxLength(2000);
            entity.Property(e => e.tt_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.tt_taid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.tt_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.tt_uname).HasMaxLength(40);
        });

        modelBuilder.Entity<totalfee>(entity =>
        {
            entity.HasKey(e => new { e.this_year, e.item_no, e.FEE_CODE }).HasName("PRIMARY");

            entity.Property(e => e.this_year)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.item_no)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.FEE_CODE)
                .HasMaxLength(10)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.memo).HasMaxLength(60);
            entity.Property(e => e.out_year).HasColumnType("int(11)");
            entity.Property(e => e.seq_no).HasColumnType("smallint(6)");
            entity.Property(e => e.status).HasColumnType("int(11)");
        });

        modelBuilder.Entity<view_readmessage>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("view_readmessage");

            entity.Property(e => e.rm_funcid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.rm_funcname).HasMaxLength(100);
            entity.Property(e => e.rm_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.tcount).HasColumnType("bigint(21)");
        });

        modelBuilder.Entity<vow>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.v_cdate).HasMaxLength(254);
            entity.Property(e => e.v_cid).HasMaxLength(254);
            entity.Property(e => e.v_class).HasMaxLength(254);
            entity.Property(e => e.v_cname).HasMaxLength(254);
            entity.Property(e => e.v_content).HasMaxLength(254);
            entity.Property(e => e.v_id).HasMaxLength(254);
            entity.Property(e => e.v_no).HasColumnType("int(11)");
            entity.Property(e => e.v_place).HasMaxLength(254);
            entity.Property(e => e.v_rno).HasColumnType("int(11)");
            entity.Property(e => e.v_rnote).HasMaxLength(254);
            entity.Property(e => e.v_status).HasColumnType("int(11)");
            entity.Property(e => e.v_type).HasColumnType("int(11)");
            entity.Property(e => e.v_udate).HasMaxLength(254);
            entity.Property(e => e.v_uid).HasMaxLength(254);
            entity.Property(e => e.v_uname).HasMaxLength(254);
            entity.Property(e => e.v_vdate).HasMaxLength(254);
            entity.Property(e => e.v_verdate).HasMaxLength(254);
            entity.Property(e => e.v_verdesc).HasMaxLength(254);
            entity.Property(e => e.v_vernote).HasMaxLength(254);
            entity.Property(e => e.v_vernote_old).HasMaxLength(254);
            entity.Property(e => e.v_verstatus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11) unsigned");
            entity.Property(e => e.v_veruid).HasMaxLength(254);
        });

        modelBuilder.Entity<vowdharma>(entity =>
        {
            entity.HasKey(e => e.vd_id).HasName("PRIMARY");

            entity.Property(e => e.vd_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.vd_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.vd_cid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.vd_class).HasMaxLength(100);
            entity.Property(e => e.vd_cname).HasMaxLength(40);
            entity.Property(e => e.vd_convention).HasMaxLength(60);
            entity.Property(e => e.vd_ddate)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.vd_duty).HasMaxLength(60);
            entity.Property(e => e.vd_group).HasMaxLength(60);
            entity.Property(e => e.vd_place).HasMaxLength(60);
            entity.Property(e => e.vd_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.vd_system)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.vd_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.vd_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.vd_uname).HasMaxLength(40);
            entity.Property(e => e.vd_vdate)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<vowverify>(entity =>
        {
            entity.HasKey(e => e.vv_id).HasName("PRIMARY");

            entity.HasIndex(e => e.vv_uid, "vv_uid");

            entity.HasIndex(e => e.vv_vid, "vv_vid");

            entity.Property(e => e.vv_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.vv_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.vv_cname).HasMaxLength(40);
            entity.Property(e => e.vv_date)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.vv_desc).HasMaxLength(100);
            entity.Property(e => e.vv_level)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.vv_status).HasColumnType("tinyint(4)");
            entity.Property(e => e.vv_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.vv_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.vv_uname).HasMaxLength(40);
            entity.Property(e => e.vv_vid)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<words>(entity =>
        {
            entity.HasKey(e => e.w_id).HasName("PRIMARY");

            entity.Property(e => e.w_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.w_category)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.w_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.w_cname).HasMaxLength(20);
            entity.Property(e => e.w_content).HasMaxLength(200);
            entity.Property(e => e.w_no)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)");
            entity.Property(e => e.w_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.w_uname).HasMaxLength(20);
        });

        modelBuilder.Entity<x_calendar>(entity =>
        {
            entity.HasKey(e => e.c_id).HasName("PRIMARY");

            entity.Property(e => e.c_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.c_area)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.c_begdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.c_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.c_cname).HasMaxLength(20);
            entity.Property(e => e.c_content).HasMaxLength(2000);
            entity.Property(e => e.c_enddate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.c_file).HasMaxLength(20);
            entity.Property(e => e.c_filedesc).HasMaxLength(60);
            entity.Property(e => e.c_place).HasMaxLength(100);
            entity.Property(e => e.c_title).HasMaxLength(80);
            entity.Property(e => e.c_type)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.c_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.c_uname).HasMaxLength(20);
        });

        modelBuilder.Entity<x_coursesignin>(entity =>
        {
            entity.HasKey(e => e.cs_id).HasName("PRIMARY");

            entity.Property(e => e.cs_id).HasColumnType("int(11)");
            entity.Property(e => e.cs_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.cs_cname).HasMaxLength(40);
            entity.Property(e => e.cs_sign).HasColumnType("int(11)");
            entity.Property(e => e.cs_signtime)
                .HasMaxLength(14)
                .IsFixedLength();
        });

        modelBuilder.Entity<x_courseuser>(entity =>
        {
            entity.HasKey(e => e.cu_id).HasName("PRIMARY");

            entity.Property(e => e.cu_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.cu_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.cu_cid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.cu_cname).HasMaxLength(40);
            entity.Property(e => e.cu_sign).HasColumnType("int(11)");
            entity.Property(e => e.cu_signtime).HasMaxLength(14);
            entity.Property(e => e.cu_type).HasColumnType("int(11)");
            entity.Property(e => e.cu_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.cu_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.cu_uname).HasMaxLength(40);
        });

        modelBuilder.Entity<x_donation>(entity =>
        {
            entity.HasKey(e => e.d_id).HasName("PRIMARY");

            entity.Property(e => e.d_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.d_bank).HasMaxLength(100);
            entity.Property(e => e.d_bankno).HasMaxLength(10);
            entity.Property(e => e.d_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.d_cname).HasMaxLength(40);
            entity.Property(e => e.d_ddate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.d_donateitem)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.d_handled).HasMaxLength(40);
            entity.Property(e => e.d_isprint).HasColumnType("int(11)");
            entity.Property(e => e.d_money)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.d_note).HasMaxLength(200);
            entity.Property(e => e.d_status).HasColumnType("int(11)");
            entity.Property(e => e.d_tempno).HasMaxLength(20);
            entity.Property(e => e.d_title).HasMaxLength(100);
            entity.Property(e => e.d_type).HasMaxLength(10);
            entity.Property(e => e.d_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.d_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.d_uname).HasMaxLength(40);
        });

        modelBuilder.Entity<x_duty>(entity =>
        {
            entity.HasKey(e => e.d_id).HasName("PRIMARY");

            entity.Property(e => e.d_id).HasColumnType("bigint(11)");
            entity.Property(e => e.d_aid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.d_aname).HasMaxLength(40);
            entity.Property(e => e.d_cdate).HasMaxLength(14);
            entity.Property(e => e.d_cid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.d_cname).HasMaxLength(20);
            entity.Property(e => e.d_date)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.d_note).HasMaxLength(100);
            entity.Property(e => e.d_status).HasColumnType("int(11)");
            entity.Property(e => e.d_udate).HasMaxLength(14);
            entity.Property(e => e.d_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.d_uname).HasMaxLength(20);
        });

        modelBuilder.Entity<x_dutylog>(entity =>
        {
            entity.HasKey(e => e.dl_id).HasName("PRIMARY");

            entity.Property(e => e.dl_id).HasColumnType("bigint(11)");
            entity.Property(e => e.dl_aid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.dl_aname).HasMaxLength(40);
            entity.Property(e => e.dl_cid).HasMaxLength(10);
            entity.Property(e => e.dl_date)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.dl_status).HasColumnType("int(11)");
            entity.Property(e => e.dl_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.dl_uname).HasMaxLength(20);
        });

        modelBuilder.Entity<x_epaper>(entity =>
        {
            entity.HasKey(e => e.ep_id).HasName("PRIMARY");

            entity.Property(e => e.ep_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.LC_ID).HasMaxLength(10);
            entity.Property(e => e.ep_catalog)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ep_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.ep_class).HasMaxLength(200);
            entity.Property(e => e.ep_cname).HasMaxLength(20);
            entity.Property(e => e.ep_content).HasColumnType("text");
            entity.Property(e => e.ep_filedesc1).HasMaxLength(200);
            entity.Property(e => e.ep_filedesc10).HasMaxLength(200);
            entity.Property(e => e.ep_filedesc2).HasMaxLength(200);
            entity.Property(e => e.ep_filedesc3).HasMaxLength(200);
            entity.Property(e => e.ep_filedesc4).HasMaxLength(200);
            entity.Property(e => e.ep_filedesc5).HasMaxLength(200);
            entity.Property(e => e.ep_filedesc6).HasMaxLength(200);
            entity.Property(e => e.ep_filedesc7).HasMaxLength(200);
            entity.Property(e => e.ep_filedesc8).HasMaxLength(200);
            entity.Property(e => e.ep_filedesc9).HasMaxLength(200);
            entity.Property(e => e.ep_name).HasMaxLength(200);
            entity.Property(e => e.ep_no).HasColumnType("int(11)");
            entity.Property(e => e.ep_pdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.ep_status).HasColumnType("int(11)");
            entity.Property(e => e.ep_title).HasMaxLength(100);
            entity.Property(e => e.ep_type)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ep_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.ep_uname).HasMaxLength(20);
        });

        modelBuilder.Entity<x_epaper_st>(entity =>
        {
            entity.HasKey(e => e.ep_id).HasName("PRIMARY");

            entity.Property(e => e.ep_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ep_catalog)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ep_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.ep_class).HasMaxLength(100);
            entity.Property(e => e.ep_cname).HasMaxLength(20);
            entity.Property(e => e.ep_content).HasColumnType("text");
            entity.Property(e => e.ep_name).HasMaxLength(100);
            entity.Property(e => e.ep_no).HasColumnType("int(11)");
            entity.Property(e => e.ep_pdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.ep_status).HasColumnType("int(11)");
            entity.Property(e => e.ep_title).HasMaxLength(100);
            entity.Property(e => e.ep_type)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ep_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.ep_uname).HasMaxLength(20);
        });

        modelBuilder.Entity<x_epaperlog>(entity =>
        {
            entity.HasKey(e => e.el_id).HasName("PRIMARY");

            entity.Property(e => e.el_id).HasColumnType("bigint(11)");
            entity.Property(e => e.el_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.el_desc).HasMaxLength(2000);
            entity.Property(e => e.el_eid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.el_email).HasMaxLength(200);
            entity.Property(e => e.el_status).HasColumnType("int(11)");
            entity.Property(e => e.el_type).HasColumnType("int(11)");
        });

        modelBuilder.Entity<x_mailfrom>(entity =>
        {
            entity.HasKey(e => e.mf_id).HasName("PRIMARY");

            entity.Property(e => e.mf_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.mf_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.mf_cname).HasMaxLength(100);
            entity.Property(e => e.mf_content).HasColumnType("text");
            entity.Property(e => e.mf_file1).HasMaxLength(20);
            entity.Property(e => e.mf_file1desc).HasMaxLength(200);
            entity.Property(e => e.mf_file2).HasMaxLength(20);
            entity.Property(e => e.mf_file2desc).HasMaxLength(200);
            entity.Property(e => e.mf_file3).HasMaxLength(20);
            entity.Property(e => e.mf_file3desc).HasMaxLength(200);
            entity.Property(e => e.mf_file4).HasMaxLength(20);
            entity.Property(e => e.mf_file4desc).HasMaxLength(200);
            entity.Property(e => e.mf_file5).HasMaxLength(20);
            entity.Property(e => e.mf_file5desc).HasMaxLength(200);
            entity.Property(e => e.mf_imp).HasColumnType("int(200)");
            entity.Property(e => e.mf_pdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.mf_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.mf_tounit).HasMaxLength(200);
            entity.Property(e => e.mf_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.mf_unitname).HasMaxLength(100);
        });

        modelBuilder.Entity<x_mailreply>(entity =>
        {
            entity.HasKey(e => e.mr_id).HasName("PRIMARY");

            entity.Property(e => e.mr_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.mr_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.mr_cname).HasMaxLength(20);
            entity.Property(e => e.mr_content).HasColumnType("text");
            entity.Property(e => e.mr_mfid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.mr_status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.mr_uid)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<x_mailto>(entity =>
        {
            entity.HasKey(e => e.mt_id).HasName("PRIMARY");

            entity.Property(e => e.mt_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.mt_cdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.mt_checkdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.mt_ischeck).HasColumnType("int(11)");
            entity.Property(e => e.mt_mfid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.mt_status).HasColumnType("int(11)");
            entity.Property(e => e.mt_uid)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.mt_uname).HasMaxLength(20);
        });

        modelBuilder.Entity<x_training>(entity =>
        {
            entity.HasKey(e => e.t_id).HasName("PRIMARY");

            entity.Property(e => e.t_id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.t_adate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.t_begdate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.t_cdate).HasMaxLength(60);
            entity.Property(e => e.t_contact).HasMaxLength(20);
            entity.Property(e => e.t_content).HasMaxLength(2000);
            entity.Property(e => e.t_enddate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.t_file).HasMaxLength(20);
            entity.Property(e => e.t_filedesc)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.t_formsresulturl).HasMaxLength(200);
            entity.Property(e => e.t_formsurl).HasMaxLength(200);
            entity.Property(e => e.t_ischeck).HasColumnType("int(11)");
            entity.Property(e => e.t_license).HasMaxLength(200);
            entity.Property(e => e.t_name).HasMaxLength(120);
            entity.Property(e => e.t_place).HasMaxLength(120);
            entity.Property(e => e.t_type)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.t_udate)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.t_uname).HasMaxLength(20);
            entity.Property(e => e.t_unit).HasMaxLength(80);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
