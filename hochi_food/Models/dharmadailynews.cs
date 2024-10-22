using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class dharmadailynews
{
    public string ddn_id { get; set; } = null!;

    public string ddn_date { get; set; } = null!;

    public string ddn_pdate { get; set; } = null!;

    public string? ddn_desc { get; set; }

    public string ddn_content { get; set; } = null!;

    public string ddn_cdate { get; set; } = null!;

    public string ddn_cname { get; set; } = null!;

    public string ddn_udate { get; set; } = null!;

    public string ddn_uname { get; set; } = null!;

    public sbyte ddn_status { get; set; }

    public string? ddn_file1 { get; set; }

    public string? ddn_couldurl { get; set; }
}
