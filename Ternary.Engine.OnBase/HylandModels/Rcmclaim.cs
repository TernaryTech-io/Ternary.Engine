using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmclaim
{
    public long Rcmclaimnum { get; set; }

    public long? Batchnum { get; set; }

    public long? Rcmeobchecknum { get; set; }

    public long? Rcmpatientnum { get; set; }

    public long? Rcmbillingnum { get; set; }

    public long? Rcmincidentnum { get; set; }

    public long? Itemnum { get; set; }

    public long? Batchitempagenum { get; set; }

    public string? Rcmbillingnumber { get; set; }

    public long? Rcmbillingtypenum { get; set; }

    public string? Rcmunitnumber { get; set; }

    public string? Originalplan { get; set; }

    public string? Overrideplan { get; set; }

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

    public long? Rcmhostsystemnum { get; set; }

    public long? Rcmbypasscodenum { get; set; }

    public DateTime? Bypassdate { get; set; }

    public long? Isclaimposted { get; set; }

    public DateTime? Posteddate { get; set; }

    public long? Editusernum { get; set; }

    public DateTime? Edituserdate { get; set; }

    public decimal? Originalacctbalance { get; set; }

    public decimal? Finalacctbalance { get; set; }

    public decimal? Originalinsbalance { get; set; }

    public decimal? Finalinsbalance { get; set; }

    public DateTime? Pendedpostdate { get; set; }

    public long? Lookupmethod { get; set; }

    public long? Rcmfacilitynum { get; set; }

    public string? Rcmfinancialclass { get; set; }

    public string? Rcmaccounttype { get; set; }

    public string? Rcmpatienttype { get; set; }

    public string? Hospitalservice { get; set; }

    public string? Rcmgroupnumber { get; set; }

    public string? Insuranceclaimno { get; set; }

    public string? Claimreferencenumber { get; set; }

    public string? Claimstatus { get; set; }

    public string? Secondaryplancode { get; set; }

    public string? Claimsubmitterid { get; set; }

    public long? Postedinsrank { get; set; }

    public string? Filingindicatorcode { get; set; }

    public string? Rcmtransfertoname { get; set; }

    public string? Rcmtransfertoid { get; set; }

    public decimal? Transferamount { get; set; }

    public string? Claimsubscriberid { get; set; }

    public long? Ispendinghostresponse { get; set; }

    public string? Nationalproviderid { get; set; }

    public string? Facilitytypecode { get; set; }

    public string? Claimfrequencycode { get; set; }

    public long? Warningreleasecheck { get; set; }

    public long? Bypassusernum { get; set; }

    public long? Nullamounts { get; set; }

    public long? Clp835num { get; set; }

    public long? Pagecount { get; set; }

    public string? Rcmpatfirstname { get; set; }

    public string? Rcmpatlastname { get; set; }

    public string? Rcmpatmi { get; set; }

    public string? Rcmmrn { get; set; }

    public DateTime? Dateofservicefrom { get; set; }

    public DateTime? Dateofserviceto { get; set; }

    public long? Externalclaimid { get; set; }

    public long? Plb835num { get; set; }

    public long? Flags { get; set; }
}
