using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class teamoperationmember
{
    public string tom_id { get; set; } = null!;

    public string tom_toid { get; set; } = null!;

    /// <summary>
    /// 體系序號
    /// </summary>
    public int tom_no { get; set; }

    public string? tom_uid { get; set; }

    public string tom_usrname { get; set; } = null!;

    public string? tom_system { get; set; }

    public string tom_cdate { get; set; } = null!;

    public string tom_cname { get; set; } = null!;

    public string tom_udate { get; set; } = null!;

    public string tom_uname { get; set; } = null!;
}
