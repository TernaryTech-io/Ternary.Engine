using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Physicalplatterpath
{
    public long Physicalplatternum { get; set; }

    public long Logicalplatternum { get; set; }

    public long Diskgroupnum { get; set; }

    public string? Lastuseddrive { get; set; }
}
