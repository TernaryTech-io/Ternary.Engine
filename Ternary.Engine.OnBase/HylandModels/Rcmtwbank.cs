using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmtwbank
{
    public long Rcmtwbanknum { get; set; }

    public string? Bankaccountno { get; set; }

    public string? Bankbatchno { get; set; }

    public decimal? Batchamount { get; set; }

    public string? Twbankcomment { get; set; }

    public long? Deactcodenum { get; set; }

    public string? Deactivatedcomment { get; set; }

    public long? Deactivatedflag { get; set; }

    public long? Deactivatedusernum { get; set; }

    public long? Rcmfacilitynum { get; set; }

    public DateTime? Lockboxdate { get; set; }

    public string? Lockboxcode { get; set; }

    public string? Baicompanyid { get; set; }

    public long? Rcmpayornum { get; set; }

    public DateTime? Processeddate { get; set; }

    public long? Createdusernum { get; set; }

    public string? Baimerchantid { get; set; }

    public string? Bairecipientid { get; set; }

    public string? Bairecipientname { get; set; }

    public string? Baicustomerid { get; set; }

    public string? Baitransactiontypecode { get; set; }

    public string? Twdepositcategory { get; set; }

    public string? Twdepositcategorydtl { get; set; }

    public string? Rcmchecknumber { get; set; }

    public string? Baipayername { get; set; }

    public string? Rcmtwbaistring { get; set; }

    public string? Depositslipnumber { get; set; }

    public string? Depositsliplocation { get; set; }

    public string? Hcclaimpayment { get; set; }
}
