using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class h_attendance_day
{
    /// <summary>
    /// 同修 ID
    /// </summary>
    public string user_id { get; set; } = null!;

    /// <summary>
    /// 同修姓名
    /// </summary>
    public string user_name { get; set; } = null!;

    /// <summary>
    /// 出勤日
    /// </summary>
    public DateTime attendance_day { get; set; }

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

    /// <summary>
    /// 晨下煉完紫光系
    /// </summary>
    public int morning_light_down_after_purple_light { get; set; }
}
