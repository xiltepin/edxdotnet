using System;
using WebServer.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace WebServer.Controllers
{
    [Route("api/products/price")]
    public class PricesController : Controller
    {
        [HttpGet("{firstPrice}/{secondPrice}")]
        public Product[] Get(int firstPrice, int secondPrice)
        {
            return Repository.GetProductByPrice(firstPrice, secondPrice).ToArray();
        }
    }
}