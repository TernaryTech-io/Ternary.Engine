using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ufaction
{
    public long Ufactionnum { get; set; }

    public long? Ufformnum { get; set; }

    public long? Formrevnum { get; set; }

    public long? Ufactiontype { get; set; }

    public string? Targetelementkey { get; set; }

    public long? Targettype { get; set; }

    public string? Actionparam { get; set; }

    public string? Sourceelementkey { get; set; }

    public long? Sourcetype { get; set; }

    public long? Eventtype { get; set; }

    public long? Seqnum { get; set; }
}
