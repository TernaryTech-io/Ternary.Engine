using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Sqbatchcustom
{
    public long Queuenum { get; set; }

    public string? Sqprocessname { get; set; }

    public long? Processtype { get; set; }

    public long? Seqnum { get; set; }

    public long? Vbscriptnum { get; set; }

    public string? Processconfig { get; set; }

    public long? Flags { get; set; }

    public string? Processconfig2 { get; set; }

    public long Statusstepnum { get; set; }

    public long? Unityscriptnum { get; set; }
}
