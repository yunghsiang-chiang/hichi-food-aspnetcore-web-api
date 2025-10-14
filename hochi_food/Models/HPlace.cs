using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HPlace
{
    public int HID { get; set; }

    /// <summary>
    /// 大區
    /// </summary>
    public string? HLArea { get; set; }

    /// <summary>
    /// 區屬
    /// </summary>
    public string? HAreaID { get; set; }

    /// <summary>
    /// 地點層級
    /// </summary>
    public string? HPlaceLevel { get; set; }

    /// <summary>
    /// 地點名稱
    /// </summary>
    public string? HPlaceName { get; set; }

    /// <summary>
    /// 負責人
    /// </summary>
    public string? HManager { get; set; }

    /// <summary>
    /// 地址
    /// </summary>
    public string? HAddress { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
