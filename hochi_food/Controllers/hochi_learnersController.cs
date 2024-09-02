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
    public class hochi_learnersController : ControllerBase
    {
        private readonly hochi_configContext _hochi_configContext;

        public hochi_learnersController(hochi_configContext hochi_ConfigContext)
        {
            _hochi_configContext = hochi_ConfigContext;
        }

        [HttpGet("get_person_IdName")]
        public IEnumerable<personIdNameDTO> get_person_IdName()
        {
            var temp = from row in _hochi_configContext.c_fellow_hochi_learners
                       select new personIdNameDTO { person_id = row.person_id, person_name = row.person_name };
            return temp;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
