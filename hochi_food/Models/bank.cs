using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class bank
{
    public string PAY_DATE { get; set; } = null!;

    public string? PAY_TIME { get; set; }

    public string? PAY_TYPE_DESC { get; set; }

    public string? PAY_TYPE { get; set; }

    public string? PAY_BANK { get; set; }

    public int? PAY { get; set; }

    public string? MEMO { get; set; }

    public string? CK_FLAG { get; set; }

    public string? D_FLAG { get; set; }

    public string? TXT_ID { get; set; }

    public string? TXT_DATE { get; set; }

    public string? TXT_TIME { get; set; }

    public int SEQ_NO { get; set; }

    public string? RECEPT_ID { get; set; }

    public string? RECEPT_BANK { get; set; }

    public string? SYS_CODE { get; set; }

    public string? AREA { get; set; }

    public int? status { get; set; }
}
