using System.Security.Cryptography.Xml;
using AutoMapper;
using Business.Abstract;
using Business.Utilities.AutoMapper;
using Business.Utilities.Dtos.ReferenceDtos;
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
        public IActionResult AddReference(AddReferenceDto reference)
        {
            Reference r = MapperUtil<AddReferenceDto, Reference>.Map(reference);
            _referenceService.TAdd(r);
            return Ok("başarılı");
        }
        [HttpDelete("delete")]
        public IActionResult DeleteReference(int id)
        {
            var reference = _referenceService.GetById(id);
            _referenceService.TRemove(reference);
            return Ok("başarılı");
        }

        [HttpPut("update")]
        public IActionResult UpdateReference(UpdateReferenceDto updateReferenceDto)
        {
            Reference r = MapperUtil<UpdateReferenceDto, Reference>.Map(updateReferenceDto);
            r.JobTitle = updateReferenceDto.JobTitle;
            r.NameSurname = updateReferenceDto.NameSurname;
            r.Description = updateReferenceDto.Description;
            r.Id = updateReferenceDto.Id;
            r.UpdatedDate = DateTime.Now;
            
            _referenceService.TUpdate(r);
            return Ok("başarılı");
        }

    }
}
