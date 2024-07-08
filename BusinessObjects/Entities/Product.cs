using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Entities
{
    public class Product
    {
        public required int ProductId { get; set; }
        [MaxLength(255)]
        public string? ProductName { get; set; }
        public required int CategoryId { get; set; }
        public float Weight { get; set; }
        public float UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public Category? Category { get; set; }
        public IEnumerable<OrderDetail>? OrderDetails { get; set; }

    }
}
