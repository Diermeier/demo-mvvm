using System;

namespace Demo.MVVM.Shared.Models.Sale
{
    public class Order
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }  
        public DateTime OrderCreatedDate { get; set; }
        public DateTime? OrderClosedDate { get; set; }

        public bool IsReadOnly => OrderClosedDate.HasValue;
    }
}