using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HCBChangeRecord
{
    public int HID { get; set; }

    public string HOrderGroupSrc { get; set; } = null!;

    public string HOrderNumSrc { get; set; } = null!;

    public string? HOrderGroupNew { get; set; }

    public string? HOrderNumNew { get; set; }

    public string? HAttendSrc { get; set; }

    public int? HMemberID { get; set; }

    public string? HCPkgHIDSrc { get; set; }

    public string? HCourseIDSrc { get; set; }

    public int? HCourseIDNew { get; set; }

    public string? HMerchantTradeNo { get; set; }

    public string? HTradeNo { get; set; }

    public int? HCTemplateID { get; set; }

    public string? HCourseName { get; set; }

    public string? HDateRange { get; set; }

    public int? HPMethod { get; set; }

    public int? HAttendNew { get; set; }

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

    public int? HCourseDonate { get; set; }

    public string? HRoomRemark { get; set; }

    public int? HOtherRoom { get; set; }

    public string? HORCInfo { get; set; }

    public int? HItemStatus { get; set; }

    public int? HStatus { get; set; }

    public int? HChangeStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }

    public int? HCPkgYN { get; set; }

    public int? HPkgPAmount { get; set; }

    public int? HPkgSubTotal { get; set; }
}
