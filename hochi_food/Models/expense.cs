using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class expense
{
    public string SPEND_DATE { get; set; } = null!;

    public string? DONATE_KIND { get; set; }

    public string? FEE_CODE { get; set; }

    public string? DESCRIPT { get; set; }

    public int? SPEND { get; set; }

    public int SPEND_SEQ_NO { get; set; }

    public string? PAY_KIND { get; set; }

    public string? TXT_ID { get; set; }

    public string? TXT_DATE { get; set; }

    public int? status { get; set; }

    public string? FRAME { get; set; }

    public string? TXT_NAME { get; set; }
}
