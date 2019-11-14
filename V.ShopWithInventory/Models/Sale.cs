namespace V.ShopWithInventory.Models
{
    public class Sale
    {
        public int ID { get; set; }

        public Client Client { get; set; }

        public Product BoughtProduct { get; set; }

        public int BoughtQuantity { get; set; }
    }
}
