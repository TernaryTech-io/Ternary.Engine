using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Checkxdiskgroup
{
    public long Parsefilenum { get; set; }

    public long Institution { get; set; }

    public long? Onusdiskgroupnum { get; set; }

    public long? Trandiskgroupnum { get; set; }

    public long? Otherdiskgroupnum { get; set; }

    public long? Useother { get; set; }

    public long? Flags { get; set; }

    public long? Renddiskgroupnum { get; set; }
}
