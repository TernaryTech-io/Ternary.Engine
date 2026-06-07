using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Blaqbatch
{
    public long Blaqprocessnum { get; set; }

    public long Batchnum { get; set; }

    public string? Batchname { get; set; }

    public long? Status { get; set; }

    public long? Flags { get; set; }
}
