using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class v_kpi_coverage90_area
{
    public int? larea_id { get; set; }

    public string? larea_name { get; set; }

    public int? area_id { get; set; }

    public string? area_name { get; set; }

    public int? roster { get; set; }

    public int? active90 { get; set; }

    public decimal? coverage90 { get; set; }
}
