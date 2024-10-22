using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class avzone
{
    public string av_id { get; set; } = null!;

    public string av_pdate { get; set; } = null!;

    public int av_type { get; set; }

    public string av_title { get; set; } = null!;

    public string? av_desc { get; set; }

    public int av_status { get; set; }

    public string av_cdate { get; set; } = null!;

    public string av_cname { get; set; } = null!;

    public string av_udate { get; set; } = null!;

    public string av_uname { get; set; } = null!;

    public string av_link { get; set; } = null!;

    public string av_begdate { get; set; } = null!;

    public string av_enddate { get; set; } = null!;

    public int? av_imp { get; set; }

    public string? av_len { get; set; }

    public int av_impuser { get; set; }
}
