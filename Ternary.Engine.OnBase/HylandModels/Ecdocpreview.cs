using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ecdocpreview
{
    public long Ecdocpreviewnum { get; set; }

    public long? Ecrestrictionnum { get; set; }

    public string? Ecname { get; set; }

    public string? Ecdesc { get; set; }

    public long? Zoneleft { get; set; }

    public long? Zonetop { get; set; }

    public long? Zoneright { get; set; }

    public long? Zonebottom { get; set; }

    public long? Zonecolor { get; set; }

    public long? Eczoneaction { get; set; }
}
