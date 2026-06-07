using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmtwfinancedetail
{
    public long Rcmtwfinancdtlnum { get; set; }

    public long? Rcmtwfinnum { get; set; }

    public string? Rcmchecknumber { get; set; }

    public decimal? Lineitemdepositamount { get; set; }

    public long? Rcmtwdeposittypenum { get; set; }

    public long? Glcodenum { get; set; }

    public long? Rcmtransactionnum { get; set; }

    public string? Rcmtwfindtlcomment { get; set; }

    public long? Deactivatedcodenum { get; set; }

    public string? Deactivatedcomment { get; set; }

    public long? Deactivatedflag { get; set; }

    public long? Deactivatedusernum { get; set; }
}
