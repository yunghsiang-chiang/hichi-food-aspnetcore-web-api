using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HTreePeople
{
    public int HNo { get; set; }

    public int? HMemberHID { get; set; }

    public string? HTreeStructure { get; set; }

    public string? HOccupation { get; set; }
}
