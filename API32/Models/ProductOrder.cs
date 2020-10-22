namespace API32.Models
{
    public class ProductOrder
    {
        public int id { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }

        public int OrderId { get; set; }

        public Orders Orders { get; set; }
        public Product Product { get; set; }
    }
}