using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mpwkstation
{
    public long Mpwkstationnum { get; set; }

    public string? Registername { get; set; }

    public string? Stationdesc { get; set; }

    public long? Facilitynum { get; set; }

    public long? Unitnum { get; set; }

    public long? Flags { get; set; }
}
