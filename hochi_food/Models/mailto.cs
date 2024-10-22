using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class mailto
{
    public string mt_id { get; set; } = null!;

    public string mt_mfid { get; set; } = null!;

    public string mt_uid { get; set; } = null!;

    public string mt_from { get; set; } = null!;

    public string mt_subject { get; set; } = null!;

    public bool? mt_status { get; set; }

    public string mt_cdate { get; set; } = null!;
}
