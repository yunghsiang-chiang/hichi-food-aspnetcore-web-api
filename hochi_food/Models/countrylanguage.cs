using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class countrylanguage
{
    public string CountryCode { get; set; } = null!;

    public string Language { get; set; } = null!;

    public string IsOfficial { get; set; } = null!;

    public decimal Percentage { get; set; }

    public virtual country CountryCodeNavigation { get; set; } = null!;
}
