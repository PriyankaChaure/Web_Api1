using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExceptionHandlingEx.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MathController : ControllerBase
    {
        [HttpGet("{a}/{b}")]
        public IActionResult getdivision(int a, int b)
        {
            int c = a/b;
            return Ok(c);
        }
    }
}
