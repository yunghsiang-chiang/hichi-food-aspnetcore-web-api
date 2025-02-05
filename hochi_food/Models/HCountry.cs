using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HCountry
{
    public int HID { get; set; }

    public string? CountryEN { get; set; }

    public string? CountryTW { get; set; }

    public string? CountryCN { get; set; }

    public string? HCode { get; set; }
}
