using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcm835exploader
{
    public long Rcm835expldrnum { get; set; }

    public long? Rcm835exportnum { get; set; }

    public long? Rcmpayornum { get; set; }

    public string? Loadername { get; set; }
}
