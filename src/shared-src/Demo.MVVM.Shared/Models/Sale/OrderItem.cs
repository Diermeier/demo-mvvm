namespace Demo.MVVM.Shared.Models.Sale
{
    public class OrderItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public int? OriginProduct { get; set; }
    }
}