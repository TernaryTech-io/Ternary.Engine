using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rspmtlineitem
{
    public long Lineitemnum { get; set; }

    public long? Linequantity { get; set; }

    public decimal? Lineamount { get; set; }

    public DateTime? Transactiondate { get; set; }

    public long? Instrumentnum { get; set; }

    public long? Feetypenum { get; set; }

    public long? Feetyperevnum { get; set; }

    public long? Rsreceiptnum { get; set; }

    public string? Lineitemtext { get; set; }
}
