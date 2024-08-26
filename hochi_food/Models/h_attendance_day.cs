using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class h_attendance_day
{
    /// <summary>
    /// 同修姓名
    /// </summary>
    public string user_name { get; set; } = null!;

    /// <summary>
    /// 出勤日
    /// </summary>
    public DateTime attendance_day { get; set; }

    /// <summary>
    /// 出勤狀態
    /// </summary>
    public string attendance_state { get; set; } = null!;

    /// <summary>
    /// 連續小時
    /// </summary>
    public float consecutive_hours { get; set; }

    /// <summary>
    /// 晨光上
    /// </summary>
    public int morning_light_up { get; set; }

    /// <summary>
    /// 晨光下
    /// </summary>
    public int morning_light_down { get; set; }

    /// <summary>
    /// 晨會
    /// </summary>
    public int morning_meeting { get; set; }
}
