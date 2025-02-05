using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HPoints
{
    public int HID { get; set; }

    public int? HMemberID { get; set; }

    public string? HRecrodDate { get; set; }

    public string? HBuyDate { get; set; }

    public string? HPayMethod { get; set; }

    public int? HBuy { get; set; }

    public int? HAmount { get; set; }

    public string? HEndDate { get; set; }

    public string? HRecord { get; set; }

    public int? HUse { get; set; }

    public string? HUseFor { get; set; }

    public string? HRemark { get; set; }

    public string? HInvoiceNo { get; set; }

    public string? HOrderNum { get; set; }

    public string? HOrderGroup { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
