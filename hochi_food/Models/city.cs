using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class city
{
    public int ID { get; set; }

    public string Name { get; set; } = null!;

    public string CountryCode { get; set; } = null!;

    public string District { get; set; } = null!;

    public int Population { get; set; }

    public virtual country CountryCodeNavigation { get; set; } = null!;
}
