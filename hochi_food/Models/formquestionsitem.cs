using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class formquestionsitem
{
    public string fqi_id { get; set; } = null!;

    public string fqi_fqid { get; set; } = null!;

    public sbyte fqi_no { get; set; }

    public sbyte fqi_status { get; set; }

    public sbyte fqi_type { get; set; }

    public string fqi_name { get; set; } = null!;

    public string? fqi_value { get; set; }

    public string? fqi_desc { get; set; }
}
