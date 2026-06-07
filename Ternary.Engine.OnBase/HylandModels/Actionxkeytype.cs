using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Actionxkeytype
{
    public long Keytypenum { get; set; }

    public long Actionnum { get; set; }

    public long? Keywordnum { get; set; }

    public long? Keysetnum { get; set; }

    public long? Flags { get; set; }

    public string? Keyvaluechar { get; set; }
}
