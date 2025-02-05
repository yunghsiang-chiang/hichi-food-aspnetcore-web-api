using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class OrderReport
{
    public int HID { get; set; }

    public string? HOrderGroup { get; set; }

    public string? HOrderNum { get; set; }

    public string? HCourseName { get; set; }

    public string? CTypeName { get; set; }

    public string? HDateRange { get; set; }

    public string? Username { get; set; }

    public string? HPlaceName { get; set; }

    public int? BCPrice { get; set; }

    public int? HAttend { get; set; }

    public string? HDCode { get; set; }

    public int? DPrice { get; set; }

    public int? HCourseDonate { get; set; }

    public string? HBDate { get; set; }

    public int? HPMethod { get; set; }

    public string PMethod { get; set; } = null!;

    public int? HStatus { get; set; }

    public string? HPoint { get; set; }

    public int? HLDiscount { get; set; }

    public string? HPayMethod { get; set; }

    public string PayMethod { get; set; } = null!;

    public int? Price { get; set; }

    public int? HUse { get; set; }

    public int? PointStatus { get; set; }

    public int? LDiscount { get; set; }

    public string Attend { get; set; } = null!;

    public string? HMerchantTradeNo { get; set; }

    public string? HPaymentDate { get; set; }

    public int? HPayAmt { get; set; }

    public string? HFinanceRemark { get; set; }

    public string? HInvoiceNo { get; set; }

    public string? HInvoiceDate { get; set; }

    public int? HInvoiceStatus { get; set; }
}
