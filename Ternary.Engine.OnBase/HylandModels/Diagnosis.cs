using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Diagnosis
{
    public long Diagnum { get; set; }

    public string? Diagcode { get; set; }

    public string? Diagdesc { get; set; }
}
