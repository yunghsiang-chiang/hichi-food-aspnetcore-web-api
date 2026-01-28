using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HPracticeRecord
{
    /// <summary>
    /// 流水號
    /// </summary>
    public int HID { get; set; }

    /// <summary>
    /// 築基原因ID (HPracticeRecordReason.HID)
    /// </summary>
    public int HPracticeRecordReasonID { get; set; }

    /// <summary>
    /// 法築基紀錄HID 
    /// </summary>
    public int HDharmaRecordID { get; set; }

    /// <summary>
    /// 學員HID
    /// </summary>
    public int HMemberID { get; set; }

    /// <summary>
    /// 傳光日期
    /// </summary>
    public DateOnly? HPracticeDate { get; set; }

    /// <summary>
    /// 傳光人數/次數
    /// </summary>
    public int? HPracticeNum { get; set; }

    /// <summary>
    /// 平均傳光時間
    /// </summary>
    public string? HAvgTime { get; set; }

    /// <summary>
    /// 狀態
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
