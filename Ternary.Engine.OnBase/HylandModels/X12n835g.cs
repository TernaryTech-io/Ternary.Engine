using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class X12n835g
{
    public long Gs835num { get; set; }

    public long? Batchnum { get; set; }

    public long? Isa835num { get; set; }

    public string? Gs01funcidcode { get; set; }

    public string? Gs02appsendcode { get; set; }

    public string? Gs03apprecvcode { get; set; }

    public DateTime? Gs04date { get; set; }

    public string? Gs05time { get; set; }

    public string? Gs06ctrlnumber { get; set; }

    public string? Gs07respagency { get; set; }

    public string? Gs08version { get; set; }
}
