using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class person_identity
{
    public string person_key { get; set; } = null!;

    public int src_id { get; set; }

    public string src_table { get; set; } = null!;

    public string? full_name { get; set; }

    public string? full_name_norm { get; set; }

    public string? mobile_norm { get; set; }

    public string? line_user_id { get; set; }

    public DateOnly? birth_date { get; set; }

    public string? dupe_key { get; set; }

    public DateTime? created_at { get; set; }

    public DateTime? updated_at { get; set; }
}
