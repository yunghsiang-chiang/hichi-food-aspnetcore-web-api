using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class sc_time
{
    public string SC_ID { get; set; } = null!;

    public string? WEEKDAY { get; set; }

    public string? START_TIME { get; set; }

    public string? END_TIME { get; set; }

    public string? LEADER_ID { get; set; }

    public string? LEADER_ID_1 { get; set; }

    public string? PLACE { get; set; }

    public string? RECORDER_ID { get; set; }

    public string? KIND { get; set; }

    public int? status { get; set; }

    public string SC_ID_no { get; set; } = null!;

    public string? TXT_NAME { get; set; }

    public string? TXT_DATE { get; set; }
}
