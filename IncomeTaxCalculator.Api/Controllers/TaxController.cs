using IncomeTaxCalculator.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IncomeTaxCalculator.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxController : ControllerBase
    {
        private readonly ILogger<TaxController> _logger;
        public TaxController(ILogger<TaxController> logger) 
        {
            _logger = logger;
        }

        [HttpPost]
        [Route("CalculateIncomeTax")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<IActionResult> Post([FromBody] TaxSalaryRequest taxSalaryRequest) 
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(string.Format("{0} - {1}", DateTime.Now, ex.ToString()));
                return BadRequest(ex.Message);
            }
        }
    }
}
