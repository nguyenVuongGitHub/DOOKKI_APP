using System;
using System.Collections.Generic;

namespace DOOKKI_APP.Models.Entities;

public partial class Ticket
{
    public int TicketId { get; set; }

    public string TicketName { get; set; } = null!;

    public decimal TicketPrice { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
