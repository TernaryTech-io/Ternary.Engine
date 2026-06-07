using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Dripabbr
{
    public long Parsefilenum { get; set; }

    public long Itemtypenum { get; set; }

    public string? Doctypeabbr { get; set; }

    public long? Flags { get; set; }
}
