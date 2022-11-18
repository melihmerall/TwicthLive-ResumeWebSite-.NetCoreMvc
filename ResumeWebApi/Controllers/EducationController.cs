using Business.Abstract;
using Business.Utilities.AutoMapper;
using Business.Utilities.Dtos.EducationDtos;
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
        public IActionResult AddEducation(EducationDto educationDto)
        {
            Education e = MapperUtil<EducationDto, Education>.Map(educationDto);
            _educationService.TAdd(e);
            return Ok("başarılı");
        }

        [HttpDelete("delete")]
        public IActionResult DeleteEducation(int id)
        {

            var education =  _educationService.GetById(id);

            _educationService.TRemove(education);
            return Ok("Başarılı");
        }

        [HttpPut("update")]
        public IActionResult UpdateEducation(EducationDto educationDto)
        {
            Education e = MapperUtil<EducationDto,Education>.Map(educationDto);

            e.Description = educationDto.Description;
            e.GraduationAverage = educationDto.GraduationAverage;
            e.EndDate = educationDto.EndDate;
            e.Id = e.Id;
            e.StartDate = educationDto.StartDate;
            e.SchoolName = educationDto.SchoolName;
            e.Status = educationDto.Status;

            _educationService.TUpdate(e);

            return Ok("Başarılı");
        }

    }
}
