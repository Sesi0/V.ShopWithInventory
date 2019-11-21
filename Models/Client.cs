using System.Collections.Generic;

namespace V.ShopWithInventory.Models
{
    public class Client
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public List<Sale> Sales { get; set; }
    }
}
