using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ResumeWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EducationController : Controller
    {
        private readonly IEducationService _educationService;

        public EducationController(IEducationService educationService)
        {
            _educationService = educationService;
        }
        [HttpGet("get")]
        public ActionResult GetAllEducation()
        {
            var educationList =  _educationService.GetList();
            return Ok(educationList);
        }

        [HttpPost("add")]
        public IActionResult AddEducation(Education education)
        {
            _educationService.TAdd(education);
            return Ok("başarılı");
        }

        [HttpDelete("delete")]
        public IActionResult DeleteEducation(int id)
        {

            var education =  _educationService.GetById(id);

            _educationService.TRemove(education);
            return Ok("Başarılı");
        }

    }
}
