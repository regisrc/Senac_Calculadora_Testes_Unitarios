using Microsoft.AspNetCore.Mvc;

namespace CalculadoraComTestes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculadoraController : ControllerBase
    {
        [HttpGet()]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}