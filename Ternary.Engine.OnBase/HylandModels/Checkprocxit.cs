using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Checkprocxit
{
    public long Parsefilenum { get; set; }

    public long Itemtypeid { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Flags { get; set; }
}
