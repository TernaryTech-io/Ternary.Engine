using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Dcmapplicationentity
{
    public long Appentitynum { get; set; }

    public string? Appentityname { get; set; }

    public string? Appentitytitle { get; set; }

    public long? Pdumaxlength { get; set; }

    public long? Maxsimassociation { get; set; }

    public long? Maxreattempts { get; set; }

    public long? Dcmtimeoutlength { get; set; }

    public long? Flags { get; set; }
}
