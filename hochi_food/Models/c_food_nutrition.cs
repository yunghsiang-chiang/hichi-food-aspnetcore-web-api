using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class c_food_nutrition
{
    public string 樣品編號 { get; set; } = null!;

    public string 食品分類 { get; set; } = null!;

    public string? 樣品名稱 { get; set; }

    public string? 俗名 { get; set; }

    public string? 內容物描述 { get; set; }

    public int 廢棄率___ { get; set; }

    public int 熱量_kcal_ { get; set; }

    public int 修正熱量_kcal_ { get; set; }

    public double 水分_g_ { get; set; }

    public double 粗蛋白_g_ { get; set; }

    public double 粗脂肪_g_ { get; set; }

    public double 飽和脂肪_g_ { get; set; }

    public double 灰分_g_ { get; set; }

    public double 總碳水化合物_g_ { get; set; }

    public double 膳食纖維_g_ { get; set; }

    public double 糖質總量_g_ { get; set; }

    public int 葡萄糖_g_ { get; set; }

    public int 果糖_g_ { get; set; }

    public int 半乳糖_g_ { get; set; }

    public int 麥芽糖_g_ { get; set; }

    public double 蔗糖_g_ { get; set; }

    public int 乳糖_g_ { get; set; }

    public int 鈉_mg_ { get; set; }

    public int 鉀_mg_ { get; set; }

    public int 鈣_mg_ { get; set; }

    public int 鎂_mg_ { get; set; }

    public double 鐵_mg_ { get; set; }

    public double 鋅_mg_ { get; set; }

    public int 磷_mg_ { get; set; }

    public int 銅_mg_ { get; set; }

    public int 錳_mg_ { get; set; }

    public int 維生素A總量_IU_ { get; set; }

    public int 視網醇當量_RE__ug_ { get; set; }

    public int 視網醇_ug_ { get; set; }

    public int α_胡蘿蔔素_ug_ { get; set; }

    public int β_胡蘿蔔素_ug_ { get; set; }

    public int 維生素D總量_IU_ { get; set; }

    public int 維生素D總量_ug_ { get; set; }

    public int 維生素D2_ug_ { get; set; }

    public int 維生素D3_ug_ { get; set; }

    public double 維生素E總量_mg_ { get; set; }

    public double α_維生素E當量_α_TE__mg_ { get; set; }

    public double α_生育酚_mg_ { get; set; }

    public double β_生育酚_mg_ { get; set; }

    public double γ_生育酚_mg_ { get; set; }

    public double δ_生育酚_mg_ { get; set; }

    public int 維生素K1_ug_ { get; set; }

    public int 維生素K2__MK_4__ug_ { get; set; }

    public int 維生素K2__MK_7__ug_ { get; set; }

    public double 維生素B1_mg_ { get; set; }

    public double 維生素B2_mg_ { get; set; }

    public double 菸鹼素_mg_ { get; set; }

    public double 維生素B6_mg_ { get; set; }

    public int 維生素B12_ug_ { get; set; }

    public double 葉酸_ug_ { get; set; }

    public double 維生素C_mg_ { get; set; }

    public int 脂肪酸S總量_mg_ { get; set; }

    public int 酪酸_4_0__mg_ { get; set; }

    public int 己酸_6_0__mg_ { get; set; }

    public int 辛酸_8_0__mg_ { get; set; }

    public int 癸酸_10_0__mg_ { get; set; }

    public int 月桂酸_12_0__mg_ { get; set; }

    public int 十三酸_13_0__mg_ { get; set; }

    public int 肉豆蔻酸_14_0__mg_ { get; set; }

    public int 十五酸_15_0__mg_ { get; set; }

    public int 棕櫚酸_16_0__mg_ { get; set; }

    public int 十七酸_17_0__mg_ { get; set; }

    public int 硬脂酸_18_0__mg_ { get; set; }

    public int 十九酸_19_0__mg_ { get; set; }

    public int 花生酸_20_0__mg_ { get; set; }

    public int 山酸_22_0__mg_ { get; set; }

    public int 廿四酸_24_0__mg_ { get; set; }

    public int 脂肪酸M總量_mg_ { get; set; }

    public int 肉豆蔻烯酸_14_1__mg_ { get; set; }

    public int 棕櫚烯酸_16_1__mg_ { get; set; }

    public int 油酸_18_1__mg_ { get; set; }

    public int 鱈烯酸_20_1__mg_ { get; set; }

    public int 芥子酸_22_1__mg_ { get; set; }

    public int 脂肪酸P總量_mg_ { get; set; }

    public int 亞麻油酸_18_2__mg_ { get; set; }

    public int 次亞麻油酸_18_3__mg_ { get; set; }

    public int 十八碳四烯酸_18_4__mg_ { get; set; }

    public int 花生油酸_20_4__mg_ { get; set; }

    public int 廿碳五烯酸_20_5__mg_ { get; set; }

    public int 廿二碳五烯酸_22_5__mg_ { get; set; }

    public int 廿二碳六烯酸_22_6__mg_ { get; set; }

    public int 其他脂肪酸_mg_ { get; set; }

    public string P_M_S { get; set; } = null!;

    public int 反式脂肪_mg_ { get; set; }

    public int 水解胺基酸總量_mg_ { get; set; }

    public int 天門冬胺酸_Asp__mg_ { get; set; }

    public int 酥胺酸_Thr__mg_ { get; set; }

    public int 絲胺酸_Ser__mg_ { get; set; }

    public int 麩胺酸_Glu__mg_ { get; set; }

    public int 脯胺酸_Pro__mg_ { get; set; }

    public int 甘胺酸_Gly__mg_ { get; set; }

    public int 丙胺酸_Ala__mg_ { get; set; }

    public int 胱胺酸_Cys__mg_ { get; set; }

    public int 纈胺酸_Val__mg_ { get; set; }

    public int 甲硫胺酸_Met__mg_ { get; set; }

    public int 異白胺酸_Ile__mg_ { get; set; }

    public int 白胺酸_Leu__mg_ { get; set; }

    public int 酪胺酸_Tyr__mg_ { get; set; }

    public int 苯丙胺酸_Phe__mg_ { get; set; }

    public int 離胺酸_Lys__mg_ { get; set; }

    public int 組胺酸_His__mg_ { get; set; }

    public int 精胺酸_Arg__mg_ { get; set; }

    public int 色胺酸_Trp__mg_ { get; set; }

    public int 膽固醇_mg_ { get; set; }

    public int 酒精含量_g_ { get; set; }
}
