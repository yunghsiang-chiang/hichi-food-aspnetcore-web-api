using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HLNGroupStandard
{
    public int HID { get; set; }

    public string? HLNGroupCode { get; set; }

    /// <summary>
    /// 學習族群名稱
    /// </summary>
    public string? HLNGroupName { get; set; }

    /// <summary>
    /// 【回應/分享數量】第一小項:專欄回應次數
    /// </summary>
    public int? H1010 { get; set; }

    /// <summary>
    /// 【回應/分享數量】第二小項:成長紀錄建立次數
    /// </summary>
    public int? H1011 { get; set; }

    /// <summary>
    /// 【時間投入程度】第一小項:瀏覽教材次數
    /// </summary>
    public int? H2010 { get; set; }

    /// <summary>
    /// 【時間投入程度】第二小項:課程護持服務時數統計
    /// </summary>
    public int? H2011 { get; set; }

    /// <summary>
    /// 【學習異常狀況】第一小項:缺席次數
    /// </summary>
    public int? H3010 { get; set; }

    /// <summary>
    /// 【學員異常狀況】第二小項:作業未繳交次數
    /// </summary>
    public int? H3011 { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
