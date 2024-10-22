using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class memorialdayreply
{
    public string mdr_id { get; set; } = null!;

    public string mdr_mdid { get; set; } = null!;

    public string mdr_uid { get; set; } = null!;

    public string? mdr_content { get; set; }

    public sbyte mdr_status { get; set; }

    public string mdr_cdate { get; set; } = null!;

    public string mdr_cname { get; set; } = null!;

    public string mdr_udate { get; set; } = null!;

    public string mdr_uname { get; set; } = null!;

    public string? mdr_file1 { get; set; }

    public string? mdr_file2 { get; set; }

    public string? mdr_file3 { get; set; }

    public string? mdr_file4 { get; set; }

    public string? mdr_file5 { get; set; }

    public string? mdr_parent { get; set; }
}
