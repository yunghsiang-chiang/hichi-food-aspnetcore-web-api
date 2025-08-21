using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HSCGRMsg_Mood
{
    public int HID { get; set; }

    /// <summary>
    /// 成長紀錄留言HID(HSCGRMsg.HID)
    /// </summary>
    public int? HSCGRMsgID { get; set; }

    /// <summary>
    /// 學員HID(HMember.HID)
    /// </summary>
    public int? HMemberID { get; set; }

    /// <summary>
    /// 心情狀態(1:讚/2:愛心/3:笑臉)
    /// </summary>
    public int? HType { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
