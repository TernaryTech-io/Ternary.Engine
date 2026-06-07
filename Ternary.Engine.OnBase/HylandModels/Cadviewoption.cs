using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Cadviewoption
{
    public long Usernum { get; set; }

    public long? Displayflags { get; set; }

    public long? Scalerotateflags { get; set; }

    public string? Scalefactor { get; set; }

    public long? Showflags { get; set; }

    public long? Gridflags { get; set; }

    public string? Gridspacing { get; set; }

    public long? Gridspacingdim { get; set; }

    public long? Gridcolor { get; set; }

    public string? Scrollstepsize { get; set; }

    public string? Zoomstepsize { get; set; }
}
