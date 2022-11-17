using AutoMapper;
using Business.Abstract;


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
            var abouts = _aboutService.GetList().Where(x => x.Status == true);
            return Ok(abouts);
        }

        [HttpPost("add")]
        public IActionResult AddAbout(About about)
        {
            
            _aboutService.TAdd(about);

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
        public IActionResult UpdateAbout(About about)
        {
            

            _aboutService.TUpdate(about);
            return Ok("başarılı");


        }
    }
}
