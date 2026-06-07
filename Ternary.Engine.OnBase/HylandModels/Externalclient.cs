using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Externalclient
{
    public long Externalclientnum { get; set; }

    public string? Externalclientname { get; set; }

    public long? Portalusergroupnum { get; set; }

    public long? Superusergroupnum { get; set; }

    public long? Flags { get; set; }

    public long? Billingtype { get; set; }
}
