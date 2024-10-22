using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class words
{
    public string w_id { get; set; } = null!;

    public sbyte w_category { get; set; }

    public sbyte? w_no { get; set; }

    public string w_content { get; set; } = null!;

    public string w_cdate { get; set; } = null!;

    public string w_cname { get; set; } = null!;

    public string w_udate { get; set; } = null!;

    public string w_uname { get; set; } = null!;
}
