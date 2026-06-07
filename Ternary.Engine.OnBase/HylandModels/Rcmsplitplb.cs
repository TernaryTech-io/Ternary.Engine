using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmsplitplb
{
    public long Splitplbnum { get; set; }

    public long? Splitcheckoutnum { get; set; }

    public long? Splitcheckinnum { get; set; }

    public long? Batchnum { get; set; }

    public string? Plbrefident { get; set; }

    public DateTime? Plbdate { get; set; }

    public string? Plbreason { get; set; }

    public string? Plbcomment { get; set; }

    public decimal? Plbamount { get; set; }
}
