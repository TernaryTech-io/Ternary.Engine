using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Subscriptiontable
{
    public long Subscriptionnum { get; set; }

    public string? Subscriptionname { get; set; }

    public long? Namedaccountnum { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Attachitemtypenum { get; set; }

    public long? Ssflags { get; set; }

    public long? Queuenum { get; set; }

    public long? Institution { get; set; }

    public long? Keytypenum { get; set; }
}
