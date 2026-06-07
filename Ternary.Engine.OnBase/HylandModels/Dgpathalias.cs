using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Dgpathalias
{
    public long Diskgroupnum { get; set; }

    public long Logicalplatternum { get; set; }

    public long Physicalplatternum { get; set; }

    public string Filepath { get; set; } = null!;

    public string? Aliaspath { get; set; }
}
