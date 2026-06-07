using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Dynfoldinfo
{
    public long Keytypenum { get; set; }

    public long Itemtypenum { get; set; }

    public long Foldertypenum { get; set; }

    public long? Keytypesetflags { get; set; }

    public long? Dynfoldflags { get; set; }

    public long? Keysetnum { get; set; }

    public long? Seqnum { get; set; }
}
