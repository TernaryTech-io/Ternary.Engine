using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Hl7policy
{
    public long Hl7policynum { get; set; }

    public string? Hl7policyname { get; set; }

    public string? Hl7policyswitch { get; set; }

    public long? Hl7tlsversion { get; set; }

    public long? Flags { get; set; }
}
