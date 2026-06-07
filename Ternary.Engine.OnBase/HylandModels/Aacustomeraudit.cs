using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Aacustomeraudit
{
    public long? Masterauditnum { get; set; }

    public long? Aacustomernum { get; set; }

    public string? Tenantcustidentifier { get; set; }

    public string? Tenantcustname { get; set; }

    public long? Flags { get; set; }
}
