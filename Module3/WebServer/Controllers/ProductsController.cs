using System;
using WebServer.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace WebServer.Controllers
{
    [Route("api/products")]
    public class ProductsController : Controller
    {
        [HttpGet]
        public Product[] Get()
        {
            return Repository.Products.ToArray();
        }

        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return Repository.GetProductByID(id);
        }

        [HttpPost]
        public void Post([FromBody]Product product)
        {
            Repository.AddProduct(product);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Product product)
        {
            Repository.ReplaceProductById(id, product);
        }

        [HttpPut("raise/{replaceValue}")]
        public void PutProduct(int replaceValue)
        {
            Repository.ReplaceProductsPrice(replaceValue);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Repository.RemovePersonByID(id);
        }

    }
}
