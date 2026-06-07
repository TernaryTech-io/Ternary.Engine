using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mkplbid
{
    public long Mkplbidnum { get; set; }

    public long? Mkplcasenum { get; set; }

    public long? Mkplprospectnum { get; set; }

    public long? Mkplcontactnum { get; set; }

    public long? Contactmethod { get; set; }

    public decimal? Requestedamount { get; set; }

    public long? Amounttype { get; set; }

    public string? Isocurrencyname { get; set; }

    public long? Status { get; set; }

    public DateTime? Createddate { get; set; }

    public DateTime? Datemodified { get; set; }

    public decimal? Offercost { get; set; }

    public long? Offernum { get; set; }
}
