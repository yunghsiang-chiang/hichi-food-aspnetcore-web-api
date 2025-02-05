using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HNews_Class
{
    public int HID { get; set; }

    public string? HNewsClass { get; set; }

    public int? HNewsStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
