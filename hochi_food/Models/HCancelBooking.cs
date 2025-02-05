using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HCancelBooking
{
    /// <summary>
    /// 流水號
    /// </summary>
    public int HID { get; set; }

    public int? HCancelStatus { get; set; }

    /// <summary>
    /// 訂單代碼
    /// </summary>
    public string? HOrderGroup { get; set; }

    /// <summary>
    /// 訂單編號
    /// </summary>
    public string? HOrderNum { get; set; }

    /// <summary>
    /// 綠界交易編號
    /// </summary>
    public string? HTradeNo { get; set; }

    /// <summary>
    /// 我們傳給綠界的廠商交易編號
    /// </summary>
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

    public int? HPAmount { get; set; }

    public int? HSubTotal { get; set; }

    public int? HLodging { get; set; }

    public string? HBDate { get; set; }

    public string? HLDate { get; set; }

    public string? HLCourse { get; set; }

    public string? HLCourseName { get; set; }

    public int? HLDiscount { get; set; }

    public string? HCGuide { get; set; }

    public string? HPayMethod { get; set; }

    /// <summary>
    /// 基金會代表金額；文化事業的課程代表點數
    /// </summary>
    public string? HPoint { get; set; }

    public string? HMemberGroup { get; set; }

    public string? HDharmaPass { get; set; }

    public int? HRoom { get; set; }

    public string? HRoomTime { get; set; }

    public string? HSubscribe { get; set; }

    public string? HDCode { get; set; }

    public string? HDPoint { get; set; }

    public int? HPayAmt { get; set; }

    public string? HPaymentNo { get; set; }

    public string? HExpireDate { get; set; }

    public string? HFailReason { get; set; }

    public string? HPaymentDate { get; set; }

    public int? HECPAmount { get; set; }

    public string? HGwsr { get; set; }

    public string? HFinanceRemark { get; set; }

    public int? HInvoiceType { get; set; }

    public string? HInvoiveTitle { get; set; }

    public string? HTaxID { get; set; }

    public string? HInvoiceNo { get; set; }

    public string? HInvoiceDate { get; set; }

    public int? HInvoiceStatus { get; set; }

    public string? HRemark { get; set; }

    public int? HCourseDonate { get; set; }

    /// <summary>
    /// 住宿備註
    /// </summary>
    public string? HRoomRemark { get; set; }

    /// <summary>
    /// 其他住宿
    /// </summary>
    public int? HOtherRoom { get; set; }

    /// <summary>
    /// 其他住宿之聯絡資訊
    /// </summary>
    public string? HORCInfo { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
