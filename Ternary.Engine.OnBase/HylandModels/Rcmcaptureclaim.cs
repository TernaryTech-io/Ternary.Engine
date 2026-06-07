using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmcaptureclaim
{
    public long Claimitemnum { get; set; }

    public long? Payoritemnum { get; set; }

    public long? Batchnum { get; set; }

    public long? Itemnum { get; set; }

    public long? Itempagenum { get; set; }

    public long? Claimpagecount { get; set; }

    public long? Originalitemnum { get; set; }

    public long? Originalpagenum { get; set; }

    public long? Claimstatusid { get; set; }

    public string? Claimnumber { get; set; }

    public string? Taxidnumber { get; set; }

    public string? Insuredpolicynumber { get; set; }

    public string? Invoicenumber { get; set; }

    public string? Rcmclaimpatientname { get; set; }

    public string? Parsedpatientfname { get; set; }

    public string? Parsedpatientmi { get; set; }

    public string? Parsedpatientlname { get; set; }

    public decimal? Checkamount { get; set; }

    public DateTime? Checkdate { get; set; }

    public string? Checknumber { get; set; }

    public DateTime? Billdate { get; set; }

    public DateTime? Dateofservicebegin { get; set; }

    public DateTime? Dateofserviceend { get; set; }

    public decimal? Billedamounttotal { get; set; }

    public decimal? Deniedamounttotal { get; set; }

    public decimal? Allowedamounttotal { get; set; }

    public decimal? Deductibleamounttotal { get; set; }

    public decimal? Patientamounttotal { get; set; }

    public decimal? Paidamounttotal { get; set; }

    public decimal? Coinsurancetotal { get; set; }

    public decimal? Copaytotal { get; set; }

    public long? Rcmcaptureeobnum { get; set; }

    public long? Extractedclaimindex { get; set; }

    public string? Rcmclaiminsuredname { get; set; }

    public string? Parsedinsuredfname { get; set; }

    public string? Parsedinsuredmi { get; set; }

    public string? Parsedinsuredlname { get; set; }

    public string? Parsedinsuredsuffix { get; set; }

    public string? Parsedpatientsuffix { get; set; }

    public decimal? Discountamttotal { get; set; }

    public long? Snippetitemnum { get; set; }
}
