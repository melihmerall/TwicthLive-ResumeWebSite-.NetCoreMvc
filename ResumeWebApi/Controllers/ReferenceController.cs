using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ResumeWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReferenceController : Controller
    {
        private readonly IReferenceService _referenceService;

        public ReferenceController(IReferenceService referenceService)
        {
            _referenceService = referenceService;
        }

        [HttpGet("api/getAllReference")]
        public IActionResult GetAllReference()
        {
            var referenceList = _referenceService.GetList();
            return Ok();
        }

    }
}
