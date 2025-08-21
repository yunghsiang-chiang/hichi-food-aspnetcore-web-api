using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HSCGRMsgResponse
{
    public int HID { get; set; }

    public int? HSCGRMsgID { get; set; }

    /// <summary>
    /// 學員HID(HMember.HID)
    /// </summary>
    public int? HMemberID { get; set; }

    /// <summary>
    /// 回應留言
    /// </summary>
    public string? HGRMRContent { get; set; }

    /// <summary>
    /// 上傳檔案
    /// </summary>
    public string? HGRMRFile1 { get; set; }

    /// <summary>
    /// MP3檔案
    /// </summary>
    public string? HGRMRThumbsUp { get; set; }

    public string? HGRMRHappy { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
