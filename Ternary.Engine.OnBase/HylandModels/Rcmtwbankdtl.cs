using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmtwbankdtl
{
    public long Rcmtwbankdtlnum { get; set; }

    public long? Rcmtwbanknum { get; set; }

    public string? Rcmchecknumber { get; set; }

    public string? Twbankdtlcomment { get; set; }

    public long? Deactivatedcodenum { get; set; }

    public string? Deactivatedcomment { get; set; }

    public long? Deactivatedflag { get; set; }

    public long? Deactivatedusernum { get; set; }

    public long? Rcmdeposittypenum { get; set; }

    public decimal? Lineitemdepositamount { get; set; }

    public string? Rcmcheckseqno { get; set; }

    public string? Baitransactiontypecode { get; set; }

    public string? Lockboxcode { get; set; }
}
