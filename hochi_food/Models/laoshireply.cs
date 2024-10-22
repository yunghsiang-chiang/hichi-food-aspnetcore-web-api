using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class laoshireply
{
    public string lr_id { get; set; } = null!;

    public string lr_lid { get; set; } = null!;

    public string lr_uid { get; set; } = null!;

    public string lr_content { get; set; } = null!;

    public sbyte lr_status { get; set; }

    public string lr_cdate { get; set; } = null!;

    public string lr_cname { get; set; } = null!;

    public string lr_udate { get; set; } = null!;

    public string lr_uname { get; set; } = null!;

    public string? lr_file1 { get; set; }

    public string? lr_file2 { get; set; }

    public string? lr_file3 { get; set; }

    public sbyte lr_q { get; set; }

    public string lr_parent { get; set; } = null!;

    public string? lr_no { get; set; }

    public string? lr_qno { get; set; }

    public string? lr_yqno { get; set; }

    public string? lr_copynote { get; set; }

    public sbyte? lr_isshowdaily { get; set; }
}
