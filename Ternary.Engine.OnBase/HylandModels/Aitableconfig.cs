using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Aitableconfig
{
    public long Aigroupnum { get; set; }

    public string? Groupdescription { get; set; }

    public long? Flags { get; set; }

    public string? Aggregateguid { get; set; }
}
