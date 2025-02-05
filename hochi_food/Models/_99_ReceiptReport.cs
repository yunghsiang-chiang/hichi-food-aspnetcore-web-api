using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class _99_ReceiptReport
{
    public string TaxID { get; set; } = null!;

    public string PhoneCode { get; set; } = null!;

    public string Nature { get; set; } = null!;

    public string? InvoiceDate { get; set; }

    public string Barcode { get; set; } = null!;

    public string BarcodeShow { get; set; } = null!;

    public string BarcodeHide { get; set; } = null!;

    public string HeartCode { get; set; } = null!;

    public string Num { get; set; } = null!;

    public string ItemName { get; set; } = null!;

    public string Numbers { get; set; } = null!;

    public string Unit { get; set; } = null!;

    public int? HPayAmt { get; set; }

    public string NoTaxPrice { get; set; } = null!;

    public int? Total { get; set; }

    public string? HMerchantTradeNo { get; set; }

    public string? ItemCode { get; set; }

    public string? Name { get; set; }

    public string MainRemark { get; set; } = null!;

    public string? HAccount { get; set; }

    public string Address { get; set; } = null!;

    public string principle { get; set; } = null!;

    public string? BookDate { get; set; }
}
