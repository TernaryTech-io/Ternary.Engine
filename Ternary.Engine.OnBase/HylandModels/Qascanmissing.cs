using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Qascanmissing
{
    public long Batchnum { get; set; }

    public long Itemnum { get; set; }

    public long Itempagenum { get; set; }

    public long? Pagecount { get; set; }

    public string? Notetext { get; set; }
}
