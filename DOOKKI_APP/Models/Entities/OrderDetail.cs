using System;
using System.Collections.Generic;

namespace DOOKKI_APP.Models.Entities;

public partial class OrderDetail
{
    public int Id { get; set; }

    public decimal Quantily { get; set; }

    public int? TicketId { get; set; }

    public int? PaymentId { get; set; }

    public int? OrderId { get; set; }

    public bool? IsActive { get; set; }

    public virtual Order? Order { get; set; }

    public virtual Payment? Payment { get; set; }

    public virtual Ticket? Ticket { get; set; }
}
