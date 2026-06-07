using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Gicondition
{
    public long Giconditionnum { get; set; }

    public long? Giexpressionnum { get; set; }

    public string? Conditionkey { get; set; }

    public long? Flags { get; set; }

    public long? Giconditiontype { get; set; }

    public string? Giconditionvalue { get; set; }
}
