using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HSCTMsgResponse
{
    public int HID { get; set; }

    /// <summary>
    /// 回應主題HID(HSCTMsg.HID)
    /// </summary>
    public int? HSCTMsgID { get; set; }

    /// <summary>
    /// 學員HID(HMember.HID)
    /// </summary>
    public int? HMemberID { get; set; }

    /// <summary>
    /// 回應留言
    /// </summary>
    public string? HMsgResponse { get; set; }

    public string? HVoice { get; set; }

    /// <summary>
    /// 狀態(0:刪掉/1:正常/2:隱藏)
    /// </summary>
    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
