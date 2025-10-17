using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class v_crm_people_search
{
    public string source_type { get; set; } = null!;

    public int? newfriend_id { get; set; }

    public int? edu_hid { get; set; }

    public string? full_name { get; set; }

    public string? mobile_norm { get; set; }

    public string? City { get; set; }

    public string? District { get; set; }

    public string? Address { get; set; }
}
