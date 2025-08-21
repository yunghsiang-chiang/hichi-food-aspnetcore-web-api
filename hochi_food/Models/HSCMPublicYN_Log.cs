using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HSCMPublicYN_Log
{
    public int HID { get; set; }

    /// <summary>
    /// 課程討論區與主題設定ID(HSCCTopicSetting.HID)
    /// </summary>
    public int? HSCForumClassID { get; set; }

    public string? HSCFCName { get; set; }

    /// <summary>
    /// 0=不公開/1=公開
    /// </summary>
    public int? HSCMPublicYN { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
