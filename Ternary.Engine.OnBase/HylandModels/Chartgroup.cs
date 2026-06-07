using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Chartgroup
{
    public long Chtgroupnum { get; set; }

    public string? Chtgroupname { get; set; }

    public long? Facilitynum { get; set; }

    public long? Dptnum { get; set; }

    public long? Unitnum { get; set; }

    public long? Admittypenum { get; set; }
}
