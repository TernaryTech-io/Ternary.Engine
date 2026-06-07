using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmediconfig
{
    public long Rcmediconfignum { get; set; }

    public string? Rcmediconfigname { get; set; }

    public long? Rcminsuranceconum { get; set; }

    public long? Processclassnum { get; set; }

    public string? Rcmuserinitials { get; set; }

    public string? Seflocation { get; set; }

    public long? Rcmpayornum { get; set; }

    public long? Maxclaimsperbatch { get; set; }

    public long? Plbvbscriptnum { get; set; }

    public long? Plbprocessclassnum { get; set; }

    public long? Rcmsefconfignum { get; set; }
}
