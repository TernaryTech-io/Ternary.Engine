using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Trancodexref
{
    public long Institution { get; set; }

    public long Trancode { get; set; }

    public long Itemtypenum { get; set; }

    public long? Trancodenum { get; set; }
}
