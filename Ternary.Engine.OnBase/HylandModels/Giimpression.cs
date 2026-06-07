using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Giimpression
{
    public long Giimpressionnum { get; set; }

    public long? Gireportnum { get; set; }

    public long? Gifindtypenum { get; set; }

    public long? Gifindingnum { get; set; }

    public string? Giimpressiontext { get; set; }

    public long? Flags { get; set; }

    public long? Giimpresstypenum { get; set; }
}
