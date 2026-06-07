using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Bcconfig
{
    public long Parsefilenum { get; set; }

    public long? Encodingoptions { get; set; }

    public string? Tellerreportpath { get; set; }

    public long? Tellerreportfilter { get; set; }

    public long? Tellreportopts { get; set; }

    public long? Optionflags { get; set; }

    public long? Confidence1 { get; set; }

    public long? Carlarnum { get; set; }
}
