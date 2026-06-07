using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Sigverifyjob
{
    public long Sigjobnum { get; set; }

    public long? Batchnum { get; set; }

    public long? Startitem { get; set; }

    public long? Enditem { get; set; }

    public long? Locked { get; set; }
}
