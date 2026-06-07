using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Sapbiclog
{
    public long Saptransactionnum { get; set; }

    public string? Sapguid { get; set; }

    public string? Onbaseguid { get; set; }

    public long? Itemnum { get; set; }

    public DateTime? Entrydate { get; set; }

    public long? Action { get; set; }

    public string? Bicmessage { get; set; }

    public long? Bicqueuenum { get; set; }
}
