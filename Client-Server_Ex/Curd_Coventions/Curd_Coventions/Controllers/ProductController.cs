using Curd_Coventions.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Curd_Coventions.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        CompanyContext cc;
        public ProductController(CompanyContext cc)
        {
            this.cc = cc;
        }
        [HttpGet]
        public IActionResult getproducts()
        {
            return Ok(this.cc.Products.ToList());
        }
        [HttpGet("{id}")]
        public IActionResult GetById ( Int64 id)
        {
            if(id==0)
                return BadRequest();
            var v = this.cc.Products.Find(id);
            if(v!=null)
                return Ok(v);
            else return NotFound();
        }
        [HttpPost]
        public IActionResult Create(Product rec)
        {
            if(rec==null)
                return BadRequest();
            if(ModelState.IsValid)
            {
                this.cc.Products.Add(rec);
                this.cc.SaveChanges();
                return Ok("Product Created!!");
            }
           else
                return BadRequest(ModelState);
            
        }
        [HttpPut]
        public IActionResult Edit(Product rec)
        { 
            if(rec==null)
                return BadRequest();
           this.cc.Entry(rec).State=Microsoft.EntityFrameworkCore.EntityState.Modified;
            this.cc.SaveChanges();
            return Ok("Successfully Updated!!");
        }
        [HttpPatch("{id}")]
        public IActionResult Patch(Int64 id,JsonPatchDocument<Product> patch)
        {
            if (patch==null)
                return BadRequest();
            var oldrec=this.cc.Products.Find(id);
            patch.ApplyTo(oldrec);
            this.cc.SaveChanges();
            return Ok("Product Patched!!");
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Int64 id)
        {
            if(id==0)
                return BadRequest();
            var v = this.cc.Products.Find(id);
            if(v==null)
            {
                return NotFound();
            }
            else if(v!=null)
            {
                this.cc.Products.Remove(v);
                this.cc.SaveChanges();
                return Ok("Data Deleted!!");
            }
            return BadRequest();
        }
    }
}
