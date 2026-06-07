using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Obmacrostep
{
    public long Obmacronum { get; set; }

    public long? Action { get; set; }

    public long? Virtkey { get; set; }

    public long Seqnum { get; set; }

    public long? Flags { get; set; }
}
