using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HMainTeam
{
    /// <summary>
    /// 流水號
    /// </summary>
    public int HID { get; set; }

    /// <summary>
    /// 大區代碼(簡稱+流水號)
    /// </summary>
    public string? HLAreaCode { get; set; }

    /// <summary>
    /// HLArea.HID
    /// </summary>
    public int? HLAreaID { get; set; }

    /// <summary>
    /// 定位日期
    /// </summary>
    public DateOnly? HDate { get; set; }

    /// <summary>
    /// 真光團代碼(大區-傳光玉成單位-真光團)
    /// </summary>
    public string? HMainTeamCode { get; set; }

    /// <summary>
    /// 區屬 HArea.HID
    /// </summary>
    public string? HAreaID { get; set; }

    /// <summary>
    /// 光團HID (格式: HID,1 或 HID,2；1=母光團(HMTeam)、2=子光團(HCTeam))
    /// </summary>
    public string? HTeamID { get; set; }

    /// <summary>
    /// 導師 (HMember.HID)
    /// </summary>
    public int? HMentorID { get; set; }

    /// <summary>
    /// 團長 (HMember.HID)
    /// </summary>
    public int? HTeamLeaderID { get; set; }

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
