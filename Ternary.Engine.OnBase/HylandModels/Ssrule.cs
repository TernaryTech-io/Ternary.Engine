using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ssrule
{
    public long Subscriptionnum { get; set; }

    public long? Keytypenum { get; set; }

    public string? Keycompare { get; set; }

    public long? Booleanop { get; set; }

    public long? Connector { get; set; }

    public long Seqnum { get; set; }
}
