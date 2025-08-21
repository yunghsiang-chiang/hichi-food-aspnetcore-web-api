using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HCCPOPaidRecord
{
    /// <summary>
    /// 流水號
    /// </summary>
    public int HID { get; set; }

    /// <summary>
    /// 關連信用卡授權訂單明細.HID (HCCPODetail.HID)
    /// </summary>
    public int? HCCPODetailID { get; set; }

    /// <summary>
    /// 付款金額
    /// </summary>
    public int? HPayAmount { get; set; }

    /// <summary>
    /// 付款日期
    /// </summary>
    public string? HPaymentDate { get; set; }

    /// <summary>
    /// 付款方式 (1=EIP付款、2=ATM匯款)
    /// </summary>
    public string? HPayMethod { get; set; }

    /// <summary>
    /// 付款狀態
    /// </summary>
    public int? HPayStatus { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string? HRemark { get; set; }

    /// <summary>
    /// 狀態
    /// </summary>
    public int? HStatus { get; set; }

    /// <summary>
    /// 建立者
    /// </summary>
    public string? HCreate { get; set; }

    /// <summary>
    /// 建立日期
    /// </summary>
    public string? HCreateDT { get; set; }

    /// <summary>
    /// 修改者
    /// </summary>
    public string? HModify { get; set; }

    /// <summary>
    /// 修改日期
    /// </summary>
    public string? HModifyDT { get; set; }
}
