using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class codevalue
{
    public string CV_ID { get; set; } = null!;

    public string CV_CTID { get; set; } = null!;

    public string CV_NAME { get; set; } = null!;

    public string CV_CONTENT1 { get; set; } = null!;

    public int CV_STATUS { get; set; }

    public string? CV_CONTENT2 { get; set; }

    public int CV_ORDER { get; set; }

    public string CV_UNAME { get; set; } = null!;

    public string CV_CDATE { get; set; } = null!;

    public string CV_UDATE { get; set; } = null!;

    public string CV_PARENT { get; set; } = null!;
}
