using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class avzonereply
{
    public string ar_id { get; set; } = null!;

    public string ar_avid { get; set; } = null!;

    public string ar_uid { get; set; } = null!;

    public string ar_content { get; set; } = null!;

    public int ar_status { get; set; }

    public string ar_cdate { get; set; } = null!;

    public string ar_cname { get; set; } = null!;

    public string ar_udate { get; set; } = null!;

    public string ar_uname { get; set; } = null!;
}
