using System;
using System.Collections.Generic;

namespace DOOKKI_APP.Models.Entities;

public partial class DayWork
{
    public int Id { get; set; }

    public int? TimeWork { get; set; }

    public DateOnly? Day { get; set; }

    public int? EmployeeId { get; set; }

    public bool? IsActive { get; set; }

    public virtual Employee? Employee { get; set; }
}
