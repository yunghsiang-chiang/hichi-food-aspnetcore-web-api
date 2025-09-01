using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HFeelingsJournalsMsg
{
    /// <summary>
    /// 流水號
    /// </summary>
    public int HID { get; set; }

    /// <summary>
    /// 心情日誌HID(HFeelingsJournals.HID)
    /// </summary>
    public int? HFeelingsJournalsID { get; set; }

    /// <summary>
    /// 學員HID(HMember.HID)
    /// </summary>
    public int? HMemberID { get; set; }

    /// <summary>
    /// 留言內容
    /// </summary>
    public string? HContent { get; set; }

    /// <summary>
    /// 狀態(0:刪掉/1:顯示)
    /// </summary>
    public int? HStatus { get; set; }

    /// <summary>
    /// 建立者
    /// </summary>
    public string? HCreate { get; set; }

    /// <summary>
    /// 建立日期
    /// </summary>
    public string? HCreateDT { get; set; }

    /// <summary>
    /// 修改者
    /// </summary>
    public string? HModify { get; set; }

    /// <summary>
    /// 修改日期
    /// </summary>
    public string? HModifyDT { get; set; }
}
