using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class bloodconnection
{
    public string bc_id { get; set; } = null!;

    public string bc_cid { get; set; } = null!;

    public string bc_uid { get; set; } = null!;

    public int bc_cno { get; set; }

    public string bc_cuid { get; set; } = null!;

    public string? bc_time { get; set; }

    public sbyte bc_status { get; set; }

    public string bc_cdate { get; set; } = null!;

    public string bc_cname { get; set; } = null!;

    public string bc_udate { get; set; } = null!;

    public string bc_uname { get; set; } = null!;

    public sbyte bc_times { get; set; }

    public string bc_name { get; set; } = null!;
}
