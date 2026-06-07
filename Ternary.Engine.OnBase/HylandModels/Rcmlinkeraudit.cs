using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmlinkeraudit
{
    public long Rcmlinkerauditnum { get; set; }

    public long? Batchnum { get; set; }

    public long? Rcmclaimnum { get; set; }

    public long? Rcmdetailnum { get; set; }

    public long? Rcmtransactiontype { get; set; }

    public string? Rcmtransactioncode { get; set; }

    public DateTime? Rcmtransactiondate { get; set; }

    public decimal? Rcmtransactionamount { get; set; }

    public string? Rcmtransactiondesc { get; set; }

    public string? Rcmlinkerversion { get; set; }

    public string? Rcmupdatedvalue { get; set; }

    public string? Rcmhostbatchnumber { get; set; }

    public string? Rcmtransactionplan { get; set; }
}
