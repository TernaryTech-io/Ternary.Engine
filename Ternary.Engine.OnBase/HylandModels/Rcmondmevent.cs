using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmondmevent
{
    public long Rcmdmeventnum { get; set; }

    public long? Rcmdmeventtype { get; set; }

    public long? Rcmdmdenialnum { get; set; }

    public long? Rcmclaimnum { get; set; }

    public long? Flags { get; set; }
}
