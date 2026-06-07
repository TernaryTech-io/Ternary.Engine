using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Dmaitem
{
    public long Itemnum { get; set; }

    public string? Oiid { get; set; }

    public DateTime? Doclastused { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Itrevnum { get; set; }
}
