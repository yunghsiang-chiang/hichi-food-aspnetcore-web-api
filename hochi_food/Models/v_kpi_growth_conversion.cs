using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class v_kpi_growth_conversion
{
    public string window_tag { get; set; } = null!;

    public int? new_in { get; set; }

    public int? first_attend { get; set; }

    public decimal? first_attend_rate { get; set; }
}
