using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Zoneocrdoc
{
    public long Itemnum { get; set; }

    public long? Batchnum { get; set; }

    public long? Zoneocrformnum { get; set; }

    public long? Offsetx { get; set; }

    public long? Offsety { get; set; }

    public long? Identfields { get; set; }

    public long? Suspectfields { get; set; }

    public long? Origitemtype { get; set; }

    public long? Locked { get; set; }

    public string? Scalefactor { get; set; }

    public long? Correctedfields { get; set; }

    public long? Duration { get; set; }
}
