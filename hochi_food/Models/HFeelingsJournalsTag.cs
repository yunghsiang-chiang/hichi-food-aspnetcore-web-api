using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HFeelingsJournalsTag
{
    public int HID { get; set; }

    public int HFeelingsJournalsID { get; set; }

    public string HTagContent { get; set; } = null!;

    /// <summary>
    /// 建立者
    /// </summary>
    public int HTaggerMemberID { get; set; }

    public int HStatus { get; set; }

    public int? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public int? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
