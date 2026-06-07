using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmsplitfileout
{
    public long Splitfileoutnum { get; set; }

    public long? Splitfileinnum { get; set; }

    public long? Batchnum { get; set; }

    public long? Claimcount { get; set; }

    public decimal? Claimpaidamount { get; set; }

    public string? Outputfile { get; set; }

    public long? Rcmbatchnum { get; set; }
}
