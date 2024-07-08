using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Entities
{
    public class OrderDetail
    {
        public required int OrderId { get; set; }
        public required int ProductId { get; set; }
        public float UnitPrice { get; set; }
        public int Quantity { get; set; }
        public float Discount { get; set; }
        public Order? Order { get; set; }
        public Product? Product { get; set; }
    }
}
