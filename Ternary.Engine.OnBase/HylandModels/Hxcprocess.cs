using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Hxcprocess
{
    public long Hxcprocessnum { get; set; }

    public long? Diskgroupnum { get; set; }

    public long? Scanqueuenum { get; set; }

    public long? Scanqueuestatus { get; set; }

    public long? Processingflags { get; set; }

    public string? Hxcprocessname { get; set; }
}
