using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Hl7v3trigger
{
    public long Hl7v3triggernum { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Hl7v3triggertype { get; set; }

    public string? Hl7v3triggername { get; set; }

    public string? Hl7v3description { get; set; }

    public long? Hl7v3templatenum { get; set; }

    public long? Hl7v3destnum { get; set; }

    public long? Flags { get; set; }

    public DateTime? Lastmodifieddate { get; set; }

    public long? Lastmodifieduser { get; set; }
}
