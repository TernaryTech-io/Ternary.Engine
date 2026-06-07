using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ecfailedtransaction
{
    public long Failedtxnnum { get; set; }

    public long Ecpurchasenum { get; set; }

    public string? Reasonfailed { get; set; }
}
