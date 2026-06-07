using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Hl7msgsendrule
{
    public long Hl7msgsendrulenum { get; set; }

    public string? Hl7msgsendrulname { get; set; }

    public long? Hl7messagenum { get; set; }

    public long? Hl7destnum { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Scope { get; set; }

    public long? Flags { get; set; }
}
