using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Lbpublishbatch
{
    public long? Autopubordernum { get; set; }

    public long? Isbatchnum { get; set; }

    public DateTime? Pubdate { get; set; }

    public DateTime? Fromdate { get; set; }

    public DateTime? Todate { get; set; }

    public long? Publishtype { get; set; }

    public long? Lockboxnum { get; set; }

    public DateTime? Processingdate { get; set; }

    public DateTime? Postdate { get; set; }

    public long? Paymentcount { get; set; }

    public long? Transactioncount { get; set; }

    public decimal? Totalamount { get; set; }

    public long? Remitcount { get; set; }

    public long? Othercount { get; set; }

    public string? Alphaisbatchnum { get; set; }
}
