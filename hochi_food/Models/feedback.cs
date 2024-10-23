using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class feedback
{
    public int id { get; set; }

    public int participant_id { get; set; }

    public string? color_choice { get; set; }

    public string? color_choice_text { get; set; }

    public string? satisfaction { get; set; }

    public string? feedback_text { get; set; }

    public string? promoter_observation { get; set; }

    public string? others { get; set; }

    public DateTime? created_at { get; set; }

    public virtual participants participant { get; set; } = null!;
}
