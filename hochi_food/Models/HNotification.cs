using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HNotification
{
    public int HID { get; set; }

    /// <summary>
    /// 接收通知的學員(HMember.HID)
    /// </summary>
    public int? HMemberID { get; set; }

    /// <summary>
    /// 觸發通知的學員(HMember.HID)
    /// </summary>
    public int? HActorMemberID { get; set; }

    /// <summary>
    /// 通知類型(1:回應、2:心情(讚)、3:心情(愛心)、4:心情(微笑)、5:分享、6:提問)
    /// </summary>
    public int? HNotifyType { get; set; }

    /// <summary>
    /// 回應/心情/提問/分享關連的資料表HID
    /// </summary>
    public int? HTargetID { get; set; }

    /// <summary>
    /// 資料表名稱
    /// </summary>
    public string? HTableName { get; set; }

    /// <summary>
    /// 是否已讀(0:未讀、1已讀)
    /// </summary>
    public int? HReadStatus { get; set; }

    /// <summary>
    /// 啟用狀態(0:停用、1:啟用)
    /// </summary>
    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
