using Microsoft.AspNetCore.Mvc;
using Price.Models;
using Price.Services;

namespace Price.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PriceController : ControllerBase
    {
        private readonly IPriceService _priceService;

        public PriceController(IPriceService priceService)
        {
            _priceService = priceService;
        }


        [HttpPost]
        public async Task<IActionResult> Calculate(CalculatePriceRequest request)
        {
            var result = _priceService.Calculate(request);

            return Ok(result);
        }
    }
}