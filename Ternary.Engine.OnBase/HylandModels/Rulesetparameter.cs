using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rulesetparameter
{
    public long Rulesetnum { get; set; }

    public string Parametername { get; set; } = null!;

    public string? Parametervalue { get; set; }

    public long? Flags { get; set; }

    public long Rsversionnum { get; set; }
}
