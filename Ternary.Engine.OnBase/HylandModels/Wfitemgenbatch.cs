using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Wfitemgenbatch
{
    public long? Wfgenbatchnum { get; set; }

    public long? Wfgeneratornum { get; set; }

    public long? Wfgeneratorsetnum { get; set; }

    public DateTime? Batchdate { get; set; }

    public long? Createdbyuser { get; set; }

    public long? Flags { get; set; }
}
