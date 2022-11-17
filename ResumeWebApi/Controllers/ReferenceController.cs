using System.Security.Cryptography.Xml;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using Reference = Entities.Concrete.Reference;

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

        [HttpGet("get")]
        public IActionResult GetAllReference()
        {
            var referenceList = _referenceService.GetList();
            return Ok();
        }

        [HttpPost("add")]
        public IActionResult AddReference(Reference reference)
        {
            _referenceService.TAdd(reference);
            return Ok("başarılı");
        }
        [HttpDelete("delete")]
        public IActionResult DeleteReference(int id)
        {
            var reference = _referenceService.GetById(id);
            _referenceService.TRemove(reference);
            return Ok("başarılı");
        }


    }
}
