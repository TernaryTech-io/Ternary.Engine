using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmbatchvalstatus
{
    public long? Batchnum { get; set; }

    public long? Rcmvalstatnum { get; set; }

    public long? Rcmgrdcolenum { get; set; }

    public string? Rcmerrormsg { get; set; }
}
