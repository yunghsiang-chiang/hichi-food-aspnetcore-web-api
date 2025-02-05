using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HTest
{
    public int HID { get; set; }

    public string? HMemberID { get; set; }

    public string? HRAccess { get; set; }

    public string? HCondition { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
