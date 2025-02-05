using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HRoom
{
    public int HID { get; set; }

    public string? HRoomName { get; set; }

    public string? HExplanation { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
