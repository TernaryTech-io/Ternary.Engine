using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rulevariable
{
    public long Variablenum { get; set; }

    public string? Variablename { get; set; }

    public string? Variablevalue { get; set; }

    public long? Flags { get; set; }
}
