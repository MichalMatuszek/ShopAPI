using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ShopApi.Models;

namespace ShopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        public static List<Order> ordersList = new List<Order>();

        [HttpGet]
        [Route("{clientName}")]
        public List<Order> GetOrderByClientName(string clientName)
        {
            return ordersList.Where(x => x.Client.Name == clientName).ToList();
        }

        [HttpGet]
        public List<Order> GetOrders()
        {
            return ordersList;
        }

        [HttpPost]
        public void AddOrderForClient(Order orderToAdd)
        {
            var order = new Order()
            {
                Client = orderToAdd.Client,
                Products = orderToAdd.Products,
                TotalPrice = orderToAdd.Products.Sum(x => x.Price)
            };

            ordersList.Add(order);
        }
    }
}