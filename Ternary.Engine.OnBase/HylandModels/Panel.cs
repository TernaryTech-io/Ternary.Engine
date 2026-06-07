using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Panel
{
    public long Panelnum { get; set; }

    public string? Panelname { get; set; }

    public string? Paneldesc { get; set; }

    public string? Panelhelp { get; set; }

    public long? Xloc { get; set; }

    public long? Xsize { get; set; }

    public long? Yloc { get; set; }

    public long? Ysize { get; set; }
}
