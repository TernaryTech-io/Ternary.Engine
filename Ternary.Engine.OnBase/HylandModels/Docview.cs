using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Docview
{
    public long Docviewnum { get; set; }

    public string? Docviewname { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Seqnum { get; set; }

    public long? Flags { get; set; }
}
