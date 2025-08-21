using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HSCGRecord_Share
{
    public int HID { get; set; }

    /// <summary>
    /// 主題HID(HSCTopic.HID)
    /// </summary>
    public int? HSCGRecordID { get; set; }

    /// <summary>
    /// 學員HID(HMember.HID)
    /// </summary>
    public int? HMemberID { get; set; }

    /// <summary>
    /// 瀏覽次數
    /// </summary>
    public int? HTimes { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
