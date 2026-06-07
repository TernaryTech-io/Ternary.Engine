using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rsinstrtyperef
{
    public long Instrumenttypenum { get; set; }

    public string? Instrtypecode1 { get; set; }

    public string? Instrtypecode2 { get; set; }

    public string? Instrtypename { get; set; }

    public long? Instrtypeflags { get; set; }

    public long? Pricemodeltypenum { get; set; }
}
