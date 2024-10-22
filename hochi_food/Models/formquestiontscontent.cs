using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class formquestiontscontent
{
    public string fqc_id { get; set; } = null!;

    public string fqc_fqdid { get; set; } = null!;

    public string fqc_fqiid { get; set; } = null!;

    public string? fqc_content { get; set; }
}
