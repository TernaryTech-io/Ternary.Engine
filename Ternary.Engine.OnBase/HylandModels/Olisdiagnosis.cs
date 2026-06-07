using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Olisdiagnosis
{
    public long? Olisordernum { get; set; }

    public long? Olissessionnum { get; set; }

    public string? Diagidentifier { get; set; }

    public string? Diagtext { get; set; }

    public string? Diagcodingsys { get; set; }
}
