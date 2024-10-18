using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class seasonings
{
    public int seasoning_id { get; set; }

    public int recipe_id { get; set; }

    public string seasoning_name { get; set; } = null!;

    public decimal amount { get; set; }

    public string? unit { get; set; }

    public virtual recipe recipe { get; set; } = null!;
}
