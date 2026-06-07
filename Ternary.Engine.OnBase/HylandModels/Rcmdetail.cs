using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmdetail
{
    public long Rcmdetailnum { get; set; }

    public long? Batchnum { get; set; }

    public long? Rcmeobchecknum { get; set; }

    public long? Rcmclaimnum { get; set; }

    public long? Claimitempagenum { get; set; }

    public long? Batchitempagenum { get; set; }

    public long? Coreinvdetailnum { get; set; }

    public DateTime? Posteddate { get; set; }

    public long? Isrecordposted { get; set; }

    public decimal? Billedamount { get; set; }

    public decimal? Allowedamount { get; set; }

    public decimal? Notallowedamount { get; set; }

    public decimal? Withholdamount { get; set; }

    public decimal? Sequesteramount { get; set; }

    public decimal? Capitationamount { get; set; }

    public decimal? Interestamount { get; set; }

    public decimal? Discountamount { get; set; }

    public decimal? Paidamount { get; set; }

    public decimal? Contractadjamount { get; set; }

    public decimal? Deductibleamount { get; set; }

    public decimal? Copayamount { get; set; }

    public decimal? Coinsuranceamount { get; set; }

    public string? Rcmcomments { get; set; }

    public long? Rcmbypasscodenum { get; set; }

    public long? Bypassusernum { get; set; }

    public DateTime? Bypassdate { get; set; }

    public long? Editusernum { get; set; }

    public DateTime? Edituserdate { get; set; }

    public string? Originalplan { get; set; }

    public string? Overrideplan { get; set; }

    public string? Secondaryplancode { get; set; }

    public long? Postedinsrank { get; set; }

    public decimal? Originalinsbalance { get; set; }

    public decimal? Finalinsbalance { get; set; }

    public decimal? Originalbalance { get; set; }

    public decimal? Finalbalance { get; set; }

    public long? Servicepaidcount { get; set; }

    public long? Origservicepaidcount { get; set; }

    public string? Rcmcptcode { get; set; }

    public string? Rcmcptmod1 { get; set; }

    public string? Rcmcptmod2 { get; set; }

    public string? Rcmcptmod3 { get; set; }

    public string? Rcmcptmod4 { get; set; }

    public long? Nullamounts { get; set; }

    public long? Svc835num { get; set; }

    public DateTime? Dateofservicefrom { get; set; }

    public DateTime? Dateofserviceto { get; set; }
}
