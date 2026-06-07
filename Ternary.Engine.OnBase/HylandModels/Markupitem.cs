using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Markupitem
{
    public long Itemnum { get; set; }

    public long Markupitemnum { get; set; }

    public long? Mindocrev { get; set; }

    public long? Maxdocrev { get; set; }

    public long? Itempagenum { get; set; }

    public long? Seqnum { get; set; }

    public string? Hashdata { get; set; }

    public long? Datatype { get; set; }
}
