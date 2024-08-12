using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class country
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Continent { get; set; } = null!;

    public string Region { get; set; } = null!;

    public decimal SurfaceArea { get; set; }

    public short? IndepYear { get; set; }

    public int Population { get; set; }

    public decimal? LifeExpectancy { get; set; }

    public decimal? GNP { get; set; }

    public decimal? GNPOld { get; set; }

    public string LocalName { get; set; } = null!;

    public string GovernmentForm { get; set; } = null!;

    public string? HeadOfState { get; set; }

    public int? Capital { get; set; }

    public string Code2 { get; set; } = null!;

    public virtual ICollection<city> city { get; set; } = new List<city>();

    public virtual ICollection<countrylanguage> countrylanguage { get; set; } = new List<countrylanguage>();
}
