using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Recipientxdist
{
    public long Recipientnum { get; set; }

    public long Distprocessnum { get; set; }

    public string Idkeywords { get; set; } = null!;

    public long? Distributionflags { get; set; }

    public long? Numbercopies { get; set; }

    public long? Stmtdelivinfonum { get; set; }

    public long? Processclassnum { get; set; }

    public string? Customerid { get; set; }

    public string? Sitecode { get; set; }

    public long? Accounts { get; set; }
}
