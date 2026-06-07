using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Giindicationtype
{
    public long Giindicattypenum { get; set; }

    public long? Giproctypenum { get; set; }

    public string? Indicationtype { get; set; }

    public long? Flags { get; set; }

    public string? Indicationtext { get; set; }

    public long? Seqnum { get; set; }
}
