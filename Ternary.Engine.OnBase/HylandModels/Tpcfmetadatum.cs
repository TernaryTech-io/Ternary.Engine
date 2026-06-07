using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Tpcfmetadatum
{
    public long Itemnum { get; set; }

    public long Itempagenum { get; set; }

    public string? Metadatajson { get; set; }
}
