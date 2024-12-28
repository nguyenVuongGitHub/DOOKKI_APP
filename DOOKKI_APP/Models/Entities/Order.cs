using System;
using System.Collections.Generic;

namespace DOOKKI_APP.Models.Entities;

public partial class Order
{
    public int Id { get; set; }

    public TimeOnly Time { get; set; }

    public int? CustomerId { get; set; }

    public int? Discount { get; set; }

    public bool? IsActive { get; set; }

    public int? Status { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual ICollection<Table> Tables { get; set; } = new List<Table>();
}
