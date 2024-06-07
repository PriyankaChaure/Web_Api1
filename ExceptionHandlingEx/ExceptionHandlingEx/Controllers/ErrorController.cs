using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExceptionHandlingEx.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class ErrorController : ControllerBase
    {
        [HttpGet("error")]
        public IActionResult showError()
        {
            var err = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            var msg = err.Error.Message+""+err.Path;
            return Ok(msg);
        }
    }
}
