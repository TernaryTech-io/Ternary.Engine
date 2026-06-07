using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Reporttype
{
    public long Reporttypenum { get; set; }

    public string? Reporttypename { get; set; }

    public long? Flags { get; set; }
}
