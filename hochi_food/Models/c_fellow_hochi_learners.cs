using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class c_fellow_hochi_learners
{
    public string person_id { get; set; } = null!;

    public string? person_name { get; set; }

    public string? person_password { get; set; }

    public string? person_area { get; set; }

    public string? person_subinv { get; set; }

    public string? person_calendar { get; set; }
}
