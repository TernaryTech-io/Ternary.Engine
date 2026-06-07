using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Configtag
{
    public long Keykeytype { get; set; }

    public long Keynum { get; set; }

    public long? Keytypenum { get; set; }

    public string Keyvaluechar { get; set; } = null!;
}
