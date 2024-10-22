using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class course_his
{
    public string c_id { get; set; } = null!;

    public string c_name { get; set; } = null!;

    public sbyte? c_status { get; set; }
}
