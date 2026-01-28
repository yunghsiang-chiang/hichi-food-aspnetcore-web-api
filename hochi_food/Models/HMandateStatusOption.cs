using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HMandateStatusOption
{
    public int HId { get; set; }

    public string HStatus { get; set; } = null!;

    public int HSort { get; set; }

    public bool HIsActive { get; set; }
}
