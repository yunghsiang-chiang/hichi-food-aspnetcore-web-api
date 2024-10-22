using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class x_mailreply
{
    public string mr_id { get; set; } = null!;

    public string mr_mfid { get; set; } = null!;

    public string mr_cname { get; set; } = null!;

    public string mr_cdate { get; set; } = null!;

    public int mr_status { get; set; }

    public string mr_content { get; set; } = null!;

    public string mr_uid { get; set; } = null!;
}
