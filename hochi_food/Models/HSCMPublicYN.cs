using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HSCMPublicYN
{
    public int HID { get; set; }

    public int? HSCForumClassID { get; set; }

    /// <summary>
    /// 0=不公開/1=公開
    /// </summary>
    public int? HSCMPublicYN1 { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
