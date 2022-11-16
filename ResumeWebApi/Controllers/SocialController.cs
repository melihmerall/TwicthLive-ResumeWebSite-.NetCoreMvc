using Business.Abstract;
using DataAccess.Abstract;
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

        [HttpGet("api/getAllSocial")]
        public IActionResult GetAllSocial()
        {
            var socialList = _socialService.GetList();
            return Ok(socialList);
        }
    }
}
