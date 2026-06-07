using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Dgfnpathalias
{
    public long Diskgroupnum { get; set; }

    public long Logicalplatternum { get; set; }

    public long Physicalplatternum { get; set; }

    public string Filepath { get; set; } = null!;

    public long Offset { get; set; }

    public string? Aliaspath { get; set; }
}
