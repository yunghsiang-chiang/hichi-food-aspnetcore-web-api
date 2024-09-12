using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class c_fellow_hochi_learners
{
    /// <summary>
    /// id
    /// </summary>
    public string person_id { get; set; } = null!;

    /// <summary>
    /// 姓名
    /// </summary>
    public string? person_name { get; set; }

    /// <summary>
    /// 密碼
    /// </summary>
    public string? person_password { get; set; }

    /// <summary>
    /// 區屬
    /// </summary>
    public string? person_area { get; set; }

    /// <summary>
    /// 辦公位置
    /// </summary>
    public string? person_subinv { get; set; }

    /// <summary>
    /// google calendar的url
    /// </summary>
    public string? person_calendar { get; set; }

    /// <summary>
    /// 人員類型
    /// </summary>
    public string? person_type { get; set; }
}
