using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class hundredbasecontent
{
    public string hbc_id { get; set; } = null!;

    public string hbc_hbdid { get; set; } = null!;

    public string hbc_hbqiid { get; set; } = null!;

    public string hbc_content { get; set; } = null!;

    public sbyte hbc_status { get; set; }
}
