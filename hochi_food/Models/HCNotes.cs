using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HCNotes
{
    public int HUserId { get; set; }

    public string HCourseName { get; set; } = null!;

    public string HDirections { get; set; } = null!;

    public int HCreateUser { get; set; }

    public DateTime HCreateTime { get; set; }
}
