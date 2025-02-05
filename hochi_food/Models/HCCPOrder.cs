using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HCCPOrder
{
    public int HID { get; set; }

    public string? HCCPOrderCode { get; set; }

    public string? HCCPImportNum { get; set; }

    public string? HRemark { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }

    /// <summary>
    /// 是否為紙本
    /// </summary>
    public int? HPaperYN { get; set; }
}
