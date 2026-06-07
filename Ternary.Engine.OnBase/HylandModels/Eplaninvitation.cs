using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Eplaninvitation
{
    public long Epinvitationnum { get; set; }

    public long? Ecusernum { get; set; }

    public long? Epprojectnum { get; set; }

    public string? Eprequestemail { get; set; }

    public long? Ecgroupnum { get; set; }

    public long? Status { get; set; }

    public long? Epprojectgroupnum { get; set; }

    public long? Epprivileges { get; set; }

    public string? Upperrequestemail { get; set; }
}
