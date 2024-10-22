using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class growthrecordsummary
{
    public string grs_id { get; set; } = null!;

    public string grs_uid { get; set; } = null!;

    public int grs_type { get; set; }

    public string grs_content { get; set; } = null!;

    public string grs_cdate { get; set; } = null!;

    public string grs_cname { get; set; } = null!;

    public string grs_udate { get; set; } = null!;

    public string grs_uname { get; set; } = null!;

    public string grs_suid { get; set; } = null!;

    public int grs_status { get; set; }

    public string grs_recorddate { get; set; } = null!;
}
