using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class c_food_nutrition
{
    public string 樣品編號 { get; set; } = null!;

    public string 食品分類 { get; set; } = null!;

    public string 樣品名稱 { get; set; } = null!;

    public string? 俗名 { get; set; }

    public string? 內容物描述 { get; set; }
}
