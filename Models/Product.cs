using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V.ShopWithInventory.Models
{
    public class Product
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public decimal PriceForEach { get; set; }

        public int QuantityInStock { get; set; }
    }
}
