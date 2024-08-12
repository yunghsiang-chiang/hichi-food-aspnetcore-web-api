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
    public class worldController : Controller
    {
        private readonly worldContext _worldContext;   //先在全域宣告資料庫物件

        public worldController(worldContext worldContext) {
            _worldContext = worldContext;
        }

        [HttpGet]
        public IEnumerable<t_questionnaire_answers> Get()
        {
            return _worldContext.t_questionnaire_answers;
        }

        [HttpGet("Get_distinct_question")]
        public IEnumerable<questionnaire_questionDTO> Get_distinct_question()
        {
            var temp = (from row in _worldContext.t_questionnaire_answers
                       select new questionnaire_questionDTO { question = row.question }).Distinct();

            return temp;
        }
        /// <summary>
        /// 得到 問題對應 答覆資訊
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        [HttpGet("get_question_answer")]
        public IEnumerable<questionnaire_answerDTO> get_question_answer(string question)
        {
            var temp = from row in _worldContext.t_questionnaire_answers
                       where row.question == question
                       group row by row.回答 into p
                       select new questionnaire_answerDTO
                       {
                           回答 = p.Key,
                           Qty = p.Count()
                       };
            return temp;
        }

    }
}
