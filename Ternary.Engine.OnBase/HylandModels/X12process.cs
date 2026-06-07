using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class X12process
{
    public long Parsefilenum { get; set; }

    public long Itemtypenum { get; set; }

    public long? Flags { get; set; }

    public string? Codespath { get; set; }
}
