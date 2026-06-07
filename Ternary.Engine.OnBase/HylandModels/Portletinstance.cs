using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Portletinstance
{
    public long Portletinstnum { get; set; }

    public string? Portletinstname { get; set; }

    public long? Portletnum { get; set; }

    public long? Layoutnum { get; set; }

    public string? Configxml { get; set; }
}
