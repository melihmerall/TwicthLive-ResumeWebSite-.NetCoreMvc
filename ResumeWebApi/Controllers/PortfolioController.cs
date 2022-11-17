using Business.Abstract;
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
        public IActionResult AddPortfol(Portfolio portfolio)
        {
            _portfolioService.TAdd(portfolio);
            return Ok("başarılı");
        }

        [HttpDelete("delete")]
        public IActionResult DeletePortfolio(int id)
        {
            var portfolio = _portfolioService.GetById(id);
            _portfolioService.TRemove(portfolio);
            return Ok("başarılı");
        }


    }
}
