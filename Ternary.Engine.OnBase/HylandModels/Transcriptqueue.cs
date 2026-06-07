using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Transcriptqueue
{
    public long Tsqueuenum { get; set; }

    public long? Itemnum { get; set; }

    public long? Docrevnum { get; set; }

    public long? Usernum { get; set; }

    public long? Status { get; set; }

    public long? Flags { get; set; }

    public long? Batchnum { get; set; }

    public DateTime? Locktime { get; set; }
}
