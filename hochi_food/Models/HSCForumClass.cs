using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HSCForumClass
{
    public int HID { get; set; }

    /// <summary>
    /// 討論區上一層HID(HSCForumClass.HID)
    /// </summary>
    public int? HSCFCMaster { get; set; }

    /// <summary>
    /// 討論區類別名稱
    /// </summary>
    public string? HSCFCName { get; set; }

    /// <summary>
    /// 討論區類別階層
    /// </summary>
    public string? HSCFCLevel { get; set; }

    public int? HSort { get; set; }

    /// <summary>
    /// 公開狀態(0:不公開、1:公開)
    /// </summary>
    public int? HPublic { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
