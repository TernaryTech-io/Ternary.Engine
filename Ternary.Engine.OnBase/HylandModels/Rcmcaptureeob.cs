using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmcaptureeob
{
    public long Rcmcaptureeobnum { get; set; }

    public long? Payoritemnum { get; set; }

    public long? Batchnum { get; set; }

    public long? Itemnum { get; set; }

    public long? Itempagenum { get; set; }

    public long? Eobpagecount { get; set; }

    public long? Originalitemnum { get; set; }

    public long? Originalpagenum { get; set; }

    public decimal? Checkamount { get; set; }

    public DateTime? Checkdate { get; set; }

    public string? Checknumber { get; set; }

    public DateTime? Billdate { get; set; }

    public DateTime? Eobcreateddate { get; set; }
}
