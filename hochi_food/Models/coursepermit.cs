using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class coursepermit
{
    public string cp_id { get; set; } = null!;

    public string cp_cid { get; set; } = null!;

    public string cp_uid { get; set; } = null!;

    public string cp_cdate { get; set; } = null!;

    public string cp_cname { get; set; } = null!;

    public string cp_udate { get; set; } = null!;

    public string cp_uname { get; set; } = null!;

    public string cp_begdate { get; set; } = null!;

    public string cp_enddate { get; set; } = null!;
}
