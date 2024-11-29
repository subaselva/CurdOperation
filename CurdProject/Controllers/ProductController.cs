using CurdProject.Db;
using CurdProject.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CurdProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public ProductController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpPost]
        [Route("Create")] //Multiple returntype
        public IActionResult Create([FromBody] Product s1)
        {
            _db.Add(s1);
            _db.SaveChanges();
            return Ok(s1);
        }
        [HttpGet]
        [Route("GetAllProduct")]
        public IActionResult GetAll()
        {
            List<Product> products = new List<Product>();
            products = _db.Products.ToList();
            return Ok(products);


        }
        [HttpGet]
        [Route("GetById")]
        public IActionResult GetById(int id)
        {
            Product s1 = _db.Products.FirstOrDefault(x => x.Id == id);
            return Ok(s1);

        }
        [HttpPut]
        [Route("Update")]
        public IActionResult Update(Product s1)
        {
            _db.Update(s1);
            _db.SaveChanges();
            return Ok();
        }
        [HttpDelete]
        [Route("Delete")]
        public IActionResult DeleteById(int id)
        {
            Product s1 = _db.Products.FirstOrDefault(x => x.Id == id);
            _db.Remove(s1);
            _db.SaveChanges();
            return Ok(s1);
        }

    }
}
