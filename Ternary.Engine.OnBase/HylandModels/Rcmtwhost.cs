using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmtwhost
{
    public long Rcmtwhostnum { get; set; }

    public long? Rcmhostsystemnum { get; set; }

    public string? Rcmgroupnumber { get; set; }

    public string? Hostbatchno { get; set; }

    public decimal? Totalamount { get; set; }

    public string? Hostbatchdescription { get; set; }

    public DateTime? Lockboxdate { get; set; }

    public string? Rcmtwhostcomment { get; set; }

    public DateTime? Hostbatchcloseddate { get; set; }

    public long? Rcmbatchnum { get; set; }

    public string? Rcmuserinitials { get; set; }

    public long? Transactioncount { get; set; }

    public long? Deactivatedflag { get; set; }

    public long? Deactivatedcodenum { get; set; }

    public string? Deactivateduser { get; set; }

    public string? Deactivatedcomment { get; set; }

    public long? Rcmfacilitynum { get; set; }

    public DateTime? Processeddate { get; set; }

    public string? Arbatchno { get; set; }

    public long? Deactivatedusernum { get; set; }

    public long? Originalbatchnum { get; set; }

    public string? Depositslipnumber { get; set; }

    public string? Depositsliplocation { get; set; }

    public string? Baimerchantid { get; set; }

    public string? Rcmmerchanttrannumber { get; set; }

    public string? Rcmtransactionlocation { get; set; }

    public string? Rcmtrancode { get; set; }

    public string? Voidmatchnumber { get; set; }

    public DateTime? Voiddate { get; set; }

    public long? Rcmtwfinancenum { get; set; }

    public long? Rcmtwpaymentnum { get; set; }

    public DateTime? Matcheddate { get; set; }
}
