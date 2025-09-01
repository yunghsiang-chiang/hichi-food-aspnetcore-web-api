using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HMMentorRelationship
{
    public int HID { get; set; }

    /// <summary>
    /// 學員HID (關聯HMember.HID)
    /// </summary>
    public int? HMemberID { get; set; }

    /// <summary>
    /// 上層導師HID (關聯HMember.HID)
    /// </summary>
    public int? HMentorMemberID { get; set; }

    /// <summary>
    /// 上層導師類型(關聯HMentorType.HID)
    /// </summary>
    public int? HMentorTypeID { get; set; }

    /// <summary>
    /// 上層導師角色(關聯HMentorRole.HID)
    /// </summary>
    public int? HMentorRoleID { get; set; }

    /// <summary>
    /// 護持開始日期
    /// </summary>
    public DateOnly? HStartDate { get; set; }

    /// <summary>
    /// 護持結束日期
    /// </summary>
    public DateOnly? HEndDate { get; set; }

    /// <summary>
    /// 是否為個人主要導師
    /// </summary>
    public bool? HPrimaryYN { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string? HRemark { get; set; }

    /// <summary>
    /// 狀態
    /// </summary>
    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
