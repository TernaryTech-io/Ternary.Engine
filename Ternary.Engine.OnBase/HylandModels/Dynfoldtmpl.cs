using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Dynfoldtmpl
{
    public long Seqnum { get; set; }

    public long Foldertypenum { get; set; }

    public long? Itemtypenum { get; set; }

    public string? Itemname { get; set; }

    public long? Flags { get; set; }

    public long? Templatenum { get; set; }
}
