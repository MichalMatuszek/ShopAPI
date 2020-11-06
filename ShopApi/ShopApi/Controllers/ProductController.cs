using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopApi.Models;

namespace ShopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public static List<Product> productsList = new List<Product>();
        [HttpGet]
        public List<Product> GetProducts()
        {
            return productsList;
        }

        [HttpPost]
        public void AddProduct(Product productToAdd)
        {
            var product = new Product()
            {
                Name = productToAdd.Name,
                Price = productToAdd.Price,
                Color = productToAdd.Color,
                IBan = productToAdd.IBan
            };
            
            productsList.Add(product);
        }

    }
}