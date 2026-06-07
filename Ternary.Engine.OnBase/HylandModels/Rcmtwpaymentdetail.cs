using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmtwpaymentdetail
{
    public long Rcmtwpmtdtlnum { get; set; }

    public long? Rcmeobchecknum { get; set; }

    public long? Deactivatedcodenum { get; set; }

    public string? Deactivatedcomment { get; set; }

    public long? Deactivatedflag { get; set; }

    public long? Deactivatedusernum { get; set; }

    public long? Rcmtwpaymentnum { get; set; }
}
