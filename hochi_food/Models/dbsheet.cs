using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class dbsheet
{
    public string DONATE_KIND { get; set; } = null!;

    public string this_year { get; set; } = null!;

    public int? donate { get; set; }

    public int? expense { get; set; }

    public int? balance { get; set; }

    public int? A_balance { get; set; }

    public string? memo { get; set; }

    public int? balance0 { get; set; }

    public int? status { get; set; }
}
