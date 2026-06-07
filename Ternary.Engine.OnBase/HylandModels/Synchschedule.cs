using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Synchschedule
{
    public long Schednum { get; set; }

    public string? Schedname { get; set; }

    public long? Schedtype { get; set; }

    public DateTime? Dtlastprocdate { get; set; }

    public long? Typenum { get; set; }

    public long? Exectime { get; set; }

    public long? Execday { get; set; }

    public long? Idletimeout { get; set; }
}
