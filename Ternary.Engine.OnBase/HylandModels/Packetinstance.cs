using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Packetinstance
{
    public long Packetinstancenum { get; set; }

    public long? Batchnum { get; set; }

    public long? Usernum { get; set; }

    public long? Instanceflags { get; set; }

    public string? Instancekey { get; set; }

    public long? Instancestatus { get; set; }
}
