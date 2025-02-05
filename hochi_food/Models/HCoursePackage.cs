using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HCoursePackage
{
    public int HID { get; set; }

    /// <summary>
    /// 套裝課程名稱
    /// </summary>
    public string? HCPkgName { get; set; }

    /// <summary>
    /// 套裝價格(金額)
    /// </summary>
    public int? HBCPrice { get; set; }

    /// <summary>
    /// 繳費帳戶(1=基金會、2=文化事業)
    /// </summary>
    public string? HCPMethod { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string? HRemark { get; set; }

    /// <summary>
    /// 內容標題
    /// </summary>
    public string? HContentTitle { get; set; }

    /// <summary>
    /// 內容
    /// </summary>
    public string? HContent { get; set; }

    /// <summary>
    /// 圖片
    /// </summary>
    public string? HImg { get; set; }

    /// <summary>
    /// 上課開始日期，沒使用
    /// </summary>
    public string? HCStartDate { get; set; }

    /// <summary>
    /// 報名截止日期
    /// </summary>
    public string? HCDeadline { get; set; }

    public int? HStatus { get; set; }

    public int? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public int? HModify { get; set; }

    public string? HModifyDT { get; set; }

    public int? HSave { get; set; }
}
