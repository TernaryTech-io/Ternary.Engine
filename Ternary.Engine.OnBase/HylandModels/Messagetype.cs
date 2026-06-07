using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Messagetype
{
    public long Messagetypenum { get; set; }

    public string? Messagename { get; set; }

    public long? Flags { get; set; }
}
