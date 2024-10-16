using System;
using System.Collections.Generic;

namespace hochi_food.Models;

/// <summary>
/// Table to store information about each chef
/// </summary>
public partial class chef
{
    /// <summary>
    /// Unique identifier for each chef
    /// </summary>
    public int chef_id { get; set; }

    /// <summary>
    /// Name of the chef (e.g., 王金對)
    /// </summary>
    public string name { get; set; } = null!;

    /// <summary>
    /// Region or location associated with the chef (optional)
    /// </summary>
    public string? region { get; set; }

    public virtual ICollection<recipe> recipe { get; set; } = new List<recipe>();
}
