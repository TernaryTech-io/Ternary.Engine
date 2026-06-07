using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcm835expov
{
    public long Rcm835expovnum { get; set; }

    public long? Rcm835exportnum { get; set; }

    public long? Loop { get; set; }

    public string? Segment { get; set; }

    public long? Isoverride { get; set; }

    public long? Flags { get; set; }
}
