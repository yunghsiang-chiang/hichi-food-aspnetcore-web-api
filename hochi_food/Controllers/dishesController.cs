using hochi_food.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Cors;

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
        [HttpGet("get_dishes_by_name/{dishesName}")]
        public c_dishes get_dishes_by_name(string dishesName)
        {
            return _foodContext.c_dishes.FirstOrDefault(n=>n.dishes_name==dishesName);
        }

        [HttpGet("get_dishes_type")]
        public IEnumerable<c_dishes_type> get_dishes_type()
        {
            return _foodContext.c_dishes_type;
        }

        [HttpGet("get_cooking_method")]
        public IEnumerable<c_cooking_method> get_cooking_method()
        {
            return _foodContext.c_cooking_method;
        }

        [HttpGet("search_dishes_by_words/{words}")]
        public IEnumerable<c_dishes> search_dishes_by_words(string words) { 
            return _foodContext.c_dishes.Where(n=>n.dishes_name.Contains(words));
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
