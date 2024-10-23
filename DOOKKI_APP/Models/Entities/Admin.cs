using System;
using System.Collections.Generic;

namespace DOOKKI_APP.Models.Entities;

public partial class Admin
{
    public int AdminId { get; set; }

    public string AdminUserName { get; set; } = null!;

    public string AdminPassword { get; set; } = null!;

    public string AdminPhone { get; set; } = null!;

    public string AdminName { get; set; } = null!;

    public string Roles { get; set; } = null!;
}
