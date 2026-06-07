using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Itemtypexref
{
    public long Xrefitemtypenum { get; set; }

    public long Itemtypenum { get; set; }

    public long? Xreftype { get; set; }

    public string? Xrefname { get; set; }
}
