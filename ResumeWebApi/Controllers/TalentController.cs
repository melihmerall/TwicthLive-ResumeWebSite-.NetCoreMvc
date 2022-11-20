using AutoMapper;
using Business.Abstract;
using Business.Utilities.AutoMapper;
using Business.Utilities.Dtos.TalentDtos;
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
        public IActionResult AddTalent(AddTalentDto talent)
        {
            Talent t = MapperUtil<AddTalentDto, Talent>.Map(talent);
            _talentService.TAdd(t);
            return Ok("başarılı");
        }

        [HttpDelete("delete")]
        public IActionResult DeleteTalent(int id)
        {
            var talent = _talentService.GetById(id); 
            _talentService.TRemove(talent);
            return Ok("başarılı");
        }

        [HttpPut("update")]
        public IActionResult UpdateTalent(UpdateTalentDto updateTalentDto)
        {
            Talent t = MapperUtil<UpdateTalentDto,Talent>.Map(updateTalentDto);
            t.Name = updateTalentDto.Name;
            t.Rate = updateTalentDto.Rate;
            t.Description = updateTalentDto.Description;
            t.UpdatedDate = DateTime.Now;
            t.Id = updateTalentDto.Id;
            _talentService.TUpdate(t);
            return Ok();
        }
    }
}
