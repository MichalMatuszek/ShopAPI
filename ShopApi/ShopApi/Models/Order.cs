using ShopApi;
using ShopApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApi.Models
{
    public class Order
    {
        public Client Client { get; set; }
        public List<Product> Products { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
