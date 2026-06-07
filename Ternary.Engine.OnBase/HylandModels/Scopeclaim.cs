using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Scopeclaim
{
    public long Scopeclaimnum { get; set; }

    public long? Scopenum { get; set; }

    public long? Claimtypenum { get; set; }

    public long? Flags { get; set; }
}
