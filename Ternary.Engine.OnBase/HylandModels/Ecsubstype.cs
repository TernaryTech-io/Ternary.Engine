using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ecsubstype
{
    public long Ecsubstypenum { get; set; }

    public long? Ecstorenum { get; set; }

    public string? Ecname { get; set; }

    public string? Ecdesc { get; set; }

    public long? Canview { get; set; }

    public long? Canrenew { get; set; }

    public long? Seqnum { get; set; }

    public long? Flags { get; set; }

    public long? Durationtype { get; set; }

    public long? Duration { get; set; }

    public decimal? Ecprice { get; set; }

    public long? Ectokencount { get; set; }
}
