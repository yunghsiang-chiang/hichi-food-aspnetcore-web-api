using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HSCCTopicSetting
{
    public int HID { get; set; }

    /// <summary>
    /// 課程範本HID(HCourse_T.HID)
    /// </summary>
    public int? HCTemplateID { get; set; }

    /// <summary>
    /// 討論區名稱HID(HSCForumName.HID)
    /// </summary>
    public int? HSCForumClassID { get; set; }

    /// <summary>
    /// 主題名稱產生方式(1=依課程名稱;2=依上課日期;3=不依上課地點)
    /// </summary>
    public int? HTopicNameType { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
