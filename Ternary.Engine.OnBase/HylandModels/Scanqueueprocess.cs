using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Scanqueueprocess
{
    public long Queuenum { get; set; }

    public long Processtype { get; set; }

    public string? Processconfig { get; set; }

    public long? Flags { get; set; }

    public string? Sqprocessname { get; set; }

    public long? Seqnum { get; set; }

    public long? Filetypenum { get; set; }

    public long? Extrainfo1 { get; set; }

    public string? Processconfig2 { get; set; }

    public long? Statusstepnum { get; set; }
}
