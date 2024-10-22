using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class codetype
{
    public string CT_ID { get; set; } = null!;

    public string CT_NAME { get; set; } = null!;

    public string? CT_CONTENT { get; set; }

    public int CT_STATUS { get; set; }
}
