using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Imagetransfer
{
    public long Itemtypenum { get; set; }

    public string Extdoctypeid { get; set; } = null!;

    public long? Loankeytypenum { get; set; }
}
