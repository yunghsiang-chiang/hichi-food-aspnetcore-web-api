using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class OrderList_Backend
{
    public long? ROW { get; set; }

    public string? HOrderGroup { get; set; }

    public string? CourseName { get; set; }

    public string? HOrderNum { get; set; }

    public string? HCXLApplyDate { get; set; }

    public string? HMerchantTradeNo { get; set; }

    public string? PMethod { get; set; }

    public int? HMemberID { get; set; }

    public string PayMethod { get; set; } = null!;

    public string? HPaymentDate { get; set; }

    public int? HPayAmt { get; set; }

    public int? HECPAmount { get; set; }

    public int? HStatus { get; set; }

    public int? HUse { get; set; }

    public string? UserName { get; set; }

    public string? HCreateDT { get; set; }

    public string? HOrderGroupSrc { get; set; }
}
