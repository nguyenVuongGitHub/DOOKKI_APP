using System;
using System.Collections.Generic;

namespace DOOKKI_APP.Models.Entities;

public partial class CategoryTicket
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
