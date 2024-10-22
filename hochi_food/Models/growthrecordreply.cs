using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class growthrecordreply
{
    public string grr_id { get; set; } = null!;

    public string grr_grid { get; set; } = null!;

    public string grr_uid { get; set; } = null!;

    public string grr_content { get; set; } = null!;

    public int grr_status { get; set; }

    public string grr_cdate { get; set; } = null!;

    public string grr_cname { get; set; } = null!;

    public string grr_udate { get; set; } = null!;

    public string grr_uname { get; set; } = null!;

    public string? grr_file1 { get; set; }

    public string? grr_file2 { get; set; }

    public string? grr_file3 { get; set; }

    public string? grr_lrid { get; set; }
}
