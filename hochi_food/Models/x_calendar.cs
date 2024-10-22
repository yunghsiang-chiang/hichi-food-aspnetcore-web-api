using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class x_calendar
{
    public string c_id { get; set; } = null!;

    public string c_type { get; set; } = null!;

    public string c_area { get; set; } = null!;

    public string c_title { get; set; } = null!;

    public string c_begdate { get; set; } = null!;

    public string c_enddate { get; set; } = null!;

    public string c_content { get; set; } = null!;

    public string c_file { get; set; } = null!;

    public string c_filedesc { get; set; } = null!;

    public string c_cdate { get; set; } = null!;

    public string c_cname { get; set; } = null!;

    public string c_udate { get; set; } = null!;

    public string c_uname { get; set; } = null!;

    public string? c_place { get; set; }
}
