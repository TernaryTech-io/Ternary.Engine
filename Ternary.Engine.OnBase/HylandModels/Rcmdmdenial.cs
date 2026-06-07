using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmdmdenial
{
    public long Rcmdmdenialnum { get; set; }

    public long? Rcmdmctgmstnum { get; set; }

    public long? Rcmclaimnum { get; set; }

    public long? Rcmrmkrefnum { get; set; }

    public long? Rcmdmversionnumber { get; set; }

    public DateTime? Closeddate { get; set; }

    public long? Rcmbasedenialnum { get; set; }

    public long? Flags { get; set; }

    public long? Rcmdmrmkrtoexpnum { get; set; }
}
