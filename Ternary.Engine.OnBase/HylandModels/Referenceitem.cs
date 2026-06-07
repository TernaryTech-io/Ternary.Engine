using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Referenceitem
{
    public long Packetinstancenum { get; set; }

    public long Itemnum { get; set; }

    public long? Refitemflags { get; set; }

    public long? Refitemstatus { get; set; }

    public long? Refitemseq { get; set; }
}
