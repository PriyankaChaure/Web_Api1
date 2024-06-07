using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Status_Code_Ex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StringController : ControllerBase
    {
        [HttpGet]
        public string GetString()
        {
            return "Get String Called!";
        }

        [HttpPost]
        public string PostString()
        {
            return "Post String Called!";
        }

        [HttpPut]
        public string PutString()
        {
            return "Put String Called!";
        }

        [HttpDelete]
        public string DeleteString()
        {
            return "Delete String Called!";
        }
    }
}
