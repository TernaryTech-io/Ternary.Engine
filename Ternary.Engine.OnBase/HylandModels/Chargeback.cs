using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Chargeback
{
    public long Chargebacknum { get; set; }

    public string? Chargetype { get; set; }

    public string? Partnumber { get; set; }

    public long? Chargequantity { get; set; }

    public DateTime? Chargedate { get; set; }

    public string? Chargebackcust { get; set; }

    public string? Ponumber { get; set; }

    public decimal? Chargeamount { get; set; }

    public string? Chargedesc1 { get; set; }

    public string? Chargedesc2 { get; set; }

    public long? Usernum { get; set; }

    public long? Registernum { get; set; }

    public long? Sessionid { get; set; }

    public long? Itemnum { get; set; }
}
