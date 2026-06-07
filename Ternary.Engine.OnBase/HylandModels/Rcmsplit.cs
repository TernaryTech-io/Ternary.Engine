using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmsplit
{
    public long Rcmsplitnum { get; set; }

    public long? Parsefilenum { get; set; }

    public string? Unmatcheddir { get; set; }

    public long? Rcmsefconfignum { get; set; }

    public long? Recalculateamounts { get; set; }

    public long? Balanceamounts { get; set; }

    public string? Parsedir { get; set; }

    public string? Parsefile { get; set; }
}
