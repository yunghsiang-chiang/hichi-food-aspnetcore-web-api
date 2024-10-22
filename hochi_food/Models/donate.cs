using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class donate
{
    public string PSN_ID { get; set; } = null!;

    public int GIVE_SEQ_NO { get; set; }

    public string? DONATE_KIND { get; set; }

    public string? TITLE { get; set; }

    public string? GIVE_TYPE { get; set; }

    public string? GIVE_DATE { get; set; }

    public string? TXT_NAME { get; set; }

    public string? GIVE_BANK { get; set; }

    public string? ATM_NO { get; set; }

    public int? GIVE { get; set; }

    public string? RECEPT_NO { get; set; }

    public string? TXT_ID { get; set; }

    public string? TXT_DATE { get; set; }

    public int? SEQ_NO { get; set; }

    public string? STATE { get; set; }

    public string? G_FLAG { get; set; }

    public string? P_FLAG { get; set; }

    public string? NAME { get; set; }

    public string? DONATE_CLASS { get; set; }

    public string? F_FLAG { get; set; }

    public string? AREA_RECEPT_NO { get; set; }

    public string? AREA { get; set; }

    public string? A_RECEPT_NO { get; set; }

    public string? memo { get; set; }

    public string? RECEIVE_DATE { get; set; }

    public int? status { get; set; }

    public string? CLASS_ID { get; set; }

    public string? PsnId_from { get; set; }
}
