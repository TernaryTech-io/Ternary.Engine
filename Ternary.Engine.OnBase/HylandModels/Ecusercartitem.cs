using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ecusercartitem
{
    public long Eccartitemnum { get; set; }

    public long? Ecstorenum { get; set; }

    public long? Ecusernum { get; set; }

    public long? Seqnum { get; set; }

    public long? Itemnum { get; set; }

    public long? Pagestart { get; set; }

    public long? Pageend { get; set; }

    public decimal? Ecitemcost { get; set; }

    public long? Action1num { get; set; }

    public long? Action2num { get; set; }
}
