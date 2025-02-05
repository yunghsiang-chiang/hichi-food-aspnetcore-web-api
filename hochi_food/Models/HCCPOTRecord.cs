using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HCCPOTRecord
{
    public int HID { get; set; }

    public int? HCCPODetailID { get; set; }

    public string? HMerchantTradeNo { get; set; }

    /// <summary>
    /// 綠界交易編號
    /// </summary>
    public string? HTradeNo { get; set; }

    /// <summary>
    /// 信用卡授權交易單號
    /// </summary>
    public string? HGwsr { get; set; }

    public int? HAmount { get; set; }

    public int? HRtnCode { get; set; }

    public string? HRtnMsg { get; set; }

    public string? HProcessDate { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
