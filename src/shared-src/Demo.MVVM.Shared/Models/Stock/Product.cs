namespace Demo.MVVM.Shared.Models.Stock
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int NumberInStock { get; set; }
        
        public bool IsInStock => NumberInStock > 0;
    }
}