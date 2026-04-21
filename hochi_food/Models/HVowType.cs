using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HVowType
{
    public int HVowTypeID { get; set; }

    public string? HVowTypeName { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModiftDT { get; set; }
}
