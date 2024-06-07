using Curd_Coventions.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Curd_Coventions.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        CompanyContext cc;
        public AuthenticationController(CompanyContext cc)
        {
            this.cc = cc;
        }
        [HttpPost]
        public IActionResult validateUser(LoginVM rec)
        {
            if (rec == null)
            {
                return BadRequest();
            }
            if(ModelState.IsValid)
            {
                var urec = this.cc.Users.SingleOrDefault(p => p.EmailId==rec.EmailId && p.Password==rec.Password);
                if (urec != null)
                {
                    //generate token
                    //first delete any old tokens
                    var oldtoken= this.cc.Tokens.Where(p => p.UserId==urec.UserId);
                    foreach(var temp in oldtoken)
                    {
                        this.cc.Tokens.Remove(temp);
                    }
                    this.cc.SaveChanges();

                    string token=Guid.NewGuid().ToString();
                    //save it
                    Token t = new Token();
                    t.UserId=urec.UserId;
                    t.TokenName=token;
                    this.cc.Tokens.Add(t);
                    this.cc.SaveChanges();
                    //return it
                    return Ok(token);
                }
                else
                {
                    return Ok("Invalid EmailId Or Password!!");
                }
            }
            return BadRequest(rec);
        }
    }
}
