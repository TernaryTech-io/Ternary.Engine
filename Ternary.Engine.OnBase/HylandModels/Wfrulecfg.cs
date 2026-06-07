using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Wfrulecfg
{
    public long Rulenum { get; set; }

    public long? Flags { get; set; }

    public string? Configxml { get; set; }

    public long Seqnum { get; set; }
}
