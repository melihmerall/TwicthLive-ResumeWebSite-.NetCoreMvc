using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ResumeWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HobbyController : Controller
    {
        private readonly IHobbyService hobbyService;

        public HobbyController(IHobbyService hobbyService)
        {
            this.hobbyService = hobbyService;
        }

        [HttpGet("api/getAllHobby")]
        public ActionResult GetAllHobby()
        {
            var hobbyList = hobbyService.GetList();
            return Ok(hobbyList);
        }
        [HttpGet("api/getHobbById")]
        public ActionResult GetHobbyById(int id)
        {
            var hobbById = hobbyService.GetById(id);

            return Ok(hobbById);
        }

        [HttpPost("AddHobby")]
        public IActionResult AddHobby(Hobby hobby)
        {
            hobbyService.TAdd(hobby);
            return Ok("başarılı");
        }

        [HttpDelete("delete")]
        public IActionResult DeleteHobby(int id)
        {
            var hobby = hobbyService.GetById(id);
            hobbyService.TRemove(hobby);
            return Ok("başarılı");
        }
    }
}
