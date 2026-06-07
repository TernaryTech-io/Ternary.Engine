using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Sapbichistory
{
    public long Saptransactionnum { get; set; }

    public string? Sapguid { get; set; }

    public string? Onbaseguid { get; set; }

    public long? Itemnum { get; set; }

    public DateTime? Entrydate { get; set; }

    public string? Sapkeytypename { get; set; }

    public string? Sapkeyvalue { get; set; }
}
