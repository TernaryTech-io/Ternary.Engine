using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Dailyrepassitem
{
    public long Institution { get; set; }

    public string Tracenum { get; set; } = null!;

    public string Postingdate { get; set; } = null!;

    public string? Transcode { get; set; }

    public string? Accountnum { get; set; }

    public string? Checknumber { get; set; }

    public string? Routingnum { get; set; }

    public string? Tranamount { get; set; }

    public long? Batchnum { get; set; }

    public long Itemnum { get; set; }
}
