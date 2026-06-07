using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmtwgldetail
{
    public long Rcmtwgldtlnum { get; set; }

    public long? Rcmtwglnum { get; set; }

    public decimal? Lineitemdepositamount { get; set; }

    public long? Rcmtwglcodenum { get; set; }

    public long? Rcmtransactionnum { get; set; }

    public string? Twglcomment { get; set; }

    public long? Deactivatedcodenum { get; set; }

    public string? Deactivatedcomment { get; set; }

    public long? Deactivatedflag { get; set; }

    public long? Deactivatedusernum { get; set; }

    public long? Rcmtwglrulcritnum { get; set; }
}
