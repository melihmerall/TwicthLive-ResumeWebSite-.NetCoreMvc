using Business.Abstract;
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
        [HttpGet("api/getAllTalent")]
        public ActionResult GetAllTalent()
        {
            var talentList = _talentService.GetList();
            return Ok(talentList);
        }
    }
}
