using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Statusstep
{
    public long Statusstepnum { get; set; }

    public string? Statusname { get; set; }

    public long? Scanprocessxsqnum { get; set; }

    public long? Statusnum { get; set; }

    public long? Actionnum { get; set; }

    public long? Obblobnum { get; set; }
}
