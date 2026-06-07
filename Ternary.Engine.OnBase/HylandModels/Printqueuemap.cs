using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Printqueuemap
{
    public long Pqueuenum { get; set; }

    public long Usernum { get; set; }

    public long Registernum { get; set; }

    public string? Pqueuedev { get; set; }

    public long? Pqueueland { get; set; }

    public string? Pqueueport { get; set; }

    public long? Pqueueflags { get; set; }
}
