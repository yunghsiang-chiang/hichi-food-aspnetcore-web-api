using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HShoppingCart
{
    public int HID { get; set; }

    public string? HOrderNum { get; set; }

    /// <summary>
    /// 綠界交易編號
    /// </summary>
    public string? HTradeNo { get; set; }

    public string? HMerchantTradeNo { get; set; }

    /// <summary>
    /// 會員ID
    /// </summary>
    public int? HMemberID { get; set; }

    /// <summary>
    /// 課程ID
    /// </summary>
    public int? HCourseID { get; set; }

    public int? HCTemplateID { get; set; }

    public string? HCourseName { get; set; }

    public string? HDateRange { get; set; }

    public int? HPMethod { get; set; }

    public int? HAttend { get; set; }

    public int? HLodging { get; set; }

    public string? HBDate { get; set; }

    public string? HLDate { get; set; }

    public string? HLCourse { get; set; }

    public string? HLCourseName { get; set; }

    public int? HLDiscount { get; set; }

    public string? HCGuide { get; set; }

    public string? HPayMethod { get; set; }

    public string? HPoint { get; set; }

    public string? HMemberGroup { get; set; }

    public string? HDharmaPass { get; set; }

    public int? HRoom { get; set; }

    public string? HRoomTime { get; set; }

    public string? HSubscribe { get; set; }

    public int? HPAmount { get; set; }

    public int? HSubTotal { get; set; }

    public string? HDCode { get; set; }

    public string? HDPoint { get; set; }

    public string? HPaymentNo { get; set; }

    public string? HExpireDate { get; set; }

    public string? HFailReason { get; set; }

    public string? HPaymentDate { get; set; }

    public int? HPayAmt { get; set; }

    public string? HFinanceRemark { get; set; }

    public string? HInvoiceNo { get; set; }

    public string? HInvoiceDate { get; set; }

    public int? HInvoiceStatus { get; set; }

    public string? HRemark { get; set; }

    public bool? HSelect { get; set; }

    public int? HCourseDonate { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
