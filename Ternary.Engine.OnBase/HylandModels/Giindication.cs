using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Giindication
{
    public long Giindicationnum { get; set; }

    public long? Gireportnum { get; set; }

    public long? Giindicattypenum { get; set; }

    public string? Giindicationtext { get; set; }

    public long? Flags { get; set; }
}
