﻿using System;
using System.Collections.Generic;

namespace DOOKKI_APP.Models.Entities;

public partial class Ticket
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public decimal Price { get; set; }

    public bool? IsActive { get; set; }

    public int? IdCategory { get; set; }

    public virtual CategoryTicket? IdCategoryNavigation { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
