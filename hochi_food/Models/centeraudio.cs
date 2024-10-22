using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class centeraudio
{
    public string ca_id { get; set; } = null!;

    public int ca_category { get; set; }

    public string ca_title { get; set; } = null!;

    public string? ca_desc { get; set; }

    public int ca_status { get; set; }

    public string ca_cdate { get; set; } = null!;

    public string ca_cname { get; set; } = null!;

    public string ca_udate { get; set; } = null!;

    public string ca_uname { get; set; } = null!;

    public string ca_link { get; set; } = null!;

    public int ca_type { get; set; }
}
