using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Raaudittype
{
    public long Raaudittypenum { get; set; }

    public string? Raaudittypename { get; set; }

    public long? Numberoflevels { get; set; }

    public long? Flags { get; set; }
}
