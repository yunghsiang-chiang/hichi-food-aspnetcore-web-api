using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class TableSchema
{
    public int id { get; set; }

    public string? table_name { get; set; }

    public string? column_name { get; set; }

    public string? column_type { get; set; }

    public string? allowed_functions { get; set; }
}
