using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class newsmsg
{
    public string nm_id { get; set; } = null!;

    public string? nm_content { get; set; }

    public string? nm_settime { get; set; }

    public string? nm_cuser { get; set; }
}
