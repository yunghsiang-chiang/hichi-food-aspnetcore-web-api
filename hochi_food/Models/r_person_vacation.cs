using System;
using System.Collections.Generic;

namespace hochi_food.Models;

/// <summary>
/// 休假即時表
/// </summary>
public partial class r_person_vacation
{
    /// <summary>
    /// ID
    /// </summary>
    public string person_id { get; set; } = null!;

    /// <summary>
    /// 姓名
    /// </summary>
    public string person_name { get; set; } = null!;

    /// <summary>
    /// 到職日
    /// </summary>
    public DateTime start_work { get; set; }

    /// <summary>
    /// 特休時數
    /// </summary>
    public float special_vacation_hours { get; set; }

    /// <summary>
    /// 事假
    /// </summary>
    public float personal_leave_hours { get; set; }

    /// <summary>
    /// 補休
    /// </summary>
    public float compensatory_leave_hours { get; set; }
}
