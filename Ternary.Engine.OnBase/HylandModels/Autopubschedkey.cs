using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Autopubschedkey
{
    public long Schedordernum { get; set; }

    public long Keytypenum { get; set; }

    public string Keyvaluechar { get; set; } = null!;
}
