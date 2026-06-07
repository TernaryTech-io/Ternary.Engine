using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ecpurchasejoblineitem
{
    public long Ecpurchasejobnum { get; set; }

    public long Seqnum { get; set; }

    public long? Itemnum { get; set; }

    public long? Pagestart { get; set; }

    public long? Pageend { get; set; }

    public long? Lineitemstatus { get; set; }
}
