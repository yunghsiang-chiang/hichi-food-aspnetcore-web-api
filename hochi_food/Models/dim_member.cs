using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class dim_member
{
    public int contact_hid { get; set; }

    public string? full_name { get; set; }

    public string? mobile_norm { get; set; }

    public string? line_user_id { get; set; }

    public string? birth_text { get; set; }

    public int? member_status { get; set; }

    public int? larea_id { get; set; }

    public string? larea_name { get; set; }

    public int? area_id { get; set; }

    public string? area_name { get; set; }

    public int? team_type { get; set; }

    public int? team_node_id { get; set; }
}
