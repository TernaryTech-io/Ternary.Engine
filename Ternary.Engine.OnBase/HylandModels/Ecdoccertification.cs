using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ecdoccertification
{
    public long Ecdoccertnum { get; set; }

    public long? Ecrestrictionnum { get; set; }

    public string? Ecname { get; set; }

    public string? Ecdesc { get; set; }

    public long? Ecdoccertaction { get; set; }

    public long? Flags { get; set; }
}
