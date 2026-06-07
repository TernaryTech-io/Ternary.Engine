using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ecaccesslevelreq
{
    public long Accesslvlreqnum { get; set; }

    public long? Ecusernum { get; set; }

    public long? Ecaccountnum { get; set; }

    public long? Accesslvltypenum { get; set; }

    public string? Ecreqreason { get; set; }

    public DateTime? Ecreqdate { get; set; }
}
