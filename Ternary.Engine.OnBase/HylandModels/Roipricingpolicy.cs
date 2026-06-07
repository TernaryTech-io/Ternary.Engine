using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Roipricingpolicy
{
    public long Pricingpolicynum { get; set; }

    public string? Pricingpolicyname { get; set; }

    public string? Pricingpolicydesc { get; set; }

    public long? Flags { get; set; }
}
