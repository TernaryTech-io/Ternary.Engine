using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmtwfinancexhost
{
    public long Rcmtwfinxhostnum { get; set; }

    public long? Rcmtwfinancenum { get; set; }

    public long? Rcmtwhostnum { get; set; }

    public DateTime? Matcheddate { get; set; }

    public DateTime? Reconcileddate { get; set; }
}
