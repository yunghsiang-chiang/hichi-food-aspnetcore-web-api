using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class participants
{
    public int id { get; set; }

    public string gender { get; set; } = null!;

    public string age_range { get; set; } = null!;

    public DateTime? created_at { get; set; }

    public virtual ICollection<color_preferences> color_preferences { get; set; } = new List<color_preferences>();

    public virtual ICollection<feedback> feedback { get; set; } = new List<feedback>();

    public virtual ICollection<social_check_in> social_check_in { get; set; } = new List<social_check_in>();
}
