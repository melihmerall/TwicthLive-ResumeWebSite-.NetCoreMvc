using Business.Abstract;
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
        public IActionResult AddLanguage(Language language)
        {
            _languageService.TAdd(language);
            return Ok("başarılı");
        }

        [HttpDelete("delete")]
        public IActionResult DeleteLanguage(int id)
        {
            var language = _languageService.GetById(id);
            _languageService.TRemove(language);
            return Ok("başarılı");
        }
    }
}
