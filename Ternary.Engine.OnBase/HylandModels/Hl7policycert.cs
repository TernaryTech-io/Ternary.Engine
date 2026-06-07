using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Hl7policycert
{
    public long? Hl7policynum { get; set; }

    public string? Hl7certthumbprint { get; set; }

    public long? Hl7certtype { get; set; }

    public long? Flags { get; set; }
}
