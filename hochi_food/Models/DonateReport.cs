using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class DonateReport
{
    public string? DonatePerson { get; set; }

    public string? InvoiceTitle { get; set; }

    public string TempNo { get; set; } = null!;

    public string? DonateDate { get; set; }

    public string PayMethod { get; set; } = null!;

    public string Donate { get; set; } = null!;

    public string DPurpose { get; set; } = null!;

    public string DItem { get; set; } = null!;

    public string? Project { get; set; }

    public string? HPoint { get; set; }

    public string InvoiceType { get; set; } = null!;

    public string ICBank { get; set; } = null!;

    public string ICDate { get; set; } = null!;

    public string? HAccount { get; set; }

    public string Tax { get; set; } = null!;

    public string? HPersonID { get; set; }

    public string Aboard { get; set; } = null!;

    public string Tel { get; set; } = null!;

    public string? HPhone { get; set; }

    public string Postal { get; set; } = null!;

    public string City { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string BankType { get; set; } = null!;

    public string BTitle { get; set; } = null!;

    public string? Remark { get; set; }
}
