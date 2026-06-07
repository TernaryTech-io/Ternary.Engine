using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Idpclaimtype
{
    public long Idpclaimtypenum { get; set; }

    public string? Idpclaimtypename { get; set; }

    public string? Description { get; set; }

    public long? Flags { get; set; }
}
