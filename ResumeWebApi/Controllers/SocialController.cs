using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ResumeWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SocialController : Controller
    {
        private readonly ISocialService _socialService;

        public SocialController(ISocialService socialService)
        {
            _socialService = socialService;
        }

        [HttpGet("get")]
        public IActionResult GetAllSocial()
        {
            var socialList = _socialService.GetList();
            return Ok(socialList);
        }

        [HttpPost("add")]
        public IActionResult AddSocial(Social social)
        {
            _socialService.TAdd(social);
            return Ok("başarılı");
        }
        [HttpDelete("delete")]
        public IActionResult DeleteSocial(Social social)
        {
            _socialService.TAdd(social);
            return Ok("başarılı");
        }
    }
}
