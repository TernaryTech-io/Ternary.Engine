using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Siglocation
{
    public long Siglocationnum { get; set; }

    public long? Itempagenum { get; set; }

    public long? Sigleft { get; set; }

    public long? Sigright { get; set; }

    public long? Sigtop { get; set; }

    public long? Sigbottom { get; set; }

    public long? Regionunits { get; set; }

    public long? Sigflags { get; set; }

    public long Seqnum { get; set; }
}
