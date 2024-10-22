using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class edu_psn_class
{
    public string u_period { get; set; } = null!;

    public string u_name { get; set; } = null!;

    public string? area_name { get; set; }

    public string? sex_name { get; set; }

    public int? age { get; set; }
}
