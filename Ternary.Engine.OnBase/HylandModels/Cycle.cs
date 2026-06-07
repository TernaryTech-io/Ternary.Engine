using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Cycle
{
    public long Institution { get; set; }

    public long Cyclenum { get; set; }

    public string? Cyclename { get; set; }

    public long? Cycleday { get; set; }

    public long? Cycleflag { get; set; }

    public long? Diskgroupnum { get; set; }

    public long? Logicalplatternum { get; set; }

    public long? Diskthreshold { get; set; }

    public string? Begrange { get; set; }

    public string? Endrange { get; set; }

    public long? Keytypenum { get; set; }

    public long? Tmpdiskgroupnum { get; set; }
}
