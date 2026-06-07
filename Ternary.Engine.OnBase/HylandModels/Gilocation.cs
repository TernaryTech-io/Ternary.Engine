using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Gilocation
{
    public long Gilocationnum { get; set; }

    public long? Parentlocationnum { get; set; }

    public string? Gilocationname { get; set; }

    public long? Seqnum { get; set; }

    public long? Flags { get; set; }

    public long? Giproctypenum { get; set; }
}
