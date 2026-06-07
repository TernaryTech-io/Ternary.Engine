using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ecstore
{
    public long Ecstorenum { get; set; }

    public string? Ecstorename { get; set; }

    public string? Storefrontcontent { get; set; }

    public decimal? Minimumcost { get; set; }

    public long? Ecchargescriptnum { get; set; }

    public long? Eccdescriptnum { get; set; }

    public long? Defaultproductnum { get; set; }

    public long? Seqnum { get; set; }

    public long? Canview { get; set; }

    public long? Flags { get; set; }
}
