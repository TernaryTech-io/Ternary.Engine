using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ruleclass
{
    public long Ruleclassnum { get; set; }

    public string? Ruleclasstype { get; set; }

    public string? Progid { get; set; }

    public string? Methodinit { get; set; }

    public string? Methodvalue { get; set; }

    public string? Methodvaluelist { get; set; }

    public long? Flags { get; set; }

    public string? Methodsetvalue { get; set; }
}
