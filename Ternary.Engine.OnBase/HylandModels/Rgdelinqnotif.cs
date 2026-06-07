using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rgdelinqnotif
{
    public long Rgnotifnum { get; set; }

    public long? Readinggroupnum { get; set; }

    public long? Daysdelinquent { get; set; }

    public string? Additionaltext { get; set; }

    public long? Vbscriptnum { get; set; }

    public long? Flags { get; set; }
}
