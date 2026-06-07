using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class S3dgarule
{
    public long S3dgarulenum { get; set; }

    public string? Rulename { get; set; }

    public long? Agethreshold { get; set; }

    public long? Recurrencedays { get; set; }

    public long? Disabled { get; set; }

    public long? Analysistype { get; set; }

    public long? Analysisflags { get; set; }

    public long? Stopthreshold { get; set; }
}
