using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rulexkeytype
{
    public long Rulenum { get; set; }

    public long Keytypenum { get; set; }

    public long? Keysetnum { get; set; }

    public string? Keyvaluechar { get; set; }

    public long? Keywordnum { get; set; }

    public long? Notblank { get; set; }

    public long? Flags { get; set; }
}
