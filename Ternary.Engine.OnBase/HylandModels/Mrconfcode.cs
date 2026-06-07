using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mrconfcode
{
    public long Confcodenum { get; set; }

    public string? Confcode { get; set; }

    public string? Confcodedesc { get; set; }

    public long? Flags { get; set; }
}
