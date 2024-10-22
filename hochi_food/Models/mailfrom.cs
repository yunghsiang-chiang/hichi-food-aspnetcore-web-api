using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class mailfrom
{
    public string mf_id { get; set; } = null!;

    public string mf_uid { get; set; } = null!;

    public string mf_to { get; set; } = null!;

    public string mf_subject { get; set; } = null!;

    public string? mf_content { get; set; }

    public string mf_cdate { get; set; } = null!;

    public bool? mf_status { get; set; }

    public string? mf_file1 { get; set; }

    public string? mf_file2 { get; set; }

    public string? mf_file3 { get; set; }

    public string? mf_file1desc { get; set; }

    public string? mf_file2desc { get; set; }

    public string? mf_file3desc { get; set; }
}
