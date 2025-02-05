using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HPointBooking
{
    public int HID { get; set; }

    public string? HOrderNum { get; set; }

    public int? HMemberID { get; set; }

    public int? HPayMethod { get; set; }

    public int? HPoint { get; set; }

    public int? HAmount { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }

    public string? HRemark { get; set; }

    /// <summary>
    /// 綠界交易編號
    /// </summary>
    public string? HTradeNo { get; set; }

    public string? HPaymentNo { get; set; }

    public string? HExpireDate { get; set; }

    public string? HPaymentDate { get; set; }
}
