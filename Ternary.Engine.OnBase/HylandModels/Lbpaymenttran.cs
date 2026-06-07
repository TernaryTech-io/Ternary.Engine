using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Lbpaymenttran
{
    public long? Lockboxnum { get; set; }

    public long? Isbatchnum { get; set; }

    public long Batchnum { get; set; }

    public long Seqnum { get; set; }

    public long? Transactionnum { get; set; }

    public string? Accountnum { get; set; }

    public decimal? Totalamount { get; set; }

    public long? Paymentcount { get; set; }

    public long? Remitcount { get; set; }

    public long? Othercount { get; set; }

    public string? Alphaisbatchnum { get; set; }
}
