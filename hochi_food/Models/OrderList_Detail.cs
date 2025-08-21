using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class OrderList_Detail
{
    public int HID { get; set; }

    public string? HOrderGroup { get; set; }

    public string? HOrderGroupSrc { get; set; }

    public string? HOrderNum { get; set; }

    public int? HCourseID { get; set; }

    public string? HTradeNo { get; set; }

    public string? HMerchantTradeNo { get; set; }

    public int? HMemberID { get; set; }

    public int? HPMethod { get; set; }

    public string? HAttend { get; set; }

    public int? HPAmount { get; set; }

    public int? HSubTotal { get; set; }

    public string? HCourseName { get; set; }

    public string? HPayMethod { get; set; }

    public string? HPoint { get; set; }

    public string? HDCode { get; set; }

    public string? HDPoint { get; set; }

    public int? HPayAmt { get; set; }

    public string? HPaymentNo { get; set; }

    public string? HPaymentDate { get; set; }

    public int? HECPAmount { get; set; }

    public int? HInvoiceType { get; set; }

    public string? HInvoiveTitle { get; set; }

    public string? HTaxID { get; set; }

    public string? HInvoiceNo { get; set; }

    public string? HInvoiceDate { get; set; }

    public int? HInvoiceStatus { get; set; }

    public int? HCourseDonate { get; set; }

    public int? HItemStatus { get; set; }

    public int? HStatus { get; set; }

    public int? HChangeStatus { get; set; }

    public int? HCXLReason { get; set; }

    public string? HDateRange { get; set; }

    public string? HDate { get; set; }

    public string? HCourseLink { get; set; }

    public string? HSATCourseLink { get; set; }

    public string? HSUNCourseLink { get; set; }

    public string? HCourseLinkRelay { get; set; }

    public string? HCourseLinkTask { get; set; }

    public int? HShowZoom { get; set; }

    public string? HOCPlace { get; set; }

    public string? HPlaceName { get; set; }

    public string? HCreateDT { get; set; }

    public int? HBookByDateYN { get; set; }
}
