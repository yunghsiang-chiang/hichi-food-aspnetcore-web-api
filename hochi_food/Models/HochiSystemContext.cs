using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace hochi_food.Models;

public partial class HochiSystemContext : DbContext
{
    public HochiSystemContext(DbContextOptions<HochiSystemContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CourseList> CourseList { get; set; }

    public virtual DbSet<Course_BackendList> Course_BackendList { get; set; }

    public virtual DbSet<CulturalCourse_BookingList> CulturalCourse_BookingList { get; set; }

    public virtual DbSet<CulturalDonateReport> CulturalDonateReport { get; set; }

    public virtual DbSet<DonateReport> DonateReport { get; set; }

    public virtual DbSet<HACMaterial> HACMaterial { get; set; }

    public virtual DbSet<HACMaterialRecord> HACMaterialRecord { get; set; }

    public virtual DbSet<HACMaterial_Class> HACMaterial_Class { get; set; }

    public virtual DbSet<HActivity> HActivity { get; set; }

    public virtual DbSet<HActivity_Class> HActivity_Class { get; set; }

    public virtual DbSet<HArea> HArea { get; set; }

    public virtual DbSet<HAreaHistory> HAreaHistory { get; set; }

    public virtual DbSet<HAxisCTeam> HAxisCTeam { get; set; }

    public virtual DbSet<HAxisMTeam> HAxisMTeam { get; set; }

    public virtual DbSet<HAxisType> HAxisType { get; set; }

    public virtual DbSet<HBudgetType> HBudgetType { get; set; }

    public virtual DbSet<HCBChangeRecord> HCBChangeRecord { get; set; }

    public virtual DbSet<HCCPControl> HCCPControl { get; set; }

    public virtual DbSet<HCCPOPaidRecord> HCCPOPaidRecord { get; set; }

    public virtual DbSet<HCCPOTRecord> HCCPOTRecord { get; set; }

    public virtual DbSet<HCCPOrder> HCCPOrder { get; set; }

    public virtual DbSet<HCCPOrderDetail> HCCPOrderDetail { get; set; }

    public virtual DbSet<HCCPeriod> HCCPeriod { get; set; }

    public virtual DbSet<HCCRegular> HCCRegular { get; set; }

    public virtual DbSet<HCDeadline> HCDeadline { get; set; }

    public virtual DbSet<HCMaterialRecord> HCMaterialRecord { get; set; }

    public virtual DbSet<HCTLeaderHistory> HCTLeaderHistory { get; set; }

    public virtual DbSet<HCTeam> HCTeam { get; set; }

    public virtual DbSet<HCVerifyLog> HCVerifyLog { get; set; }

    public virtual DbSet<HCVerifyUnit> HCVerifyUnit { get; set; }

    public virtual DbSet<HCancelBooking> HCancelBooking { get; set; }

    public virtual DbSet<HColCategory> HColCategory { get; set; }

    public virtual DbSet<HColParmTab> HColParmTab { get; set; }

    public virtual DbSet<HCountry> HCountry { get; set; }

    public virtual DbSet<HCourse> HCourse { get; set; }

    public virtual DbSet<HCourseBooking> HCourseBooking { get; set; }

    public virtual DbSet<HCourseBooking_Activity> HCourseBooking_Activity { get; set; }

    public virtual DbSet<HCourseBooking_DateAttend> HCourseBooking_DateAttend { get; set; }

    public virtual DbSet<HCourseBooking_Group> HCourseBooking_Group { get; set; }

    public virtual DbSet<HCourseBooking_Other> HCourseBooking_Other { get; set; }

    public virtual DbSet<HCourseCombine> HCourseCombine { get; set; }

    public virtual DbSet<HCourseDate> HCourseDate { get; set; }

    public virtual DbSet<HCourseEvaluation> HCourseEvaluation { get; set; }

    public virtual DbSet<HCourseHomework> HCourseHomework { get; set; }

    public virtual DbSet<HCourseKeyWord> HCourseKeyWord { get; set; }

    public virtual DbSet<HCourseLevel> HCourseLevel { get; set; }

    public virtual DbSet<HCourseList_View> HCourseList_View { get; set; }

    public virtual DbSet<HCourseMaterial> HCourseMaterial { get; set; }

    public virtual DbSet<HCourseMaterial_T> HCourseMaterial_T { get; set; }

    public virtual DbSet<HCoursePackage> HCoursePackage { get; set; }

    public virtual DbSet<HCoursePackage_Detail> HCoursePackage_Detail { get; set; }

    public virtual DbSet<HCourseTMaterial> HCourseTMaterial { get; set; }

    public virtual DbSet<HCourseTMaterial_T> HCourseTMaterial_T { get; set; }

    public virtual DbSet<HCourseTask> HCourseTask { get; set; }

    public virtual DbSet<HCourseVerifyList> HCourseVerifyList { get; set; }

    public virtual DbSet<HCourse_Class> HCourse_Class { get; set; }

    public virtual DbSet<HCourse_EIP> HCourse_EIP { get; set; }

    public virtual DbSet<HCourse_HWSetting> HCourse_HWSetting { get; set; }

    public virtual DbSet<HCourse_Merge> HCourse_Merge { get; set; }

    public virtual DbSet<HCourse_MergeCopy> HCourse_MergeCopy { get; set; }

    public virtual DbSet<HCourse_T> HCourse_T { get; set; }

    public virtual DbSet<HDCGListTemp> HDCGListTemp { get; set; }

    public virtual DbSet<HDCGroup> HDCGroup { get; set; }

    public virtual DbSet<HDOFVerifyLog> HDOFVerifyLog { get; set; }

    public virtual DbSet<HDPurpose> HDPurpose { get; set; }

    public virtual DbSet<HDayOffForm> HDayOffForm { get; set; }

    public virtual DbSet<HDharma> HDharma { get; set; }

    public virtual DbSet<HDharmaType> HDharmaType { get; set; }

    public virtual DbSet<HDiscountCode> HDiscountCode { get; set; }

    public virtual DbSet<HDocCType> HDocCType { get; set; }

    public virtual DbSet<HDocCTypeClass> HDocCTypeClass { get; set; }

    public virtual DbSet<HDonationItem> HDonationItem { get; set; }

    public virtual DbSet<HEPItem> HEPItem { get; set; }

    public virtual DbSet<HEPType> HEPType { get; set; }

    public virtual DbSet<HExamBase> HExamBase { get; set; }

    public virtual DbSet<HExamBaseAnswer> HExamBaseAnswer { get; set; }

    public virtual DbSet<HExamBaseItem> HExamBaseItem { get; set; }

    public virtual DbSet<HExamClassRoom> HExamClassRoom { get; set; }

    public virtual DbSet<HExamContent> HExamContent { get; set; }

    public virtual DbSet<HExamContentDetail> HExamContentDetail { get; set; }

    public virtual DbSet<HExamFee> HExamFee { get; set; }

    public virtual DbSet<HExamJoin> HExamJoin { get; set; }

    public virtual DbSet<HExamPaper> HExamPaper { get; set; }

    public virtual DbSet<HExamPaperAnswer> HExamPaperAnswer { get; set; }

    public virtual DbSet<HExamPaperItem> HExamPaperItem { get; set; }

    public virtual DbSet<HExamParmTab> HExamParmTab { get; set; }

    public virtual DbSet<HExamScore> HExamScore { get; set; }

    public virtual DbSet<HExamSubject> HExamSubject { get; set; }

    public virtual DbSet<HExamSubjectClassRoom> HExamSubjectClassRoom { get; set; }

    public virtual DbSet<HFParmTab> HFParmTab { get; set; }

    public virtual DbSet<HFeelingsJournals> HFeelingsJournals { get; set; }

    public virtual DbSet<HFeelingsJournalsMsg> HFeelingsJournalsMsg { get; set; }

    public virtual DbSet<HFileType> HFileType { get; set; }

    public virtual DbSet<HGroup> HGroup { get; set; }

    public virtual DbSet<HIndexSlide> HIndexSlide { get; set; }

    public virtual DbSet<HInvoiceTemp> HInvoiceTemp { get; set; }

    public virtual DbSet<HLArea> HLArea { get; set; }

    public virtual DbSet<HLCourse> HLCourse { get; set; }

    public virtual DbSet<HLCourse_Detail> HLCourse_Detail { get; set; }

    public virtual DbSet<HLeadingCourse> HLeadingCourse { get; set; }

    public virtual DbSet<HLeadingCourse_T> HLeadingCourse_T { get; set; }

    public virtual DbSet<HLogs_HPosition> HLogs_HPosition { get; set; }

    public virtual DbSet<HMMentorRelationship> HMMentorRelationship { get; set; }

    public virtual DbSet<HMTLeaderHistory> HMTLeaderHistory { get; set; }

    public virtual DbSet<HMTeam> HMTeam { get; set; }

    public virtual DbSet<HMType> HMType { get; set; }

    public virtual DbSet<HMailRecord> HMailRecord { get; set; }

    public virtual DbSet<HMember> HMember { get; set; }

    public virtual DbSet<HMemberTemp> HMemberTemp { get; set; }

    public virtual DbSet<HMentorRole> HMentorRole { get; set; }

    public virtual DbSet<HMentorType> HMentorType { get; set; }

    public virtual DbSet<HMonth> HMonth { get; set; }

    public virtual DbSet<HNews> HNews { get; set; }

    public virtual DbSet<HNews_Class> HNews_Class { get; set; }

    public virtual DbSet<HNotification> HNotification { get; set; }

    public virtual DbSet<HPBookingList> HPBookingList { get; set; }

    public virtual DbSet<HPBookingReport> HPBookingReport { get; set; }

    public virtual DbSet<HParmTab> HParmTab { get; set; }

    public virtual DbSet<HPlace> HPlace { get; set; }

    public virtual DbSet<HPlaceList> HPlaceList { get; set; }

    public virtual DbSet<HPlacePriority> HPlacePriority { get; set; }

    public virtual DbSet<HPointBooking> HPointBooking { get; set; }

    public virtual DbSet<HPoints> HPoints { get; set; }

    public virtual DbSet<HPoints_bk> HPoints_bk { get; set; }

    public virtual DbSet<HPopularTags> HPopularTags { get; set; }

    public virtual DbSet<HPositionHistory> HPositionHistory { get; set; }

    public virtual DbSet<HQualify> HQualify { get; set; }

    public virtual DbSet<HQuestion> HQuestion { get; set; }

    public virtual DbSet<HQuestionAnswer> HQuestionAnswer { get; set; }

    public virtual DbSet<HQuestionItem> HQuestionItem { get; set; }

    public virtual DbSet<HReceiptTemp> HReceiptTemp { get; set; }

    public virtual DbSet<HRelation> HRelation { get; set; }

    public virtual DbSet<HRole> HRole { get; set; }

    public virtual DbSet<HRoleMListTemp> HRoleMListTemp { get; set; }

    public virtual DbSet<HRollCall> HRollCall { get; set; }

    public virtual DbSet<HRoom> HRoom { get; set; }

    public virtual DbSet<HSCCTopicSetting> HSCCTopicSetting { get; set; }

    public virtual DbSet<HSCClass> HSCClass { get; set; }

    public virtual DbSet<HSCForumClass> HSCForumClass { get; set; }

    public virtual DbSet<HSCGProgress> HSCGProgress { get; set; }

    public virtual DbSet<HSCGRMsg> HSCGRMsg { get; set; }

    public virtual DbSet<HSCGRMsgResponse> HSCGRMsgResponse { get; set; }

    public virtual DbSet<HSCGRMsgResponse_Log> HSCGRMsgResponse_Log { get; set; }

    public virtual DbSet<HSCGRMsg_Mood> HSCGRMsg_Mood { get; set; }

    public virtual DbSet<HSCGRecord> HSCGRecord { get; set; }

    public virtual DbSet<HSCGRecord_Mood> HSCGRecord_Mood { get; set; }

    public virtual DbSet<HSCGRecord_Share> HSCGRecord_Share { get; set; }

    public virtual DbSet<HSCGRecord_View> HSCGRecord_View { get; set; }

    public virtual DbSet<HSCHotHashTag> HSCHotHashTag { get; set; }

    public virtual DbSet<HSCMPublicYN> HSCMPublicYN { get; set; }

    public virtual DbSet<HSCMPublicYN_Log> HSCMPublicYN_Log { get; set; }

    public virtual DbSet<HSCMRule> HSCMRule { get; set; }

    public virtual DbSet<HSCMRule_Log> HSCMRule_Log { get; set; }

    public virtual DbSet<HSCModeratorSetting> HSCModeratorSetting { get; set; }

    public virtual DbSet<HSCParmTab> HSCParmTab { get; set; }

    public virtual DbSet<HSCRecordType> HSCRecordType { get; set; }

    public virtual DbSet<HSCRule_T> HSCRule_T { get; set; }

    public virtual DbSet<HSCTMsg> HSCTMsg { get; set; }

    public virtual DbSet<HSCTMsgResponse> HSCTMsgResponse { get; set; }

    public virtual DbSet<HSCTMsgResponse_Log> HSCTMsgResponse_Log { get; set; }

    public virtual DbSet<HSCTMsg_Log> HSCTMsg_Log { get; set; }

    public virtual DbSet<HSCTMsg_Mood> HSCTMsg_Mood { get; set; }

    public virtual DbSet<HSCTopic> HSCTopic { get; set; }

    public virtual DbSet<HSCTopic_Log> HSCTopic_Log { get; set; }

    public virtual DbSet<HSCTopic_Mood> HSCTopic_Mood { get; set; }

    public virtual DbSet<HSCTopic_Role> HSCTopic_Role { get; set; }

    public virtual DbSet<HSCTopic_Share> HSCTopic_Share { get; set; }

    public virtual DbSet<HSCTopic_View> HSCTopic_View { get; set; }

    public virtual DbSet<HSCourseKeyWord> HSCourseKeyWord { get; set; }

    public virtual DbSet<HShoppingCart> HShoppingCart { get; set; }

    public virtual DbSet<HShoppingCart_Activity> HShoppingCart_Activity { get; set; }

    public virtual DbSet<HShoppingCart_Group> HShoppingCart_Group { get; set; }

    public virtual DbSet<HShoppingCart_Other> HShoppingCart_Other { get; set; }

    public virtual DbSet<HSystem> HSystem { get; set; }

    public virtual DbSet<HSystemFeedback> HSystemFeedback { get; set; }

    public virtual DbSet<HTArea> HTArea { get; set; }

    public virtual DbSet<HTAreaUnit> HTAreaUnit { get; set; }

    public virtual DbSet<HTMaterial_View> HTMaterial_View { get; set; }

    public virtual DbSet<HTMaterial_View_old> HTMaterial_View_old { get; set; }

    public virtual DbSet<HTVerifyLog> HTVerifyLog { get; set; }

    public virtual DbSet<HTask_Class> HTask_Class { get; set; }

    public virtual DbSet<HTeacher> HTeacher { get; set; }

    public virtual DbSet<HTeacherMaterial> HTeacherMaterial { get; set; }

    public virtual DbSet<HTeacherMaterial_Detail> HTeacherMaterial_Detail { get; set; }

    public virtual DbSet<HTeamHistory> HTeamHistory { get; set; }

    public virtual DbSet<HTeamTVerifyLog> HTeamTVerifyLog { get; set; }

    public virtual DbSet<HTeamTransfer> HTeamTransfer { get; set; }

    public virtual DbSet<HTest> HTest { get; set; }

    public virtual DbSet<HTodoList> HTodoList { get; set; }

    public virtual DbSet<HTodoList_T> HTodoList_T { get; set; }

    public virtual DbSet<HTopicTypeRec> HTopicTypeRec { get; set; }

    public virtual DbSet<HTreePeople> HTreePeople { get; set; }

    public virtual DbSet<HTreeStructure> HTreeStructure { get; set; }

    public virtual DbSet<HUTaskHistory> HUTaskHistory { get; set; }

    public virtual DbSet<HVerifyType> HVerifyType { get; set; }

    public virtual DbSet<HWTItem> HWTItem { get; set; }

    public virtual DbSet<HWType> HWType { get; set; }

    public virtual DbSet<HWay> HWay { get; set; }

    public virtual DbSet<Invoice> Invoice { get; set; }

    public virtual DbSet<InvoiceReport> InvoiceReport { get; set; }

    public virtual DbSet<MemberBasicInfo> MemberBasicInfo { get; set; }

    public virtual DbSet<MemberList> MemberList { get; set; }

    public virtual DbSet<OrderList> OrderList { get; set; }

    public virtual DbSet<OrderList_Backend> OrderList_Backend { get; set; }

    public virtual DbSet<OrderList_Detail> OrderList_Detail { get; set; }

    public virtual DbSet<OrderList_Front> OrderList_Front { get; set; }

    public virtual DbSet<OrderList_Merge> OrderList_Merge { get; set; }

    public virtual DbSet<OrderList_Zoom> OrderList_Zoom { get; set; }

    public virtual DbSet<OrderReport> OrderReport { get; set; }

    public virtual DbSet<ReceiptReport> ReceiptReport { get; set; }

    public virtual DbSet<ReceiptReport_Group> ReceiptReport_Group { get; set; }

    public virtual DbSet<RemainPoints> RemainPoints { get; set; }

    public virtual DbSet<_99_FoundationBooking> _99_FoundationBooking { get; set; }

    public virtual DbSet<_99_HPUsingReport> _99_HPUsingReport { get; set; }

    public virtual DbSet<_99_ReceiptReport> _99_ReceiptReport { get; set; }

    public virtual DbSet<psn_class_20220626_1_> psn_class_20220626_1_ { get; set; }

    public virtual DbSet<sqlmapoutput> sqlmapoutput { get; set; }

    public virtual DbSet<ssqlinjection> ssqlinjection { get; set; }

    public virtual DbSet<xx_Invoice> xx_Invoice { get; set; }

    public virtual DbSet<工作表1_> 工作表1_ { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CourseList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CourseList");

            entity.Property(e => e.HBCPoint).HasMaxLength(10);
            entity.Property(e => e.HCBatchNum).HasMaxLength(50);
            entity.Property(e => e.HCDeadline).HasMaxLength(50);
            entity.Property(e => e.HContentTitle).HasMaxLength(200);
            entity.Property(e => e.HCourseName).HasMaxLength(100);
            entity.Property(e => e.HCourseNum).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HETime).HasMaxLength(30);
            entity.Property(e => e.HIRestriction).HasMaxLength(200);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HOCPlace).HasMaxLength(50);
            entity.Property(e => e.HPMethod).HasMaxLength(50);
            entity.Property(e => e.HSTime).HasMaxLength(30);
            entity.Property(e => e.HTeacherName).HasMaxLength(50);
            entity.Property(e => e.HTime).HasMaxLength(61);
            entity.Property(e => e.Location).HasMaxLength(255);
        });

        modelBuilder.Entity<Course_BackendList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Course_BackendList");

            entity.Property(e => e.HCourseName).HasMaxLength(100);
            entity.Property(e => e.HCourseNum).HasMaxLength(50);
            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HOCPlace).HasMaxLength(50);
            entity.Property(e => e.HPlaceName).HasMaxLength(255);
            entity.Property(e => e.HSave).HasMaxLength(10);
            entity.Property(e => e.HTeacherName).HasMaxLength(50);
            entity.Property(e => e.Row_).HasColumnName("Row#");
        });

        modelBuilder.Entity<CulturalCourse_BookingList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CulturalCourse_BookingList");

            entity.Property(e => e.HCourseName).HasMaxLength(100);
            entity.Property(e => e.HMerchantTradeNo).HasMaxLength(50);
            entity.Property(e => e.HOrderGroup).HasMaxLength(100);
            entity.Property(e => e.HOrderNum).HasMaxLength(50);
            entity.Property(e => e.HPaymentDate).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(281);
            entity.Property(e => e.PayMethod)
                .HasMaxLength(13)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CulturalDonateReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CulturalDonateReport");

            entity.Property(e => e.CoursePrice).HasMaxLength(50);
            entity.Property(e => e.DonateDate)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.HArea).HasMaxLength(255);
            entity.Property(e => e.HMerchantTradeNo).HasMaxLength(50);
            entity.Property(e => e.HOrderGroup).HasMaxLength(100);
            entity.Property(e => e.HOrderNum).HasMaxLength(50);
            entity.Property(e => e.HPeriod).HasMaxLength(25);
            entity.Property(e => e.InvoiceTitle).HasMaxLength(255);
            entity.Property(e => e.PayMethod)
                .HasMaxLength(13)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DonateReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DonateReport");

            entity.Property(e => e.Aboard)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Address)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.BTitle)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.BankType)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.DItem)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.DPurpose)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Donate)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.DonateDate)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.DonatePerson).HasMaxLength(255);
            entity.Property(e => e.HAccount).HasMaxLength(255);
            entity.Property(e => e.HPersonID).HasMaxLength(30);
            entity.Property(e => e.HPhone).HasMaxLength(4000);
            entity.Property(e => e.HPoint).HasMaxLength(50);
            entity.Property(e => e.ICBank)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.ICDate)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceTitle).HasMaxLength(255);
            entity.Property(e => e.InvoiceType)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.PayMethod)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.Postal)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Remark).HasMaxLength(202);
            entity.Property(e => e.Tax)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Tel)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.TempNo)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HACMaterial>(entity =>
        {
            entity.HasKey(e => e.HID).HasName("PK_HACMaterial_1");

            entity.Property(e => e.HCMName).HasMaxLength(100);
            entity.Property(e => e.HCourseName).HasMaxLength(100);
            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HEIPLink).HasMaxLength(250);
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HSave).HasMaxLength(10);
            entity.Property(e => e.HUP1).HasMaxLength(100);
            entity.Property(e => e.HUP2).HasMaxLength(100);
            entity.Property(e => e.HUP3).HasMaxLength(100);
            entity.Property(e => e.HUP4).HasMaxLength(100);
            entity.Property(e => e.HUP5).HasMaxLength(100);
        });

        modelBuilder.Entity<HACMaterialRecord>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
        });

        modelBuilder.Entity<HACMaterial_Class>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HACMClass).HasMaxLength(10);
            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
        });

        modelBuilder.Entity<HActivity>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
        });

        modelBuilder.Entity<HActivity_Class>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
        });

        modelBuilder.Entity<HArea>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HArea1)
                .HasMaxLength(255)
                .HasColumnName("HArea");
            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
        });

        modelBuilder.Entity<HAreaHistory>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.HCDate).HasMaxLength(50);
            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HID).ValueGeneratedOnAdd();
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HNew).HasMaxLength(50);
            entity.Property(e => e.HOld).HasMaxLength(50);
        });

        modelBuilder.Entity<HAxisCTeam>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HType).HasMaxLength(10);
        });

        modelBuilder.Entity<HAxisMTeam>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HType).HasMaxLength(10);
        });

        modelBuilder.Entity<HAxisType>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HAxisType1)
                .HasMaxLength(250)
                .HasColumnName("HAxisType");
            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
        });

        modelBuilder.Entity<HBudgetType>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.HCode).HasMaxLength(50);
            entity.Property(e => e.HContent).HasMaxLength(200);
            entity.Property(e => e.HCreate).HasMaxLength(200);
            entity.Property(e => e.HCreateDT).HasMaxLength(30);
            entity.Property(e => e.HID).ValueGeneratedOnAdd();
            entity.Property(e => e.HItem).HasMaxLength(200);
            entity.Property(e => e.HModify).HasMaxLength(200);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
        });

        modelBuilder.Entity<HCBChangeRecord>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HATMBankCode).HasMaxLength(50);
            entity.Property(e => e.HATMVAccount).HasMaxLength(100);
            entity.Property(e => e.HAttendSrc).HasMaxLength(50);
            entity.Property(e => e.HBDate).HasMaxLength(30);
            entity.Property(e => e.HCPkgHIDSrc).HasMaxLength(50);
            entity.Property(e => e.HCourseIDSrc).HasMaxLength(50);
            entity.Property(e => e.HCourseName).HasMaxLength(100);
            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HDCode).HasMaxLength(30);
            entity.Property(e => e.HDPoint).HasMaxLength(30);
            entity.Property(e => e.HExpireDate).HasMaxLength(50);
            entity.Property(e => e.HGwsr).HasMaxLength(50);
            entity.Property(e => e.HInvoiceDate).HasMaxLength(50);
            entity.Property(e => e.HInvoiceNo).HasMaxLength(100);
            entity.Property(e => e.HMemberGroup).HasMaxLength(20);
            entity.Property(e => e.HMerchantTradeNo).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HOrderGroupNew).HasMaxLength(100);
            entity.Property(e => e.HOrderGroupSrc).HasMaxLength(100);
            entity.Property(e => e.HOrderNumNew).HasMaxLength(50);
            entity.Property(e => e.HOrderNumSrc).HasMaxLength(50);
            entity.Property(e => e.HPayMethod).HasMaxLength(30);
            entity.Property(e => e.HPaymentDate).HasMaxLength(50);
            entity.Property(e => e.HPaymentNo).HasMaxLength(100);
            entity.Property(e => e.HPoint).HasMaxLength(50);
            entity.Property(e => e.HRoomTime).HasMaxLength(30);
            entity.Property(e => e.HRtnCode).HasMaxLength(100);
            entity.Property(e => e.HSubscribe).HasMaxLength(20);
            entity.Property(e => e.HTaxID).HasMaxLength(20);
            entity.Property(e => e.HTradeNo).HasMaxLength(50);
        });

        modelBuilder.Entity<HCCPControl>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCCPControl1).HasColumnName("HCCPControl");
            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
        });

        modelBuilder.Entity<HCCPOPaidRecord>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HID).HasComment("流水號");
            entity.Property(e => e.HCCPODetailID).HasComment("關連信用卡授權訂單明細.HID (HCCPODetail.HID)");
            entity.Property(e => e.HCreate)
                .HasMaxLength(100)
                .HasComment("建立者");
            entity.Property(e => e.HCreateDT)
                .HasMaxLength(50)
                .HasComment("建立日期");
            entity.Property(e => e.HModify)
                .HasMaxLength(100)
                .HasComment("修改者");
            entity.Property(e => e.HModifyDT)
                .HasMaxLength(50)
                .HasComment("修改日期");
            entity.Property(e => e.HPayAmount).HasComment("付款金額");
            entity.Property(e => e.HPayMethod)
                .HasMaxLength(20)
                .HasComment("付款方式 (1=EIP付款、2=ATM匯款)");
            entity.Property(e => e.HPayStatus).HasComment("付款狀態");
            entity.Property(e => e.HPaymentDate)
                .HasMaxLength(50)
                .HasComment("付款日期");
            entity.Property(e => e.HRemark)
                .HasMaxLength(255)
                .HasComment("備註");
            entity.Property(e => e.HStatus).HasComment("狀態");
        });

        modelBuilder.Entity<HCCPOTRecord>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HGwsr)
                .HasMaxLength(50)
                .HasComment("信用卡授權交易單號");
            entity.Property(e => e.HMerchantTradeNo).HasMaxLength(100);
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HProcessDate).HasMaxLength(100);
            entity.Property(e => e.HRtnMsg).HasMaxLength(100);
            entity.Property(e => e.HTradeNo)
                .HasMaxLength(50)
                .HasComment("綠界交易編號");
        });

        modelBuilder.Entity<HCCPOrder>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCCPImportNum).HasMaxLength(100);
            entity.Property(e => e.HCCPOrderCode).HasMaxLength(100);
            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HPaperYN).HasComment("是否為紙本");
        });

        modelBuilder.Entity<HCCPOrderDetail>(entity =>
        {
            entity.HasKey(e => e.HID).HasName("PK_HCCPOrderDetail_1");

            entity.Property(e => e.HCCPeriodCode)
                .HasMaxLength(100)
                .HasComment("信用卡定期定額授權申請單號");
            entity.Property(e => e.HCHPersonID).HasMaxLength(30);
            entity.Property(e => e.HCHPhone).HasMaxLength(30);
            entity.Property(e => e.HCVCCode).HasMaxLength(20);
            entity.Property(e => e.HCardBank).HasMaxLength(100);
            entity.Property(e => e.HCardHolder).HasMaxLength(255);
            entity.Property(e => e.HCardNum).HasMaxLength(50);
            entity.Property(e => e.HCardValidDate).HasMaxLength(30);
            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HDBirth).HasMaxLength(50);
            entity.Property(e => e.HDCCPEDate).HasMaxLength(20);
            entity.Property(e => e.HDCCPSDate).HasMaxLength(20);
            entity.Property(e => e.HDEmail).HasMaxLength(255);
            entity.Property(e => e.HDItem).HasComment("捐款項目");
            entity.Property(e => e.HDPersonID).HasMaxLength(30);
            entity.Property(e => e.HDPhone).HasMaxLength(30);
            entity.Property(e => e.HDPostal).HasMaxLength(50);
            entity.Property(e => e.HDPurpose).HasComment("捐款用途");
            entity.Property(e => e.HDTel).HasMaxLength(50);
            entity.Property(e => e.HDUserName).HasMaxLength(255);
            entity.Property(e => e.HMemberID).HasComment("學員HID");
            entity.Property(e => e.HMerchantTradeNo).HasMaxLength(100);
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HPaperYN).HasComment("是否為紙本");
            entity.Property(e => e.HRtnCode).HasComment("匯入綠界信用卡定期定額授權訂單之回傳交易回應碼(1=已授權，其他為失敗)");
            entity.Property(e => e.HRtnMsg)
                .HasMaxLength(100)
                .HasComment("綠界回傳之授權狀態訊息");
        });

        modelBuilder.Entity<HCCPeriod>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCCPeriodCode)
                .HasMaxLength(100)
                .HasComment("信用卡定期定額授權申請單號");
            entity.Property(e => e.HCHPersonID).HasMaxLength(30);
            entity.Property(e => e.HCHPhone).HasMaxLength(30);
            entity.Property(e => e.HCVCCode).HasMaxLength(20);
            entity.Property(e => e.HCardBank).HasMaxLength(100);
            entity.Property(e => e.HCardHolder).HasMaxLength(255);
            entity.Property(e => e.HCardNum).HasMaxLength(50);
            entity.Property(e => e.HCardValidDate).HasMaxLength(30);
            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HDBirth).HasMaxLength(50);
            entity.Property(e => e.HDCCPEDate).HasMaxLength(20);
            entity.Property(e => e.HDCCPSDate).HasMaxLength(20);
            entity.Property(e => e.HDEmail).HasMaxLength(255);
            entity.Property(e => e.HDItem).HasComment("捐款項目");
            entity.Property(e => e.HDPersonID).HasMaxLength(30);
            entity.Property(e => e.HDPhone).HasMaxLength(30);
            entity.Property(e => e.HDPostal).HasMaxLength(50);
            entity.Property(e => e.HDPurpose).HasComment("捐款用途");
            entity.Property(e => e.HDTel).HasMaxLength(50);
            entity.Property(e => e.HDUserName).HasMaxLength(255);
            entity.Property(e => e.HMemberID).HasComment("學員HID");
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HNewDCCPSDate).HasMaxLength(50);
            entity.Property(e => e.HOrderGroup).HasMaxLength(100);
            entity.Property(e => e.HOrderStatus).HasComment("是否轉成授權訂單(1:未成立、2:已成立)");
            entity.Property(e => e.HOriCCPOrderCode).HasMaxLength(100);
            entity.Property(e => e.HPaperYN).HasComment("是否為紙本");
            entity.Property(e => e.HVerifyDT).HasMaxLength(50);
        });

        modelBuilder.Entity<HCCRegular>(entity =>
        {
            entity.HasKey(e => e.HID).HasName("PK_HRegularQuota");

            entity.Property(e => e.HCCPCodeHead).HasMaxLength(50);
            entity.Property(e => e.HCCPSDate).HasMaxLength(20);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HDCCPAmount).HasComment("每期捐款金額");
            entity.Property(e => e.HDExpDate)
                .HasMaxLength(20)
                .HasComment("截止捐款日期");
            entity.Property(e => e.HDItem)
                .HasMaxLength(255)
                .HasComment("捐款項目");
            entity.Property(e => e.HDItemID).HasComment("捐款項目HID");
            entity.Property(e => e.HDOpenDate)
                .HasMaxLength(20)
                .HasComment("開放捐款日期");
            entity.Property(e => e.HDPurpose)
                .HasMaxLength(255)
                .HasComment("捐款用途");
            entity.Property(e => e.HDPurposeID).HasComment("捐款用途HID");
            entity.Property(e => e.HLimitTotal).HasComment("是否限制最低總金額");
            entity.Property(e => e.HMaxTimes).HasComment("最高扣款期數");
            entity.Property(e => e.HMinTimes).HasComment("最低扣款期數");
            entity.Property(e => e.HMinTotal).HasComment("最低總金額");
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
        });

        modelBuilder.Entity<HCDeadline>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCDeadline1).HasColumnName("HCDeadline");
            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HSave).HasMaxLength(10);
        });

        modelBuilder.Entity<HCMaterialRecord>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
        });

        modelBuilder.Entity<HCTLeaderHistory>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.HCDate).HasMaxLength(50);
            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HID).ValueGeneratedOnAdd();
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HNew).HasMaxLength(50);
            entity.Property(e => e.HOld).HasMaxLength(50);
        });

        modelBuilder.Entity<HCTeam>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCTeam1).HasColumnName("HCTeam");
            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HType).HasMaxLength(10);
        });

        modelBuilder.Entity<HCVerifyLog>(entity =>
        {
            entity.HasKey(e => e.HID).HasName("PK_HVerifyRecord");

            entity.Property(e => e.HCBatchNum).HasMaxLength(50);
            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HSave).HasMaxLength(10);
            entity.Property(e => e.HSignName).HasMaxLength(100);
            entity.Property(e => e.HVDate).HasMaxLength(30);
        });

        modelBuilder.Entity<HCVerifyUnit>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
        });

        modelBuilder.Entity<HCancelBooking>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HID).HasComment("流水號");
            entity.Property(e => e.HBDate).HasMaxLength(30);
            entity.Property(e => e.HCourseID).HasComment("課程ID");
            entity.Property(e => e.HCourseName).HasMaxLength(100);
            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HDCode).HasMaxLength(30);
            entity.Property(e => e.HDPoint).HasMaxLength(30);
            entity.Property(e => e.HExpireDate).HasMaxLength(50);
            entity.Property(e => e.HGwsr).HasMaxLength(50);
            entity.Property(e => e.HInvoiceDate).HasMaxLength(50);
            entity.Property(e => e.HInvoiceNo).HasMaxLength(100);
            entity.Property(e => e.HMemberGroup).HasMaxLength(20);
            entity.Property(e => e.HMemberID).HasComment("會員ID");
            entity.Property(e => e.HMerchantTradeNo)
                .HasMaxLength(100)
                .HasComment("我們傳給綠界的廠商交易編號");
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HORCInfo).HasComment("其他住宿之聯絡資訊");
            entity.Property(e => e.HOrderGroup)
                .HasMaxLength(100)
                .HasComment("訂單代碼");
            entity.Property(e => e.HOrderNum)
                .HasMaxLength(50)
                .HasComment("訂單編號");
            entity.Property(e => e.HOtherRoom).HasComment("其他住宿");
            entity.Property(e => e.HPayMethod).HasMaxLength(30);
            entity.Property(e => e.HPaymentDate).HasMaxLength(50);
            entity.Property(e => e.HPaymentNo).HasMaxLength(100);
            entity.Property(e => e.HPoint)
                .HasMaxLength(50)
                .HasComment("基金會代表金額；文化事業的課程代表點數");
            entity.Property(e => e.HRoomRemark).HasComment("住宿備註");
            entity.Property(e => e.HRoomTime).HasMaxLength(30);
            entity.Property(e => e.HSubscribe).HasMaxLength(20);
            entity.Property(e => e.HTaxID).HasMaxLength(20);
            entity.Property(e => e.HTradeNo)
                .HasMaxLength(50)
                .HasComment("綠界交易編號");
        });

        modelBuilder.Entity<HColCategory>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HColCategory1)
                .HasMaxLength(50)
                .HasColumnName("HColCategory");
            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
        });

        modelBuilder.Entity<HColParmTab>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
        });

        modelBuilder.Entity<HCountry>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.CountryCN).HasMaxLength(20);
            entity.Property(e => e.CountryEN).HasMaxLength(10);
            entity.Property(e => e.CountryTW).HasMaxLength(20);
            entity.Property(e => e.HCode).HasMaxLength(10);
        });

        modelBuilder.Entity<HCourse>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.HasIndex(e => new { e.HCourseName, e.HOCPlace }, "IX_HCourse");

            entity.HasIndex(e => e.HCTemplateID, "IX_HCourse_1");

            entity.Property(e => e.HApplicant).HasMaxLength(50);
            entity.Property(e => e.HApplyTime).HasMaxLength(30);
            entity.Property(e => e.HAttRateStandard).HasComment("出席率標準");
            entity.Property(e => e.HAxisClass).HasComment("軸線類別");
            entity.Property(e => e.HAxisYN).HasComment("是否為軸線課程");
            entity.Property(e => e.HBCPoint).HasMaxLength(10);
            entity.Property(e => e.HCBatchNum).HasMaxLength(50);
            entity.Property(e => e.HCDeadline)
                .HasMaxLength(50)
                .HasComment("換課、修改上課地點或參班身分的最後修改時間點(開課前幾天以前)");
            entity.Property(e => e.HCDeadlineDay).HasComment("課程報名截止日天數");
            entity.Property(e => e.HContentTitle).HasMaxLength(200);
            entity.Property(e => e.HCourseName).HasMaxLength(100);
            entity.Property(e => e.HCourseNum).HasMaxLength(50);
            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HETime).HasMaxLength(30);
            entity.Property(e => e.HExamPaperID).HasComment("考卷");
            entity.Property(e => e.HExamPassStandard).HasComment("檢覈成績通過標準");
            entity.Property(e => e.HExamSubject).HasComment("檢覈科目名稱");
            entity.Property(e => e.HGradeCalculation).HasComment("成績計算方式：1-加權平均;2-單一成績");
            entity.Property(e => e.HIRestriction).HasMaxLength(200);
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HOCPlace).HasMaxLength(150);
            entity.Property(e => e.HOSystem).HasMaxLength(50);
            entity.Property(e => e.HPMethod).HasMaxLength(50);
            entity.Property(e => e.HParticipantLimit).HasComment("報名人數上限");
            entity.Property(e => e.HQuestionID).HasMaxLength(200);
            entity.Property(e => e.HRollcallYN).HasDefaultValueSql("('0')");
            entity.Property(e => e.HSCourseID).HasMaxLength(100);
            entity.Property(e => e.HSTime).HasMaxLength(30);
            entity.Property(e => e.HSave).HasMaxLength(10);
            entity.Property(e => e.HSupervise).HasComment("督導");
            entity.Property(e => e.HTMaterialID).HasComment("講師教材HID(關聯dbi.HTeacherMaterial)");
            entity.Property(e => e.HTeacherClass).HasComment("講師類別(1:識透講師/2:玉成講師/3:教練/4:傳承師)");
            entity.Property(e => e.HTeacherName).HasMaxLength(50);
            entity.Property(e => e.HTearcherLV).HasComment("講師層級分類(1:見習/2:初任/3:正式)");
            entity.Property(e => e.HType).HasMaxLength(50);
            entity.Property(e => e.HVerifyNum).HasMaxLength(50);
            entity.Property(e => e.HVerifyTime).HasMaxLength(30);
        });

        modelBuilder.Entity<HCourseBooking>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.HasIndex(e => new { e.HCourseID, e.HOrderGroup, e.HMemberID, e.HMerchantTradeNo, e.HTradeNo }, "IX_HCourseBooking");

            entity.HasIndex(e => e.HMemberID, "IX_HCourseBooking_1");

            entity.HasIndex(e => new { e.HOrderGroup, e.HItemStatus }, "IX_HCourseBooking_2");

            entity.Property(e => e.HATMBankCode).HasMaxLength(50);
            entity.Property(e => e.HATMVAccount).HasMaxLength(100);
            entity.Property(e => e.HAttend).HasComment("參班身分: 1=參班、5=純護持(非班員)、6=參班兼護持");
            entity.Property(e => e.HBDate).HasMaxLength(30);
            entity.Property(e => e.HCXLApplyDate).HasMaxLength(50);
            entity.Property(e => e.HCXLBAName).HasMaxLength(50);
            entity.Property(e => e.HCXLBAccount).HasMaxLength(50);
            entity.Property(e => e.HCXLBankCode).HasMaxLength(50);
            entity.Property(e => e.HCXLBankName).HasMaxLength(100);
            entity.Property(e => e.HCXLBranchName)
                .HasMaxLength(100)
                .HasComment("分行名稱");
            entity.Property(e => e.HCXLFinishDate).HasMaxLength(50);
            entity.Property(e => e.HCXLOrderGroup).HasMaxLength(100);
            entity.Property(e => e.HCXLRtnCode).HasMaxLength(10);
            entity.Property(e => e.HCXLRtnMsg).HasMaxLength(100);
            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HDCode).HasMaxLength(30);
            entity.Property(e => e.HDPoint).HasMaxLength(30);
            entity.Property(e => e.HExpireDate).HasMaxLength(50);
            entity.Property(e => e.HGwsr).HasMaxLength(50);
            entity.Property(e => e.HInvoiceDate).HasMaxLength(50);
            entity.Property(e => e.HInvoiceNo).HasMaxLength(100);
            entity.Property(e => e.HMemberGroup).HasMaxLength(20);
            entity.Property(e => e.HMerchantTradeNo).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HOrderGroup).HasMaxLength(100);
            entity.Property(e => e.HOrderNum).HasMaxLength(50);
            entity.Property(e => e.HPMethod).HasComment("HPMethod(繳費帳戶)：1=基金會；2=文化事業(HPoint*10)");
            entity.Property(e => e.HPayMethod).HasMaxLength(30);
            entity.Property(e => e.HPaymentDate).HasMaxLength(50);
            entity.Property(e => e.HPaymentNo).HasMaxLength(100);
            entity.Property(e => e.HPoint)
                .HasMaxLength(50)
                .HasComment("基金會(HPMethod=1)代表金額；文化事業(HPMethod=2)的課程代表點數(*10才轉成金額)");
            entity.Property(e => e.HRoomTime).HasMaxLength(30);
            entity.Property(e => e.HRtnCode).HasMaxLength(100);
            entity.Property(e => e.HSubscribe).HasMaxLength(20);
            entity.Property(e => e.HTaxID).HasMaxLength(20);
            entity.Property(e => e.HTest).HasMaxLength(50);
            entity.Property(e => e.HTradeNo)
                .HasMaxLength(50)
                .HasComment("綠界交易編號");
            entity.Property(e => e.HUploadIRS).HasComment("是否願意將捐款資料上傳國稅局");
        });

        modelBuilder.Entity<HCourseBooking_Activity>(entity =>
        {
            entity.HasKey(e => e.HID).HasName("PK_HCourseBooking_Friend");

            entity.Property(e => e.HAName).HasMaxLength(255);
            entity.Property(e => e.HARelation).HasMaxLength(255);
            entity.Property(e => e.HAmount).HasMaxLength(50);
            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
        });

        modelBuilder.Entity<HCourseBooking_DateAttend>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
        });

        modelBuilder.Entity<HCourseBooking_Group>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HGDay).HasMaxLength(10);
            entity.Property(e => e.HGETime).HasMaxLength(30);
            entity.Property(e => e.HGSTime).HasMaxLength(30);
            entity.Property(e => e.HGroupID).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HTask).HasMaxLength(255);
        });

        modelBuilder.Entity<HCourseBooking_Other>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
        });

        modelBuilder.Entity<HCourseCombine>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("HCourseCombine");

            entity.Property(e => e.HBCPoint).HasMaxLength(10);
            entity.Property(e => e.HCBatchNum).HasMaxLength(50);
            entity.Property(e => e.HCourseName).HasMaxLength(100);
            entity.Property(e => e.HIRestriction).HasMaxLength(200);
            entity.Property(e => e.HOCPlace).HasMaxLength(50);
            entity.Property(e => e.HPMethod).HasMaxLength(50);
            entity.Property(e => e.HPlaceName).HasMaxLength(255);
        });

        modelBuilder.Entity<HCourseDate>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCBatchNum).HasMaxLength(50);
            entity.Property(e => e.HCourseName).HasMaxLength(100);
            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
        });

        modelBuilder.Entity<HCourseEvaluation>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCBatchNum)
                .HasMaxLength(50)
                .HasComment("課程代碼(批號)");
            entity.Property(e => e.HCEContent).HasComment("評比內容描述");
            entity.Property(e => e.HCENum).HasComment("繳交數量");
            entity.Property(e => e.HCEType).HasComment("評比類型(1:影片/2:檔案)");
            entity.Property(e => e.HCourseID).HasComment("課程HID(HCourse.HID)");
            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
        });

        modelBuilder.Entity<HCourseHomework>(entity =>
        {
            entity.HasKey(e => e.HID).HasName("PK_HCourseWork");

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HFile).HasMaxLength(250);
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HSDate).HasMaxLength(50);
            entity.Property(e => e.HTRDate).HasMaxLength(50);
            entity.Property(e => e.HWSettingID).HasMaxLength(10);
        });

        modelBuilder.Entity<HCourseKeyWord>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HKeyword).HasMaxLength(10);
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
        });

        modelBuilder.Entity<HCourseLevel>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCLClassID).HasComment("1:教材學程；2:出版分類");
            entity.Property(e => e.HCourseLevel1)
                .HasMaxLength(50)
                .HasColumnName("HCourseLevel");
            entity.Property(e => e.HCreate)
                .HasMaxLength(100)
                .HasComment("建立者");
            entity.Property(e => e.HCreateDT)
                .HasMaxLength(50)
                .HasComment("建立日期");
            entity.Property(e => e.HModify)
                .HasMaxLength(100)
                .HasComment("編輯者");
            entity.Property(e => e.HModifyDT)
                .HasMaxLength(50)
                .HasComment("編輯日期");
            entity.Property(e => e.HStatus).HasComment("狀態");
        });

        modelBuilder.Entity<HCourseList_View>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("HCourseList_View");

            entity.Property(e => e.HBCPoint).HasMaxLength(10);
            entity.Property(e => e.HCBatchNum).HasMaxLength(50);
            entity.Property(e => e.HCourseName).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HIRestriction).HasMaxLength(200);
            entity.Property(e => e.HOCPlace).HasMaxLength(150);
            entity.Property(e => e.HPMethod).HasMaxLength(50);
        });

        modelBuilder.Entity<HCourseMaterial>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.HCBatchNum).HasMaxLength(50);
            entity.Property(e => e.HCMName).HasMaxLength(100);
            entity.Property(e => e.HCMaterial).HasMaxLength(100);
            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HID).ValueGeneratedOnAdd();
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HSave).HasMaxLength(10);
        });

        modelBuilder.Entity<HCourseMaterial_T>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.HCBatchNum).HasMaxLength(50);
            entity.Property(e => e.HCMName).HasMaxLength(100);
            entity.Property(e => e.HCMaterial).HasMaxLength(100);
            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HID).ValueGeneratedOnAdd();
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HSave).HasMaxLength(10);
        });

        modelBuilder.Entity<HCoursePackage>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HBCPrice).HasComment("套裝價格(金額)");
            entity.Property(e => e.HCDeadline)
                .HasMaxLength(20)
                .HasComment("報名截止日期");
            entity.Property(e => e.HCPMethod)
                .HasMaxLength(20)
                .HasComment("繳費帳戶(1=基金會、2=文化事業)");
            entity.Property(e => e.HCPkgName).HasComment("套裝課程名稱");
            entity.Property(e => e.HCStartDate)
                .HasMaxLength(50)
                .HasComment("上課開始日期，沒使用");
            entity.Property(e => e.HContent).HasComment("內容");
            entity.Property(e => e.HContentTitle)
                .HasMaxLength(255)
                .HasComment("內容標題");
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HImg)
                .HasMaxLength(255)
                .HasComment("圖片");
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HRemark).HasComment("備註");
        });

        modelBuilder.Entity<HCoursePackage_Detail>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCBatchCode)
                .HasMaxLength(50)
                .HasComment("批號(關聯HCourse.HCBatchCode)");
            entity.Property(e => e.HCPkgHID).HasComment("關聯HCoursePackage.HID");
            entity.Property(e => e.HCourseName).HasComment("課程名稱(關聯HCourse.HCourseName)");
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HDateRange).HasComment("上課日期(關聯HCourse.HDateRange)");
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
        });

        modelBuilder.Entity<HCourseTMaterial>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCBatchNum).HasMaxLength(50);
            entity.Property(e => e.HCourseID).HasComment("課程HID");
            entity.Property(e => e.HCreate)
                .HasMaxLength(100)
                .HasComment("建立者");
            entity.Property(e => e.HCreateDT)
                .HasMaxLength(50)
                .HasComment("建立日期");
            entity.Property(e => e.HModify)
                .HasMaxLength(100)
                .HasComment("編輯者");
            entity.Property(e => e.HModifyDT)
                .HasMaxLength(50)
                .HasComment("編輯日期");
            entity.Property(e => e.HSave).HasMaxLength(10);
            entity.Property(e => e.HSort).HasComment("排序");
            entity.Property(e => e.HStatus).HasComment("狀態");
            entity.Property(e => e.HTMaterial).HasMaxLength(100);
            entity.Property(e => e.HTMaterialID).HasComment("講師教材HID");
        });

        modelBuilder.Entity<HCourseTMaterial_T>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate)
                .HasMaxLength(100)
                .HasComment("建立者");
            entity.Property(e => e.HCreateDT)
                .HasMaxLength(50)
                .HasComment("建立日期");
            entity.Property(e => e.HModify)
                .HasMaxLength(100)
                .HasComment("編輯者");
            entity.Property(e => e.HModifyDT)
                .HasMaxLength(50)
                .HasComment("編輯日期");
            entity.Property(e => e.HSave).HasMaxLength(10);
            entity.Property(e => e.HSort).HasComment("排序");
            entity.Property(e => e.HStatus).HasComment("狀態");
            entity.Property(e => e.HTMaterial)
                .HasMaxLength(100)
                .HasComment("講師教材檔案");
            entity.Property(e => e.HTMaterialID).HasComment("講師教材HID");
        });

        modelBuilder.Entity<HCourseTask>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HTask).HasMaxLength(255);
        });

        modelBuilder.Entity<HCourseVerifyList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("HCourseVerifyList");

            entity.Property(e => e.Applicant).HasMaxLength(255);
            entity.Property(e => e.HApplyTime).HasMaxLength(30);
            entity.Property(e => e.HCourseName).HasMaxLength(100);
            entity.Property(e => e.HSave).HasMaxLength(10);
            entity.Property(e => e.HVerifyTime).HasMaxLength(30);
        });

        modelBuilder.Entity<HCourse_Class>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
        });

        modelBuilder.Entity<HCourse_EIP>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.HApplicant).HasMaxLength(50);
            entity.Property(e => e.HApplyTime).HasMaxLength(30);
            entity.Property(e => e.HBCPoint).HasMaxLength(10);
            entity.Property(e => e.HContentTitle).HasMaxLength(200);
            entity.Property(e => e.HCourseName).HasMaxLength(100);
            entity.Property(e => e.HCourseNum).HasMaxLength(50);
            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HETime).HasMaxLength(30);
            entity.Property(e => e.HID).ValueGeneratedOnAdd();
            entity.Property(e => e.HIRestriction).HasMaxLength(200);
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HOCPlace).HasMaxLength(50);
            entity.Property(e => e.HOSystem).HasMaxLength(50);
            entity.Property(e => e.HPMethod).HasMaxLength(50);
            entity.Property(e => e.HQuestionID).HasMaxLength(200);
            entity.Property(e => e.HSCourseID).HasMaxLength(100);
            entity.Property(e => e.HSTime).HasMaxLength(30);
            entity.Property(e => e.HSave).HasMaxLength(10);
            entity.Property(e => e.HTeacherName).HasMaxLength(50);
            entity.Property(e => e.HType).HasMaxLength(50);
            entity.Property(e => e.HVerifyNum).HasMaxLength(50);
            entity.Property(e => e.HVerifyTime).HasMaxLength(30);
        });

        modelBuilder.Entity<HCourse_HWSetting>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCBatchNum).HasMaxLength(50);
            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HDescription).HasComment("作業內容描述");
            entity.Property(e => e.HHWType).HasComment("作業類型(回應/問卷)");
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HQuestionHID).HasComment("問卷(關聯HQuestionHID)");
            entity.Property(e => e.HSave).HasMaxLength(10);
        });

        modelBuilder.Entity<HCourse_Merge>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("HCourse_Merge");

            entity.Property(e => e.HApplicant).HasMaxLength(50);
            entity.Property(e => e.HApplyTime).HasMaxLength(30);
            entity.Property(e => e.HBCPoint).HasMaxLength(10);
            entity.Property(e => e.HCBatchNum).HasMaxLength(50);
            entity.Property(e => e.HCDeadline).HasMaxLength(50);
            entity.Property(e => e.HContentTitle).HasMaxLength(200);
            entity.Property(e => e.HCourseName).HasMaxLength(100);
            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HETime).HasMaxLength(30);
            entity.Property(e => e.HIRestriction).HasMaxLength(200);
            entity.Property(e => e.HOSystem).HasMaxLength(50);
            entity.Property(e => e.HPMethod).HasMaxLength(50);
            entity.Property(e => e.HQuestionID).HasMaxLength(200);
            entity.Property(e => e.HSCourseID).HasMaxLength(100);
            entity.Property(e => e.HSTime).HasMaxLength(30);
            entity.Property(e => e.HSave).HasMaxLength(10);
            entity.Property(e => e.HTeacherName).HasMaxLength(50);
            entity.Property(e => e.HType).HasMaxLength(50);
            entity.Property(e => e.HUserName).HasMaxLength(255);
            entity.Property(e => e.HVerifyNum).HasMaxLength(50);
            entity.Property(e => e.HVerifyTime).HasMaxLength(30);
        });

        modelBuilder.Entity<HCourse_MergeCopy>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("HCourse_MergeCopy");

            entity.Property(e => e.HApplicant).HasMaxLength(50);
            entity.Property(e => e.HApplyTime).HasMaxLength(30);
            entity.Property(e => e.HBCPoint).HasMaxLength(10);
            entity.Property(e => e.HCBatchNum).HasMaxLength(50);
            entity.Property(e => e.HCDeadline).HasMaxLength(50);
            entity.Property(e => e.HContentTitle).HasMaxLength(200);
            entity.Property(e => e.HCourseName).HasMaxLength(100);
            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HETime).HasMaxLength(30);
            entity.Property(e => e.HIRestriction).HasMaxLength(200);
            entity.Property(e => e.HOSystem).HasMaxLength(50);
            entity.Property(e => e.HPMethod).HasMaxLength(50);
            entity.Property(e => e.HQuestionID).HasMaxLength(200);
            entity.Property(e => e.HSCourseID).HasMaxLength(100);
            entity.Property(e => e.HSTime).HasMaxLength(30);
            entity.Property(e => e.HSave).HasMaxLength(10);
            entity.Property(e => e.HTeacherName).HasMaxLength(50);
            entity.Property(e => e.HType).HasMaxLength(50);
            entity.Property(e => e.HUserName).HasMaxLength(255);
            entity.Property(e => e.HVerifyNum).HasMaxLength(50);
            entity.Property(e => e.HVerifyTime).HasMaxLength(30);
        });

        modelBuilder.Entity<HCourse_T>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.HID, e.HTemplateName }, "IX_HCourse_T");

            entity.Property(e => e.HARoleID).HasMaxLength(50);
            entity.Property(e => e.HBCPoint).HasMaxLength(10);
            entity.Property(e => e.HBudgetType).HasMaxLength(50);
            entity.Property(e => e.HCDeadline)
                .HasMaxLength(50)
                .HasComment("換課、修改上課地點或參班身分的最後修改時間點(開課前幾天以前)");
            entity.Property(e => e.HCDeadlineDay).HasComment("課程報名截止日天數");
            entity.Property(e => e.HContentTitle).HasMaxLength(200);
            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HID).ValueGeneratedOnAdd();
            entity.Property(e => e.HIRestriction).HasMaxLength(200);
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HOSystem).HasMaxLength(50);
            entity.Property(e => e.HPMethod).HasMaxLength(50);
            entity.Property(e => e.HParticipantLimit).HasComment("報名人數上限");
            entity.Property(e => e.HQuestionID).HasMaxLength(200);
            entity.Property(e => e.HRollcallYN).HasDefaultValueSql("('0')");
            entity.Property(e => e.HSave).HasMaxLength(10);
            entity.Property(e => e.HTMaterialID).HasComment("講師教材HID(關聯dbi.HTeacherMaterial)");
            entity.Property(e => e.HTemplateName).HasMaxLength(100);
            entity.Property(e => e.HTemplateNum).HasMaxLength(50);
            entity.Property(e => e.HType).HasMaxLength(50);
            entity.Property(e => e.HVRoleID).HasMaxLength(50);
        });

        modelBuilder.Entity<HDCGListTemp>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.HMemberID).HasMaxLength(50);
            entity.Property(e => e.HUserName).HasMaxLength(200);
        });

        modelBuilder.Entity<HDCGroup>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HGName).HasMaxLength(50);
            entity.Property(e => e.HGNum).HasMaxLength(50);
            entity.Property(e => e.HGType).HasMaxLength(30);
            entity.Property(e => e.HID).ValueGeneratedOnAdd();
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
        });

        modelBuilder.Entity<HDOFVerifyLog>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HID).ValueGeneratedOnAdd();
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HSave).HasMaxLength(10);
            entity.Property(e => e.HSignName).HasMaxLength(100);
            entity.Property(e => e.HVDate).HasMaxLength(30);
        });

        modelBuilder.Entity<HDPurpose>(entity =>
        {
            entity.HasKey(e => e.HID).HasName("PK_HDPurpose\"");

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HDPurpose1)
                .HasMaxLength(50)
                .HasColumnName("HDPurpose");
            entity.Property(e => e.HDTypeCode).HasMaxLength(20);
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
        });

        modelBuilder.Entity<HDayOffForm>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.HApplyDT).HasMaxLength(50);
            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HDayOffNum).HasMaxLength(50);
            entity.Property(e => e.HID).ValueGeneratedOnAdd();
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HVDT).HasMaxLength(50);
        });

        modelBuilder.Entity<HDharma>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
        });

        modelBuilder.Entity<HDharmaType>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HDharmaType1)
                .HasMaxLength(200)
                .HasColumnName("HDharmaType");
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
        });

        modelBuilder.Entity<HDiscountCode>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.HCTemplateID).HasComment("可使用的課程範本(HCourse_T.HID)");
            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HDCode).HasMaxLength(30);
            entity.Property(e => e.HDPoint).HasMaxLength(30);
            entity.Property(e => e.HDType).HasMaxLength(30);
            entity.Property(e => e.HEDate)
                .HasMaxLength(30)
                .HasComment("折扣碼有效期間(迄)");
            entity.Property(e => e.HID).ValueGeneratedOnAdd();
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HSDate)
                .HasMaxLength(30)
                .HasComment("折扣碼有效期間(起)");
            entity.Property(e => e.HUseOnce).HasComment("僅能使用一次");
        });

        modelBuilder.Entity<HDocCType>(entity =>
        {
            entity.HasKey(e => e.HID).HasName("PK_HDocType");

            entity.Property(e => e.HCreate)
                .HasMaxLength(100)
                .HasComment("建立者");
            entity.Property(e => e.HCreateDT)
                .HasMaxLength(50)
                .HasComment("建立日期");
            entity.Property(e => e.HDocCTCode)
                .HasMaxLength(50)
                .HasComment("編碼");
            entity.Property(e => e.HDocCType1)
                .HasMaxLength(50)
                .HasComment("課程類型(法系編碼規則)")
                .HasColumnName("HDocCType");
            entity.Property(e => e.HModify)
                .HasMaxLength(100)
                .HasComment("編輯者");
            entity.Property(e => e.HModifyDT)
                .HasMaxLength(50)
                .HasComment("編輯日期");
            entity.Property(e => e.HStatus).HasComment("狀態");
        });

        modelBuilder.Entity<HDocCTypeClass>(entity =>
        {
            entity.HasKey(e => e.HID).HasName("PK_HCTypeClass");

            entity.Property(e => e.HCreate)
                .HasMaxLength(100)
                .HasComment("建立者");
            entity.Property(e => e.HCreateDT)
                .HasMaxLength(50)
                .HasComment("建立日期");
            entity.Property(e => e.HDocCTCCode)
                .HasMaxLength(5)
                .HasComment("課程類型班別編號");
            entity.Property(e => e.HDocCTClass)
                .HasMaxLength(100)
                .HasComment("課程類型班別");
            entity.Property(e => e.HDocCTypeID).HasComment("課程類型 (關聯dbo. HDocCType HID)");
            entity.Property(e => e.HModify)
                .HasMaxLength(100)
                .HasComment("編輯者");
            entity.Property(e => e.HModifyDT)
                .HasMaxLength(50)
                .HasComment("編輯日期");
            entity.Property(e => e.HRemark).HasComment("備註");
            entity.Property(e => e.HStatus).HasComment("狀態");
        });

        modelBuilder.Entity<HDonationItem>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HDItem).HasMaxLength(200);
            entity.Property(e => e.HDItemCode).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
        });

        modelBuilder.Entity<HEPItem>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HEPItem1)
                .HasMaxLength(150)
                .HasColumnName("HEPItem");
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
        });

        modelBuilder.Entity<HEPType>(entity =>
        {
            entity.HasKey(e => e.HID).HasName("PK_HID");

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HEPType1)
                .HasMaxLength(150)
                .HasColumnName("HEPType");
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
        });

        modelBuilder.Entity<HExamBase>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HExamBaseClass).HasMaxLength(10);
            entity.Property(e => e.HExamBaseNum).HasMaxLength(100);
            entity.Property(e => e.HExamMethod).HasComment("檢覈方式(1:證照檢覈、2:分級檢定)");
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HSave).HasMaxLength(10);
        });

        modelBuilder.Entity<HExamBaseAnswer>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HID).ValueGeneratedOnAdd();
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
        });

        modelBuilder.Entity<HExamBaseItem>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HSave).HasMaxLength(10);
        });

        modelBuilder.Entity<HExamClassRoom>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HExamClassRoom1)
                .HasMaxLength(50)
                .HasComment("教室")
                .HasColumnName("HExamClassRoom");
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HPlaceID).HasComment("考場名稱");
        });

        modelBuilder.Entity<HExamContent>(entity =>
        {
            entity.HasKey(e => e.HID).HasName("PK_HExamTemplate");

            entity.Property(e => e.HChargeMethod).HasComment("收費方式(1:不分科目/2:一科一個金額/3:依報考科目總數量而定)");
            entity.Property(e => e.HCourseClassID).HasComment("檢核項目類別 (dbo.HCourse_Class.HID)");
            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HExamClassRoomType).HasComment("考場與教室設定");
            entity.Property(e => e.HExamContentName)
                .HasMaxLength(50)
                .HasComment("檢覈範本名稱");
            entity.Property(e => e.HExamPassYN).HasComment("勾稽成績通過");
            entity.Property(e => e.HExamType).HasComment("檢覈類型(1:筆試/2:實作/3:試教)");
            entity.Property(e => e.HLeadingExam).HasComment("對應的前導檢覈名稱(多選)");
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HRemark)
                .HasMaxLength(50)
                .HasComment("備註");
        });

        modelBuilder.Entity<HExamContentDetail>(entity =>
        {
            entity.HasKey(e => e.HID).HasName("PK_HExamTemplateDetail");

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HExamClassRoomID).HasComment("教室名稱(dbo.HExamClassRoom.HID)");
            entity.Property(e => e.HExamContentID).HasComment("dbo.HExamTemplate.HID");
            entity.Property(e => e.HExamDayPNum).HasComment("一天可容納考試總人數");
            entity.Property(e => e.HExamSort).HasComment("檢覈順序");
            entity.Property(e => e.HExamSubjectID).HasComment("科目名稱(dbo.HExamSubject.HID)");
            entity.Property(e => e.HExamTime).HasComment("檢覈時間(分鐘)");
            entity.Property(e => e.HExamTimesPNum).HasComment("可同時檢覈人數");
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HPlaceID).HasComment("考場名稱(dbo.HPlace.HID)");
            entity.Property(e => e.HRemark)
                .HasMaxLength(50)
                .HasComment("備註");
        });

        modelBuilder.Entity<HExamFee>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HExamContentID).HasComment("dbo.HExamTemplate.HID");
            entity.Property(e => e.HExamFee1)
                .HasMaxLength(50)
                .HasComment("檢覈費用")
                .HasColumnName("HExamFee");
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HSubjectMaxNum).HasComment("報考科目最大值");
            entity.Property(e => e.HSubjectMinNum).HasComment("報考科目最小值");
        });

        modelBuilder.Entity<HExamJoin>(entity =>
        {
            entity.HasKey(e => e.HID).HasName("PK_HExamList");

            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HExamSubjectID)
                .HasMaxLength(50)
                .HasComment("檢覈科目名稱");
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
        });

        modelBuilder.Entity<HExamPaper>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HExamBaseID).HasMaxLength(10);
            entity.Property(e => e.HExamPaperClass).HasMaxLength(10);
            entity.Property(e => e.HExamPaperNum).HasMaxLength(100);
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HSave).HasMaxLength(10);
        });

        modelBuilder.Entity<HExamPaperAnswer>(entity =>
        {
            entity.HasKey(e => new { e.HCourseID, e.HExamPaperID, e.HExamPaperGroup, e.HMemberID });

            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HID).ValueGeneratedOnAdd();
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
        });

        modelBuilder.Entity<HExamPaperItem>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HSave).HasMaxLength(10);
        });

        modelBuilder.Entity<HExamParmTab>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
        });

        modelBuilder.Entity<HExamScore>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HComment).HasComment("評語");
            entity.Property(e => e.HCourseID).HasComment("檢覈名稱HID");
            entity.Property(e => e.HCreate)
                .HasMaxLength(10)
                .HasComment("建立者");
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HExamClassRoomID).HasComment("教室名稱(dbo.HExamClassRoom.HID)");
            entity.Property(e => e.HExamResult1).HasComment("檢覈結果1");
            entity.Property(e => e.HExamResult2).HasComment("檢覈結果2");
            entity.Property(e => e.HExamResult3).HasComment("檢覈結果3");
            entity.Property(e => e.HExamSubjectID).HasComment("科目名稱(dbo.HExamSubject.HID)");
            entity.Property(e => e.HExamineeCode)
                .HasMaxLength(20)
                .HasComment("考生編號");
            entity.Property(e => e.HFinalExamResult).HasComment("總檢覈結果");
            entity.Property(e => e.HFinalScore).HasComment("總成績");
            entity.Property(e => e.HMemberID).HasComment("考生HID");
            entity.Property(e => e.HModify).HasMaxLength(10);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HPlaceID).HasComment("考場名稱(dbo.HPlace.HID)");
            entity.Property(e => e.HScore1).HasComment("主考官成績1");
            entity.Property(e => e.HScore2).HasComment("主考官成績2");
            entity.Property(e => e.HScore3).HasComment("主考官成績3");
            entity.Property(e => e.HStatus).HasComment("狀態");
            entity.Property(e => e.HType).HasComment("1:非教練檢覈/2:教練檢覈");
        });

        modelBuilder.Entity<HExamSubject>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HExamSubjectName)
                .HasMaxLength(50)
                .HasComment("檢覈科目名稱");
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
        });

        modelBuilder.Entity<HExamSubjectClassRoom>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HExamClassRoomID).HasComment("教室名稱(dbo.HExamClassRoom.HID)");
            entity.Property(e => e.HExamPNum).HasComment("教室同時可容納考試總人數");
            entity.Property(e => e.HExamSubjectID).HasComment("科目名稱(dbo.HExamSubject.HID)");
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HPlaceID).HasComment("考場名稱(dbo.HPlace.HID)");
        });

        modelBuilder.Entity<HFParmTab>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
        });

        modelBuilder.Entity<HFeelingsJournals>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HID).HasComment("流水號");
            entity.Property(e => e.HContent).HasComment("分享內容");
            entity.Property(e => e.HCreate)
                .HasMaxLength(100)
                .HasComment("建立者");
            entity.Property(e => e.HCreateDT)
                .HasMaxLength(50)
                .HasComment("建立日期");
            entity.Property(e => e.HFile1)
                .HasMaxLength(200)
                .HasComment("附件一 (預留欄位，暫無使用)");
            entity.Property(e => e.HFile2)
                .HasMaxLength(200)
                .HasComment("附件二  (預留欄位，暫無使用)");
            entity.Property(e => e.HFile3)
                .HasMaxLength(200)
                .HasComment("附件三  (預留欄位，暫無使用)");
            entity.Property(e => e.HHashTag)
                .HasMaxLength(255)
                .HasComment("HashTag標籤  (預留欄位，暫無使用)");
            entity.Property(e => e.HMemberID)
                .HasMaxLength(200)
                .HasComment("學員ID (HMember.HID)");
            entity.Property(e => e.HModify)
                .HasMaxLength(100)
                .HasComment("修改者");
            entity.Property(e => e.HModifyDT)
                .HasMaxLength(50)
                .HasComment("修改日期");
            entity.Property(e => e.HStatus).HasComment("狀態");
        });

        modelBuilder.Entity<HFeelingsJournalsMsg>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HID).HasComment("流水號");
            entity.Property(e => e.HContent).HasComment("留言內容");
            entity.Property(e => e.HCreate)
                .HasMaxLength(50)
                .HasComment("建立者");
            entity.Property(e => e.HCreateDT)
                .HasMaxLength(50)
                .HasComment("建立日期");
            entity.Property(e => e.HFeelingsJournalsID).HasComment("心情日誌HID(HFeelingsJournals.HID)");
            entity.Property(e => e.HMemberID).HasComment("學員HID(HMember.HID)");
            entity.Property(e => e.HModify)
                .HasMaxLength(50)
                .HasComment("修改者");
            entity.Property(e => e.HModifyDT)
                .HasMaxLength(50)
                .HasComment("修改日期");
            entity.Property(e => e.HStatus).HasComment("狀態(0:刪掉/1:顯示)");
        });

        modelBuilder.Entity<HFileType>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate)
                .HasMaxLength(100)
                .HasComment("建立者");
            entity.Property(e => e.HCreateDT)
                .HasMaxLength(50)
                .HasComment("建立日期");
            entity.Property(e => e.HFTCode)
                .HasMaxLength(5)
                .HasComment("檔案類型編號");
            entity.Property(e => e.HFType)
                .HasMaxLength(100)
                .HasComment("檔案類型");
            entity.Property(e => e.HModify)
                .HasMaxLength(100)
                .HasComment("編輯者");
            entity.Property(e => e.HModifyDT)
                .HasMaxLength(50)
                .HasComment("編輯日期");
            entity.Property(e => e.HRemark).HasComment("備註");
            entity.Property(e => e.HStatus).HasComment("狀態");
        });

        modelBuilder.Entity<HGroup>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HGroupName).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
        });

        modelBuilder.Entity<HIndexSlide>(entity =>
        {
            entity.HasKey(e => e.HID).HasName("PK_COM_IndexSlide");

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HLink).HasMaxLength(255);
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HTitle).HasMaxLength(255);
        });

        modelBuilder.Entity<HInvoiceTemp>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HBuyAdd).HasMaxLength(10);
            entity.Property(e => e.HBuyMail).HasMaxLength(10);
            entity.Property(e => e.HBuyName).HasMaxLength(10);
            entity.Property(e => e.HCarrierA).HasMaxLength(10);
            entity.Property(e => e.HCarrierB).HasMaxLength(10);
            entity.Property(e => e.HCount).HasMaxLength(10);
            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HDutyFree).HasMaxLength(50);
            entity.Property(e => e.HFollowNote).HasMaxLength(10);
            entity.Property(e => e.HInvoiceDate).HasMaxLength(30);
            entity.Property(e => e.HInvoiceName).HasMaxLength(50);
            entity.Property(e => e.HItemNo).HasMaxLength(100);
            entity.Property(e => e.HLoveCode).HasMaxLength(10);
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HNo).HasMaxLength(50);
            entity.Property(e => e.HOrderNo).HasMaxLength(10);
            entity.Property(e => e.HPhoneNo).HasMaxLength(15);
            entity.Property(e => e.HPrincipal).HasMaxLength(10);
            entity.Property(e => e.HProductNo).HasMaxLength(50);
            entity.Property(e => e.HProductNoBarcode).HasMaxLength(50);
            entity.Property(e => e.HRemarkA).HasMaxLength(20);
            entity.Property(e => e.HRemarkB).HasMaxLength(20);
            entity.Property(e => e.HSubtotal).HasMaxLength(50);
            entity.Property(e => e.HTaxID).HasMaxLength(50);
            entity.Property(e => e.HTaxablePrice).HasMaxLength(50);
            entity.Property(e => e.HUnit).HasMaxLength(10);
            entity.Property(e => e.HZeroTaxPrice).HasMaxLength(10);
        });

        modelBuilder.Entity<HLArea>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HALeaderID).HasMaxLength(255);
            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HLArea1)
                .HasMaxLength(255)
                .HasColumnName("HLArea");
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
        });

        modelBuilder.Entity<HLCourse>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HID).ValueGeneratedOnAdd();
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HSave).HasMaxLength(10);
        });

        modelBuilder.Entity<HLCourse_Detail>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HDiscount)
                .HasComment("折扣點數(*10)才會轉成金額")
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.HID).ValueGeneratedOnAdd();
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HSave).HasMaxLength(10);
        });

        modelBuilder.Entity<HLeadingCourse>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.HCBatchNum)
                .HasMaxLength(50)
                .HasComment("課程代碼(批號)");
            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HDiscount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.HID).ValueGeneratedOnAdd();
            entity.Property(e => e.HLCourseCode).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HPercentage)
                .HasMaxLength(20)
                .HasComment("依比例");
            entity.Property(e => e.HRequired).HasComment("必修/選修");
            entity.Property(e => e.HSave).HasMaxLength(10);
        });

        modelBuilder.Entity<HLeadingCourse_T>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.HCBatchNum).HasMaxLength(50);
            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HDiscount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.HID).ValueGeneratedOnAdd();
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HSave).HasMaxLength(10);
        });

        modelBuilder.Entity<HLogs_HPosition>(entity =>
        {
            entity.HasKey(e => e.HID).HasName("PK_Logs_HPosition");

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HType).HasMaxLength(100);
        });

        modelBuilder.Entity<HMMentorRelationship>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HEndDate).HasComment("護持結束日期");
            entity.Property(e => e.HMemberID).HasComment("學員HID (關聯HMember.HID)");
            entity.Property(e => e.HMentorMemberID).HasComment("上層導師HID (關聯HMember.HID)");
            entity.Property(e => e.HMentorRoleID).HasComment("上層導師角色(關聯HMentorRole.HID)");
            entity.Property(e => e.HMentorTypeID).HasComment("上層導師類型(關聯HMentorType.HID)");
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HPrimaryYN).HasComment("是否為個人主要導師");
            entity.Property(e => e.HRemark)
                .HasMaxLength(255)
                .HasComment("備註");
            entity.Property(e => e.HStartDate).HasComment("護持開始日期");
            entity.Property(e => e.HStatus).HasComment("狀態");
        });

        modelBuilder.Entity<HMTLeaderHistory>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.HCDate).HasMaxLength(50);
            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HID).ValueGeneratedOnAdd();
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HNew).HasMaxLength(50);
            entity.Property(e => e.HOld).HasMaxLength(50);
        });

        modelBuilder.Entity<HMTeam>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HMTeam1).HasColumnName("HMTeam");
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HType).HasMaxLength(10);
        });

        modelBuilder.Entity<HMType>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HMType1).HasColumnName("HMType");
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
        });

        modelBuilder.Entity<HMailRecord>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HBody).HasComment("信件內容");
            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HImg).HasComment("圖片");
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HReceiver).HasComment("收件者");
            entity.Property(e => e.HSubject).HasComment("信件主旨");
        });

        modelBuilder.Entity<HMember>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.HID, "IX_HMember").IsUnique();

            entity.HasIndex(e => new { e.HAreaID, e.HSystemID, e.HTeamID }, "IX_HMember_1");

            entity.HasIndex(e => e.HAccount, "IX_HMember_2");

            entity.Property(e => e.HAccount).HasMaxLength(255);
            entity.Property(e => e.HAxisType)
                .HasMaxLength(200)
                .HasComment("學員軸線類別");
            entity.Property(e => e.HBirth).HasMaxLength(50);
            entity.Property(e => e.HCPostal).HasMaxLength(50);
            entity.Property(e => e.HCTel).HasMaxLength(50);
            entity.Property(e => e.HCarrier).HasDefaultValueSql("('0')");
            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HDad).HasMaxLength(255);
            entity.Property(e => e.HDeadDT).HasMaxLength(50);
            entity.Property(e => e.HDisease).HasMaxLength(255);
            entity.Property(e => e.HEPItem).HasMaxLength(200);
            entity.Property(e => e.HEmail).HasMaxLength(255);
            entity.Property(e => e.HEmerName).HasMaxLength(255);
            entity.Property(e => e.HEmerPhone).HasMaxLength(50);
            entity.Property(e => e.HEmerRelated).HasMaxLength(100);
            entity.Property(e => e.HExpertise).HasMaxLength(200);
            entity.Property(e => e.HFB).HasMaxLength(255);
            entity.Property(e => e.HFDisease).HasMaxLength(255);
            entity.Property(e => e.HForeignID).HasMaxLength(50);
            entity.Property(e => e.HGraduate).HasMaxLength(255);
            entity.Property(e => e.HID).ValueGeneratedOnAdd();
            entity.Property(e => e.HIntroName).HasMaxLength(255);
            entity.Property(e => e.HIntroRelated).HasMaxLength(100);
            entity.Property(e => e.HJDuration).HasMaxLength(100);
            entity.Property(e => e.HLearningGroup).HasMaxLength(20);
            entity.Property(e => e.HLearningType).HasMaxLength(20);
            entity.Property(e => e.HLeaveDT).HasMaxLength(50);
            entity.Property(e => e.HLifeLeaderID).HasComment("生命導師HID(dbo.HMember.HID)_學員類別(2~7階)");
            entity.Property(e => e.HLightEnvoy).HasDefaultValueSql("('0')");
            entity.Property(e => e.HLineID).HasMaxLength(150);
            entity.Property(e => e.HLoginType)
                .HasDefaultValue(1)
                .HasComment("登入方式");
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HMom).HasMaxLength(255);
            entity.Property(e => e.HOEmail).HasMaxLength(255);
            entity.Property(e => e.HOTel).HasMaxLength(50);
            entity.Property(e => e.HPPName).HasMaxLength(255);
            entity.Property(e => e.HPassword).HasMaxLength(255);
            entity.Property(e => e.HPeriod).HasMaxLength(25);
            entity.Property(e => e.HPersonID).HasMaxLength(30);
            entity.Property(e => e.HPhone).HasMaxLength(50);
            entity.Property(e => e.HQReason).HasMaxLength(255);
            entity.Property(e => e.HRPostal).HasMaxLength(50);
            entity.Property(e => e.HRainbow).HasDefaultValueSql("('0')");
            entity.Property(e => e.HRank).HasMaxLength(255);
            entity.Property(e => e.HReligion).HasMaxLength(150);
            entity.Property(e => e.HSADate).HasMaxLength(50);
            entity.Property(e => e.HSAReason).HasMaxLength(255);
            entity.Property(e => e.HSCFClassFavorite).HasMaxLength(200);
            entity.Property(e => e.HSeries).HasMaxLength(50);
            entity.Property(e => e.HServiceTitle).HasMaxLength(255);
            entity.Property(e => e.HSiblingNum).HasMaxLength(255);
            entity.Property(e => e.HSpouse).HasMaxLength(255);
            entity.Property(e => e.HTeamID).HasMaxLength(50);
            entity.Property(e => e.HTeamType).HasMaxLength(10);
            entity.Property(e => e.HType).HasMaxLength(100);
            entity.Property(e => e.HUnitName).HasMaxLength(255);
            entity.Property(e => e.HUploadIRS).HasComment("是否願意將捐款資料上傳國稅局");
            entity.Property(e => e.HUserName).HasMaxLength(255);
            entity.Property(e => e.HUsualTask).HasMaxLength(255);
            entity.Property(e => e.HWechat).HasMaxLength(150);
            entity.Property(e => e.HWhatsapp).HasMaxLength(150);
            entity.Property(e => e.HWorkName).HasMaxLength(255);
        });

        modelBuilder.Entity<HMemberTemp>(entity =>
        {
            entity.HasKey(e => e.HAccount).HasName("PK_HMemberRegisterTemp");

            entity.Property(e => e.HAccount).HasMaxLength(255);
            entity.Property(e => e.HAxisType).HasMaxLength(200);
            entity.Property(e => e.HBirth).HasMaxLength(50);
            entity.Property(e => e.HCPostal).HasMaxLength(50);
            entity.Property(e => e.HCTel).HasMaxLength(50);
            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HDad).HasMaxLength(255);
            entity.Property(e => e.HDeadDT).HasMaxLength(50);
            entity.Property(e => e.HDisease).HasMaxLength(255);
            entity.Property(e => e.HEPItem).HasMaxLength(200);
            entity.Property(e => e.HEmail).HasMaxLength(255);
            entity.Property(e => e.HEmerName).HasMaxLength(255);
            entity.Property(e => e.HEmerPhone).HasMaxLength(50);
            entity.Property(e => e.HEmerRelated).HasMaxLength(100);
            entity.Property(e => e.HExpertise).HasMaxLength(200);
            entity.Property(e => e.HFB).HasMaxLength(150);
            entity.Property(e => e.HFDisease).HasMaxLength(255);
            entity.Property(e => e.HForeignID).HasMaxLength(50);
            entity.Property(e => e.HGraduate).HasMaxLength(255);
            entity.Property(e => e.HID).ValueGeneratedOnAdd();
            entity.Property(e => e.HIntroName).HasMaxLength(255);
            entity.Property(e => e.HIntroRelated).HasMaxLength(100);
            entity.Property(e => e.HJDuration).HasMaxLength(100);
            entity.Property(e => e.HLearningGroup).HasMaxLength(20);
            entity.Property(e => e.HLearningType).HasMaxLength(20);
            entity.Property(e => e.HLeaveDT).HasMaxLength(50);
            entity.Property(e => e.HLineID).HasMaxLength(150);
            entity.Property(e => e.HMentor).HasMaxLength(150);
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HMom).HasMaxLength(255);
            entity.Property(e => e.HOEmail).HasMaxLength(255);
            entity.Property(e => e.HOTel).HasMaxLength(50);
            entity.Property(e => e.HPPName).HasMaxLength(255);
            entity.Property(e => e.HPassword).HasMaxLength(50);
            entity.Property(e => e.HPeriod).HasMaxLength(25);
            entity.Property(e => e.HPersonID).HasMaxLength(30);
            entity.Property(e => e.HPhone).HasMaxLength(30);
            entity.Property(e => e.HQReason).HasMaxLength(255);
            entity.Property(e => e.HRPostal).HasMaxLength(50);
            entity.Property(e => e.HRank).HasMaxLength(30);
            entity.Property(e => e.HReligion).HasMaxLength(150);
            entity.Property(e => e.HSADate).HasMaxLength(50);
            entity.Property(e => e.HSAReason).HasMaxLength(255);
            entity.Property(e => e.HSCFClassFavorite).HasMaxLength(200);
            entity.Property(e => e.HSeries).HasMaxLength(50);
            entity.Property(e => e.HServiceTitle).HasMaxLength(255);
            entity.Property(e => e.HSiblingNum).HasMaxLength(30);
            entity.Property(e => e.HSpouse).HasMaxLength(255);
            entity.Property(e => e.HTeamID).HasMaxLength(50);
            entity.Property(e => e.HTeamType).HasMaxLength(10);
            entity.Property(e => e.HType).HasMaxLength(100);
            entity.Property(e => e.HUnitName).HasMaxLength(255);
            entity.Property(e => e.HUserName).HasMaxLength(255);
            entity.Property(e => e.HUsualTask).HasMaxLength(255);
            entity.Property(e => e.HWechat).HasMaxLength(150);
            entity.Property(e => e.HWhatsapp).HasMaxLength(150);
            entity.Property(e => e.HWorkName).HasMaxLength(255);
        });

        modelBuilder.Entity<HMentorRole>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HMentorRoleName)
                .HasMaxLength(255)
                .HasComment("導師角色名稱(ex:教練、總領、傳導師...)");
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HRemark)
                .HasMaxLength(255)
                .HasComment("備註");
            entity.Property(e => e.HSort).HasComment("排序");
            entity.Property(e => e.HStatus).HasComment("狀態");
        });

        modelBuilder.Entity<HMentorType>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HMentorTypeName)
                .HasMaxLength(255)
                .HasComment("導師類型名稱(ex:生命導師、動功導師)");
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HRemark)
                .HasMaxLength(255)
                .HasComment("備註");
            entity.Property(e => e.HSort)
                .HasMaxLength(255)
                .HasComment("排序");
            entity.Property(e => e.HStatus).HasComment("狀態");
        });

        modelBuilder.Entity<HMonth>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HMonth1)
                .HasMaxLength(10)
                .HasColumnName("HMonth");
        });

        modelBuilder.Entity<HNews>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
        });

        modelBuilder.Entity<HNews_Class>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
        });

        modelBuilder.Entity<HNotification>(entity =>
        {
            entity.HasKey(e => e.HID).HasName("PK_HSCNotification");

            entity.Property(e => e.HActorMemberID).HasComment("觸發通知的學員(HMember.HID)");
            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HMemberID).HasComment("接收通知的學員(HMember.HID)");
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HNotifyType).HasComment("通知類型(1:回應、2:心情(讚)、3:心情(愛心)、4:心情(微笑)、5:分享、6:提問)");
            entity.Property(e => e.HReadStatus).HasComment("是否已讀(0:未讀、1已讀)");
            entity.Property(e => e.HStatus).HasComment("啟用狀態(0:停用、1:啟用)");
            entity.Property(e => e.HTableName)
                .HasMaxLength(200)
                .HasComment("資料表名稱");
            entity.Property(e => e.HTargetID).HasComment("回應/心情/提問/分享關連的資料表HID");
        });

        modelBuilder.Entity<HPBookingList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("HPBookingList");

            entity.Property(e => e.Address)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Barcode)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.BarcodeHide)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.BarcodeShow)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.BookDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.HAccount).HasMaxLength(255);
            entity.Property(e => e.HTradeNo).HasMaxLength(50);
            entity.Property(e => e.HeartCode)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceDate)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.ItemCode)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.ItemName)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.MainRemark)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(281);
            entity.Property(e => e.Nature)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.NoTaxPrice)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Num)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Numbers)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.PhoneCode)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.TaxID)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Unit)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.principle)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HPBookingReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("HPBookingReport");

            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HPeriod).HasMaxLength(25);
            entity.Property(e => e.HRecord)
                .HasMaxLength(41)
                .IsUnicode(false);
            entity.Property(e => e.Husername).HasMaxLength(255);
        });

        modelBuilder.Entity<HParmTab>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
        });

        modelBuilder.Entity<HPlace>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.HAreaID).HasMaxLength(50);
            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HID).ValueGeneratedOnAdd();
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HPlaceName).HasMaxLength(255);
        });

        modelBuilder.Entity<HPlaceList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("HPlaceList");

            entity.Property(e => e.HAreaID).HasMaxLength(50);
            entity.Property(e => e.HLArea).HasMaxLength(255);
            entity.Property(e => e.HPlaceName).HasMaxLength(255);
        });

        modelBuilder.Entity<HPlacePriority>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HMemberID).HasComment("關聯HMember.HID");
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HPlaceID).HasComment("關聯HPlace.HID");
            entity.Property(e => e.HPriority).HasComment("順序(先到後:由小至大)");
            entity.Property(e => e.HSave).HasMaxLength(10);
        });

        modelBuilder.Entity<HPointBooking>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HExpireDate).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HOrderNum).HasMaxLength(50);
            entity.Property(e => e.HPaymentDate).HasMaxLength(50);
            entity.Property(e => e.HPaymentNo).HasMaxLength(100);
            entity.Property(e => e.HTradeNo)
                .HasMaxLength(50)
                .HasComment("綠界交易編號");
        });

        modelBuilder.Entity<HPoints>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.HBuyDate).HasMaxLength(30);
            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HEndDate).HasMaxLength(30);
            entity.Property(e => e.HID).ValueGeneratedOnAdd();
            entity.Property(e => e.HInvoiceNo).HasMaxLength(255);
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HOrderGroup).HasMaxLength(50);
            entity.Property(e => e.HOrderNum).HasMaxLength(50);
            entity.Property(e => e.HPayMethod).HasMaxLength(30);
            entity.Property(e => e.HRecord).HasMaxLength(200);
            entity.Property(e => e.HRecrodDate).HasMaxLength(30);
            entity.Property(e => e.HUseFor).HasMaxLength(20);
        });

        modelBuilder.Entity<HPoints_bk>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.HBuyDate).HasMaxLength(30);
            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HEndDate).HasMaxLength(30);
            entity.Property(e => e.HID).ValueGeneratedOnAdd();
            entity.Property(e => e.HInvoiceNo).HasMaxLength(255);
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HPayMethod).HasMaxLength(30);
            entity.Property(e => e.HRecord).HasMaxLength(200);
            entity.Property(e => e.HRecrodDate).HasMaxLength(30);
            entity.Property(e => e.HUseFor).HasMaxLength(20);
        });

        modelBuilder.Entity<HPopularTags>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HPopularTags1)
                .HasMaxLength(50)
                .HasColumnName("HPopularTags");
        });

        modelBuilder.Entity<HPositionHistory>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.HCDate).HasMaxLength(50);
            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HID).ValueGeneratedOnAdd();
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HNew).HasMaxLength(50);
            entity.Property(e => e.HOld).HasMaxLength(50);
        });

        modelBuilder.Entity<HQualify>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HID).ValueGeneratedOnAdd();
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HTDate1).HasMaxLength(50);
            entity.Property(e => e.HTDate2).HasMaxLength(50);
            entity.Property(e => e.HTDate3).HasMaxLength(50);
            entity.Property(e => e.HTPDate1).HasMaxLength(50);
            entity.Property(e => e.HTPDate2).HasMaxLength(50);
            entity.Property(e => e.HTPDate3).HasMaxLength(50);
            entity.Property(e => e.HTScore1).HasMaxLength(10);
            entity.Property(e => e.HTScore2).HasMaxLength(10);
            entity.Property(e => e.HTScore3).HasMaxLength(10);
        });

        modelBuilder.Entity<HQuestion>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HID).ValueGeneratedOnAdd();
            entity.Property(e => e.HMemberType).HasMaxLength(10);
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HQuestionNum).HasMaxLength(100);
            entity.Property(e => e.HSave).HasMaxLength(10);
        });

        modelBuilder.Entity<HQuestionAnswer>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HID).ValueGeneratedOnAdd();
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
        });

        modelBuilder.Entity<HQuestionItem>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HID).ValueGeneratedOnAdd();
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HSave).HasMaxLength(10);
        });

        modelBuilder.Entity<HReceiptTemp>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HAccountBank).HasMaxLength(30);
            entity.Property(e => e.HAccountDate).HasMaxLength(10);
            entity.Property(e => e.HAddress).HasMaxLength(50);
            entity.Property(e => e.HBankType).HasMaxLength(50);
            entity.Property(e => e.HCRLetter).HasMaxLength(50);
            entity.Property(e => e.HCity).HasMaxLength(10);
            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HDonateDate).HasMaxLength(10);
            entity.Property(e => e.HDonateItem).HasMaxLength(20);
            entity.Property(e => e.HDonateMethod).HasMaxLength(20);
            entity.Property(e => e.HDonatePrice).HasMaxLength(10);
            entity.Property(e => e.HDonatePurpose).HasMaxLength(20);
            entity.Property(e => e.HDonorName).HasMaxLength(10);
            entity.Property(e => e.HEmail).HasMaxLength(30);
            entity.Property(e => e.HIdentityCard).HasMaxLength(10);
            entity.Property(e => e.HInclude).HasMaxLength(10);
            entity.Property(e => e.HInvoiceNo).HasMaxLength(10);
            entity.Property(e => e.HMobilePhone).HasMaxLength(10);
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HOverseasNo).HasMaxLength(10);
            entity.Property(e => e.HPID).HasMaxLength(10);
            entity.Property(e => e.HPostalCode).HasMaxLength(10);
            entity.Property(e => e.HProductAct).HasMaxLength(20);
            entity.Property(e => e.HReceiptHeader).HasMaxLength(10);
            entity.Property(e => e.HReceiptIssuance).HasMaxLength(30);
            entity.Property(e => e.HRemark).HasMaxLength(50);
            entity.Property(e => e.HTelephone).HasMaxLength(10);
            entity.Property(e => e.HTown).HasMaxLength(10);
            entity.Property(e => e.HYN).HasMaxLength(30);
        });

        modelBuilder.Entity<HRelation>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HRelation1)
                .HasMaxLength(255)
                .HasColumnName("HRelation");
        });

        modelBuilder.Entity<HRole>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HCrossRegion).HasComment("是否跨區(只運用於學員管理的權限判斷)");
            entity.Property(e => e.HID).ValueGeneratedOnAdd();
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HRName).HasMaxLength(50);
            entity.Property(e => e.HRNum).HasMaxLength(50);
            entity.Property(e => e.HRType)
                .HasMaxLength(30)
                .HasComment("角色類別(1=常態任務、2=天命法位)");
            entity.Property(e => e.HUTSystem).HasMaxLength(30);
            entity.Property(e => e.HUTaskClass).HasMaxLength(30);
        });

        modelBuilder.Entity<HRoleMListTemp>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.HMemberID).HasMaxLength(50);
            entity.Property(e => e.HUserName).HasMaxLength(200);
        });

        modelBuilder.Entity<HRollCall>(entity =>
        {
            entity.HasKey(e => e.HID).HasName("PK_HRollCall_1");

            entity.Property(e => e.HAStatusDT).HasMaxLength(50);
            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HQRCode).HasMaxLength(100);
        });

        modelBuilder.Entity<HRoom>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HRoomName).HasMaxLength(50);
        });

        modelBuilder.Entity<HSCCTopicSetting>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCTemplateID).HasComment("課程範本HID(HCourse_T.HID)");
            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HSCForumClassID).HasComment("討論區名稱HID(HSCForumName.HID)");
            entity.Property(e => e.HTopicNameType).HasComment("主題名稱產生方式(1=依課程名稱;2=依上課日期;3=不依上課地點)");
        });

        modelBuilder.Entity<HSCClass>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HSCClassName)
                .HasMaxLength(50)
                .HasComment("專欄分類");
        });

        modelBuilder.Entity<HSCForumClass>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HPublic).HasComment("公開狀態(0:不公開、1:公開)");
            entity.Property(e => e.HSCFCLevel)
                .HasMaxLength(5)
                .HasComment("討論區類別階層");
            entity.Property(e => e.HSCFCMaster).HasComment("討論區上一層HID(HSCForumClass.HID)");
            entity.Property(e => e.HSCFCName)
                .HasMaxLength(50)
                .HasComment("討論區類別名稱");
        });

        modelBuilder.Entity<HSCGProgress>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HSCGProgressName).HasMaxLength(255);
        });

        modelBuilder.Entity<HSCGRMsg>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HContent).HasComment("內容");
            entity.Property(e => e.HCourseID)
                .HasMaxLength(255)
                .HasComment("課程名稱HID(HCourse.HID)");
            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HFile1)
                .HasMaxLength(100)
                .HasComment("上傳檔案1");
            entity.Property(e => e.HFile2)
                .HasMaxLength(100)
                .HasComment("上傳檔案2");
            entity.Property(e => e.HFile3)
                .HasMaxLength(100)
                .HasComment("上傳檔案3");
            entity.Property(e => e.HGProgress).HasComment("成長進度");
            entity.Property(e => e.HHashTag)
                .HasMaxLength(255)
                .HasComment("HashTag標籤");
            entity.Property(e => e.HMemberID).HasComment("學員HID(HMember.HID)");
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HOGProgress)
                .HasMaxLength(50)
                .HasComment("其他成長進度");
            entity.Property(e => e.HOpenObject).HasComment("開放對象");
            entity.Property(e => e.HSCClassID).HasComment("專欄分類HID(HSCClass.HID)");
            entity.Property(e => e.HSCJiugonggeTypeID).HasComment("九宮格類型");
            entity.Property(e => e.HSCRecordTypeID).HasComment("紀錄類型HID(HSCRecordType.HID)");
            entity.Property(e => e.HTopicName)
                .HasMaxLength(50)
                .HasComment("主題名稱");
            entity.Property(e => e.HVideoLink)
                .HasMaxLength(200)
                .HasComment("影片嵌入連結");
        });

        modelBuilder.Entity<HSCGRMsgResponse>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HGRMRContent).HasComment("回應留言");
            entity.Property(e => e.HGRMRFile1)
                .HasMaxLength(100)
                .HasComment("上傳檔案");
            entity.Property(e => e.HGRMRHappy)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.HGRMRThumbsUp)
                .HasMaxLength(200)
                .HasComment("MP3檔案");
            entity.Property(e => e.HMemberID).HasComment("學員HID(HMember.HID)");
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
        });

        modelBuilder.Entity<HSCGRMsgResponse_Log>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HLogType)
                .HasMaxLength(255)
                .HasComment("回應留言Log類型(0:刪除/1:編輯/2:隱藏)");
            entity.Property(e => e.HMemberID).HasComment("學員HID(HMember.HID)");
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HReason)
                .HasMaxLength(255)
                .HasComment("原因");
            entity.Property(e => e.HSCGRMsgResponseID).HasComment("回應留言HID(HSCGRMsgResponse.HID)");
        });

        modelBuilder.Entity<HSCGRMsg_Mood>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HMemberID).HasComment("學員HID(HMember.HID)");
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HSCGRMsgID).HasComment("成長紀錄留言HID(HSCGRMsg.HID)");
            entity.Property(e => e.HType).HasComment("心情狀態(1:讚/2:愛心/3:笑臉)");
        });

        modelBuilder.Entity<HSCGRecord>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HSCForumClassID).HasComment("討論區名稱HID");
            entity.Property(e => e.HTopicName)
                .HasMaxLength(50)
                .HasComment("主題名稱");
        });

        modelBuilder.Entity<HSCGRecord_Mood>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HMemberID).HasComment("學員HID(HMember.HID)");
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HSCGRecordID).HasComment("主題HID(HSCTopic.HID)");
            entity.Property(e => e.HType).HasComment("心情狀態(1:讚/2:愛心/3:笑臉)");
        });

        modelBuilder.Entity<HSCGRecord_Share>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HMemberID).HasComment("學員HID(HMember.HID)");
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HSCGRecordID).HasComment("主題HID(HSCTopic.HID)");
            entity.Property(e => e.HTimes).HasComment("瀏覽次數");
        });

        modelBuilder.Entity<HSCGRecord_View>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HMemberID).HasComment("學員HID(HMember.HID)");
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HSCGRecordID).HasComment("成長紀錄HID(HSCGRecord.HID)");
            entity.Property(e => e.HTimes).HasComment("瀏覽次數");
        });

        modelBuilder.Entity<HSCHotHashTag>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HSCHHashTag)
                .HasMaxLength(50)
                .HasComment("熱門標籤");
        });

        modelBuilder.Entity<HSCMPublicYN>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HSCMPublicYN1)
                .HasComment("0=不公開/1=公開")
                .HasColumnName("HSCMPublicYN");
        });

        modelBuilder.Entity<HSCMPublicYN_Log>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HSCFCName).HasMaxLength(255);
            entity.Property(e => e.HSCForumClassID).HasComment("課程討論區與主題設定ID(HSCCTopicSetting.HID)");
            entity.Property(e => e.HSCMPublicYN).HasComment("0=不公開/1=公開");
        });

        modelBuilder.Entity<HSCMRule>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HSCForumClassID).HasComment("課程討論區與主題設定ID(HSCCTopicSetting.HID)");
            entity.Property(e => e.HSCMRule1)
                .HasComment("版規內容")
                .HasColumnName("HSCMRule");
        });

        modelBuilder.Entity<HSCMRule_Log>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HSCCTopicID).HasComment("課程討論區與主題設定ID(HSCCTopicSetting.HID)");
            entity.Property(e => e.HSCMRule).HasComment("版規內容");
            entity.Property(e => e.HSCMRuleID).HasComment("討論區版規ID(HSCMRule.HID)");
        });

        modelBuilder.Entity<HSCModeratorSetting>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HMemberID).HasComment("學員HID(HMember.HID)");
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HSCForumClassID).HasComment("討論區名稱HID(HSCForumName.HID)");
        });

        modelBuilder.Entity<HSCParmTab>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
        });

        modelBuilder.Entity<HSCRecordType>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HSCRTName)
                .HasMaxLength(50)
                .HasComment("紀錄類型");
        });

        modelBuilder.Entity<HSCRule_T>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
        });

        modelBuilder.Entity<HSCTMsg>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HContent).HasComment("內容");
            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HFile1)
                .HasMaxLength(100)
                .HasComment("上傳檔案1");
            entity.Property(e => e.HMemberID).HasComment("學員HID(HMember.HID)");
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HQuestionYN).HasComment("是否為提問(0:不是、1:是)");
            entity.Property(e => e.HSCTopicID).HasComment("主題HID(HSCTopic.HID)");
            entity.Property(e => e.HStatus).HasComment("狀態(0:刪掉/1:正常/2:隱藏");
            entity.Property(e => e.HVideoLink)
                .HasMaxLength(200)
                .HasComment("影片嵌入連結");
        });

        modelBuilder.Entity<HSCTMsgResponse>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HMemberID).HasComment("學員HID(HMember.HID)");
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HMsgResponse).HasComment("回應留言");
            entity.Property(e => e.HSCTMsgID).HasComment("回應主題HID(HSCTMsg.HID)");
            entity.Property(e => e.HStatus).HasComment("狀態(0:刪掉/1:正常/2:隱藏)");
            entity.Property(e => e.HVoice).HasMaxLength(200);
        });

        modelBuilder.Entity<HSCTMsgResponse_Log>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HLogType)
                .HasMaxLength(255)
                .HasComment("回應留言Log類型(0:刪除/1:編輯/2:隱藏)");
            entity.Property(e => e.HMemberID).HasComment("學員HID(HMember.HID)");
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HReason)
                .HasMaxLength(255)
                .HasComment("原因");
            entity.Property(e => e.HSCTMsgResponseID).HasComment("回應留言HID(HSCTMsgResponse.HID)");
        });

        modelBuilder.Entity<HSCTMsg_Log>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HLogType)
                .HasMaxLength(255)
                .HasComment("留言Log類型(0:刪除/1:編輯/2:隱藏/3:取消隱藏)");
            entity.Property(e => e.HMemberID).HasComment("學員HID(HMember.HID)");
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HReason)
                .HasMaxLength(255)
                .HasComment("原因");
            entity.Property(e => e.HSCTMsgID).HasComment("回應主題HID(HSCTMsg.HID)");
        });

        modelBuilder.Entity<HSCTMsg_Mood>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HMemberID).HasComment("學員HID(HMember.HID)");
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HSCTMsgID).HasComment("回應主題HID(HSCTMsg.HID)");
            entity.Property(e => e.HType).HasComment("心情狀態(1:讚/2:愛心/3:笑臉)");
        });

        modelBuilder.Entity<HSCTopic>(entity =>
        {
            entity.HasKey(e => e.HID).HasName("PK_HTopic");

            entity.Property(e => e.HContent).HasComment("主題內容");
            entity.Property(e => e.HCourseID).HasComment("課程HID");
            entity.Property(e => e.HCreate)
                .HasMaxLength(100)
                .HasComment("建立者");
            entity.Property(e => e.HCreateDT)
                .HasMaxLength(50)
                .HasComment("建立日期");
            entity.Property(e => e.HFile1).HasComment("附件一");
            entity.Property(e => e.HFile2).HasComment("附件二");
            entity.Property(e => e.HFile3).HasComment("附件三");
            entity.Property(e => e.HGProgress).HasComment("成長紀錄");
            entity.Property(e => e.HHashTag).HasComment("HashTag標籤");
            entity.Property(e => e.HModify)
                .HasMaxLength(100)
                .HasComment("修改者");
            entity.Property(e => e.HModifyDT)
                .HasMaxLength(50)
                .HasComment("修改日期");
            entity.Property(e => e.HOGProgress).HasComment("其他成長紀錄");
            entity.Property(e => e.HPinTop).HasComment("是否置頂");
            entity.Property(e => e.HSCClassID).HasComment("專欄類別HID (HSCClass.HID)");
            entity.Property(e => e.HSCForumClassID).HasComment("討論區名稱HID(HSCForumClass.HID)");
            entity.Property(e => e.HSCJiugonggeTypeID).HasComment("九宮格類型");
            entity.Property(e => e.HSCRecordTypeID).HasComment("紀錄類型HID (HSCRecordType.HID)");
            entity.Property(e => e.HStatus).HasComment("狀態");
            entity.Property(e => e.HTopicName).HasComment("主題名稱");
            entity.Property(e => e.HVideoLink).HasComment("影片連結");
        });

        modelBuilder.Entity<HSCTopic_Log>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HLogType)
                .HasMaxLength(255)
                .HasComment("主題Log類型(0:刪除/1:編輯/2:隱藏)");
            entity.Property(e => e.HMemberID).HasComment("學員HID(HMember.HID)");
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HReason)
                .HasMaxLength(255)
                .HasComment("原因");
            entity.Property(e => e.HSCTopicID).HasComment("主題HID(HSCTopic.HID)");
        });

        modelBuilder.Entity<HSCTopic_Mood>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HMemberID).HasComment("學員HID(HMember.HID)");
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HSCTopicID).HasComment("主題HID(HSCTopic.HID)");
            entity.Property(e => e.HType).HasComment("心情狀態(1:讚/2:愛心/3:笑臉)");
        });

        modelBuilder.Entity<HSCTopic_Role>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HMemberID).HasComment("學員HID(HMember.HID)");
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HSCForumClassID).HasComment("討論區名稱HID(HSCForumClass.HID)");
            entity.Property(e => e.HSCTopicID).HasComment("主題HID(HSCTopic.HID)");
        });

        modelBuilder.Entity<HSCTopic_Share>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HMemberID).HasComment("學員HID(HMember.HID)");
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HSCTopicID).HasComment("主題HID(HSCTopic.HID)");
            entity.Property(e => e.HTimes).HasComment("瀏覽次數");
        });

        modelBuilder.Entity<HSCTopic_View>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HMemberID).HasComment("學員HID(HMember.HID)");
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HSCTopicID).HasComment("主題HID(HSCTopic.HID)");
        });

        modelBuilder.Entity<HSCourseKeyWord>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HSKeyword).HasMaxLength(10);
        });

        modelBuilder.Entity<HShoppingCart>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HBDate).HasMaxLength(30);
            entity.Property(e => e.HCourseID).HasComment("課程ID");
            entity.Property(e => e.HCourseName).HasMaxLength(100);
            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HDCode).HasMaxLength(30);
            entity.Property(e => e.HDPoint).HasMaxLength(30);
            entity.Property(e => e.HExpireDate).HasMaxLength(50);
            entity.Property(e => e.HInvoiceDate).HasMaxLength(50);
            entity.Property(e => e.HInvoiceNo).HasMaxLength(100);
            entity.Property(e => e.HLDate).HasMaxLength(30);
            entity.Property(e => e.HMemberGroup).HasMaxLength(20);
            entity.Property(e => e.HMemberID).HasComment("會員ID");
            entity.Property(e => e.HMerchantTradeNo).HasMaxLength(100);
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HOrderNum).HasMaxLength(50);
            entity.Property(e => e.HPayMethod).HasMaxLength(30);
            entity.Property(e => e.HPaymentDate).HasMaxLength(50);
            entity.Property(e => e.HPaymentNo).HasMaxLength(100);
            entity.Property(e => e.HPoint).HasMaxLength(50);
            entity.Property(e => e.HRoomTime).HasMaxLength(30);
            entity.Property(e => e.HSubscribe).HasMaxLength(20);
            entity.Property(e => e.HTradeNo)
                .HasMaxLength(50)
                .HasComment("綠界交易編號");
        });

        modelBuilder.Entity<HShoppingCart_Activity>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HAName).HasMaxLength(255);
            entity.Property(e => e.HARelation).HasMaxLength(255);
            entity.Property(e => e.HAmount).HasMaxLength(50);
            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
        });

        modelBuilder.Entity<HShoppingCart_Group>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HGDay).HasMaxLength(10);
            entity.Property(e => e.HGETime).HasMaxLength(30);
            entity.Property(e => e.HGSTime).HasMaxLength(30);
            entity.Property(e => e.HGroupID).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HTask).HasMaxLength(255);
        });

        modelBuilder.Entity<HShoppingCart_Other>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
        });

        modelBuilder.Entity<HSystem>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HSystemName).HasMaxLength(255);
        });

        modelBuilder.Entity<HSystemFeedback>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCategory).HasComment("回饋分類(1:建議、2:改善(問題回報))");
            entity.Property(e => e.HContent).HasComment("詳細說明");
            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HEventStatus).HasComment("處理狀態(1:待處理、2:處理中、3:已處理)");
            entity.Property(e => e.HHandleContent).HasComment("處理狀況");
            entity.Property(e => e.HHandleTime)
                .HasMaxLength(20)
                .HasComment("處理時間");
            entity.Property(e => e.HHandler).HasComment("處理者");
            entity.Property(e => e.HMemberID).HasComment("學員HID");
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HTitle)
                .HasMaxLength(100)
                .HasComment("標題");
        });

        modelBuilder.Entity<HTArea>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HApplicant).HasMaxLength(50);
            entity.Property(e => e.HApplyTime).HasMaxLength(30);
            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HTargetAreaID).HasMaxLength(255);
            entity.Property(e => e.HVerifyNum).HasMaxLength(50);
            entity.Property(e => e.HVerifyTime).HasMaxLength(30);
        });

        modelBuilder.Entity<HTAreaUnit>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
        });

        modelBuilder.Entity<HTMaterial_View>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("HTMaterial_View");

            entity.Property(e => e.HCBatchNum).HasMaxLength(50);
            entity.Property(e => e.HCourseName).HasMaxLength(100);
            entity.Property(e => e.HTeacherName).HasMaxLength(50);
        });

        modelBuilder.Entity<HTMaterial_View_old>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("HTMaterial_View_old");

            entity.Property(e => e.HCourseName).HasMaxLength(100);
            entity.Property(e => e.HSave).HasMaxLength(10);
            entity.Property(e => e.HTeacherName).HasMaxLength(50);
        });

        modelBuilder.Entity<HTVerifyLog>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HSave).HasMaxLength(10);
            entity.Property(e => e.HSignName).HasMaxLength(100);
            entity.Property(e => e.HVDate).HasMaxLength(30);
            entity.Property(e => e.HVTeamID).HasMaxLength(50);
        });

        modelBuilder.Entity<HTask_Class>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HClassName).HasMaxLength(100);
            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
        });

        modelBuilder.Entity<HTeacher>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HTeacherClass).HasComment("講師類別");
            entity.Property(e => e.HTearcherLV).HasComment("講師層級分類");
        });

        modelBuilder.Entity<HTeacherMaterial>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HClassNo)
                .HasMaxLength(10)
                .HasComment("堂數(分段/分片)");
            entity.Property(e => e.HCreate)
                .HasMaxLength(100)
                .HasComment("建立者");
            entity.Property(e => e.HCreateDT)
                .HasMaxLength(50)
                .HasComment("建立日期");
            entity.Property(e => e.HDocCTClassID).HasComment("課程類型班別(Course Type Class) (關聯dbo. HDocCTypeClass HID)");
            entity.Property(e => e.HFestival)
                .HasMaxLength(10)
                .HasComment("節");
            entity.Property(e => e.HFileTypeID).HasComment("檔案類型(關聯dbo.HFileType HID)");
            entity.Property(e => e.HModify)
                .HasMaxLength(100)
                .HasComment("編輯者");
            entity.Property(e => e.HModifyDT)
                .HasMaxLength(50)
                .HasComment("編輯日期");
            entity.Property(e => e.HStatus).HasComment("狀態");
            entity.Property(e => e.HTMDate)
                .HasMaxLength(30)
                .HasComment("西元年月日(yyyy/MM/dd)");
            entity.Property(e => e.HTMLink).HasComment("講師教材連結");
            entity.Property(e => e.HTMName)
                .HasMaxLength(100)
                .HasComment("講師教材名稱");
            entity.Property(e => e.HTMaterial)
                .HasMaxLength(100)
                .HasComment("講師教材檔案");
        });

        modelBuilder.Entity<HTeacherMaterial_Detail>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCourseID).HasComment("課程HID");
            entity.Property(e => e.HCreate)
                .HasMaxLength(100)
                .HasComment("建立者");
            entity.Property(e => e.HCreateDT)
                .HasMaxLength(50)
                .HasComment("建立日期");
            entity.Property(e => e.HModify)
                .HasMaxLength(100)
                .HasComment("編輯者");
            entity.Property(e => e.HModifyDT)
                .HasMaxLength(50)
                .HasComment("編輯日期");
            entity.Property(e => e.HSort).HasComment("排序");
            entity.Property(e => e.HStatus).HasComment("狀態");
            entity.Property(e => e.HTMID).HasComment("講師教材HID");
        });

        modelBuilder.Entity<HTeamHistory>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.HCDate).HasMaxLength(50);
            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HID).ValueGeneratedOnAdd();
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HNew).HasMaxLength(50);
            entity.Property(e => e.HOld).HasMaxLength(50);
        });

        modelBuilder.Entity<HTeamTVerifyLog>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HSignName).HasMaxLength(100);
            entity.Property(e => e.HVDate).HasMaxLength(30);
        });

        modelBuilder.Entity<HTeamTransfer>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HApplicant).HasMaxLength(50);
            entity.Property(e => e.HApplyTime).HasMaxLength(30);
            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HOriginTeamID).HasMaxLength(50);
            entity.Property(e => e.HTargetTeamID).HasMaxLength(50);
            entity.Property(e => e.HVerifyNum).HasMaxLength(50);
            entity.Property(e => e.HVerifyTime).HasMaxLength(30);
        });

        modelBuilder.Entity<HTest>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HID).ValueGeneratedOnAdd();
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
        });

        modelBuilder.Entity<HTodoList>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.HCourseID, e.HSave }, "IX_HTodoList");

            entity.Property(e => e.HCBatchNum).HasMaxLength(50);
            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HExamStaff).HasComment("試務人員名單");
            entity.Property(e => e.HGroupName).HasMaxLength(10);
            entity.Property(e => e.HID).ValueGeneratedOnAdd();
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HSave).HasMaxLength(10);
            entity.Property(e => e.HTask).HasMaxLength(10);
            entity.Property(e => e.HTaskNum).HasComment("人數");
        });

        modelBuilder.Entity<HTodoList_T>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.HCBatchNum).HasMaxLength(50);
            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HExamStaff).HasComment("試務人員名單");
            entity.Property(e => e.HGroupName).HasMaxLength(10);
            entity.Property(e => e.HID).ValueGeneratedOnAdd();
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HSave).HasMaxLength(10);
            entity.Property(e => e.HTask).HasMaxLength(10);
            entity.Property(e => e.HTaskNum).HasComment("人數");
        });

        modelBuilder.Entity<HTopicTypeRec>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HTopicTypeRec1)
                .HasMaxLength(50)
                .HasColumnName("HTopicTypeRec");
        });

        modelBuilder.Entity<HTreePeople>(entity =>
        {
            entity.HasKey(e => e.HNo);

            entity.Property(e => e.HOccupation).HasMaxLength(50);
            entity.Property(e => e.HTreeStructure).HasMaxLength(50);
        });

        modelBuilder.Entity<HTreeStructure>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.HDepartment).HasMaxLength(50);
            entity.Property(e => e.HLevel).HasMaxLength(50);
            entity.Property(e => e.HMaster).HasMaxLength(50);
            entity.Property(e => e.HNo).HasMaxLength(50);
        });

        modelBuilder.Entity<HUTaskHistory>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.HCDate).HasMaxLength(50);
            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HID).ValueGeneratedOnAdd();
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HNew).HasMaxLength(50);
            entity.Property(e => e.HOld).HasMaxLength(50);
        });

        modelBuilder.Entity<HVerifyType>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HVTypeName).HasMaxLength(255);
        });

        modelBuilder.Entity<HWTItem>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HWTItemName).HasMaxLength(150);
        });

        modelBuilder.Entity<HWType>(entity =>
        {
            entity.HasKey(e => e.HID).HasName("PK_HWorkType");

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HWType1)
                .HasMaxLength(150)
                .HasColumnName("HWType");
        });

        modelBuilder.Entity<HWay>(entity =>
        {
            entity.HasKey(e => e.HID);

            entity.Property(e => e.HCreate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(50);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
        });

        modelBuilder.Entity<Invoice>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Invoice");

            entity.Property(e => e.HPaymentDate).HasMaxLength(10);
            entity.Property(e => e.代收銀行別)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.備註欄).HasMaxLength(253);
            entity.Property(e => e.入帳日期)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.入帳銀行)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.列入捐款)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.區屬).HasMaxLength(255);
            entity.Property(e => e.地址)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.徵信抬頭)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.捐款人).HasMaxLength(255);
            entity.Property(e => e.捐款方式)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.捐款日期)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.捐款用途)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.捐款項目)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.收據開立)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.是否願意將捐款資料上傳國稅局)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.海外編號)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.縣市)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.臨時收據編號)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.行動電話).HasMaxLength(4000);
            entity.Property(e => e.身分證_統編_居留證)
                .HasMaxLength(30)
                .HasColumnName("身分證/統編/居留證");
            entity.Property(e => e.郵遞區號)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.鄉鎮市區)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.電子信箱).HasMaxLength(255);
            entity.Property(e => e.電話)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InvoiceReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("InvoiceReport");

            entity.Property(e => e.Aboard)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Address)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.BTitle)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.BankType)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Country)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.DItem)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.DPurpose)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Donate)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.DonateDate)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.DonatePerson).HasMaxLength(255);
            entity.Property(e => e.HAccount).HasMaxLength(255);
            entity.Property(e => e.HPersonID).HasMaxLength(30);
            entity.Property(e => e.HPhone).HasMaxLength(4000);
            entity.Property(e => e.HPoint).HasMaxLength(50);
            entity.Property(e => e.ICBank)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.ICDate)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceTitle).HasMaxLength(255);
            entity.Property(e => e.InvoiceType)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.PayMethod)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.Postal)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Remark).HasMaxLength(202);
            entity.Property(e => e.Tax)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Tel)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.TempNo)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MemberBasicInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("MemberBasicInfo");

            entity.Property(e => e.AreaHeadName).HasMaxLength(793);
            entity.Property(e => e.AreaName).HasMaxLength(255);
            entity.Property(e => e.CarrierName)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.HArea).HasMaxLength(255);
            entity.Property(e => e.HAxisType).HasMaxLength(200);
            entity.Property(e => e.HLightEnvoy)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.HPeriod).HasMaxLength(25);
            entity.Property(e => e.HRName).HasMaxLength(50);
            entity.Property(e => e.HSystemName).HasMaxLength(255);
            entity.Property(e => e.HTeamID).HasMaxLength(50);
            entity.Property(e => e.HUsername).HasMaxLength(255);
            entity.Property(e => e.HeaderName).HasMaxLength(4000);
            entity.Property(e => e.LAreaName).HasMaxLength(255);
            entity.Property(e => e.MMentorName).HasMaxLength(793);
            entity.Property(e => e.MentorName).HasMaxLength(793);
            entity.Property(e => e.RainbowName)
                .HasMaxLength(4)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MemberList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("MemberList");

            entity.Property(e => e.CountryTW).HasMaxLength(20);
            entity.Property(e => e.HAccount).HasMaxLength(255);
            entity.Property(e => e.HArea).HasMaxLength(255);
            entity.Property(e => e.HAxisType).HasMaxLength(200);
            entity.Property(e => e.HBirth).HasMaxLength(50);
            entity.Property(e => e.HCPostal).HasMaxLength(50);
            entity.Property(e => e.HCTel).HasMaxLength(50);
            entity.Property(e => e.HDad).HasMaxLength(255);
            entity.Property(e => e.HDeadDT).HasMaxLength(50);
            entity.Property(e => e.HDisease).HasMaxLength(255);
            entity.Property(e => e.HEPItem).HasMaxLength(200);
            entity.Property(e => e.HEmerName).HasMaxLength(255);
            entity.Property(e => e.HEmerPhone).HasMaxLength(50);
            entity.Property(e => e.HEmerRelated).HasMaxLength(100);
            entity.Property(e => e.HExpertise).HasMaxLength(200);
            entity.Property(e => e.HFB).HasMaxLength(255);
            entity.Property(e => e.HFDisease).HasMaxLength(255);
            entity.Property(e => e.HGraduate).HasMaxLength(255);
            entity.Property(e => e.HIntroName).HasMaxLength(255);
            entity.Property(e => e.HIntroRelated).HasMaxLength(100);
            entity.Property(e => e.HJDuration).HasMaxLength(100);
            entity.Property(e => e.HLeaveDT).HasMaxLength(50);
            entity.Property(e => e.HLineID).HasMaxLength(150);
            entity.Property(e => e.HMom).HasMaxLength(255);
            entity.Property(e => e.HOEmail).HasMaxLength(255);
            entity.Property(e => e.HOTel).HasMaxLength(50);
            entity.Property(e => e.HPPName).HasMaxLength(255);
            entity.Property(e => e.HPeriod).HasMaxLength(25);
            entity.Property(e => e.HPersonID).HasMaxLength(30);
            entity.Property(e => e.HPhone).HasMaxLength(50);
            entity.Property(e => e.HQReason).HasMaxLength(255);
            entity.Property(e => e.HRPostal).HasMaxLength(50);
            entity.Property(e => e.HRank).HasMaxLength(255);
            entity.Property(e => e.HReligion).HasMaxLength(150);
            entity.Property(e => e.HSADate).HasMaxLength(50);
            entity.Property(e => e.HSAReason).HasMaxLength(255);
            entity.Property(e => e.HServiceTitle).HasMaxLength(255);
            entity.Property(e => e.HSiblingNum).HasMaxLength(255);
            entity.Property(e => e.HSpouse).HasMaxLength(255);
            entity.Property(e => e.HSystemName).HasMaxLength(255);
            entity.Property(e => e.HTeamID).HasMaxLength(50);
            entity.Property(e => e.HTeamType).HasMaxLength(10);
            entity.Property(e => e.HType).HasMaxLength(100);
            entity.Property(e => e.HUnitName).HasMaxLength(255);
            entity.Property(e => e.HUserName).HasMaxLength(255);
            entity.Property(e => e.HUsualTask).HasMaxLength(255);
            entity.Property(e => e.HWechat).HasMaxLength(150);
            entity.Property(e => e.HWhatsapp).HasMaxLength(150);
            entity.Property(e => e.HWorkName).HasMaxLength(255);
        });

        modelBuilder.Entity<OrderList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("OrderList");

            entity.Property(e => e.HATMBankCode).HasMaxLength(50);
            entity.Property(e => e.HATMVAccount).HasMaxLength(100);
            entity.Property(e => e.HBCPoint).HasMaxLength(10);
            entity.Property(e => e.HBDate).HasMaxLength(30);
            entity.Property(e => e.HCDeadline).HasMaxLength(50);
            entity.Property(e => e.HCXLApplyDate).HasMaxLength(50);
            entity.Property(e => e.HCXLBAName).HasMaxLength(50);
            entity.Property(e => e.HCXLBAccount).HasMaxLength(50);
            entity.Property(e => e.HCXLBankCode).HasMaxLength(50);
            entity.Property(e => e.HCXLBankName).HasMaxLength(100);
            entity.Property(e => e.HCXLFinishDate).HasMaxLength(50);
            entity.Property(e => e.HCXLOrderGroup).HasMaxLength(100);
            entity.Property(e => e.HCourseName).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HDCode).HasMaxLength(30);
            entity.Property(e => e.HDPoint).HasMaxLength(30);
            entity.Property(e => e.HEmail).HasMaxLength(255);
            entity.Property(e => e.HExpireDate).HasMaxLength(50);
            entity.Property(e => e.HInvoiceDate).HasMaxLength(50);
            entity.Property(e => e.HInvoiceNo).HasMaxLength(100);
            entity.Property(e => e.HMerchantTradeNo).HasMaxLength(50);
            entity.Property(e => e.HOrderGroup).HasMaxLength(100);
            entity.Property(e => e.HOrderNum).HasMaxLength(50);
            entity.Property(e => e.HPayMethod).HasMaxLength(30);
            entity.Property(e => e.HPaymentDate).HasMaxLength(50);
            entity.Property(e => e.HPaymentNo).HasMaxLength(100);
            entity.Property(e => e.HPersonID).HasMaxLength(30);
            entity.Property(e => e.HPhone).HasMaxLength(50);
            entity.Property(e => e.HPlaceName).HasMaxLength(255);
            entity.Property(e => e.HPoint).HasMaxLength(50);
            entity.Property(e => e.HRoomName).HasMaxLength(50);
            entity.Property(e => e.HRoomTime).HasMaxLength(30);
            entity.Property(e => e.HTeacherName).HasMaxLength(50);
            entity.Property(e => e.HTradeNo).HasMaxLength(50);
            entity.Property(e => e.HType).HasMaxLength(100);
            entity.Property(e => e.HUserName).HasMaxLength(255);
        });

        modelBuilder.Entity<OrderList_Backend>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("OrderList_Backend");

            entity.Property(e => e.HCXLApplyDate).HasMaxLength(50);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HMerchantTradeNo).HasMaxLength(50);
            entity.Property(e => e.HOrderGroup).HasMaxLength(100);
            entity.Property(e => e.HOrderGroupSrc).HasMaxLength(100);
            entity.Property(e => e.HOrderNum).HasMaxLength(50);
            entity.Property(e => e.HPaymentDate).HasMaxLength(50);
            entity.Property(e => e.PMethod)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.PayMethod)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.UserName).HasMaxLength(537);
        });

        modelBuilder.Entity<OrderList_Detail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("OrderList_Detail");

            entity.Property(e => e.HAttend).HasMaxLength(4000);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HDCode).HasMaxLength(30);
            entity.Property(e => e.HDPoint).HasMaxLength(30);
            entity.Property(e => e.HInvoiceDate).HasMaxLength(50);
            entity.Property(e => e.HInvoiceNo).HasMaxLength(100);
            entity.Property(e => e.HMerchantTradeNo).HasMaxLength(50);
            entity.Property(e => e.HOCPlace).HasMaxLength(50);
            entity.Property(e => e.HOrderGroup).HasMaxLength(100);
            entity.Property(e => e.HOrderGroupSrc).HasMaxLength(100);
            entity.Property(e => e.HOrderNum).HasMaxLength(50);
            entity.Property(e => e.HPayMethod).HasMaxLength(30);
            entity.Property(e => e.HPaymentDate).HasMaxLength(50);
            entity.Property(e => e.HPaymentNo).HasMaxLength(100);
            entity.Property(e => e.HPlaceName).HasMaxLength(255);
            entity.Property(e => e.HPoint).HasMaxLength(50);
            entity.Property(e => e.HTaxID).HasMaxLength(20);
            entity.Property(e => e.HTradeNo).HasMaxLength(50);
        });

        modelBuilder.Entity<OrderList_Front>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("OrderList_Front");

            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HMerchantTradeNo).HasMaxLength(50);
            entity.Property(e => e.HOrderGroup).HasMaxLength(100);
            entity.Property(e => e.HOrderGroupSrc).HasMaxLength(100);
            entity.Property(e => e.HPayMethod).HasMaxLength(30);
            entity.Property(e => e.HPaymentDate).HasMaxLength(50);
            entity.Property(e => e.PMethod)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.UserName).HasMaxLength(537);
        });

        modelBuilder.Entity<OrderList_Merge>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("OrderList_Merge");

            entity.Property(e => e.HATMBankCode).HasMaxLength(50);
            entity.Property(e => e.HATMVAccount).HasMaxLength(100);
            entity.Property(e => e.HBDate).HasMaxLength(30);
            entity.Property(e => e.HCXLApplyDate).HasMaxLength(50);
            entity.Property(e => e.HCXLBAName).HasMaxLength(50);
            entity.Property(e => e.HCXLBAccount).HasMaxLength(50);
            entity.Property(e => e.HCXLBankCode).HasMaxLength(50);
            entity.Property(e => e.HCXLBankName).HasMaxLength(100);
            entity.Property(e => e.HCXLBranchName).HasMaxLength(100);
            entity.Property(e => e.HCXLFinishDate).HasMaxLength(50);
            entity.Property(e => e.HCXLOrderGroup).HasMaxLength(100);
            entity.Property(e => e.HCXLRtnCode).HasMaxLength(10);
            entity.Property(e => e.HCXLRtnMsg).HasMaxLength(100);
            entity.Property(e => e.HCreate).HasMaxLength(100);
            entity.Property(e => e.HCreateDT).HasMaxLength(50);
            entity.Property(e => e.HDCode).HasMaxLength(30);
            entity.Property(e => e.HDPoint).HasMaxLength(30);
            entity.Property(e => e.HExpireDate).HasMaxLength(50);
            entity.Property(e => e.HFrom)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.HGwsr).HasMaxLength(50);
            entity.Property(e => e.HInvoiceDate).HasMaxLength(50);
            entity.Property(e => e.HInvoiceNo).HasMaxLength(100);
            entity.Property(e => e.HMemberGroup).HasMaxLength(20);
            entity.Property(e => e.HMerchantTradeNo).HasMaxLength(50);
            entity.Property(e => e.HModify).HasMaxLength(100);
            entity.Property(e => e.HModifyDT).HasMaxLength(50);
            entity.Property(e => e.HOCPlace).HasMaxLength(50);
            entity.Property(e => e.HOrderGroup).HasMaxLength(100);
            entity.Property(e => e.HOrderNum).HasMaxLength(50);
            entity.Property(e => e.HPayMethod).HasMaxLength(30);
            entity.Property(e => e.HPaymentDate).HasMaxLength(50);
            entity.Property(e => e.HPaymentNo).HasMaxLength(100);
            entity.Property(e => e.HPlaceName).HasMaxLength(255);
            entity.Property(e => e.HPoint).HasMaxLength(50);
            entity.Property(e => e.HQuestionID).HasMaxLength(200);
            entity.Property(e => e.HRoomTime).HasMaxLength(30);
            entity.Property(e => e.HSubscribe).HasMaxLength(20);
            entity.Property(e => e.HTaxID).HasMaxLength(20);
            entity.Property(e => e.HTradeNo).HasMaxLength(50);
            entity.Property(e => e.HType).HasMaxLength(50);
        });

        modelBuilder.Entity<OrderList_Zoom>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("OrderList_Zoom");

            entity.Property(e => e.HOCPlace).HasMaxLength(50);
            entity.Property(e => e.HPlaceName).HasMaxLength(255);
        });

        modelBuilder.Entity<OrderReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("OrderReport");

            entity.Property(e => e.Attend)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.HBDate).HasMaxLength(30);
            entity.Property(e => e.HCourseName).HasMaxLength(100);
            entity.Property(e => e.HDCode).HasMaxLength(30);
            entity.Property(e => e.HInvoiceDate).HasMaxLength(50);
            entity.Property(e => e.HInvoiceNo).HasMaxLength(100);
            entity.Property(e => e.HMerchantTradeNo).HasMaxLength(50);
            entity.Property(e => e.HOrderGroup).HasMaxLength(100);
            entity.Property(e => e.HOrderNum).HasMaxLength(50);
            entity.Property(e => e.HPayMethod).HasMaxLength(30);
            entity.Property(e => e.HPaymentDate).HasMaxLength(50);
            entity.Property(e => e.HPlaceName).HasMaxLength(255);
            entity.Property(e => e.HPoint).HasMaxLength(50);
            entity.Property(e => e.PMethod)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.PayMethod)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.Username).HasMaxLength(537);
        });

        modelBuilder.Entity<ReceiptReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ReceiptReport");

            entity.Property(e => e.Address)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Barcode)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.BarcodeHide)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.BarcodeShow)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.BookDate).HasMaxLength(30);
            entity.Property(e => e.HAccount).HasMaxLength(255);
            entity.Property(e => e.HMerchantTradeNo).HasMaxLength(50);
            entity.Property(e => e.HeartCode)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceDate)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.ItemName)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.MainRemark)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(281);
            entity.Property(e => e.Nature)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.NoTaxPrice)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Num)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Numbers)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.PhoneCode)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.TaxID)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Unit)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.principle)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ReceiptReport_Group>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ReceiptReport_Group");

            entity.Property(e => e.Address)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Barcode)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.BarcodeHide)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.BarcodeShow)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Buyer)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.HAccount).HasMaxLength(255);
            entity.Property(e => e.HMerchantTradeNo).HasMaxLength(50);
            entity.Property(e => e.HeartCode)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceDate)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.ItemCode).HasMaxLength(100);
            entity.Property(e => e.ItemName)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.MainRemark)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Memo)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(281);
            entity.Property(e => e.Nature)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.NoTaxPrice)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Num)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Numbers)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.PhoneCode)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.ROW_).HasColumnName("ROW#");
            entity.Property(e => e.TaxID)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Unit)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.UnitPrice)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.principle)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RemainPoints>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RemainPoints");

            entity.Property(e => e.HArea).HasMaxLength(255);
            entity.Property(e => e.HPeriod).HasMaxLength(25);
            entity.Property(e => e.HUserName).HasMaxLength(255);
        });

        modelBuilder.Entity<_99_FoundationBooking>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("99.FoundationBooking");

            entity.Property(e => e.Attend)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.HBDate).HasMaxLength(30);
            entity.Property(e => e.HCourseName).HasMaxLength(100);
            entity.Property(e => e.HDCode).HasMaxLength(30);
            entity.Property(e => e.HPayMethod).HasMaxLength(30);
            entity.Property(e => e.HPlaceName).HasMaxLength(255);
            entity.Property(e => e.HPoint).HasMaxLength(50);
            entity.Property(e => e.HTradeNo).HasMaxLength(50);
            entity.Property(e => e.PMethod)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.PayMethod)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.Username).HasMaxLength(537);
        });

        modelBuilder.Entity<_99_HPUsingReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("99.HPUsingReport");

            entity.Property(e => e.HPeriod).HasMaxLength(25);
            entity.Property(e => e.HRecord).HasMaxLength(200);
            entity.Property(e => e.HRecrodDate).HasMaxLength(30);
            entity.Property(e => e.Husername).HasMaxLength(255);
            entity.Property(e => e.UsePoint)
                .HasMaxLength(31)
                .IsUnicode(false);
        });

        modelBuilder.Entity<_99_ReceiptReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("99.ReceiptReport");

            entity.Property(e => e.Address)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Barcode)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.BarcodeHide)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.BarcodeShow)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.BookDate).HasMaxLength(30);
            entity.Property(e => e.HAccount).HasMaxLength(255);
            entity.Property(e => e.HMerchantTradeNo).HasMaxLength(50);
            entity.Property(e => e.HeartCode)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceDate)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.ItemName)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.MainRemark)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(281);
            entity.Property(e => e.Nature)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.NoTaxPrice)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Num)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Numbers)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.PhoneCode)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.TaxID)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Unit)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.principle)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<psn_class_20220626_1_>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.a_flag).HasColumnType("text");
            entity.Property(e => e.annals).HasColumnType("text");
            entity.Property(e => e.annals_qty).HasColumnType("text");
            entity.Property(e => e.battery).HasColumnType("text");
            entity.Property(e => e.class_area).HasColumnType("text");
            entity.Property(e => e.class_id).HasColumnType("text");
            entity.Property(e => e.del).HasColumnType("text");
            entity.Property(e => e.duty).HasColumnType("text");
            entity.Property(e => e.f).HasColumnType("text");
            entity.Property(e => e.h_flag).HasColumnType("text");
            entity.Property(e => e.lamp).HasColumnType("text");
            entity.Property(e => e.m_flag).HasColumnType("text");
            entity.Property(e => e.mission).HasColumnType("text");
            entity.Property(e => e.name).HasColumnType("text");
            entity.Property(e => e.p_flag).HasColumnType("text");
            entity.Property(e => e.pack_memo).HasColumnType("text");
            entity.Property(e => e.pay_id).HasColumnType("text");
            entity.Property(e => e.period).HasColumnType("text");
            entity.Property(e => e.psn_id).HasColumnType("text");
            entity.Property(e => e.service).HasColumnType("text");
            entity.Property(e => e.state).HasColumnType("text");
            entity.Property(e => e.sustain).HasColumnType("text");
            entity.Property(e => e.txt_id).HasColumnType("text");
        });

        modelBuilder.Entity<sqlmapoutput>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__sqlmapou__3213E83F94E896EF");

            entity.Property(e => e.data).HasMaxLength(4000);
        });

        modelBuilder.Entity<ssqlinjection>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__ssqlinje__3213E83F084F3F72");

            entity.Property(e => e.data)
                .HasMaxLength(8000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<xx_Invoice>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("xx_Invoice");

            entity.Property(e => e.HPaymentDate).HasMaxLength(10);
            entity.Property(e => e.代收銀行別)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.備註欄).HasMaxLength(253);
            entity.Property(e => e.入帳日期)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.入帳銀行)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.列入捐款)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.區屬).HasMaxLength(255);
            entity.Property(e => e.地址)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.徵信抬頭)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.捐款人).HasMaxLength(255);
            entity.Property(e => e.捐款方式)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.捐款日期)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.捐款用途)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.捐款項目)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.收據開立)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.是否願意將捐款資料上傳國稅局)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.海外編號)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.縣市)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.臨時收據編號)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.行動電話).HasMaxLength(4000);
            entity.Property(e => e.身分證_統編_居留證)
                .HasMaxLength(30)
                .HasColumnName("身分證/統編/居留證");
            entity.Property(e => e.郵遞區號)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.鄉鎮市區)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.電子信箱).HasMaxLength(255);
            entity.Property(e => e.電話)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<工作表1_>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("工作表1$");

            entity.Property(e => e.BCSchedule).HasMaxLength(255);
            entity.Property(e => e.BECSchedule).HasMaxLength(255);
            entity.Property(e => e.CPosition).HasMaxLength(255);
            entity.Property(e => e.DPosition).HasMaxLength(255);
            entity.Property(e => e.HApplicant).HasMaxLength(255);
            entity.Property(e => e.HApplySystem).HasMaxLength(255);
            entity.Property(e => e.HApplyTime).HasMaxLength(255);
            entity.Property(e => e.HBCPoint).HasMaxLength(255);
            entity.Property(e => e.HBudgetTable).HasMaxLength(255);
            entity.Property(e => e.HContent).HasMaxLength(255);
            entity.Property(e => e.HContentTitle).HasMaxLength(255);
            entity.Property(e => e.HCourseName).HasMaxLength(255);
            entity.Property(e => e.HCourseNum).HasMaxLength(255);
            entity.Property(e => e.HCreate).HasMaxLength(255);
            entity.Property(e => e.HCreateDT).HasMaxLength(255);
            entity.Property(e => e.HDateRange).HasMaxLength(255);
            entity.Property(e => e.HDharmaID).HasMaxLength(255);
            entity.Property(e => e.HETime).HasMaxLength(255);
            entity.Property(e => e.HEnableSystem).HasMaxLength(255);
            entity.Property(e => e.HIRestriction).HasMaxLength(255);
            entity.Property(e => e.HImg).HasMaxLength(255);
            entity.Property(e => e.HModify).HasMaxLength(255);
            entity.Property(e => e.HModifyDT).HasMaxLength(255);
            entity.Property(e => e.HNCWDay).HasMaxLength(255);
            entity.Property(e => e.HNCWSheet).HasMaxLength(255);
            entity.Property(e => e.HNRequirement).HasMaxLength(255);
            entity.Property(e => e.HOPlace).HasMaxLength(255);
            entity.Property(e => e.HOSystem).HasMaxLength(255);
            entity.Property(e => e.HQuestionID).HasMaxLength(255);
            entity.Property(e => e.HRNContent).HasMaxLength(255);
            entity.Property(e => e.HRSystem).HasMaxLength(255);
            entity.Property(e => e.HRemark).HasMaxLength(255);
            entity.Property(e => e.HSCourseID).HasMaxLength(255);
            entity.Property(e => e.HSGList).HasMaxLength(255);
            entity.Property(e => e.HSTime).HasMaxLength(255);
            entity.Property(e => e.HVerifyNum).HasMaxLength(255);
            entity.Property(e => e.HVerifyTime).HasMaxLength(255);
            entity.Property(e => e.ICRecord).HasMaxLength(255);
            entity.Property(e => e.TPosition).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
