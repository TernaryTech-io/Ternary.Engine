using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Functionparam
{
    public long? Functionnum { get; set; }

    public string? Parametername { get; set; }

    public string? Parameterdesc { get; set; }

    public long? Seqnum { get; set; }

    public long? Flags { get; set; }
}
