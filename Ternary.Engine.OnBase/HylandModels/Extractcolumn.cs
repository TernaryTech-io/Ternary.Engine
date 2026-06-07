using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Extractcolumn
{
    public long? Extractnum { get; set; }

    public long Columnnum { get; set; }

    public long? Seqnum { get; set; }

    public long? Rangex { get; set; }

    public long? Rangedx { get; set; }

    public long? Sortseqnum { get; set; }

    public long? Flags { get; set; }

    public string? Columnname { get; set; }

    public string? Columnheader { get; set; }
}
