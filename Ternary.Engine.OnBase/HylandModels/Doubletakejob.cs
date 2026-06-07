using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Doubletakejob
{
    public long? Diskgroupnum { get; set; }

    public long? Logicalplatternum { get; set; }

    public long? Sourceppnum { get; set; }

    public long? Destinationppnum { get; set; }

    public string? Doubletakejobid { get; set; }

    public long? Dtservernum { get; set; }

    public long? Flags { get; set; }
}
