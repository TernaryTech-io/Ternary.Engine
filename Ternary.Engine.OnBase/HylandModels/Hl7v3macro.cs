using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Hl7v3macro
{
    public long Hl7v3macronum { get; set; }

    public string? Hl7v3name { get; set; }

    public string? Hl7v3value { get; set; }

    public long? Flags { get; set; }

    public DateTime? Lastmodifieddate { get; set; }

    public long? Lastmodifieduser { get; set; }
}
