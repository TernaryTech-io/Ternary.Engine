using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmbilling
{
    public long Rcmbillingnum { get; set; }

    public string? Rcminvoicenumber { get; set; }

    public long? Rcmincidentnum { get; set; }

    public DateTime? Finalbilldate { get; set; }

    public DateTime? Originalbilldate { get; set; }

    public DateTime? Dateofservicefrom { get; set; }

    public DateTime? Dateofserviceto { get; set; }

    public long? Numberoftimesbilled { get; set; }

    public decimal? Totalcharges { get; set; }

    public decimal? Expectedreimbamount { get; set; }

    public long? Originalfcnum { get; set; }

    public string? Billingstatus { get; set; }

    public long? Rcminscoveragenum { get; set; }

    public long? Rcminscompanynum { get; set; }

    public string? Rcmunitnumber { get; set; }

    public string? Claimnpi { get; set; }

    public long? Origin { get; set; }

    public string? Rcmfinancialclass { get; set; }

    public long? Rcmhostsystemnum { get; set; }

    public long? Nullamounts { get; set; }

    public long? Cobrank { get; set; }

    public long? Originalbatchnum { get; set; }

    public long? Lastbatchnum { get; set; }

    public long? Rcmbillingtypenum { get; set; }
}
