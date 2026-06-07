using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Repcapdocmetadatum
{
    public long Rcmetadatanum { get; set; }

    public long? Rcdocumentnum { get; set; }

    public string? Rcname { get; set; }

    public string? Rcvalue { get; set; }
}
