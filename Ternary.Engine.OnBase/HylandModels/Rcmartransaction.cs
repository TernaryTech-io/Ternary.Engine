using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmartransaction
{
    public long Rcmartransactnum { get; set; }

    public long? Originalbatchnum { get; set; }

    public long? Lastbatchnum { get; set; }

    public long? Isprocessed { get; set; }

    public long? Rcmarpatientnum { get; set; }

    public long? Rcmbillingnum { get; set; }

    public long? Rcmfacilitynum { get; set; }

    public long? Rcmhostsystemnum { get; set; }

    public long? Rcmbillingtypenum { get; set; }

    public long? Rcmarguarnum { get; set; }

    public long? Rcmaremployernum { get; set; }

    public long? Rcmaraccttypenum { get; set; }

    public long? Rcmarpattypenum { get; set; }

    public long? Rcmaracctstatnum { get; set; }

    public long? Rcmarpatstatnum { get; set; }

    public long? Rcmarvisittypenum { get; set; }

    public long? Rcmorigfinclsnum { get; set; }

    public long? Rcmcurfinclsnum { get; set; }

    public string? Rcmbillingnumber { get; set; }

    public decimal? Totalcharges { get; set; }

    public decimal? Accountbalance { get; set; }

    public decimal? Rcmfinalpatbalance { get; set; }

    public decimal? Rcmtotalpaid { get; set; }

    public decimal? Rcmtotalpatpaid { get; set; }

    public decimal? Rcmtotaladjustment { get; set; }

    public decimal? Otherinspaid { get; set; }

    public decimal? Coinsuranceamount { get; set; }

    public decimal? Deductibleamount { get; set; }

    public DateTime? Registrationdate { get; set; }

    public DateTime? Admitdate { get; set; }

    public DateTime? Dischargedate { get; set; }

    public DateTime? Dateofservicefrom { get; set; }

    public DateTime? Dateofserviceto { get; set; }

    public string? Rcmarmedservice { get; set; }

    public decimal? Olddrgrate { get; set; }

    public string? Olddrgid { get; set; }

    public decimal? Newdrgrate { get; set; }

    public string? Newdrgid { get; set; }

    public string? Chartlocation { get; set; }

    public decimal? Expectedreimbamount { get; set; }

    public DateTime? Systemdate { get; set; }

    public DateTime? Pttimedeath { get; set; }

    public string? Rcmhospitalsvc { get; set; }

    public string? Rcmpatientrep { get; set; }

    public string? Rcmcourtesyallow { get; set; }

    public string? Rcmoldapc { get; set; }

    public string? Rcmnewapc { get; set; }

    public string? Abnindicator { get; set; }

    public string? Rcmorderdiagnosis { get; set; }

    public string? Rcmadmitdiagnosis { get; set; }

    public string? Rcmadmittingphysid { get; set; }

    public string? Rcmsurgicalphysid { get; set; }

    public string? Rcmattendingphysid { get; set; }

    public string? Rcmreferringphysid { get; set; }

    public string? Rcmpreregistraremp { get; set; }

    public string? Rcmregistraremp { get; set; }

    public string? Rcmcoderemp { get; set; }

    public string? Rcmadmitpriority { get; set; }

    public string? Rcmadmitsource { get; set; }

    public DateTime? Abstractcompdate { get; set; }

    public string? Rcmpmtplantype { get; set; }

    public DateTime? Lastpatpaydate { get; set; }

    public DateTime? Lastinspaydate { get; set; }

    public DateTime? Finalbilldate { get; set; }

    public DateTime? Origbilldate { get; set; }

    public DateTime? Zerobalancedate { get; set; }

    public DateTime? Collectionfwddate { get; set; }

    public string? Rcmarcolagency { get; set; }

    public string? Rcmunitnumber { get; set; }

    public string? Rcmarplancode { get; set; }

    public string? Rcmargroupcode { get; set; }

    public string? Rcmauthnumber { get; set; }

    public DateTime? Rcmauthdate { get; set; }

    public DateTime? Rcmautheffstart { get; set; }

    public DateTime? Rcmautheffend { get; set; }
}
