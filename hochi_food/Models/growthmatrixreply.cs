using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class growthmatrixreply
{
    public string gmr_id { get; set; } = null!;

    public string gmr_lid { get; set; } = null!;

    public string gmr_uid { get; set; } = null!;

    public string gmr_content { get; set; } = null!;

    public int gmr_status { get; set; }

    public string gmr_cdate { get; set; } = null!;

    public string gmr_cname { get; set; } = null!;

    public string gmr_udate { get; set; } = null!;

    public string gmr_uname { get; set; } = null!;

    public string? gmr_file1 { get; set; }

    public string? gmr_file2 { get; set; }

    public string? gmr_file3 { get; set; }
}
