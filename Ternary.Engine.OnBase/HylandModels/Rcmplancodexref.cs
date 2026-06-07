using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmplancodexref
{
    public long Rcmpcxrefnum { get; set; }

    public long? Rcmfacilitynum { get; set; }

    public string? Rcmplancode { get; set; }

    public string? Rcmtargetplancode { get; set; }
}
