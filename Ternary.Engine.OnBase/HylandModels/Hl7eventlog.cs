using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Hl7eventlog
{
    public long Hl7lognum { get; set; }

    public long? Itemnum { get; set; }

    public long? Hl7messagenum { get; set; }

    public long? Hl7destnum { get; set; }

    public DateTime? Logdate { get; set; }

    public long? Sendmethod { get; set; }

    public long? Status { get; set; }

    public string? Messagetext { get; set; }

    public long? Hl7propertysetnum { get; set; }
}
