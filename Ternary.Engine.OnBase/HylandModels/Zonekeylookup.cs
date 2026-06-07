using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Zonekeylookup
{
    public long? Keytypenum { get; set; }

    public long? Zoneocrformnum { get; set; }

    public long? Seqnum { get; set; }

    public string? Ocrreadvalue { get; set; }

    public string? Appliedvalue { get; set; }

    public long? Flags { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Displaycolor { get; set; }

    public long? Suspectcolor { get; set; }

    public string? Lookuprulename { get; set; }
}
