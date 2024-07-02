using System;
using System.Collections.Generic;

namespace BusinessObjects.Entities;

public partial class Member
{
    public int MemberId { get; set; }

    public string? Email { get; set; }

    public string? CompanyName { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
