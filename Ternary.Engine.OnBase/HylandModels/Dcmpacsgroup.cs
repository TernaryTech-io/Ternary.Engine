using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Dcmpacsgroup
{
    public long Pacsgroupnum { get; set; }

    public string? Pacsgroupname { get; set; }

    public long? Diskgroupnum { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Flags { get; set; }
}
