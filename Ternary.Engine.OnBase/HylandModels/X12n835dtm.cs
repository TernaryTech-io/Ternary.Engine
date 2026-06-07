using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class X12n835dtm
{
    public long? Batchnum { get; set; }

    public long? St835num { get; set; }

    public long? Clp835num { get; set; }

    public long? Svc835num { get; set; }

    public string? Loopid { get; set; }

    public long? Segposition { get; set; }

    public long? Setposition { get; set; }

    public string? Dtm01dateq { get; set; }

    public DateTime? Dtm02date { get; set; }
}
