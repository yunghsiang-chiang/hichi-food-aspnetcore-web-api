using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HSCMRule
{
    public int HID { get; set; }

    /// <summary>
    /// 課程討論區與主題設定ID(HSCCTopicSetting.HID)
    /// </summary>
    public int? HSCForumClassID { get; set; }

    /// <summary>
    /// 版規內容
    /// </summary>
    public string? HSCMRule1 { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
