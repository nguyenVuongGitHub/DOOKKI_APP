using System;
using System.Collections.Generic;

namespace DOOKKI_APP.Models.Entities;

public partial class PaymentMethod
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public bool? IsActive { get; set; }

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
}
