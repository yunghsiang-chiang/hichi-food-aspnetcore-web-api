using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HCourse
{
    public int HID { get; set; }

    public string? HEnableSystem { get; set; }

    public string? HApplySystem { get; set; }

    public int? HCTemplateID { get; set; }

    public string? HCBatchNum { get; set; }

    public string? HCourseNum { get; set; }

    public string? HCourseName { get; set; }

    public string? HTeacherName { get; set; }

    public string? HOCPlace { get; set; }

    public string? HOPlace { get; set; }

    public string? HDateRange { get; set; }

    public string? HSTime { get; set; }

    public string? HETime { get; set; }

    public string? HType { get; set; }

    public string? HOSystem { get; set; }

    public string? HRSystem { get; set; }

    public int? HNLCourse { get; set; }

    public int? HNGuide { get; set; }

    public int? HNFull { get; set; }

    public string? HNRequirement { get; set; }

    public string? HTeam { get; set; }

    public int? HNCWSheet { get; set; }

    public int? HNCWDay { get; set; }

    public string? HQuestionID { get; set; }

    public string? HPMethod { get; set; }

    public string? HBCPoint { get; set; }

    public int? HSGList { get; set; }

    public string? HIRestriction { get; set; }

    public string? HRemark { get; set; }

    public string? HContentTitle { get; set; }

    public string? HContent { get; set; }

    public string? HRNContent { get; set; }

    public string? HVerifyNum { get; set; }

    public string? HApplicant { get; set; }

    public string? HApplyTime { get; set; }

    public string? HVerifyTime { get; set; }

    public string? HDharmaID { get; set; }

    public int? HVerifyStatus { get; set; }

    public string? HImg { get; set; }

    public string? BCSchedule { get; set; }

    public string? BECSchedule { get; set; }

    public string? ICRecord { get; set; }

    public string? DPosition { get; set; }

    public string? CPosition { get; set; }

    public string? TPosition { get; set; }

    public bool? HDContinous { get; set; }

    public int? HBudget { get; set; }

    public string? HBudgetTable { get; set; }

    public string? HSCourseID { get; set; }

    public int? HLodging { get; set; }

    public int? HShowZoom { get; set; }

    public string? HCourseLink { get; set; }

    public string? HSATCourseLink { get; set; }

    public string? HSUNCourseLink { get; set; }

    public string? HCourseLinkRelay { get; set; }

    public string? HCourseLinkTask { get; set; }

    public string? HSave { get; set; }

    /// <summary>
    /// 講師教材HID(關聯dbi.HTeacherMaterial)
    /// </summary>
    public string? HTMaterialID { get; set; }

    /// <summary>
    /// 換課、修改上課地點或參班身分的最後修改時間點(開課前幾天以前)
    /// </summary>
    public string? HCDeadline { get; set; }

    /// <summary>
    /// 課程報名截止日天數
    /// </summary>
    public int? HCDeadlineDay { get; set; }

    public int? HSerial { get; set; }

    public string? HBudgetType { get; set; }

    public int? HCourseType { get; set; }

    /// <summary>
    /// 是否為軸線課程
    /// </summary>
    public int? HAxisYN { get; set; }

    /// <summary>
    /// 軸線類別
    /// </summary>
    public int? HAxisClass { get; set; }

    /// <summary>
    /// 檢覈科目名稱
    /// </summary>
    public int? HExamSubject { get; set; }

    /// <summary>
    /// 成績計算方式：1-加權平均;2-單一成績
    /// </summary>
    public int? HGradeCalculation { get; set; }

    /// <summary>
    /// 考卷
    /// </summary>
    public string? HExamPaperID { get; set; }

    /// <summary>
    /// 督導
    /// </summary>
    public string? HSupervise { get; set; }

    /// <summary>
    /// 出席率標準
    /// </summary>
    public int? HAttRateStandard { get; set; }

    /// <summary>
    /// 檢覈成績通過標準
    /// </summary>
    public int? HExamPassStandard { get; set; }

    public int HRollcallYN { get; set; }

    public int? HIndexShow { get; set; }

    public int? HIndexSort { get; set; }

    public int? HExamContentID { get; set; }

    /// <summary>
    /// 報名人數上限
    /// </summary>
    public int? HParticipantLimit { get; set; }

    /// <summary>
    /// 講師類別(1:識透講師/2:玉成講師/3:教練/4:傳承師)
    /// </summary>
    public int? HTeacherClass { get; set; }

    /// <summary>
    /// 講師層級分類(1:見習/2:初任/3:正式)
    /// </summary>
    public int? HTearcherLV { get; set; }

    public int? HBookByDateYN { get; set; }

    public int? HCCPeriodYN { get; set; }

    public int? HCCPeriodDItem { get; set; }

    public int HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
