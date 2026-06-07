using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Raptbillingline
{
    public long Raptbillinglnnum { get; set; }

    public long? Raptbillingrecnum { get; set; }

    public DateTime? Servicedate { get; set; }

    public string? CptHcpcs { get; set; }

    public string? Radescription { get; set; }

    public decimal? Totalcharges { get; set; }

    public long? Serviceunits { get; set; }

    public string? Revenuecode { get; set; }

    public string? Modifier1 { get; set; }

    public string? Modifier2 { get; set; }

    public string? Modifier3 { get; set; }

    public string? Modifier4 { get; set; }

    public string? Diagnonsiscode { get; set; }

    public long? Diagnosiscodeid { get; set; }

    public string? Providernpi { get; set; }

    public long? Medicareprvdrid { get; set; }

    public decimal? Amountpaid { get; set; }

    public DateTime? Datepaymentreceived { get; set; }

    public long? Raprevauditnum { get; set; }

    public string? Medprovid { get; set; }

    public string? Lineidentifier { get; set; }
}
