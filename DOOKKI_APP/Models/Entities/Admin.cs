using System;
using System.Collections.Generic;

namespace DOOKKI_APP.Models.Entities;

public partial class Admin
{
    public int Id { get; set; }

    public string Phone { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int? Idaccount { get; set; }

    public virtual Account? IdaccountNavigation { get; set; }
}
