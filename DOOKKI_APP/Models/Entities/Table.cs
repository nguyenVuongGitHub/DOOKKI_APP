﻿using System;
using System.Collections.Generic;

namespace DOOKKI_APP.Models.Entities;

public partial class Table
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public bool? Status { get; set; }

    public int? IdOrder { get; set; }

    public virtual Order? IdOrderNavigation { get; set; }
}