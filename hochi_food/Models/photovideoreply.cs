using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class photovideoreply
{
    public string pvr_id { get; set; } = null!;

    public string pvr_pvid { get; set; } = null!;

    public string pvr_uid { get; set; } = null!;

    public string? pvr_content { get; set; }

    public sbyte pvr_status { get; set; }

    public string pvr_cdate { get; set; } = null!;

    public string pvr_cname { get; set; } = null!;

    public string pvr_udate { get; set; } = null!;

    public string pvr_uname { get; set; } = null!;

    public string? pvr_file1 { get; set; }

    public string? pvr_file2 { get; set; }

    public string? pvr_file3 { get; set; }

    public string pvr_parent { get; set; } = null!;

    public string? pvr_no { get; set; }
}
