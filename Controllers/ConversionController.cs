using Microsoft.AspNetCore.Mvc;
using Unit_Conversion_API.Models;
using Unit_Conversion_API.Service;

namespace Unit_Conversion_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConversionController : Controller
    {
        private readonly ConversionService _service = new ConversionService();

        [HttpPost("convert")]
        public IActionResult Convert([FromBody] ConversionRequest request)
        {
            try
            {
                var result = _service.Convert(request.Value, request.FromUnit, request.ToUnit, request.Category);
                return Ok(new ConversionResponse { ConvertedValue = result, Message = "Success" });
            }
            catch (Exception ex)
            {
                return BadRequest(new ConversionResponse { Message = ex.Message });
            }
        }
    }
}
