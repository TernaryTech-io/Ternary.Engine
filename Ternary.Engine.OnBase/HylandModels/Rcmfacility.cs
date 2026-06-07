using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmfacility
{
    public long Rcmfacilitynum { get; set; }

    public string? Rcmfacilityname { get; set; }

    public string? Rcmfacilityprefix { get; set; }

    public string? Rcmfacilitydatabase { get; set; }

    public long? Active { get; set; }

    public string? Facilitynpi { get; set; }

    public long? Rcmhostsystemnum { get; set; }
}
