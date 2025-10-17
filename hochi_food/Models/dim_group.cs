using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class dim_group
{
    public string? node_type { get; set; }

    public int? node_id { get; set; }

    public string? parent_type { get; set; }

    public int? parent_id { get; set; }

    public string? node_name { get; set; }

    public int level_ord { get; set; }
}
