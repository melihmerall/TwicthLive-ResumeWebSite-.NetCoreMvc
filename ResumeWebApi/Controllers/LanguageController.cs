using AutoMapper;
using Business.Abstract;
using Business.Utilities.AutoMapper;
using Business.Utilities.Dtos.LanguageDtos;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ResumeWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LanguageController : Controller
    {
        private readonly ILanguageService _languageService;

        public LanguageController(ILanguageService languageService)
        {
            _languageService = languageService;
        }

        [HttpGet("api/getAllLanguageByLevel")]
        public ActionResult GetAllLanguageByLevel()
        {
            var languageList = _languageService.GetList();
            return Ok(languageList);
        }

        [HttpPost("add")]
        public IActionResult AddLanguage(AddLanguageDto languageDto)
        {
            Language l = MapperUtil<AddLanguageDto, Language>.Map(languageDto);
            _languageService.TAdd(l);
            return Ok("başarılı");
        }

        [HttpDelete("delete")]
        public IActionResult DeleteLanguage(int id)
        {
            var language = _languageService.GetById(id);
            _languageService.TRemove(language);
            return Ok("başarılı");
        }

        [HttpPut("update")]
        public IActionResult UpdateLanguage(UpdateLanguageDto updateLanguageDto)
        {
            Language l = MapperUtil<UpdateLanguageDto, Language>.Map(updateLanguageDto);

            l.Name = updateLanguageDto.Name;
            l.Level = updateLanguageDto.Level;
            l.Description = updateLanguageDto.Description;
            l.Id = updateLanguageDto.Id;
            l.UpdatedDate = DateTime.Now;

            _languageService.TUpdate(l);
       
            return Ok("başarılı");
        }
    }
}
