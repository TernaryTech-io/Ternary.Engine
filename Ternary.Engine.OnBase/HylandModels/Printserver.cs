using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Printserver
{
    public long Pqueuenum { get; set; }

    public long Registernum { get; set; }

    public long? Printserverflags { get; set; }
}
