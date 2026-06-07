using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Xferconditionalkey
{
    public long? Xferpackagenum { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Keytypenum { get; set; }

    public long? Xfercondition { get; set; }

    public string? Keyvaluechar { get; set; }

    public long? Flags { get; set; }
}
