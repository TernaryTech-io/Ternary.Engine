using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Reportgroupkey
{
    public long Keytypenum { get; set; }

    public long Reportgroupnum { get; set; }

    public string Defaultkeywordvalue { get; set; } = null!;
}
