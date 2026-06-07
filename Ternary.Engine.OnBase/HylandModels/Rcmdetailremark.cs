using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmdetailremark
{
    public long Rcmdetailrmknum { get; set; }

    public long? Batchnum { get; set; }

    public long? Rcmeobchecknum { get; set; }

    public long? Rcmdetailnum { get; set; }

    public string? Remarkcode { get; set; }

    public long? Rmkarchivepriority { get; set; }

    public long? Rmkpostingpriority { get; set; }

    public decimal? Rmkamount { get; set; }

    public string? Postedrmkcode { get; set; }

    public decimal? Postedrmkamount { get; set; }

    public long? Nullamounts { get; set; }
}
