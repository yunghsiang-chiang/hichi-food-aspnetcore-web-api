using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class OrderList_Front
{
    public long? ROW { get; set; }

    public string? HOrderGroup { get; set; }

    public string? CourseName { get; set; }

    public string? HOrderNum { get; set; }

    public string? HCXLApplyDate { get; set; }

    public string? HMerchantTradeNo { get; set; }

    public string? PMethod { get; set; }

    public int? HMemberID { get; set; }

    public string? HPayMethod { get; set; }

    public string? HPaymentDate { get; set; }

    public int? HPayAmt { get; set; }

    public int? HECPAmount { get; set; }

    public string? HStatus { get; set; }

    public int? HUse { get; set; }

    public string? UserName { get; set; }

    public string? HCreateDT { get; set; }

    public string? HOrderGroupSrc { get; set; }

    public int? HCPkgYN { get; set; }

    public int? HBookByDateYN { get; set; }

    public string? ItemStatus { get; set; }

    public string? HCXLHandleStatus { get; set; }

    public string? HCreate { get; set; }
}
