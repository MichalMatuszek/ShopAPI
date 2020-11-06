using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApi
{
    public class Product
    {
        [Required]
        public string Name { get; set; }
        [Range(0, 999999)]
        public decimal Price { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public string IBan { get; set; }
    }
}
