using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Itemdataxstatus
{
    public long? Itemnum { get; set; }

    public long? Batchnum { get; set; }

    public long? Batchstatus { get; set; }

    public long? Substatus { get; set; }

    public string? Substatusname { get; set; }

    public long? Statusstepnum { get; set; }

    public long? Scanprocessxsqnum { get; set; }

    public string? Uniquesetnum { get; set; }

    public long? Documentsetnum { get; set; }
}
