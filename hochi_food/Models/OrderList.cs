using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class OrderList
{
    public int HID { get; set; }

    public int? HStatus { get; set; }

    public string? HOrderGroup { get; set; }

    public string? HOrderNum { get; set; }

    public string? HCBCourseName { get; set; }

    public string? HCBHDateRange { get; set; }

    public int? HPMethod { get; set; }

    public string? HBDate { get; set; }

    public string? HPayMethod { get; set; }

    public int? HAttend { get; set; }

    public string? HMerchantTradeNo { get; set; }

    public string? HTradeNo { get; set; }

    public string? HCreateDT { get; set; }

    public string? HTeam { get; set; }

    public string? HType { get; set; }

    public string? HMType { get; set; }

    public string? HUserName { get; set; }

    public int? HMemberID { get; set; }

    public string? HPersonID { get; set; }

    public string? HPhone { get; set; }

    public string? HEmail { get; set; }

    public string? HCGuide { get; set; }

    public string? HCourseName { get; set; }

    public string? HDateRange { get; set; }

    public string? HTeacherName { get; set; }

    public string? HBCPoint { get; set; }

    public string? HPoint { get; set; }

    public int? HLDiscount { get; set; }

    public string? TeacherName { get; set; }

    public int? HRoom { get; set; }

    public string? HRoomName { get; set; }

    public string? HRoomTime { get; set; }

    public string? HDCode { get; set; }

    public string? HDSummary { get; set; }

    public string? HDPoint { get; set; }

    public string? HPlaceName { get; set; }

    public int? HPAmount { get; set; }

    public int? HSubTotal { get; set; }

    public int? HECPAmount { get; set; }

    public string? HPaymentDate { get; set; }

    public int? HPayAmt { get; set; }

    public string? HPaymentNo { get; set; }

    public string? HATMBankCode { get; set; }

    public string? HATMVAccount { get; set; }

    public string? HExpireDate { get; set; }

    public string? HFinanceRemark { get; set; }

    public string? HInvoiceNo { get; set; }

    public string? HInvoiceDate { get; set; }

    public int? HInvoiceStatus { get; set; }

    public int? HUse { get; set; }

    public int? HItemStatus { get; set; }

    public int? HChangeStatus { get; set; }

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

    public string? HCXLBAccount { get; set; }

    public string? HCXLBAName { get; set; }

    public string? HCDeadline { get; set; }

    public int? HCPkgYN { get; set; }

    public int? HCPkgHID { get; set; }

    public string? HCPkgName { get; set; }

    public int? HUploadIRS { get; set; }
}
