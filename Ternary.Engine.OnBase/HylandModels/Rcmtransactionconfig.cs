using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmtransactionconfig
{
    public long Rcmtxncfgnum { get; set; }

    public long? Rcmhostsystemnum { get; set; }

    public long? Rcmpayornum { get; set; }

    public long? Rcminsuranceconum { get; set; }

    public long? Rcmtransacttype { get; set; }

    public string? Rcmtransactcode { get; set; }

    public long? Rcmprioritylevel { get; set; }

    public string? Rcmaccounttype { get; set; }

    public string? Rcmpatienttype { get; set; }

    public string? Rcmfinancialclass { get; set; }

    public string? Rcmplancode { get; set; }

    public string? Rcmpatientrep { get; set; }

    public string? Rcmfacilityprefix { get; set; }

    public long? Rcmactionnum { get; set; }

    public long? Rcminsurancerank { get; set; }

    public string? Rcmagencycode { get; set; }

    public string? Hospitalservice { get; set; }

    public string? Rcmdistrictcode { get; set; }

    public string? Profeedepartment { get; set; }

    public string? Lockboxcode { get; set; }
}
