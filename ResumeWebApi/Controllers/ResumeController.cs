using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ResumeWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ResumeController : Controller
    {
        private readonly IResumeService _resumeService;
        private readonly IAboutService _aboutService;

        public ResumeController(IResumeService resumeService, IAboutService aboutService)
        {
            _resumeService = resumeService;
            _aboutService = aboutService;
        }

        [HttpGet("getAllResume")]
        public ActionResult GetAllResume()
        {
            var resumeList = _resumeService.GetList();
            return Ok(resumeList);
        }


    }
}
