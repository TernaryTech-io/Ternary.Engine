using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmtwfinancetype
{
    public long Rcmfinancetypenum { get; set; }

    public long? Rcmcvrshttmplnum { get; set; }

    public string? Rcmfintypedesc { get; set; }

    public long? Active { get; set; }
}
