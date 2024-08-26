using System;
using System.Collections.Generic;

namespace hochi_food.Models;

/// <summary>
/// 歷史出勤資訊
/// </summary>
public partial class h_attendance_infor
{
    /// <summary>
    /// 同修姓名
    /// </summary>
    public string user_name { get; set; } = null!;

    /// <summary>
    /// 出勤狀態 跟網頁上按鈕狀態有關  隨者按鈕 擴增而增加
    /// </summary>
    public string attendance_state { get; set; } = null!;

    /// <summary>
    /// 狀態起始時間  網頁按下按鈕的時間
    /// </summary>
    public DateTime create_time { get; set; }
}
