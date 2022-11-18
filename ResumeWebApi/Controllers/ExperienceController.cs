using Business.Abstract;
using Business.Utilities.AutoMapper;
using Business.Utilities.Dtos.ExperienceDtos;
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
        public IActionResult AddExperience(AddExperienceDto addExperienceDto)
        {
            Experience e = MapperUtil<AddExperienceDto, Experience>.Map(addExperienceDto);
            _experienceService.TAdd(e);
            return Ok("başarılı");
        }

        [HttpDelete("delete")]
        public IActionResult DeleteExperience(int id)
        {
            var experience = _experienceService.GetById(id);
            _experienceService.TRemove(experience);
            return Ok("Başarılı");

        }

        [HttpPut("update")]
        public IActionResult UpdateExperience(ExperienceDto experienceDto)
        {
            Experience e = MapperUtil<ExperienceDto,Experience>.Map(experienceDto);

            e.Id = experienceDto.Id;
            e.Name = experienceDto.Name;
            e.StartDate = experienceDto.StartDate;
            e.EndDate = experienceDto.EndDate;
            e.Description = experienceDto.Description;
            e.Status = experienceDto.Status;

            _experienceService.TUpdate(e);
            return Ok("başarılı");
        }
    }
}
