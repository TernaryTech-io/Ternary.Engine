using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Launchitem
{
    public long Seqnum { get; set; }

    public long Usernum { get; set; }

    public long Registernum { get; set; }

    public string? Launchpath { get; set; }

    public string? Launchparams { get; set; }

    public long? Launchflags { get; set; }
}
