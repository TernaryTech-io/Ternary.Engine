using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Foldertypedefkw
{
    public long Foldertypenum { get; set; }

    public long Keytypenum { get; set; }

    public string Defaultkeywordvalue { get; set; } = null!;

    public long? Flags { get; set; }
}
