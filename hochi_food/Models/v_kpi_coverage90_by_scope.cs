using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class v_kpi_coverage90_by_scope
{
    public int? larea_id { get; set; }

    public int? area_id { get; set; }

    public int? team_type { get; set; }

    public int? team_node_id { get; set; }

    public int? Roster { get; set; }

    public int? Active90 { get; set; }

    public decimal? Coverage90 { get; set; }
}
