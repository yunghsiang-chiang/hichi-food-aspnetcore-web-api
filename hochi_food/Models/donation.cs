using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class donation
{
    public string DT_ID { get; set; } = null!;

    public string PSN_ID { get; set; } = null!;

    public string KINSFOLK { get; set; } = null!;

    public string? RELATION { get; set; }

    public string? CONTENT { get; set; }

    public string? DONATION_1 { get; set; }

    public string? DONATION_2 { get; set; }

    public string? DONATION_3 { get; set; }

    public string DATE { get; set; } = null!;

    public string? AREA { get; set; }

    public string? DONATE_KIND { get; set; }

    public int? GIVE { get; set; }

    public string? OTHER_DONATE_KIND { get; set; }

    public int? OTHER_GIVE { get; set; }

    public string? TXT_DATE { get; set; }

    public short? ELEMENT_1 { get; set; }

    public short? ELEMENT_2 { get; set; }

    public short? ELEMENT_3 { get; set; }

    public short? ELEMENT_4 { get; set; }

    public short? ELEMENT_5 { get; set; }

    public short? ELEMENT_6 { get; set; }

    public short? ELEMENT_7 { get; set; }

    public short? QTY { get; set; }

    public int? SEQ_NO { get; set; }

    public string? STATE { get; set; }

    public string? DONATION_CLASS { get; set; }

    public string? stage { get; set; }

    public int? status { get; set; }
}
