using DataAPI_ContentNegotiation_EX.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DataAPI_ContentNegotiation_EX.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataAPIController : ControllerBase
    {
        CompanyContext cc;
        public DataAPIController(CompanyContext cc)
        {
            this.cc=cc;
        }

        [HttpGet]
        public IActionResult getproducts()
        {
            return Ok(this.cc.Products.ToList());
        }
    }
}
