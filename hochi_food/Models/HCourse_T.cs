using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HCourse_T
{
    public int HID { get; set; }

    public string? HEnableSystem { get; set; }

    public string? HApplySystem { get; set; }

    public string? HTemplateNum { get; set; }

    public string? HTemplateName { get; set; }

    public string? HType { get; set; }

    public string? HOSystem { get; set; }

    public string? HRSystem { get; set; }

    public int? HNLCourse { get; set; }

    public int? HNGuide { get; set; }

    public int? HNFull { get; set; }

    public string? HNRequirement { get; set; }

    public int? HLodging { get; set; }

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

    public string? HVRoleID { get; set; }

    public string? HARoleID { get; set; }

    public int? HBudget { get; set; }

    public int? HSerial { get; set; }

    public string? HBudgetType { get; set; }

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

    public int? HAxisYN { get; set; }

    public int? HAxisClass { get; set; }

    public int? HExamSubject { get; set; }

    public int HRollcallYN { get; set; }

    public int? HExamContentID { get; set; }

    /// <summary>
    /// 報名人數上限
    /// </summary>
    public int? HParticipantLimit { get; set; }

    public int? HBookByDateYN { get; set; }

    public string? HSave { get; set; }

    public int? HCCPeriodYN { get; set; }

    public int? HCCPeriodDItem { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
