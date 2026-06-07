using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmtwpaymentxhost
{
    public long Rcmtwpmtxhostnum { get; set; }

    public long? Rcmtwpaymentnum { get; set; }

    public long? Rcmtwhostnum { get; set; }

    public DateTime? Matcheddate { get; set; }

    public DateTime? Reconcileddate { get; set; }
}
