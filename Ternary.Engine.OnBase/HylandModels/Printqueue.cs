using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Printqueue
{
    public long Pqueuenum { get; set; }

    public string? Pqueuename { get; set; }

    public long? Bitmapnum { get; set; }

    public long? Iconnum { get; set; }

    public long? Ptype { get; set; }

    public long? Maxpageprint { get; set; }

    public long? Flags { get; set; }

    public string? Irdtopmargin { get; set; }

    public string? Irdforwardoffset { get; set; }

    public string? Irdreturnoffset { get; set; }
}
