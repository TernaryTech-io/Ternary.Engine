using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Workstationreg
{
    public string? Registername { get; set; }

    public string? Registerpwd { get; set; }

    public DateTime? Lastlogon { get; set; }

    public long? Registerstatus { get; set; }

    public string? Oldregisterpwd { get; set; }
}
