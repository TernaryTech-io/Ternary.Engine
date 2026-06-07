using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Scanqueuexit
{
    public long Queuenum { get; set; }

    public long Itemtypenum { get; set; }

    public long? Itemnum { get; set; }

    public long? Itrevnum { get; set; }

    public long? Keysetnum { get; set; }

    public long? Sqitflags { get; set; }

    public long? Topxcrop { get; set; }

    public long? Bottomxcrop { get; set; }

    public long? Topycrop { get; set; }

    public long? Bottomycrop { get; set; }

    public long? Seqnum { get; set; }

    public long? Emrflags { get; set; }
}
