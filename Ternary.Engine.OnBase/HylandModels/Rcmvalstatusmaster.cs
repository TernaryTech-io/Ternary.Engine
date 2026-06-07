using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmvalstatusmaster
{
    public long Rcmvalstatnum { get; set; }

    public string? Rcmvalstatusid { get; set; }

    public string? Rcmerrormsg { get; set; }

    public string? Rcmdescription { get; set; }

    public string? Rcmerrormsgov { get; set; }

    public long? Flags { get; set; }
}
