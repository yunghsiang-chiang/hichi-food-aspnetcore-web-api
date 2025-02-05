using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HInvoiceTemp
{
    public int HID { get; set; }

    public string? HItemNo { get; set; }

    public string? HTaxID { get; set; }

    public string? HPhoneNo { get; set; }

    public string? HInvoiceDate { get; set; }

    public string? HOrderNo { get; set; }

    public string? HCarrierA { get; set; }

    public string? HCarrierB { get; set; }

    public string? HLoveCode { get; set; }

    public string? HNo { get; set; }

    public string? HInvoiceName { get; set; }

    public string? HCount { get; set; }

    public string? HUnit { get; set; }

    public string? HTaxablePrice { get; set; }

    public string? HDutyFree { get; set; }

    public string? HSubtotal { get; set; }

    public string? HProductNo { get; set; }

    public string? HProductNoBarcode { get; set; }

    public string? HRemarkA { get; set; }

    public string? HRemarkB { get; set; }

    public string? HBuyMail { get; set; }

    public string? HBuyAdd { get; set; }

    public string? HPrincipal { get; set; }

    public string? HBuyName { get; set; }

    public string? HFollowNote { get; set; }

    public string? HZeroTaxPrice { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
