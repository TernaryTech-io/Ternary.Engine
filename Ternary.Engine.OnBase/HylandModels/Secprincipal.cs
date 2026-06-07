using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Secprincipal
{
    public long Secprincipalnum { get; set; }

    public long? Secdomainnum { get; set; }

    public string? Principalname { get; set; }

    public string? Principaldn { get; set; }

    public string? Principalsid { get; set; }

    public long? Usergroupnum { get; set; }

    public long? Principaltype { get; set; }

    public long? Mappingpurpose { get; set; }

    public long? Flags { get; set; }
}
