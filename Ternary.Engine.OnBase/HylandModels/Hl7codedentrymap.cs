using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Hl7codedentrymap
{
    public long Hl7centrymapnum { get; set; }

    public long? Hl7codedentrynum { get; set; }

    public string? Hl7code { get; set; }

    public string? Hl7root { get; set; }

    public string? Description { get; set; }

    public long? Hl7obcodedentrynum { get; set; }

    public long? Flags { get; set; }
}
