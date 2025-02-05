using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class CulturalCourse_BookingList
{
    public string? HOrderGroup { get; set; }

    public string? HOrderNum { get; set; }

    public string? HCourseName { get; set; }

    public string? Name { get; set; }

    public string PayMethod { get; set; } = null!;

    public int? Price { get; set; }

    public int? HUse { get; set; }

    public string? HMerchantTradeNo { get; set; }

    public string? HPaymentDate { get; set; }

    public int? HPayAmt { get; set; }
}
