using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmprocess
{
    public long Parsefilenum { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Flags { get; set; }

    public long Rcmediconfignum { get; set; }

    public string? Seflocation { get; set; }

    public long? Rcmbillingtypenum { get; set; }
}
