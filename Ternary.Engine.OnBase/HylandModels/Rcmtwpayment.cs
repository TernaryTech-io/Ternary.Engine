using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmtwpayment
{
    public long Rcmtwpaymentnum { get; set; }

    public long? Batchnum { get; set; }

    public string? Twpmtcomment { get; set; }

    public long? Deactivatedcodenum { get; set; }

    public string? Deactivatedcomment { get; set; }

    public long? Deactivatedflag { get; set; }

    public long? Deactivatedusernum { get; set; }

    public long? Rcmtwfinancenum { get; set; }

    public DateTime? Matcheddate { get; set; }

    public DateTime? Reconcileddate { get; set; }
}
