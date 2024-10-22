using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class x_epaperlog
{
    public long el_id { get; set; }

    public int el_type { get; set; }

    public string el_eid { get; set; } = null!;

    public string el_email { get; set; } = null!;

    public int el_status { get; set; }

    public string? el_cdate { get; set; }

    public string? el_desc { get; set; }
}
