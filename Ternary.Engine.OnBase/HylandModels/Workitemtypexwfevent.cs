using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Workitemtypexwfevent
{
    public long Workitemtypenum { get; set; }

    public long Wfeventnum { get; set; }

    public long? Flags { get; set; }

    public long? Wfeventsource { get; set; }
}
