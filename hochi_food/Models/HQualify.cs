using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HQualify
{
    public int HID { get; set; }

    public int? HCBookingID { get; set; }

    public int? HTStatus1 { get; set; }

    public string? HTDate1 { get; set; }

    public string? HTScore1 { get; set; }

    public string? HTComment1 { get; set; }

    public string? HTPDate1 { get; set; }

    public int? HTStatus2 { get; set; }

    public string? HTDate2 { get; set; }

    public string? HTScore2 { get; set; }

    public string? HTComment2 { get; set; }

    public string? HTPDate2 { get; set; }

    public int? HTStatus3 { get; set; }

    public string? HTDate3 { get; set; }

    public string? HTScore3 { get; set; }

    public string? HTComment3 { get; set; }

    public string? HTPDate3 { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
