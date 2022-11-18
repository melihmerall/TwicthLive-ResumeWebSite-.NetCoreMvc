using AutoMapper;
using Business.Abstract;
using Business.Utilities.AutoMapper;
using Business.Utilities.Dtos.AboutDtos;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ResumeWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : Controller
    {
        private readonly IAboutService _aboutService;
        
        public AboutController(IAboutService aboutService)
        {
            this._aboutService = aboutService;
         

        }
        [HttpGet("get")]
        public ActionResult GetAllActiveAbout()
        {
            // if status = true, give me list of about.
            var abouts = _aboutService.GetList();
            return Ok(abouts);
        }

        [HttpPost("add")]
        public IActionResult AddAbout(AboutDto aboutDto)
        {
            About a = MapperUtil<AboutDto, About>.Map(aboutDto);
            _aboutService.TAdd(a);

            return Ok("Başarılı");
        }

        [HttpDelete("delete")]
        public IActionResult DeleteAbout(int id)
        {
            var about = _aboutService.GetById(id);
            _aboutService.TRemove(about);
            return Ok("başarılı");
        }

        [HttpPut("update")]
        public IActionResult UpdateAbout(UpdateAboutDto updateAboutDto)
        {
            About a = MapperUtil<UpdateAboutDto, About>.Map(updateAboutDto);

            a.Name = updateAboutDto.Name;
            a.Surname = updateAboutDto.Surname;
            a.Age = updateAboutDto.Age;
            a.BirthDate = updateAboutDto.BirthDate;
            a.Email = updateAboutDto.Email;
            a.PhoneNumber = updateAboutDto.PhoneNumber;
            a.Description = updateAboutDto.Description;
            a.Id = updateAboutDto.Id;

            _aboutService.TUpdate(a);
            return Ok("başarılı");


        }
    }
}
