using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmbillingdetail
{
    public long Rcmbillingdetnum { get; set; }

    public long? Rcmbillingnum { get; set; }

    public string? Rcmdetaillineno { get; set; }

    public string? Rcmcptcode { get; set; }

    public string? Rcmcptmod1 { get; set; }

    public string? Rcmcptmod2 { get; set; }

    public string? Rcmcptmod3 { get; set; }

    public string? Rcmcptmod4 { get; set; }

    public DateTime? Dateofservicefrom { get; set; }

    public DateTime? Dateofserviceto { get; set; }

    public decimal? Billedamount { get; set; }

    public decimal? Currentacctbalance { get; set; }

    public decimal? Totalcharges { get; set; }

    public decimal? Expectedreimbamount { get; set; }

    public long? Nullamounts { get; set; }

    public long? Originalbatchnum { get; set; }

    public long? Lastbatchnum { get; set; }
}
