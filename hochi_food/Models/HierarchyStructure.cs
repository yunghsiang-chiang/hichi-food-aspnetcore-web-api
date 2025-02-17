using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HierarchyStructure
{
    public int id { get; set; }

    public string name { get; set; } = null!;

    public int? parent_id { get; set; }

    public int level { get; set; }

    public string? category { get; set; }

    public string? supervision_system { get; set; }

    public string? region_structure { get; set; }

    public string? description { get; set; }

    public virtual ICollection<HierarchyStructure> Inverseparent { get; set; } = new List<HierarchyStructure>();

    public virtual ICollection<People> People { get; set; } = new List<People>();

    public virtual HierarchyStructure? parent { get; set; }
}
