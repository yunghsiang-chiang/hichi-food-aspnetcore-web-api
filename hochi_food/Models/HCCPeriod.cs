using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HCCPeriod
{
    public int HID { get; set; }

    /// <summary>
    /// 信用卡定期定額授權申請單號
    /// </summary>
    public string? HCCPeriodCode { get; set; }

    /// <summary>
    /// 學員HID
    /// </summary>
    public int? HMemberID { get; set; }

    public int? HCTemplateID { get; set; }

    public int? HCourseID { get; set; }

    public string? HCourseName { get; set; }

    public string? HDateRange { get; set; }

    public string? HDUserName { get; set; }

    public string? HDEmail { get; set; }

    public string? HDPostal { get; set; }

    public string? HDAddress { get; set; }

    public string? HDTel { get; set; }

    public string? HDPhone { get; set; }

    public string? HDBirth { get; set; }

    public string? HDPersonID { get; set; }

    public int? HDReceiptSType { get; set; }

    public int? HNumbers { get; set; }

    public string? HDonor { get; set; }

    public string? HCardHolder { get; set; }

    public string? HCHPersonID { get; set; }

    public string? HCardNum { get; set; }

    public string? HCardBank { get; set; }

    public int? HCardType { get; set; }

    public string? HCVCCode { get; set; }

    public string? HCardValidDate { get; set; }

    public int? HDTotal { get; set; }

    public int? HDCCPTimes { get; set; }

    public int? HDCCPAmount { get; set; }

    public string? HDCCPSDate { get; set; }

    public string? HDCCPEDate { get; set; }

    public string? HCHPhone { get; set; }

    public int? HDAPublic { get; set; }

    public string? HRemark { get; set; }

    public int? HVerifyStatus { get; set; }

    public string? HVerifyDT { get; set; }

    /// <summary>
    /// 是否轉成授權訂單(1:未成立、2:已成立)
    /// </summary>
    public int? HOrderStatus { get; set; }

    /// <summary>
    /// 是否為紙本
    /// </summary>
    public int? HPaperYN { get; set; }

    public int? HCCRegularID { get; set; }

    /// <summary>
    /// 捐款用途
    /// </summary>
    public string? HDPurpose { get; set; }

    /// <summary>
    /// 捐款項目
    /// </summary>
    public string? HDItem { get; set; }

    public string? HOriCCPOrderCode { get; set; }

    public int? HPayOption { get; set; }

    public int? HPartialPayTimes { get; set; }

    public int? HPartialPayAmount { get; set; }

    public string? HOrderGroup { get; set; }

    public int? HOpenEdit { get; set; }

    public string? HNewDCCPSDate { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
