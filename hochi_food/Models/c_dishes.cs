using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class c_dishes
{
    /// <summary>
    /// 菜品編號
    /// </summary>
    public string dishes_id { get; set; } = null!;

    /// <summary>
    /// 菜品名稱
    /// </summary>
    public string dishes_name { get; set; } = null!;

    /// <summary>
    /// 菜品類型
    /// </summary>
    public string dishes_type { get; set; } = null!;

    /// <summary>
    /// 烹飪方式 分類
    /// </summary>
    public string cooking_method { get; set; } = null!;

    /// <summary>
    /// 食材名稱 代號
    /// </summary>
    public string material_id_items { get; set; } = null!;

    /// <summary>
    /// 食材名稱 中文
    /// </summary>
    public string material_id_names { get; set; } = null!;

    /// <summary>
    /// 烹飪步驟 說明限制500字以內
    /// </summary>
    public string cooking_step { get; set; } = null!;

    /// <summary>
    /// 烹飪時間 單位:分鐘
    /// </summary>
    public int cooking_time { get; set; }

    /// <summary>
    /// 菜品照片Urls
    /// </summary>
    public string? dishes_image { get; set; }

    /// <summary>
    /// 介紹菜品
    /// </summary>
    public string? commentary { get; set; }
}
