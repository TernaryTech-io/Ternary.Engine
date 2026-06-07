using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmtwbankxtwfin
{
    public long Twbankxtwfinnum { get; set; }

    public long? Rcmtwbanknum { get; set; }

    public long? Rcmtwfinnum { get; set; }

    public DateTime? Matcheddate { get; set; }

    public DateTime? Reconcileddate { get; set; }
}
