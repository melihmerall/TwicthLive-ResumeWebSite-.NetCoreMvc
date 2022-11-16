using Business.Abstract;
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


    }
}
