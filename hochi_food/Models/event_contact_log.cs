using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class event_contact_log
{
    public int event_id { get; set; }

    public string event_type { get; set; } = null!;

    public int person_id { get; set; }

    public int actor_hid { get; set; }

    public string method { get; set; } = null!;

    public string? intent_level { get; set; }

    public string? next_action { get; set; }

    public DateOnly? next_action_date { get; set; }

    public string? memo { get; set; }

    public DateTime event_ts { get; set; }
}
