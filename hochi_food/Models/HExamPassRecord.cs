using System;
using System.Collections.Generic;

namespace hochi_food.Models;

/// <summary>
/// 考試通過狀態紀錄表
/// </summary>
public partial class HExamPassRecord
{
    public int HID { get; set; }

    public int HExamGroupID { get; set; }

    public int HExamSubjectID { get; set; }

    public int HMemberID { get; set; }

    public DateOnly? HPassedDate { get; set; }

    public int? HFinalResult { get; set; }

    public int HPassStatus { get; set; }

    public string? HCertificateNo { get; set; }

    public bool HIsImported { get; set; }

    public string? HRemarks { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public DateTime? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public DateTime? HModifyDT { get; set; }
}
