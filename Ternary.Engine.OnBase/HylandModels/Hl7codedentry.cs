using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Hl7codedentry
{
    public long Hl7codedentrynum { get; set; }

    public string? Hl7codedentryname { get; set; }

    public long? Hl7codetype { get; set; }

    public long? Flags { get; set; }
}
