using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmincident
{
    public long Rcmincidentnum { get; set; }

    public string? Rcmencounternumber { get; set; }

    public long? Rcmpatientnum { get; set; }

    public long? Rcmfacilitynum { get; set; }

    public DateTime? Registrationdate { get; set; }

    public DateTime? Admitdate { get; set; }

    public DateTime? Dischargedate { get; set; }

    public DateTime? Dateofservicefrom { get; set; }

    public DateTime? Dateofserviceto { get; set; }

    public string? Rcmmrn { get; set; }

    public long? Rcmpatienttypenum { get; set; }

    public long? Rcmpatientstatusnum { get; set; }

    public long? Rcmmedsvcnum { get; set; }

    public string? Abnindicator { get; set; }

    public string? Rcmorderdx { get; set; }

    public string? Admitdx { get; set; }

    public string? Incidentstatus { get; set; }

    public string? Chartlocation { get; set; }

    public decimal? Accountbalance { get; set; }

    public long? Origin { get; set; }

    public string? Rcmunitnumber { get; set; }

    public string? Rcmpatienttype { get; set; }

    public long? Originalbatchnum { get; set; }

    public long? Lastbatchnum { get; set; }
}
