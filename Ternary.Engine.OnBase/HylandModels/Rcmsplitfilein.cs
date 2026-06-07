using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmsplitfilein
{
    public long Splitfileinnum { get; set; }

    public long? Rcmsplitnum { get; set; }

    public long? Batchnum { get; set; }

    public string? Inputfile { get; set; }

    public DateTime? Processdate { get; set; }

    public DateTime? Interchangedate { get; set; }

    public long? Claimcount { get; set; }

    public decimal? Claimpaidamount { get; set; }
}
