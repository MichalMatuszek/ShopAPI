using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShopApi.Models;

namespace Order_ShopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDiscountController : ControllerBase
    {
        public static List<Order> orders = new List<Order>();

        public async Task<List<Order>> GetDiscountOrders()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                using (var reader = await httpClient.GetAsync("http://localhost:63238/api/order"))
                {
                    var response = await reader.Content.ReadAsStringAsync();
                    orders = JsonConvert.DeserializeObject<List<Order>>(response);
                }

                foreach(var order in orders.Where(x => x.Products.Count > 1))
                {
                    order.TotalPrice = order.TotalPrice * 0.9M;
                }

                return orders;
            }
        }

    }
}