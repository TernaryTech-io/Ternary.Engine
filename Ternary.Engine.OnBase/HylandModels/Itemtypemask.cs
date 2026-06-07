using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Itemtypemask
{
    public long Itemtypenum { get; set; }

    public long? Maskstartcolumn { get; set; }

    public long? Maskendcolumn { get; set; }

    public string? Maskchar { get; set; }

    public long? Flags { get; set; }
}
