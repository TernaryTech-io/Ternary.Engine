using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmtwfinance
{
    public long Rcmtwfinancenum { get; set; }

    public long? Batchnum { get; set; }

    public string? Arbatchno { get; set; }

    public long? Fintypemasternum { get; set; }

    public string? Bankbatchno { get; set; }

    public decimal? Batchamount { get; set; }

    public decimal? Contractadjamount { get; set; }

    public DateTime? Processeddate { get; set; }

    public DateTime? Lockboxdate { get; set; }

    public string? Lockboxcode { get; set; }

    public string? Twfinancecomment { get; set; }

    public long? Eobcount { get; set; }

    public DateTime? Exportdate { get; set; }

    public long? Exportflag { get; set; }

    public long? Rcmfacilitynum { get; set; }

    public string? Rcmgroupnumber { get; set; }

    public long? Printedcount { get; set; }

    public string? Batchsequenceno { get; set; }

    public string? Rcmuserinitials { get; set; }

    public long? Deactivatedcodenum { get; set; }

    public string? Deactivatedcomment { get; set; }

    public long? Deactivatedflag { get; set; }

    public long? Deactivatedusernum { get; set; }

    public long? Createdusernum { get; set; }

    public long? Nullamounts { get; set; }

    public string? Depositslipnumber { get; set; }

    public string? Depositsliplocation { get; set; }

    public string? Rcmchecknumber { get; set; }

    public string? Baimerchantid { get; set; }

    public string? Rcmmerchanttrannumber { get; set; }

    public string? Rcmtransactionlocation { get; set; }

    public string? Rcmtrancode { get; set; }

    public DateTime? Reconcileddate { get; set; }
}
