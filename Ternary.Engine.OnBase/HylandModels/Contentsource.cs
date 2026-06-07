using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Contentsource
{
    public long Ctsourcenum { get; set; }

    public string? Ctsourcename { get; set; }

    public long? Fulltextoptions { get; set; }

    public long? Maxdocsizetocrawl { get; set; }
}
