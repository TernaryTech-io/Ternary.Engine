using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Autodelrule
{
    public long Autodelrulenum { get; set; }

    public string? Rulename { get; set; }

    public long? Ruletype { get; set; }

    public long? Threshold { get; set; }

    public long? Disabled { get; set; }
}
