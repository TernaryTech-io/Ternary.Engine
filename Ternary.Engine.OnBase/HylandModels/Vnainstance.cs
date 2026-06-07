using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Vnainstance
{
    public long Vnainstancenum { get; set; }

    public long? Vnaseriesnum { get; set; }

    public string? Sopinstanceuid { get; set; }

    public long? Vnasopclassnum { get; set; }

    public long? Vnaxfersyntaxnum { get; set; }

    public long? Dicominstancenum { get; set; }

    public long? Itemnum { get; set; }

    public long? Itempagenum { get; set; }

    public string? Hashvalue { get; set; }

    public long Vnarevnum { get; set; }

    public long? Vnarevstatus { get; set; }

    public long? Vnarevreason { get; set; }

    public DateTime? Createdate { get; set; }
}
