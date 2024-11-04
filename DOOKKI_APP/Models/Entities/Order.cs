using System;
using System.Collections.Generic;

namespace DOOKKI_APP.Models.Entities;

public partial class Order
{
    public int OrderId { get; set; }

    public TimeOnly OrderTime { get; set; }

    public int? CustomerId { get; set; }

    public int? Discount { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
