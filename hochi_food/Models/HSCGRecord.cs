using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HSCGRecord
{
    public int HID { get; set; }

    /// <summary>
    /// 討論區名稱HID
    /// </summary>
    public int? HSCForumClassID { get; set; }

    /// <summary>
    /// 主題名稱
    /// </summary>
    public string? HTopicName { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
