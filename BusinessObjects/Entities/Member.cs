using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Entities
{
    public class Member
    {
        public required int MemberId { get; set; }
        [MaxLength(255)]
        public required string Email { get; set; }
        [MaxLength(255)]
        public required string Password { get; set; }
        [MaxLength(255)]
        public required string FirstName { get; set; }
        [MaxLength(255)]
        public required string LastName { get; set; }
        [MaxLength(255)]
        public required string UserName { get; set; }
        [MaxLength(50)]
        public string? Country { get; set; }
        [MaxLength(50)]
        public string? City { get; set; }
        public IEnumerable<Order>? Orders  { get; set; }
    }
}
