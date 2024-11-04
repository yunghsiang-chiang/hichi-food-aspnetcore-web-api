using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class edusideblock
{
    public string ColumnTitle { get; set; } = null!;

    public DateTime? StartDate { get; set; }

    public DateTime? LastUsedDate { get; set; }
}
