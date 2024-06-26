﻿using hochi_food.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Cors;
using hochi_food.Dtos;

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
        /// 取得食材單位
        /// </summary>
        /// <returns></returns>
        [HttpGet("get_ingredients_unit")]
        public IEnumerable<c_ingredients_unit> get_ingredients_unit()
        {
            return _foodContext.c_ingredients_unit;
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
        /// 取得菜色名稱與類型
        /// </summary>
        /// <returns></returns>
        [HttpGet("get_dishes_type_name")]
        public IEnumerable<dishesNameTypeDTO> get_dishes_type_name()
        {
            var get_dishes_type_name_linq = from row in _foodContext.c_dishes
                                            select new dishesNameTypeDTO { dishes_name = row.dishes_name, dishes_type = row.dishes_type };
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
        /// 新增菜色資料
        /// </summary>
        /// <param name="dishes"></param>
        [HttpPost("appendNewdishes")]
        public void appendNewdishes([FromBody] c_dishes dishes)
        {
            _foodContext.Add(dishes);
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
