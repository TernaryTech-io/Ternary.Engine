using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ecpurchaseitemhistory
{
    public long Ecpurchasenum { get; set; }

    public long? Seqnum { get; set; }

    public decimal? Itemamount { get; set; }

    public long? Ecchargetype { get; set; }

    public long? Itemnum { get; set; }

    public long? Pagestart { get; set; }

    public long? Pageend { get; set; }

    public long? Action1num { get; set; }

    public long? Action2num { get; set; }
}
