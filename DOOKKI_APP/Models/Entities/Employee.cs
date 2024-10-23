using System;
using System.Collections.Generic;

namespace DOOKKI_APP.Models.Entities;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string EmployeeName { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public decimal AmountWage { get; set; }

    public string Position { get; set; } = null!;

    public virtual ICollection<DayWork> DayWorks { get; set; } = new List<DayWork>();
}
