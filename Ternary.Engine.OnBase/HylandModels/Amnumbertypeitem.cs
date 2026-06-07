using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Amnumbertypeitem
{
    public long Amnumtypeitemnum { get; set; }

    public long? Amnumbertypenum { get; set; }

    public long? Numberlevel { get; set; }

    public long? Numberformat { get; set; }

    public string? Amprefix { get; set; }

    public string? Amtrailing { get; set; }

    public long? Flags { get; set; }
}
