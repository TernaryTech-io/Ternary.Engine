using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Lease
{
    public long Leasenum { get; set; }

    public long? Locktype { get; set; }

    public long? Keynum { get; set; }

    public long? Usernum { get; set; }

    public DateTime? Initiallocktime { get; set; }

    public DateTime? Lastaccesstime { get; set; }
}
