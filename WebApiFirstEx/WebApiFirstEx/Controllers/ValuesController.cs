using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiFirstEx.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public string getvalue()
        {
            return "Get Value Callled!!!!!";
        }
        [HttpPost]
        public string postvalue()
        {
            return "Post Value Callled!!!!!";
        }
        [HttpPut]
        public string putvalue()
        {
            return "put Value Callled!!!!!";
        }
        [HttpDelete]
        public string deletevalue()
        {
            return "Delete Value Callled!!!!!";
        }
    }
}
