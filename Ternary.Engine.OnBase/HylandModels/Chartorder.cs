using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Chartorder
{
    public long Chartordernum { get; set; }

    public long? Chtnum { get; set; }

    public string? Chtordernumber { get; set; }

    public string? Accessionnum { get; set; }

    public string? Procedureinfo { get; set; }

    public DateTime? Proceduredate { get; set; }

    public string? Ordercomment { get; set; }

    public DateTime? Orderdate { get; set; }

    public long? Authphysnum { get; set; }

    public long? Orderphysnum { get; set; }

    public string? Placrorderid { get; set; }
}
