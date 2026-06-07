using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Hl7message
{
    public long Hl7messagenum { get; set; }

    public string? Hl7messagename { get; set; }

    public string? Hl7messagetype { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Flags { get; set; }
}
