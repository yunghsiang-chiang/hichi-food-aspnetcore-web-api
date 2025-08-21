using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HSCTopic_Role
{
    public int HID { get; set; }

    /// <summary>
    /// 討論區名稱HID(HSCForumClass.HID)
    /// </summary>
    public int? HSCForumClassID { get; set; }

    /// <summary>
    /// 主題HID(HSCTopic.HID)
    /// </summary>
    public int? HSCTopicID { get; set; }

    /// <summary>
    /// 學員HID(HMember.HID)
    /// </summary>
    public int? HMemberID { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
