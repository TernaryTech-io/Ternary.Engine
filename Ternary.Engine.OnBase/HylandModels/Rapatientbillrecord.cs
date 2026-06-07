using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rapatientbillrecord
{
    public long Raptbillingrecnum { get; set; }

    public string? Patientaccountnumber { get; set; }

    public string? Mrmnumber { get; set; }

    public string? Encounternumber { get; set; }

    public string? Billingnumber { get; set; }

    public string? Claimnumber { get; set; }

    public long? Raprevauditnum { get; set; }

    public DateTime? Patientdischargedate { get; set; }

    public long? Patientdischargestatus { get; set; }

    public long? Lengthofstay { get; set; }

    public string? Drg { get; set; }

    public string? Picd10 { get; set; }

    public string? Originalcoder { get; set; }

    public string? Originalbiller { get; set; }

    public string? Attendingphysicianname { get; set; }

    public long? Attendphysiciannumber { get; set; }

    public decimal? Totalclaimamount { get; set; }

    public decimal? Amountbilledtomedicare { get; set; }

    public decimal? Amountpaidbymedicare { get; set; }

    public DateTime? Datepaymentreceived { get; set; }

    public long? Accountingusernum { get; set; }

    public long? Utilizationmgmtusernum { get; set; }

    public string? Mrnpatientlastname { get; set; }

    public string? Mrnpatientfirstname { get; set; }

    public string? Mrnpatientmi { get; set; }

    public string? Icd2 { get; set; }

    public string? Icd3 { get; set; }

    public string? Icd4 { get; set; }

    public string? Icd5 { get; set; }

    public string? Icd6 { get; set; }

    public string? Icd7 { get; set; }

    public string? Icd8 { get; set; }

    public string? Icd9 { get; set; }

    public string? Icd10 { get; set; }

    public string? Ppcicd { get; set; }

    public string? Pcicd2 { get; set; }

    public string? Pcicd3 { get; set; }

    public string? Pcicd4 { get; set; }

    public string? Pcicd5 { get; set; }

    public string? Pcicd6 { get; set; }

    public long? Flags { get; set; }

    public long? Manuallyentered { get; set; }

    public DateTime? Manuallyentereddate { get; set; }

    public string? Facilitytaxid { get; set; }

    public string? Rafacilityname { get; set; }

    public string? Hicid { get; set; }

    public long? Raservicetype { get; set; }

    public long? Rafacilitytype { get; set; }

    public string? Npinumber { get; set; }

    public long? Seqnum { get; set; }

    public string? Billtype { get; set; }

    public DateTime? Servicedate { get; set; }

    public DateTime? Patientdob { get; set; }

    public long? Medicareprvdrid { get; set; }

    public DateTime? Serviceenddate { get; set; }

    public long? Claimstatuscode { get; set; }

    public string? Claimpayer { get; set; }

    public long? Batchnum { get; set; }

    public decimal? Totamtpaidbymedicare { get; set; }
}
