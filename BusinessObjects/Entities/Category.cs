using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Entities
{
    public class Category
    {
        public required int CategoryId { get; set; }
        [MaxLength(50)]
        public string? CategoryName { get; set; }
        public IEnumerable<Product>? Products { get; set; }
    }
}
