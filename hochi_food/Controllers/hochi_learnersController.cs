using hochi_food.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Cors;
using hochi_food.Dtos;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using Microsoft.Identity.Client;
using Org.BouncyCastle.Asn1.Crmf;

namespace hochi_food.Controllers
{
    [EnableCors("corsapp")]
    [Route("api/[controller]")]
    [ApiController]
    public class hochi_learnersController : ControllerBase
    {
        private readonly hochi_configContext _hochi_configContext;

        // 建構函式，將 hochi_configContext 的實例注入到控制器中
        public hochi_learnersController(hochi_configContext hochi_ConfigContext)
        {
            // 將注入的 hochi_configContext 賦值給私有變數 _hochi_configContext
            _hochi_configContext = hochi_ConfigContext;
        }

        // 定義一個 HTTP GET 方法，用來獲取人員的 ID 和名稱
        [HttpGet("get_person_IdName")]
        public IEnumerable<personIdNameDTO> get_person_IdName()
        {
            // 從資料庫中的 c_fellow_hochi_learners 表查詢人員的 ID 和名稱，並返回一個 DTO 的集合
            var temp = from row in _hochi_configContext.c_fellow_hochi_learners
                       select new personIdNameDTO { person_id = row.person_id, person_name = row.person_name };

            // 返回查詢結果
            return temp;
        }

        // 定義一個 HTTP GET 方法，用來獲取職員的總數
        [HttpGet("get_staff_qty")]
        public int get_staff_qty()
        {
            // 從 c_fellow_hochi_learners 表中篩選出 person_type 為 "staff" 的人員，並計算總數
            var temp = (from row in _hochi_configContext.c_fellow_hochi_learners
                        where row.person_type == "staff"
                        select row.person_id).Count();

            // 返回職員總數
            return temp;
        }

        // 定義一個 HTTP GET 方法，用來獲取同修的總數
        [HttpGet("get_disciple_qty")]
        public int get_disciple_qty()
        {
            // 從 c_fellow_hochi_learners 表中篩選出 person_type 為 "disciple" 或 "secretary" 的人員，並計算總數
            var temp = (from row in _hochi_configContext.c_fellow_hochi_learners
                        where row.person_type == "disciple" || row.person_type == "secretary"
                        select row.person_id).Count();

            // 返回職員總數
            return temp;
        }


    }
}
