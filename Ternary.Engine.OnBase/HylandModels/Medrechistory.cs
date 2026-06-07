using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Medrechistory
{
    public long? Mrnum { get; set; }

    public string? Prevmedrec { get; set; }

    public string? Medrecsource { get; set; }

    public string? Hl7root { get; set; }
}
