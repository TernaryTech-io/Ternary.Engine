using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ufsecurity
{
    public long Ufformnum { get; set; }

    public long Formrevnum { get; set; }

    public string Uffieldvisualkey { get; set; } = null!;

    public long? Usergroupnum { get; set; }

    public long? Flags { get; set; }
}
