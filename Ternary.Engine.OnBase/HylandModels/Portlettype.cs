using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Portlettype
{
    public long Portletnum { get; set; }

    public string? Portletname { get; set; }

    public string? Portletuuid { get; set; }

    public string? Portleturl { get; set; }

    public string? Configurl { get; set; }

    public long? Flags { get; set; }

    public long? Basetype { get; set; }
}
