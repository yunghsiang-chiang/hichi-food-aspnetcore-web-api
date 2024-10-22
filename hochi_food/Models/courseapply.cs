using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class courseapply
{
    public string ca_id { get; set; } = null!;

    public string ca_aid { get; set; } = null!;

    public string ca_areaname { get; set; } = null!;

    public string ca_uid { get; set; } = null!;

    public string ca_cdate { get; set; } = null!;

    public string ca_cname { get; set; } = null!;

    public string ca_udate { get; set; } = null!;

    public string ca_uname { get; set; } = null!;

    public string ca_coursename { get; set; } = null!;

    public string ca_coursebegdate { get; set; } = null!;

    public string ca_courseenddate { get; set; } = null!;

    public string ca_section { get; set; } = null!;

    public string ca_classarea { get; set; } = null!;

    public bool? ca_category { get; set; }

    public string? ca_file1 { get; set; }

    public string? ca_file2 { get; set; }

    public sbyte ca_status { get; set; }

    public string ca_mname { get; set; } = null!;
}
