using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class donationrecord
{
    public string d_id { get; set; } = null!;

    public string? d_datetime { get; set; }

    public int? d_unit { get; set; }

    public string? d_wish { get; set; }

    public string? d_actual { get; set; }
}
