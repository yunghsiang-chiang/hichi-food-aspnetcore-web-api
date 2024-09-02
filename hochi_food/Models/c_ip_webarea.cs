using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class c_ip_webarea
{
    public string area { get; set; } = null!;

    public string? sub_inv { get; set; }

    public string ipaddress { get; set; } = null!;
}
