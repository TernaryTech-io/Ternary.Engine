using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmbatchpostinginfo
{
    public long Rcmpostinginfonum { get; set; }

    public long? Batchnum { get; set; }

    public long? Rcmhostsystemnum { get; set; }

    public long? Totalcount { get; set; }

    public decimal? Totalamount { get; set; }

    public long? Unpostedcount { get; set; }

    public decimal? Unpostedamount { get; set; }

    public long? Pendingcount { get; set; }

    public DateTime? Pendingpostingdate { get; set; }

    public long? Bypasscount { get; set; }

    public decimal? Bypassamount { get; set; }

    public long? Workcompleted { get; set; }

    public decimal? Manualpostedamount { get; set; }

    public decimal? Postedamount { get; set; }

    public decimal? Externalbypassamount { get; set; }
}
