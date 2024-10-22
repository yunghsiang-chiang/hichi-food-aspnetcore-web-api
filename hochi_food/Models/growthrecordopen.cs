using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class growthrecordopen
{
    public string gro_id { get; set; } = null!;

    public string gro_grid { get; set; } = null!;

    public string gro_uid { get; set; } = null!;

    public sbyte gro_status { get; set; }

    public string gro_cdate { get; set; } = null!;

    public string gro_cname { get; set; } = null!;

    public string gro_udate { get; set; } = null!;

    public string gro_uname { get; set; } = null!;
}
