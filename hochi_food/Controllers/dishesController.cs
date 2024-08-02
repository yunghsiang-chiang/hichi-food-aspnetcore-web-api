using hochi_food.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Cors;
using hochi_food.Dtos;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using Microsoft.Identity.Client;

namespace hochi_food.Controllers
{
    [EnableCors("corsapp")]
    [Route("api/[controller]")]
    [ApiController]
    public class dishesController : ControllerBase
    {

        private readonly foodContext _foodContext;   //先在全域宣告資料庫物件

        public dishesController(foodContext foodcontext)
        {
            _foodContext=foodcontext;
        }

        [HttpGet]
        public IEnumerable<c_dishes> Get()
        {
            return _foodContext.c_dishes;
        }

        /// <summary>
        /// 活動名稱 Distinct
        /// </summary>
        /// <returns></returns>
        [HttpGet("get_activity_name")]
        public IEnumerable<activity_nameDTO> get_activity_name()
        {
            var activity_name_linq = (from row in _foodContext.h_activity_records
                                     select new activity_nameDTO { activity_name=row.activity_name }).Distinct();
            return activity_name_linq;
        }

        /// <summary>
        /// 取得活動歷史資料 by 活動天數
        /// </summary>
        /// <returns></returns>
        [HttpGet("get_h_activity_records_byday/{activity_days}")]
        public IEnumerable<h_activity_records> get_h_activity_records_byday(int activity_days)
        {
            return _foodContext.h_activity_records.Where(x=>x.activity_days== activity_days);
        }

        /// <summary>
        /// 取得活動歷史資料 by 活動名稱
        /// </summary>
        /// <param name="activity_name"></param>
        /// <returns></returns>
        [HttpGet("get_h_activity_records_byname/{activity_name}")]
        public IEnumerable<h_activity_records> get_h_activity_records_byname(string activity_name)
        {
            return _foodContext.h_activity_records.Where(x=>x.activity_name == activity_name);
        }

        /// <summary>
        /// 取得活動歷史資料 by 餐別
        /// </summary>
        /// <param name="mealtype"></param>
        /// <returns></returns>
        [HttpGet("get_h_activity_records_bymealtype/{meal_type}")]
        public IEnumerable<h_activity_records> get_h_activity_records_bymealtype(string meal_type) 
        {
            return _foodContext.h_activity_records.Where(x=>x.meal_type == meal_type);
        }

        /// <summary>
        /// 取得活動歷史資料 by名稱/餐別/活動天數/活動起始日/活動結束日
        /// </summary>
        /// <param name="activity_name"></param>
        /// <param name="meal_type"></param>
        /// <param name="activity_days"></param>
        /// <returns></returns>
        [HttpGet("get_h_activity_records_search")]
        public IEnumerable<activity_searchDTO> get_h_activity_records_search(string activity_name, string meal_type, string activity_days,DateTime?activity_start,DateTime?activity_end) 
        {
            var result = from row in _foodContext.h_activity_records
                         select new activity_searchDTO  { activity_name=row.activity_name,
                             activity_date=row.activity_date,
                             meal_type=row.meal_type,
                             activity_days=row.activity_days,
                             during_the_activity=row.during_the_activity,
                             lm_user=row.lm_user
                         };

            if (activity_name != "default")
            {
                result=result.Where(x => x.activity_name == activity_name);
            }
            if (meal_type != "default")
            {
                result=result.Where(x => x.meal_type == meal_type);
            }
            if (activity_days != "default")
            {
                result=result.Where(x => x.activity_days == Convert.ToInt16(activity_days));
            }
            if(activity_start != null)
            {
                result=result.Where(x=>x.activity_date >= Convert.ToDateTime(activity_start));
            }
            if (activity_end != null)
            {
                result=result.Where(x=>x.activity_date <= Convert.ToDateTime(activity_end));
            }

            return result;

        }

        /// <summary>
        /// 取得菜單資訊
        /// HID 
        /// DB Web api & DB connect   課程ID + 問卷ID
        /// 
        /// 1.問卷成立 
        /// 上傳 成功  get HID  &  慈場DB 
        /// 
        /// 方案1
        /// EDU後台 課程&問卷 setting => send 桃園慈場DB post
        /// 
        /// 方案2
        /// get web api 
        /// args  問卷ID +問卷 Title 
        ///     課程 1 2 3 4 5  ...  問卷 課程1 2 . 
        /// 
        /// 
        /// 2.回收答案
        /// 
        /// </summary>
        /// <param name="activity_name"></param>
        /// <param name="meal_type"></param>
        /// <param name="activity_days"></param>
        /// <returns></returns>
        [HttpGet("get_activity_dishes")]
        public IEnumerable<activity_dishesDTO> get_activity_dishes(string activity_name, string meal_type, string activity_date)
        {
            var data1 = from rowA in _foodContext.h_activity_records
                        where rowA.activity_name == activity_name && rowA.meal_type == meal_type && rowA.activity_date == Convert.ToDateTime(activity_date)
                        select rowA.dishes_id_str;
            try
            {
                if (!String.IsNullOrEmpty(data1.ElementAt(0).ToString()))
                {
                    string[] temp_array = data1.ElementAt(0).Split(',');
                    DataTable resultdt = new DataTable();
                    resultdt.Columns.Add("activity_name");
                    resultdt.Columns.Add("activity_date");
                    resultdt.Columns.Add("meal_type");
                    resultdt.Columns.Add("dishes_id");
                    for (int i = 0; i < temp_array.Count(); i++)
                    {
                        DataRow dataRow = resultdt.NewRow();
                        dataRow["activity_name"] = activity_name;
                        dataRow["activity_date"] = activity_date;
                        dataRow["meal_type"] = meal_type;
                        dataRow["dishes_id"] = temp_array[i];
                        resultdt.Rows.Add(dataRow);
                    }
                    var temp_linq = from row in resultdt.AsEnumerable()
                                    select new { activity_name = row.Field<string>("activity_name"), activity_date = row.Field<string>("activity_date"), meal_type = row.Field<string>("meal_type"), dishes_id = row.Field<string>("dishes_id") };
                    var dishes_linq = from row in _foodContext.c_dishes.AsEnumerable()
                                      select new { row.dishes_id, row.dishes_name, row.dishes_type };
                    var resultlinq = from rowA in temp_linq
                                     join rowB in dishes_linq
                                      on rowA.dishes_id equals rowB.dishes_id
                                     select new activity_dishesDTO { activity_name = rowA.activity_name, activity_date = rowA.activity_date, meal_type = rowA.meal_type, dishes_id = rowA.dishes_id, dishes_name = rowB.dishes_name, dishes_type = rowB.dishes_type };

                    return resultlinq;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;

            }
            
        }

        /// <summary>
        /// 取得水果
        /// </summary>
        /// <returns></returns>
        [HttpGet("get_fruits")]
        public IEnumerable<c_fruits> get_fruits()
        {
            return _foodContext.c_fruits;
        }

        /// <summary>
        /// 取得食材單位
        /// </summary>
        /// <returns></returns>
        [HttpGet("get_ingredients_unit")]
        public IEnumerable<ingredients_unitDTO> get_ingredients_unit()
        {
            var temp_linq = from row in _foodContext.c_ingredients_unit
                            orderby row.unit_type
                            select new ingredients_unitDTO { unit_chinese =row.unit_chinese , unit_english =row.unit_english , unit_type =row.unit_type , unit_description =row.unit_description };
            return temp_linq;
        }

        /// <summary>
        /// 菜色名稱 查詢 對應資訊
        /// 非模糊查詢
        /// </summary>
        /// <param name="dishesName"></param>
        /// <returns></returns>
        [HttpGet("get_dishes_by_name/{dishesName}")]
        public c_dishes get_dishes_by_name(string dishesName)
        {
            return _foodContext.c_dishes.FirstOrDefault(n=>n.dishes_name==dishesName);
        }

        /// <summary>
        /// 菜色ID查詢
        /// 前四碼 關鍵字 查詢
        /// </summary>
        /// <param name="dishes_id_like"></param>
        /// <returns></returns>
        [HttpGet("get_dishes_id_like/{dishes_id_like}")]
        public dishesIdDTO get_dishes_id_like(string dishes_id_like)
        {
            var dishes_id_last = (from row in _foodContext.c_dishes
                                 where row.dishes_id.StartsWith(dishes_id_like)
                                 orderby row.dishes_id
                                 select new dishesIdDTO { dishes_id= row.dishes_id }).LastOrDefault();
            return dishes_id_last;
        }

        /// <summary>
        /// 取得食材資訊
        /// </summary>
        /// <returns></returns>
        [HttpGet("get_food_nutrition")]
        public IEnumerable<nutritionDTO> get_food_nutrition()
        {
            var food_nutrition_linq = from row in _foodContext.c_food_nutrition
                                      select new nutritionDTO { 樣品編號 = row.樣品編號, 樣品名稱 = row.樣品名稱 };
            return food_nutrition_linq;
        }

        /// <summary>
        /// 取的食材基本欄位
        /// </summary>
        /// <param name="food_classification"></param>
        /// <returns></returns>
        [HttpGet("get_food_nutrition_simple_field")]
        public IEnumerable<food_nutrition_simple_fieldDTO> get_food_nutrition_simple_field(string food_classification)
        {
            var food_nutrition_linq = from row in _foodContext.c_food_nutrition
                                      where row.食品分類 == food_classification
                                      select new food_nutrition_simple_fieldDTO { 樣品編號 = row.樣品編號, 食品分類 = row.食品分類, 樣品名稱=row.樣品名稱, 俗名=row.俗名, 內容物描述=row.內容物描述 };
            return food_nutrition_linq;
        }

        /// <summary>
        /// 取得食材類型
        /// </summary>
        /// <returns></returns>
        [HttpGet("get_food_nutrition_category")]
        public IEnumerable<food_nutrition_categoryDTO> get_food_nutrition_category()
        {
            var food_nutrition_category_linq = (from row in _foodContext.c_food_nutrition
                                               select new food_nutrition_categoryDTO { 食品分類=row.食品分類 }).Distinct();
            return food_nutrition_category_linq;
        }

        /// <summary>
        /// 取得菜色ID、名稱與類型
        /// </summary>
        /// <returns></returns>
        [HttpGet("get_dishes_type_name")]
        public IEnumerable<dishesNameTypeDTO> get_dishes_type_name()
        {
            var get_dishes_type_name_linq = from row in _foodContext.c_dishes
                                            select new dishesNameTypeDTO { dishes_id=row.dishes_id, dishes_name = row.dishes_name, dishes_type = row.dishes_type };
            return get_dishes_type_name_linq;
        }

        /// <summary>
        /// 取得菜色定位資訊
        /// </summary>
        /// <returns></returns>
        [HttpGet("get_dishes_type")]
        public IEnumerable<c_dishes_type> get_dishes_type()
        {
            return _foodContext.c_dishes_type;
        }

        /// <summary>
        /// 取得菜色烹飪資訊
        /// </summary>
        /// <returns></returns>
        [HttpGet("get_cooking_method")]
        public IEnumerable<c_cooking_method> get_cooking_method()
        {
            return _foodContext.c_cooking_method;
        }

        /// <summary>
        /// 取得調味資訊
        /// </summary>
        /// <returns></returns>
        [HttpGet("get_seasoning")]
        public IEnumerable<c_seasoning> get_seasoning()
        {
            return _foodContext.c_seasoning;
        }

        /// <summary>
        /// 使用關鍵字 查詢 菜色資訊
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        [HttpGet("search_dishes_by_words/{words}")]
        public IEnumerable<c_dishes> search_dishes_by_words(string words) { 
            return _foodContext.c_dishes.Where(n=>n.dishes_name.Contains(words));
        }

        /// <summary>
        /// 使用關鍵字 查詢 菜色資訊
        /// </summary>
        /// <param name="material"></param>
        /// <returns></returns>
        [HttpGet("search_dishes_by_material/{material}")]
        public IEnumerable<c_dishes> search_dishes_by_material(string material)
        {
            return _foodContext.c_dishes.Where(n => n.material_id_names.Contains(material));
        }

        [HttpGet("search_dishes_by_wordsAndMaterial/{words}/{material}")]
        public IEnumerable<c_dishes> search_dishes_by_wordsAndMaterial(string words, string material) 
        {
            return _foodContext.c_dishes.Where(x=>x.dishes_name.Contains(words) && x.material_id_names.Contains(material));
        }

        /// <summary>
        /// 新增菜色資料
        /// </summary>
        /// <param name="dishes"></param>
        [HttpPost("appendNewdishes")]
        public void appendNewdishes([FromBody] c_dishes dishes)
        {
            _foodContext.Add(dishes);
            _foodContext.SaveChanges();
        }

        /// <summary>
        /// 新增歷史菜單資料c
        /// </summary>
        /// <param name="activity_records"></param>
        [HttpPost("appendActivity_records")]
        public void appendActivity_records([FromBody] h_activity_records activity_records)
        {
            _foodContext.Add(activity_records);
            _foodContext.SaveChanges();
        }



        //// GET: dishesController
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //// GET: dishesController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: dishesController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: dishesController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: dishesController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: dishesController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: dishesController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: dishesController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
