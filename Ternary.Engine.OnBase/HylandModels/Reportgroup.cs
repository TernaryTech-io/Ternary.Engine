using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Reportgroup
{
    public long Reportgroupnum { get; set; }

    public string? Reportgroupname { get; set; }

    public long? Defaultdate { get; set; }

    public string? Pagestring { get; set; }

    public long? Reportgroupflags { get; set; }

    public long? Pqueuenum { get; set; }

    public long? Printformatnum { get; set; }
}
