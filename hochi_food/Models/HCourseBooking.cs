using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HCourseBooking
{
    public int HID { get; set; }

    public string? HOrderGroup { get; set; }

    public string? HOrderNum { get; set; }

    /// <summary>
    /// 綠界交易編號
    /// </summary>
    public string? HTradeNo { get; set; }

    public string? HMerchantTradeNo { get; set; }

    public int? HMemberID { get; set; }

    public int? HCTemplateID { get; set; }

    public int? HCourseID { get; set; }

    public string? HCourseName { get; set; }

    public string? HDateRange { get; set; }

    /// <summary>
    /// HPMethod(繳費帳戶)：1=基金會；2=文化事業(HPoint*10)
    /// </summary>
    public int? HPMethod { get; set; }

    /// <summary>
    /// 參班身分: 1=參班、5=純護持(非班員)、6=參班兼護持
    /// </summary>
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
    /// 基金會(HPMethod=1)代表金額；文化事業(HPMethod=2)的課程代表點數(*10才轉成金額)
    /// </summary>
    public string? HPoint { get; set; }

    public string? HMemberGroup { get; set; }

    public string? HDharmaPass { get; set; }

    public string? HDFReason { get; set; }

    public int? HRoom { get; set; }

    public string? HRoomTime { get; set; }

    public string? HSubscribe { get; set; }

    public string? HDCode { get; set; }

    public string? HDPoint { get; set; }

    public int? HPayAmt { get; set; }

    public string? HPaymentNo { get; set; }

    public string? HATMBankCode { get; set; }

    public string? HATMVAccount { get; set; }

    public string? HExpireDate { get; set; }

    public string? HFailReason { get; set; }

    public string? HPaymentDate { get; set; }

    public int? HECPAmount { get; set; }

    public string? HGwsr { get; set; }

    public string? HRtnCode { get; set; }

    public string? HFinanceRemark { get; set; }

    public int? HInvoiceType { get; set; }

    public string? HInvoiveTitle { get; set; }

    public string? HTaxID { get; set; }

    public string? HInvoiceNo { get; set; }

    public string? HInvoiceDate { get; set; }

    public int? HInvoiceStatus { get; set; }

    public string? HRemark { get; set; }

    public string? HRoomRemark { get; set; }

    public int? HOtherRoom { get; set; }

    public string? HORCInfo { get; set; }

    public int? HCourseDonate { get; set; }

    public int? HItemStatus { get; set; }

    public int? HStatus { get; set; }

    public int? HChangeStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }

    public string? HTest { get; set; }

    public string? HCXLOrderGroup { get; set; }

    public string? HCXLApplyDate { get; set; }

    public string? HCXLFinishDate { get; set; }

    public int? HCXLAmount { get; set; }

    public int? HCXLReason { get; set; }

    public string? HCXLDetailReason { get; set; }

    public int? HCXLSubTotalSum { get; set; }

    public int? HCXLHandlingFee { get; set; }

    public int? HCXLTotal { get; set; }

    public int? HCXLHandleStatus { get; set; }

    public string? HCXLBankCode { get; set; }

    public string? HCXLBankName { get; set; }

    /// <summary>
    /// 分行名稱
    /// </summary>
    public string? HCXLBranchName { get; set; }

    public string? HCXLBAccount { get; set; }

    public string? HCXLBAName { get; set; }

    public string? HCXLRemark { get; set; }

    public string? HCXLRtnCode { get; set; }

    public string? HCXLRtnMsg { get; set; }

    public int? HCPkgHID { get; set; }

    public string? HCPkgName { get; set; }

    public int? HCPkgYN { get; set; }

    public int? HPkgPrice { get; set; }

    public int? HPkgPAmount { get; set; }

    public int? HPkgSubTotal { get; set; }

    /// <summary>
    /// 是否願意將捐款資料上傳國稅局
    /// </summary>
    public int? HUploadIRS { get; set; }
}
