using AutoMapper;
using Business.Abstract;
using Business.Utilities.AutoMapper;
using Business.Utilities.Dtos.SocialDtos;
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
        public IActionResult AddSocial(AddSocialDto socialDto)
        {
            Social s = MapperUtil<AddSocialDto, Social>.Map(socialDto);


            _socialService.TAdd(s);
            return Ok("başarılı");
        }
        [HttpDelete("delete")]
        public IActionResult DeleteSocial(Social social)
        {
            _socialService.TAdd(social);
            return Ok("başarılı");
        }

        [HttpPost("update")]
        public IActionResult UpdateSocial(UpdateSocialDto updateSocialDto)
        {
            Social s = MapperUtil<UpdateSocialDto, Social>.Map(updateSocialDto);
            s.Name = updateSocialDto.Name;
            s.Description = updateSocialDto.Description;
            s.Url = updateSocialDto.Url;
            s.Id = updateSocialDto.Id;
            s.UpdatedDate = DateTime.Now;

            _socialService.TUpdate(s);
            return Ok("başarılı");
        }
    }
}
