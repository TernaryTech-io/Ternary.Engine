using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Exceptreportkey
{
    public long Itemtypenum { get; set; }

    public long Keytypenum { get; set; }

    public long Reportnum { get; set; }

    public long? Reportflags { get; set; }

    public long? Seqnum { get; set; }
}
