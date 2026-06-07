using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rsinvoiceaccttrn
{
    public long Invoicetranssnum { get; set; }

    public DateTime? Transactiondate { get; set; }

    public string? Transactiondesc { get; set; }

    public decimal? Debitamount { get; set; }

    public decimal? Creditamount { get; set; }

    public decimal? Balanceamount { get; set; }

    public long? Rsaccountnum { get; set; }

    public long? Rsreceiptnum { get; set; }

    public long? Invoicestatus { get; set; }
}
