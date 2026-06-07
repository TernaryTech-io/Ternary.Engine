using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ecproduct
{
    public long Ecproductnum { get; set; }

    public string? Ecproductname { get; set; }

    public string? Ecproductdesc { get; set; }

    public long? Ecstorenum { get; set; }

    public long? Querynum { get; set; }

    public long? Flags { get; set; }

    public long? Seqnum { get; set; }

    public long? Ecdefaultactionnum { get; set; }

    public long? Ecpreviewactionnum { get; set; }
}
