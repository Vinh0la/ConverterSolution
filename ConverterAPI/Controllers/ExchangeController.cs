using ConverterAPI.Service;
using Microsoft.AspNetCore.Mvc;

namespace ConverterAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExchangeController : ControllerBase
    {
        private readonly ConversionRateService _conversionRateService;

        public ExchangeController(ConversionRateService conversionRateService)
        {
            _conversionRateService = conversionRateService;
        }

        [HttpGet("usd-to-brl")]
        public async Task<IActionResult> GetUsdToBrl()
        {
            try
            {
                var conversionRate = await _conversionRateService.GetUsdToBrlRateAsync();
                return Ok(conversionRate);
            }
            catch (HttpRequestException ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
