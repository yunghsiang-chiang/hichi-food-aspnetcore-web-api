using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class syslog
{
    public long L_ID { get; set; }

    public string L_UID { get; set; } = null!;

    public string L_IP { get; set; } = null!;

    public string L_Action { get; set; } = null!;

    public string L_DATE { get; set; } = null!;

    public string? L_NOTE { get; set; }

    public string? L_UNAME { get; set; }
}
