using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class x_dutylog
{
    public long dl_id { get; set; }

    public string dl_cid { get; set; } = null!;

    public string dl_date { get; set; } = null!;

    public string dl_aid { get; set; } = null!;

    public string dl_aname { get; set; } = null!;

    public string dl_uid { get; set; } = null!;

    public int dl_status { get; set; }

    public string dl_uname { get; set; } = null!;
}
