using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Extractfilter
{
    public long Extractnum { get; set; }

    public long Columnnum { get; set; }

    public string? Keyvaluechar { get; set; }

    public long? Flags { get; set; }
}
