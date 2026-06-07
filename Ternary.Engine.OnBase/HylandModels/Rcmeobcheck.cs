using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmeobcheck
{
    public long Rcmeobchecknum { get; set; }

    public long? Batchnum { get; set; }

    public long? Rcmchecktype { get; set; }

    public string? Rcmchecknumber { get; set; }

    public DateTime? Checkdate { get; set; }

    public DateTime? Depositdate { get; set; }

    public decimal? Paidamount { get; set; }

    public decimal? Checkamount { get; set; }

    public decimal? Adjustmentamount { get; set; }

    public long? Rcmpayornum { get; set; }

    public long? Rcminsuranceconum { get; set; }

    public long? Matcheobchecknum { get; set; }

    public long? Spliteobflag { get; set; }

    public string? Rcmcomments { get; set; }

    public long? Rcmbypasscodenum { get; set; }

    public long? Bypassusernum { get; set; }

    public DateTime? Bypassdate { get; set; }

    public string? Remittanceid { get; set; }

    public long? Paymentmethod { get; set; }

    public long? Batchitempagenum { get; set; }

    public long? Editusernum { get; set; }

    public DateTime? Edituserdate { get; set; }

    public long? Nullamounts { get; set; }

    public long? Itemnum { get; set; }

    public long? St835num { get; set; }
}
