using Curd_Coventions.Models;
using Microsoft.AspNetCore.Http;
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
        /// <summary>
        /// This is used for to call get product
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult getproducts()
        {
            return Ok(this.cc.Products.ToList());
        }
        /// <summary>
        /// This is used for get id 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
        /// <summary>
        /// This is used for create
        /// </summary>
        /// <param name="rec"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Create(Product rec)
        {
            if(rec==null)
                return BadRequest();
           this.cc.Products.Add(rec);
            this.cc.SaveChanges();
            return Ok("Product Created!!");
        }
        /// <summary>
        /// This is used for Edit
        /// </summary>
        /// <param name="rec"></param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult Edit(Product rec)
        { 
            if(rec==null)
                return BadRequest();
           this.cc.Entry(rec).State=Microsoft.EntityFrameworkCore.EntityState.Modified;
            this.cc.SaveChanges();
            return Ok("Successfully Updated!!");
        }
        /// <summary>
        /// This is used for Delete
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
