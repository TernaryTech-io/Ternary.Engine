using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ectokentype
{
    public long Ectokentypenum { get; set; }

    public long? Ecstorenum { get; set; }

    public string? Ecname { get; set; }

    public string? Ecdesc { get; set; }

    public long? Ectokencount { get; set; }

    public decimal? Ecprice { get; set; }

    public long? Canview { get; set; }

    public long? Seqnum { get; set; }

    public long? Flags { get; set; }
}
