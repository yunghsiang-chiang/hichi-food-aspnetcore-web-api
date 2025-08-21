using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HSCTMsg_Log
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
    /// 留言Log類型(0:刪除/1:編輯/2:隱藏/3:取消隱藏)
    /// </summary>
    public string? HLogType { get; set; }

    /// <summary>
    /// 原因
    /// </summary>
    public string? HReason { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
