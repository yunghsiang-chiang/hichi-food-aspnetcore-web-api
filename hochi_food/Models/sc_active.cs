using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class sc_active
{
    public string SC_ID { get; set; } = null!;

    public string? SC_NAME { get; set; }

    public string? LEADER_ID { get; set; }

    public string? ADDRESS { get; set; }

    public string? START_DATE { get; set; }

    public string? TIME_DESCRIPT { get; set; }

    public string? NEED { get; set; }

    public string? CLOTHES { get; set; }

    public string? SC_TYPE { get; set; }

    public string? AREA { get; set; }

    public string? MEMO { get; set; }

    public string? SC_TEL { get; set; }

    public string? CONTENT { get; set; }

    public string? END_DATE { get; set; }

    public string? TXT_NAME { get; set; }

    public string? TXT_DATE { get; set; }

    public int? status { get; set; }

    public string? old_SC_ID { get; set; }
}
