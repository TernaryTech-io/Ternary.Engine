using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Omrtable
{
    public long Omrnum { get; set; }

    public string? Omrname { get; set; }

    public long? Numcols { get; set; }

    public long? Thickness { get; set; }

    public long? Vertspace { get; set; }

    public long? Horizspace { get; set; }

    public long? Markwidth { get; set; }

    public long? Printflag { get; set; }
}
