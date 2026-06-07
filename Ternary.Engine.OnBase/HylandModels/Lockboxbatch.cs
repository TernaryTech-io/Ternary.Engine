using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Lockboxbatch
{
    public long? Lockboxnum { get; set; }

    public long? Isbatchnum { get; set; }

    public long Batchnum { get; set; }

    public DateTime? Processingdate { get; set; }

    public DateTime? Postdate { get; set; }

    public long? Paymentcount { get; set; }

    public long? Transactioncount { get; set; }

    public decimal? Totalamount { get; set; }

    public long? Batchstatus { get; set; }

    public DateTime? Laststatusupdate { get; set; }

    public decimal? Depositavail0 { get; set; }

    public decimal? Depositavail1 { get; set; }

    public decimal? Depositavail2 { get; set; }

    public decimal? Depositavail3 { get; set; }

    public decimal? Depositavail4 { get; set; }

    public decimal? Depositavail5 { get; set; }

    public long? Remitcount { get; set; }

    public long? Othercount { get; set; }

    public long? Printitemnum { get; set; }

    public string? Alphaisbatchnum { get; set; }

    public string? Lockextuserid { get; set; }

    public DateTime? Datelocked { get; set; }
}
