using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Wfactioncfg
{
    public long Actionnum { get; set; }

    public long? Flags { get; set; }

    public string? Configxml { get; set; }

    public long Seqnum { get; set; }
}
