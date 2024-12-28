using System;
using System.Collections.Generic;

namespace DOOKKI_APP.Models.Entities;

public partial class Customer
{
    public int Id { get; set; }

    public string Phone { get; set; } = null!;

    public string? Email { get; set; }

    public string? Address { get; set; }

    public string Name { get; set; } = null!;

    public int? Marks { get; set; }

    public int? Idaccount { get; set; }

    public bool? IsActive { get; set; }

    public virtual Account? IdaccountNavigation { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
