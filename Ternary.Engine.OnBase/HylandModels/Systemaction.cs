using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Systemaction
{
    public long Sysactionnum { get; set; }

    public string? Sysactionname { get; set; }

    public long? Bitmapnum { get; set; }

    public long? Iconnum { get; set; }

    public long? Lcnum { get; set; }

    public string? Helptext { get; set; }

    public long? Seqnum { get; set; }

    public long? Flags { get; set; }
}
