using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmdmdetail
{
    public long Rcmdmdetailnum { get; set; }

    public long? Rcmdmdenialnum { get; set; }

    public long? Rcmdetailnum { get; set; }

    public long? Rcmdmctgmstnum { get; set; }

    public long? Rcmrmkrefnum { get; set; }

    public long? Flags { get; set; }

    public long? Rcmdmrmkrtoexpnum { get; set; }
}
