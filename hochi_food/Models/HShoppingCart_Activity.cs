using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HShoppingCart_Activity
{
    public int HID { get; set; }

    public int? HShoppingCartID { get; set; }

    public int? HMemberID { get; set; }

    public string? HAName { get; set; }

    public int? HASex { get; set; }

    public int? HAAge { get; set; }

    public string? HARelation { get; set; }

    public string? HAmount { get; set; }

    public int HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
