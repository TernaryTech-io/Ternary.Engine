using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ecdocassembly
{
    public long Ecdocassemblynum { get; set; }

    public string? Ecname { get; set; }

    public string? Ecassemblyfile { get; set; }

    public long? Ecinsertpage { get; set; }

    public long? Ecinsertlocation { get; set; }

    public long? Ecstartpage { get; set; }

    public long? Ecendpage { get; set; }
}
