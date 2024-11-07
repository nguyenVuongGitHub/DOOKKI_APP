using System;
using System.Collections.Generic;

namespace DOOKKI_APP.Models.Entities;

public partial class Order
{
    public int Id { get; set; }

    public TimeOnly Time { get; set; }

    public int? CustomerId { get; set; }

    public int? Discount { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
