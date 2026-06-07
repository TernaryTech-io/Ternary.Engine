using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Autopubsite
{
    public long Autopubsitenum { get; set; }

    public string? Sitecode { get; set; }

    public string? Sitelocation { get; set; }

    public long? Flags { get; set; }
}
