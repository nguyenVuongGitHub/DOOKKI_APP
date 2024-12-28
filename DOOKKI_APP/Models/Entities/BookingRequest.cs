using System;
using System.Collections.Generic;

namespace DOOKKI_APP.Models.Entities;

public partial class BookingRequest
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Phone { get; set; }

    public int? NumberOfSeat { get; set; }

    public DateOnly? Date { get; set; }

    public TimeOnly? Time { get; set; }

    public string? Status { get; set; }
}
