using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ResumeWebApi.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class TalentController : Controller
    {
        private readonly ITalentService _talentService;

        public TalentController(ITalentService talentService)
        {
            _talentService = talentService;
        }
        [HttpGet("get")]
        public ActionResult GetAllTalent()
        {
            var talentList = _talentService.GetList();
            return Ok(talentList);
        }

        [HttpPost("add")]
        public IActionResult AddTalent(Talent talent)
        {
            _talentService.TAdd(talent);
            return Ok("başarılı");
        }

        [HttpDelete("delete")]
        public IActionResult DeleteTalent(int id)
        {
            var talent = _talentService.GetById(id); 
            _talentService.TRemove(talent);
            return Ok("başarılı");
        }
    }
}
