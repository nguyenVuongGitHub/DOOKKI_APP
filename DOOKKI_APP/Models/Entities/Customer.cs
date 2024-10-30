using System;
using System.Collections.Generic;

namespace DOOKKI_APP.Models.Entities;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string CustomerUserName { get; set; } = null!;

    public string CustomerPassword { get; set; } = null!;

    public string CustomerPhone { get; set; } = null!;

    public string? CustomerEmail { get; set; }

    public string? CustomerAddress { get; set; }

    public string CustomerName { get; set; } = null!;

    public int? CustomerMark { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
