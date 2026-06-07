using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Gidetailproc
{
    public long Gidetailprocnum { get; set; }

    public long? Giproctypenum { get; set; }

    public string? Detailprocedure { get; set; }

    public long? Flags { get; set; }

    public long? Seqnum { get; set; }
}
