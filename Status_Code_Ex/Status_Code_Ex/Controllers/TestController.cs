using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Status_Code_Ex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult GetStatus(int id)
        {
            switch(id)
            {
                case 1: return NotFound();
                    break;

                case 2: return Created("http://www.demp.com", new {});
                    break;
                case 3: return Unauthorized();
                    break;
                case 4: return Ok();
                    break;
                case 5: return BadRequest();
                    break;
                default: return StatusCode(501);
            }
        }
    }
}
