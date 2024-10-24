using System;
using System.Collections.Generic;

namespace hochi_food.Models;

/// <summary>
/// Table to store step-by-step instructions for each recipe
/// </summary>
public partial class recipe_steps
{
    /// <summary>
    /// Unique identifier for each recipe step
    /// </summary>
    public int step_id { get; set; }

    public int recipe_id { get; set; }

    /// <summary>
    /// The order of the step in the recipe
    /// </summary>
    public int step_number { get; set; }

    /// <summary>
    /// Detailed description of the step
    /// </summary>
    public string description { get; set; } = null!;

    /// <summary>
    /// URL for an image illustrating the step (if available)
    /// </summary>
    public string? image_url { get; set; }
}
