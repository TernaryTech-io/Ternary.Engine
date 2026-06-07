using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rulefunction
{
    public long Functionnum { get; set; }

    public string? Functionname { get; set; }

    public string? Functiondesc { get; set; }

    public long? Flags { get; set; }
}
