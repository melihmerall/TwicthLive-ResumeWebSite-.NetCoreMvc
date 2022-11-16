using DataAccess.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ResumeWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LanguageController : Controller
    {
        private readonly ILanguageDal _languageDal;

        public LanguageController(ILanguageDal languageDal)
        {
            _languageDal = languageDal;
        }

        [HttpGet("api/getAllLanguageByLevel")]
        public ActionResult GetAllLanguageByLevel(string level)
        {
            var languageList = _languageDal.Get(x => x.Level == level);
            return Ok(languageList);
        }
    }
}
