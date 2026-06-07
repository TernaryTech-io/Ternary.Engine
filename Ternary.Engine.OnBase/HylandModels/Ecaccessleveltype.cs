using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ecaccessleveltype
{
    public long Accesslvltypenum { get; set; }

    public string? Ecname { get; set; }

    public string? Ecdesc { get; set; }

    public string? Eckeyrefname { get; set; }

    public long? Flags { get; set; }

    public long? Canview { get; set; }
}
