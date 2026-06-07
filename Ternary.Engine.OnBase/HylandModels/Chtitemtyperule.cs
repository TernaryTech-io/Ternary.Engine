using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Chtitemtyperule
{
    public long Itemtyperulenum { get; set; }

    public long? Facilitynum { get; set; }

    public long? Dptnum { get; set; }

    public long? Unitnum { get; set; }

    public long? Admittypenum { get; set; }

    public long? Itemtypenum { get; set; }

    public string? Notetext { get; set; }

    public long? Dfcytype { get; set; }

    public long? Creatbasis { get; set; }
}
