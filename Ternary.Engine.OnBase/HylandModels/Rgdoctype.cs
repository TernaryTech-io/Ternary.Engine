using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rgdoctype
{
    public long Readinggroupnum { get; set; }

    public long Itemtypenum { get; set; }

    public long? Primaryagnum { get; set; }

    public long? Secondaryagnum { get; set; }
}
