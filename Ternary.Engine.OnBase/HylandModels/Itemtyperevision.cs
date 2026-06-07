using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Itemtyperevision
{
    public long Itemtypenum { get; set; }

    public long Itrevnum { get; set; }

    public long? Fontnum { get; set; }

    public long? Printformatnum { get; set; }

    public long? Charsperline { get; set; }

    public long? Linesperpage { get; set; }

    public long? Maxitrevnum { get; set; }

    public long? Headerlines { get; set; }

    public long? Footerlines { get; set; }
}
