using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class social_check_in
{
    public int id { get; set; }

    public int participant_id { get; set; }

    public string is_check_in { get; set; } = null!;

    public string? platform { get; set; }

    public DateTime? created_at { get; set; }

    public virtual participants participant { get; set; } = null!;
}
