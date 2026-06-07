using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Spsctconfig
{
    public long Spsctconfignum { get; set; }

    public long? Itemtypenum { get; set; }

    public string? Spssiteguid { get; set; }

    public long? Spscthashnum { get; set; }

    public long? Flags { get; set; }
}
