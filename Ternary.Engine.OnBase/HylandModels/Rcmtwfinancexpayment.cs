using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmtwfinancexpayment
{
    public long Rcmtwfinxpmtnum { get; set; }

    public long? Rcmtwfinancenum { get; set; }

    public long? Rcmtwpaymentnum { get; set; }

    public DateTime? Matcheddate { get; set; }

    public DateTime? Reconcileddate { get; set; }
}
