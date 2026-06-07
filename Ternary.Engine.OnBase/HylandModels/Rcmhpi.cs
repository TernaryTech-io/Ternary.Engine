using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmhpi
{
    public long Rcmhpinum { get; set; }

    public long? Rcmwlcommonnum { get; set; }

    public long? Rcmacthistorynum { get; set; }

    public long? Rcmworklistnum { get; set; }

    public long? Rcmactivitynum { get; set; }

    public long? Rcmhostsystemnum { get; set; }

    public long? Rcmhostpostpolnum { get; set; }

    public string? Rcmhostclaimid { get; set; }

    public string? Rcmnote { get; set; }

    public long? Rcmpostedflags { get; set; }

    public DateTime? Rcmposteddate { get; set; }

    public string? Rcmpostingreturnstatus { get; set; }

    public string? Unitnumber { get; set; }

    public string? Groupnumber { get; set; }

    public string? Rcmtransactioncode { get; set; }

    public string? Rcmtransactioncomment { get; set; }

    public long? Rcmclaimnum { get; set; }
}
