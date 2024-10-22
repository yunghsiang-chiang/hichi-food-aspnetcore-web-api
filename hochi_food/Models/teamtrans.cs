using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class teamtrans
{
    public string tt_id { get; set; } = null!;

    public string tt_taid { get; set; } = null!;

    public string tt_cdate { get; set; } = null!;

    public string tt_cname { get; set; } = null!;

    public string tt_udate { get; set; } = null!;

    public string tt_uname { get; set; } = null!;

    public int tt_status { get; set; }

    public string tt_content { get; set; } = null!;

    public string tt_reason { get; set; } = null!;
}
