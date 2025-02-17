using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class People
{
    public int id { get; set; }

    public string full_name { get; set; } = null!;

    public int hierarchy_id { get; set; }

    public string? role_description { get; set; }

    public virtual HierarchyStructure hierarchy { get; set; } = null!;
}
