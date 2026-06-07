using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Admittype
{
    public long Admittypenum { get; set; }

    public string? Admittypename { get; set; }

    public long? Flags { get; set; }

    public string? Admittypenamehl7 { get; set; }
}
