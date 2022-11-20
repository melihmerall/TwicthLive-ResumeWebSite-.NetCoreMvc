using Business.Abstract;
using Business.Utilities.AutoMapper;
using Business.Utilities.Dtos.PortfolioDtos;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ResumeWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PortfolioController : Controller
    {
        private readonly IPortfolioService _portfolioService;

        public PortfolioController(IPortfolioService portfolioService)
        {
            _portfolioService = portfolioService;
        }

        [HttpGet("api/getAllPortfolio")]
        public IActionResult GetAllPortfolio()
        {
            var portfolioList = _portfolioService.GetList();
            return Ok(portfolioList);
        }

        [HttpPost("add")]
        public IActionResult AddPortfol(AddPortfolioDto portfolio)
        {
            Portfolio p = MapperUtil<AddPortfolioDto, Portfolio>.Map(portfolio);
            _portfolioService.TAdd(p);
            return Ok("başarılı");
        }

        [HttpDelete("delete")]
        public IActionResult DeletePortfolio(int id)
        {
            var portfolio = _portfolioService.GetById(id);
            _portfolioService.TRemove(portfolio);
            return Ok("başarılı");
        }

        [HttpPut("update")]
        public IActionResult UpdatePortfolio(UpdatePortfolioDto updatePortfolioDto)
        {
            Portfolio p = MapperUtil<UpdatePortfolioDto, Portfolio>.Map(updatePortfolioDto);
            p.Name = updatePortfolioDto.Name;
            p.Description = updatePortfolioDto.Description;
            p.EndDate = updatePortfolioDto.EndDate;
            p.StarDate = updatePortfolioDto.StarDate;
            p.UpdatedDate = DateTime.Now;

            _portfolioService.TUpdate(p);

            return Ok("başarılı");
        }

    }
}
