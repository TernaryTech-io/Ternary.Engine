using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Tpcfprocessorlog
{
    public DateTime? Logdate { get; set; }

    public long? Status { get; set; }

    public long? Docsprocessed { get; set; }

    public long? Duration { get; set; }

    public long? Numerrors { get; set; }

    public long? Schedtasknum { get; set; }

    public long? Numtofailqueue { get; set; }
}
