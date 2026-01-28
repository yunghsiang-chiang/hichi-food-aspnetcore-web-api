using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HMainTeamMembers
{
    /// <summary>
    /// 流水號
    /// </summary>
    public int HID { get; set; }

    /// <summary>
    /// 真光團流水號(HMainTeam.HID)
    /// </summary>
    public int? HMainTeamID { get; set; }

    /// <summary>
    /// 學員HID (HMember.HID)
    /// </summary>
    public int? HMemberID { get; set; }

    /// <summary>
    /// 學習族群(1=Main、2=PartTime、3=NewFriend)
    /// </summary>
    public int? HLearningGroup { get; set; }

    /// <summary>
    /// 加入年度
    /// </summary>
    public string? HJoinYear { get; set; }

    /// <summary>
    /// 狀態 (1=啟用、0=停用)
    /// </summary>
    public int? HStatus { get; set; }

    /// <summary>
    /// 建立者
    /// </summary>
    public string? HCreate { get; set; }

    /// <summary>
    /// 建立日期
    /// </summary>
    public DateTime? HCreateDT { get; set; }

    /// <summary>
    /// 修改者
    /// </summary>
    public string? HModify { get; set; }

    /// <summary>
    /// 修改日期
    /// </summary>
    public DateTime? HModifyDT { get; set; }
}
