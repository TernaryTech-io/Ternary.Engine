using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Postagepurchase
{
    public long Popurchasenum { get; set; }

    public long? Pocustomernum { get; set; }

    public DateTime? Purchasedate { get; set; }

    public long? Purchaseamount { get; set; }

    public DateTime? Acknowledgedate { get; set; }
}
