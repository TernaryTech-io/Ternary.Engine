using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Holdreason
{
    public long Holdreasonnum { get; set; }

    public string? Reasontext { get; set; }

    public string? Holdreasonname { get; set; }

    public long? Foldertypenum { get; set; }

    public long? Holdsetnum { get; set; }
}
