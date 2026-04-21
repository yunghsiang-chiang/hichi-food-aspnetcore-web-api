using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HLightTVerifyLog
{
    public int HID { get; set; }

    /// <summary>
    /// dbo.HLightTransfer.HID
    /// </summary>
    public int? HLightTransferID { get; set; }

    /// <summary>
    /// 簽核者姓名
    /// </summary>
    public string? HSignName { get; set; }

    /// <summary>
    /// 審核日期
    /// </summary>
    public string? HVerifyDate { get; set; }

    /// <summary>
    /// 1=申請成為光使、2=光使變更光系
    /// </summary>
    public int? HApplyType { get; set; }

    /// <summary>
    /// 審核結果：0審核中、當HApplyType=1(1初審核不通過、2初審核通過、3複審核不通過、4複審核通過、5核准不通過、6核准通過)，當HApplyType=2(1原光系審核不通過、2原光系審核通過、3新光系審核不通過、4新光系審核通過)
    /// </summary>
    public int? HVerifyResult { get; set; }

    /// <summary>
    /// 簽辦意見
    /// </summary>
    public string? HVerifyOpinion { get; set; }

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
    public DateTime? HCreateDT { get; set; }

    /// <summary>
    /// 編輯者
    /// </summary>
    public string? HModify { get; set; }

    /// <summary>
    /// 編輯日期
    /// </summary>
    public DateTime? HModifyDT { get; set; }
}
