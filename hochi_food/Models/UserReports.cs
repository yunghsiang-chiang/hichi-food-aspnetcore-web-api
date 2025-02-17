using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace hochi_food.Models;

public partial class UserReports
{
    public int report_id { get; set; }

    public string? user_id { get; set; }

    public string? report_name { get; set; }

    public string? table_name { get; set; }

    public string? chart_type { get; set; }

    public string? x_axis { get; set; }

    public string? y_axes { get; set; }  // 這個應該保持 string


    public string? category_field { get; set; }

    public string? stack_field { get; set; }

    public string? filters { get; set; }

    public DateTime? created_at { get; set; }

    public bool? is_public { get; set; }

    public string? share_code { get; set; }

    public string? shared_with { get; set; }
}
