using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Girecommend
{
    public long Girecommendnum { get; set; }

    public long? Gireportnum { get; set; }

    public long? Girectypenum { get; set; }

    public string? Girecommendtext { get; set; }

    public long? Flags { get; set; }
}
