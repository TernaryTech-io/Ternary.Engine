using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmsplitcheckin
{
    public long Splitcheckinnum { get; set; }

    public long? Splitfileinnum { get; set; }

    public long? Batchnum { get; set; }

    public string? Taxid { get; set; }

    public string? Providerno { get; set; }

    public string? Checknumber { get; set; }

    public DateTime? Checkdate { get; set; }

    public decimal? Checkamount { get; set; }

    public long? Claimcount { get; set; }
}
