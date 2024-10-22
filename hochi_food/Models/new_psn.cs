using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class new_psn
{
    public string NP_ID { get; set; } = null!;

    public string? NP_LID { get; set; }

    public string? NAME { get; set; }

    public string? SEX { get; set; }

    public string? AREA { get; set; }

    public string? COUNTRY { get; set; }

    public string? CELL_TEL { get; set; }

    public string? ADDRESS_2 { get; set; }

    public string? SPONSOR { get; set; }

    public string? TXT_DATE { get; set; }

    public string? TXT_ID { get; set; }

    public string? TXT_MARK { get; set; }

    public string? T_From { get; set; }

    public int? status { get; set; }
}
