using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HRollCall
{
    public int HID { get; set; }

    public int? HCourseID { get; set; }

    public int? HMemberID { get; set; }

    public DateOnly? HRCDate { get; set; }

    public int? HAStatus { get; set; }

    public string? HAReason { get; set; }

    public string? HRemark { get; set; }

    public string? HQRCode { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }

    public string? HAStatusDT { get; set; }
}
