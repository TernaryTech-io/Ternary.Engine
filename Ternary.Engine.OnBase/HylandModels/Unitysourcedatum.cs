using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Unitysourcedatum
{
    public long Unitysourcenum { get; set; }

    public long Sourceversionnum { get; set; }

    public long Seqnum { get; set; }

    public long? Unitysourcelen { get; set; }

    public string? Unitysourcetext { get; set; }
}
