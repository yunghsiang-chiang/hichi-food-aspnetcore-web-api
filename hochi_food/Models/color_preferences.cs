using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class color_preferences
{
    public int id { get; set; }

    public int participant_id { get; set; }

    public string message_board { get; set; } = null!;

    public string? message_board_color1 { get; set; }

    public string? message_board_color2 { get; set; }

    public string balloon { get; set; } = null!;

    public string? balloon_color1 { get; set; }

    public string? balloon_color2 { get; set; }

    public DateTime? created_at { get; set; }

    public virtual participants participant { get; set; } = null!;
}
