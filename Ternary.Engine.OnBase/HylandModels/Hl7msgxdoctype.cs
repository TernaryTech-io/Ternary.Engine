using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Hl7msgxdoctype
{
    public long Itemtypenum { get; set; }

    public long? Hl7messagenum { get; set; }

    public long? Hl7destnum { get; set; }

    public long Seqnum { get; set; }

    public long? Flags { get; set; }
}
