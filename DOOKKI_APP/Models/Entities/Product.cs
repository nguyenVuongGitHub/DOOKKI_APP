using System;
using System.Collections.Generic;

namespace DOOKKI_APP.Models.Entities;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateOnly Mfg { get; set; }

    public DateOnly Exp { get; set; }

    public int UnitInStock { get; set; }

    public int? CategoryId { get; set; }

    public bool? IsActive { get; set; }

    public virtual Category? Category { get; set; }
}
