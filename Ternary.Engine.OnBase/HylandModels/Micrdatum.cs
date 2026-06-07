using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Micrdatum
{
    public string Tracenum { get; set; } = null!;

    public long Institution { get; set; }

    public string Postingdate { get; set; } = null!;

    public long? Micrbatchnum { get; set; }

    public string? Accountnum { get; set; }

    public string? Checknumber { get; set; }

    public string? Tranamount { get; set; }

    public string? Transcode { get; set; }

    public long? Checkmatched { get; set; }

    public long? Unmatchedduplicateimage { get; set; }

    public long? Batchnum { get; set; }

    public long? Itemnum { get; set; }
}
