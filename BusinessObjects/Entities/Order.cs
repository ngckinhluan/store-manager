using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Entities
{
    public class Order
    {
        public required int OrderId { get; set; }
        public required int MemberId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }
        [MaxLength(50)]
        public string? Freight { get; set; }
        public Member? Member { get; set; }
        public IEnumerable<OrderDetail>? OrderDetails { get; set; }
    }
}
