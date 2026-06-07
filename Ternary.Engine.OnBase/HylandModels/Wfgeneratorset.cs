using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Wfgeneratorset
{
    public long Wfgeneratorsetnum { get; set; }

    public string? Generatorsetname { get; set; }

    public string? Generatorsetdesc { get; set; }

    public long? Flags { get; set; }
}
