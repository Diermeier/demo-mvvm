using System.Collections.Generic;
using Demo.MVVM.Shared.Models.Sale;

namespace Demo.MVVM.Shared.Services
{
    public class SaleService
    {
        public SaleService()
        {
        }

        public Order CreateOrder()
        {
            return new Order();
        }

        public IEnumerable<Order> GetOrders()
        {
            return new Order[]
            {
                new Order() { Id = 1, OrderNumber = "First Order" },
                new Order() { Id = 2, OrderNumber = "Second Order" },
                new Order() { Id = 3, OrderNumber = "Third Order" },
            };
        }
    }
}