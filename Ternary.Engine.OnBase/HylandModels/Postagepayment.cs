using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Postagepayment
{
    public long Popurchasenum { get; set; }

    public string Ponum { get; set; } = null!;

    public string? Paymethod { get; set; }

    public DateTime? Paymentdate { get; set; }

    public long? Paymentamount { get; set; }
}
