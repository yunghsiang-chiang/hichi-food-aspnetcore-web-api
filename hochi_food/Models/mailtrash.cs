using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class mailtrash
{
    public string mtr_id { get; set; } = null!;

    public bool? mtr_type { get; set; }

    public string mtr_uid { get; set; } = null!;

    public string mtr_mfid { get; set; } = null!;

    public string mtr_mtid { get; set; } = null!;

    public string mtr_from { get; set; } = null!;

    public string mtr_subject { get; set; } = null!;

    public string mtr_cdate { get; set; } = null!;

    public string mtr_ddate { get; set; } = null!;
}
