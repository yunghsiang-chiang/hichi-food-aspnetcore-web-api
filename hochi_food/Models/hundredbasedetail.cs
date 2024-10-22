using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class hundredbasedetail
{
    public string hbd_id { get; set; } = null!;

    public string hbd_hbid { get; set; } = null!;

    public string hbd_hbqid { get; set; } = null!;

    public int hbd_no { get; set; }

    public string hbd_recorddate { get; set; } = null!;

    public sbyte hbd_status { get; set; }

    public string hbd_cdate { get; set; } = null!;

    public string hbd_cname { get; set; } = null!;

    public string hbd_udate { get; set; } = null!;

    public string hbd_uname { get; set; } = null!;

    public string? hbd_content { get; set; }
}
