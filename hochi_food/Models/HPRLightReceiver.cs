using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HPRLightReceiver
{
    /// <summary>
    /// 流水號
    /// </summary>
    public int HID { get; set; }

    /// <summary>
    /// 築基紀錄ID
    /// </summary>
    public int HPracticeRecordID { get; set; }

    /// <summary>
    /// 接光人姓名
    /// </summary>
    public string? HReceiverName { get; set; }

    /// <summary>
    /// 接光人光系
    /// </summary>
    public string? HReceiverLight { get; set; }

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
