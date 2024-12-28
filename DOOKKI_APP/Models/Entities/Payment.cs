using System;
using System.Collections.Generic;

namespace DOOKKI_APP.Models.Entities;

public partial class Payment
{
    public int Id { get; set; }

    public DateOnly Day { get; set; }

    public decimal Amount { get; set; }

    public int? PaymentMethodId { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual PaymentMethod? PaymentMethod { get; set; }
}
