using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class teamapply
{
    public string ta_id { get; set; } = null!;

    public string ta_aid { get; set; } = null!;

    public string ta_name { get; set; } = null!;

    public int ta_status { get; set; }

    public string ta_cdate { get; set; } = null!;

    public string ta_cname { get; set; } = null!;

    public string ta_udate { get; set; } = null!;

    public string ta_uname { get; set; } = null!;

    public string ta_note { get; set; } = null!;

    public int? ta_progress { get; set; }

    public string? ta_progressother { get; set; }

    public string? ta_superior { get; set; }
}
