using Business.Abstract;
using Business.Utilities.AutoMapper;
using Business.Utilities.Dtos.HobbyDtos;
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
        public IActionResult GetHobbyById(int id)
        {
            var hobbById = hobbyService.GetById(id);

            return Ok(hobbById);
        }

        [HttpPost("AddHobby")]
        public IActionResult AddHobby(AddHobbyDto addHobbyDto)
        {
            Hobby h = MapperUtil<AddHobbyDto, Hobby>.Map(addHobbyDto);
            h.CreatedDate=DateTime.Now;
            hobbyService.TAdd(h);
            return Ok("başarılı");
        }

        [HttpDelete("delete")]
        public IActionResult DeleteHobby(int id)
        {
            var hobby = hobbyService.GetById(id);
            hobbyService.TRemove(hobby);
            return Ok("başarılı");
        }
        
        [HttpPut("update")]
        public IActionResult UpdateHobby(UpdateHobbyDto updateHobbyDto)
        {
            Hobby h = MapperUtil<UpdateHobbyDto, Hobby>.Map(updateHobbyDto);
            h.Name = updateHobbyDto.Name;
            h.Description = updateHobbyDto.Description;
            h.Status = updateHobbyDto.Status;
            h.Id = updateHobbyDto.Id;
            h.Status = updateHobbyDto.Status;

            hobbyService.TUpdate(h);
            
            return Ok("başarılı");
        }
    }
}
