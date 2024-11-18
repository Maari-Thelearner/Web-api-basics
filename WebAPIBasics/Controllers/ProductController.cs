using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIBasics.Models;

namespace WebAPIBasics.Controllers
{
    [RoutePrefix("api/maari")]
    public class ProductController : ApiController
    {
        /*public string Get()
        {
            return "Hello World!";
        }

        public string GetGreetings()
        {
            return "Hello Maari!";
        }*/

        /*[HttpGet]
        public string Greet()
        {
            return "Hello Marimuthu!";
        }*/


        List<Product> Products = new List<Product>()
        {
            new Product { ProductId = 1, Name = "TV", Price = 60000},
            new Product { ProductId = 2, Name = "Washing Machine", Price = 50000},
            new Product { ProductId = 3, Name = "Fridge", Price = 100000}
        };

        public IHttpActionResult GetAll()
        {
            //string[] products = { "TV", "Washing Machine", "Fridge", "Microwave" };

            return Ok(Products);
        }

        public IHttpActionResult GetProduct(int id)
        {
            //string[] products = { "TV", "Washing Machine", "Fridge", "Microwave" };

            if(id >= 0 && id <= Products.Count)
            {
                return Ok(Products[id]);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IHttpActionResult CreateProduct([FromBody] Product product)
        {
            Products.Add(product);
            return Ok(product);
        }

        [Route("product/{id}/name")]
        public IHttpActionResult GetProductName(int id)
        {
            string name = Products.Where(x => x.ProductId == id).FirstOrDefault().Name;
            return Ok(name);
        }
    }
}
