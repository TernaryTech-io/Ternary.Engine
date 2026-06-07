using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Roipricingpolicyrule
{
    public long Pricingrulenum { get; set; }

    public long? Pricingpolicynum { get; set; }

    public string? Pricingrulename { get; set; }

    public long? Pricingruletype { get; set; }

    public long? Pricingcost { get; set; }

    public long? Startpage { get; set; }

    public long? Endpage { get; set; }

    public long? Flags { get; set; }
}
