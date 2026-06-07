using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Xferkeytypemap
{
    public long? Xferpackagenum { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Keytypenum { get; set; }

    public long? Reckeytypenum { get; set; }

    public string? Reckeytypename { get; set; }

    public long? Fieldrequired { get; set; }

    public string? Defaultvalue { get; set; }

    public long? Defaultflags { get; set; }
}
