using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ResumeWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExperienceController : Controller
    {
        private readonly IExperienceService _experienceService;

        public ExperienceController(IExperienceService experienceService)
        {
            _experienceService = experienceService;
        }
        [HttpGet("get")]
        public ActionResult GetAllExperience()
        {

            var experienceList = _experienceService.GetList();

            return Ok(experienceList);
        }

        [HttpPost("add")]
        public IActionResult AddExperience(Experience experience)
        {
            _experienceService.TAdd(experience);
            return Ok("başarılı");
        }

        [HttpDelete("delete")]
        public IActionResult DeleteExperience(int id)
        {
            var experience = _experienceService.GetById(id);
            _experienceService.TRemove(experience);
            return Ok("Başarılı");

        }




    }
}
