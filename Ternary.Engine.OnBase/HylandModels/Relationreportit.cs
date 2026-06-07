using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Relationreportit
{
    public long Itemtypenum { get; set; }

    public long Reportnum { get; set; }

    public long? Tickdays { get; set; }

    public long? Waitdays { get; set; }

    public string? Keyvaluechar { get; set; }
}
