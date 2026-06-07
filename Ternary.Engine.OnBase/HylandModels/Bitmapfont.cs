using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Bitmapfont
{
    public string Fontsetname { get; set; } = null!;

    public long Seqnum { get; set; }

    public long? Rotationflag { get; set; }

    public string? Bitmaprasterdata { get; set; }

    public long? Flags { get; set; }
}
