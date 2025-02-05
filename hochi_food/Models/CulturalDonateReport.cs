using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class CulturalDonateReport
{
    public string? HArea { get; set; }

    public string? HPeriod { get; set; }

    public string? InvoiceTitle { get; set; }

    public string? DonateDate { get; set; }

    public string PayMethod { get; set; } = null!;

    public string? Project { get; set; }

    public string? HDateRange { get; set; }

    public string? CoursePrice { get; set; }

    public int? TotalPrice { get; set; }

    public string? HMerchantTradeNo { get; set; }

    public string? HOrderNum { get; set; }

    public string? HOrderGroup { get; set; }
}
