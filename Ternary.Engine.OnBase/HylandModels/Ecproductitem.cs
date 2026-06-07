using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ecproductitem
{
    public long Ecproductitemnum { get; set; }

    public long? Ecproductnum { get; set; }

    public string? Ecname { get; set; }

    public long? Eckwitemtypenum { get; set; }

    public string? Eckwitemvalue { get; set; }

    public string? Eckwitemrvalue { get; set; }

    public long? Ecoperator { get; set; }

    public string? Ecvalidate { get; set; }

    public string? Ecdesc { get; set; }

    public long? Flags { get; set; }
}
