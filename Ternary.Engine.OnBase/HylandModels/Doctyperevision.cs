using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Doctyperevision
{
    public long Itemtypenum { get; set; }

    public long Itrevnum { get; set; }

    public long? Fontnum { get; set; }

    public long? Printformatnum { get; set; }

    public long? Charsperline { get; set; }

    public long? Linesperpage { get; set; }

    public long? Headerlines { get; set; }

    public long? Footerlines { get; set; }

    public long? Sigstartleft { get; set; }

    public long? Sigstarttop { get; set; }

    public long? Sigwidth { get; set; }

    public long? Sigheight { get; set; }
}
