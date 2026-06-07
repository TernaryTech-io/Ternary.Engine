using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Scheventitem
{
    public long Eventkey { get; set; }

    public long Eventtype { get; set; }

    public long Eventnum { get; set; }

    public long? Registernum { get; set; }

    public long? Eventflags { get; set; }

    public long? Seqnum { get; set; }
}
