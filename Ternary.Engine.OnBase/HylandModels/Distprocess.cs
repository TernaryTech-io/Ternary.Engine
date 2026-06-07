using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Distprocess
{
    public long Distprocessnum { get; set; }

    public string? Distprocessname { get; set; }

    public long? Isdefault { get; set; }

    public long? Flags { get; set; }
}
