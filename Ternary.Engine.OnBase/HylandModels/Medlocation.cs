using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Medlocation
{
    public long Medlocationnum { get; set; }

    public long? Facilitynum { get; set; }

    public long? Dptnum { get; set; }

    public long? Unitnum { get; set; }
}
