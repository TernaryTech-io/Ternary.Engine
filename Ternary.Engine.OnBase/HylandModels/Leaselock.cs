using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Leaselock
{
    public long? Locktype { get; set; }

    public long? Keynum { get; set; }

    public DateTime? Lastaccesstime { get; set; }

    public long? Usernum { get; set; }

    public DateTime? Initiallocktime { get; set; }

    public long Lockid { get; set; }
}
