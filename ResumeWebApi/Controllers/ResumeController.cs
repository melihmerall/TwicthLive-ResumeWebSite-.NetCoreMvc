using Business.Abstract;
using Business.Utilities.AutoMapper;
using Business.Utilities.Dtos.ResusmeDtos;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ResumeWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ResumeController : Controller
    {
        private readonly IResumeService _resumeService;
        private readonly IAboutService _aboutService;

        public ResumeController(IResumeService resumeService, IAboutService aboutService)
        {
            _resumeService = resumeService;
            _aboutService = aboutService;
        }

        [HttpGet("getAllResume")]
        public ActionResult GetAllResume()
        {
            var resumeList = _resumeService.GetList();
            
            return Ok(resumeList);
        }

        [HttpPost("add")]
        public IActionResult AddResume(AddResumeDto addResumeDto)
        {
            Resume r = MapperUtil<AddResumeDto, Resume>.Map(addResumeDto);
            _resumeService.TAdd(r);
            return Ok("başarılı");
        }

        [HttpPut("update")]
        public IActionResult UpdateResume(ResumeDto  resumeDto)
        {
            Resume r = MapperUtil<ResumeDto, Resume>.Map(resumeDto);
            r.AboutId = resumeDto.AboutId;
            r.EducationId = resumeDto.EducationId;
            r.ExperienceId = resumeDto.ExperienceId;
            r.HobbyId = resumeDto.HobbyId;
            r.LanguageId = resumeDto.LanguageId;
            r.Id = resumeDto.Id;
            r.PortfolioId = resumeDto.PortfolioId;
            r.ReferenceId = resumeDto.ReferenceId;
            r.SocialId = resumeDto.SocialId;
            r.TalentId = resumeDto.TalentId;

            _resumeService.TUpdate(r);
            return Ok("başarılı");
        }

        [HttpDelete("delete")]
        public IActionResult DeleteResume(int id)
        {
            var resume = _resumeService.GetById(id);
            _resumeService.TRemove(resume);

            return Ok("başarılı");
        }

    }
}
