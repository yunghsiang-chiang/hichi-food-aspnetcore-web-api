using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class x_mailfrom
{
    public string mf_id { get; set; } = null!;

    public string mf_uid { get; set; } = null!;

    public string mf_cname { get; set; } = null!;

    public string mf_unitname { get; set; } = null!;

    public string mf_content { get; set; } = null!;

    public string mf_cdate { get; set; } = null!;

    public int mf_status { get; set; }

    public string? mf_file1 { get; set; }

    public string? mf_file1desc { get; set; }

    public string? mf_file2 { get; set; }

    public string? mf_file2desc { get; set; }

    public string? mf_file3 { get; set; }

    public string? mf_file3desc { get; set; }

    public string? mf_file4 { get; set; }

    public string? mf_file4desc { get; set; }

    public string? mf_file5 { get; set; }

    public string? mf_file5desc { get; set; }

    public string mf_tounit { get; set; } = null!;

    public int mf_imp { get; set; }

    public string mf_pdate { get; set; } = null!;
}
