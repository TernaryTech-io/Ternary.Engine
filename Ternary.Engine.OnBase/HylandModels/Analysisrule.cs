using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Analysisrule
{
    public long Analysisrulenum { get; set; }

    public string? Rulename { get; set; }

    public long? Ruletype { get; set; }

    public long? Closedvolumethreshold { get; set; }

    public long? Startthreshold { get; set; }

    public long? Recurrencedays { get; set; }

    public long? Endthreshold { get; set; }

    public long? Analysistype { get; set; }

    public long? Analysisflags { get; set; }

    public long? Analysischecksumtype { get; set; }

    public long? Disabled { get; set; }
}
