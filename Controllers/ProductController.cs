using Clothesstore.Context;
using Clothesstore.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Clothesstore.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private ProductsContext _context;

        public ProductController(ProductsContext products)
        {
            _context = products;
        }


        // GET: api/<ProductController>
        [HttpGet]
        public object Get()
        {
            return _context.Product.Where(b => b.name.Contains("name")).Select((c) => new
            {
                Id = c.product_id,
                Name = c.name,
                price = c.price,
                Thumbnail = c.thumbnail,
                Seller = c.seller,
                Rating = c.rating,
                Pictures = c.pictures,
                Brand = c.brand,
                City = c.city,
                Currency = c.currency,
                Description = c.description,
                DicountPercent = c.discountPercent,
                DiscountPrice = c.discountPrice

            }).ToList();
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
