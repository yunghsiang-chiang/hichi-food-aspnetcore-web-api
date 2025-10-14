using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class OrderExportLog
{
    public int ExportID { get; set; }

    public string? SourceSystem { get; set; }

    public DateOnly? ExportStartDate { get; set; }

    public DateOnly? ExportEndDate { get; set; }

    public DateTime? ExportTime { get; set; }

    public int? TotalOrders { get; set; }

    public string? FileName { get; set; }

    public string? Remark { get; set; }
}
