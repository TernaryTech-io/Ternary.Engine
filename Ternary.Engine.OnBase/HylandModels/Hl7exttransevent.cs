using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Hl7exttransevent
{
    public long Exttxeventnum { get; set; }

    public string? Hl7externaldocid { get; set; }

    public long? Physusernum { get; set; }

    public long? Signphysnumber { get; set; }

    public long? Chtnum { get; set; }

    public DateTime? Proceduredate { get; set; }

    public long? Status { get; set; }

    public long? Itemnum { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Processingstate { get; set; }

    public long? Processtype { get; set; }

    public long? Dfcytype { get; set; }
}
