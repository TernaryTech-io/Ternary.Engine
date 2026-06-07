using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Registeredsvr
{
    public string? Regservername { get; set; }

    public long? Regservertype { get; set; }

    public long? Wkstationnum { get; set; }

    public string? Version { get; set; }

    public DateTime? Regserverheartbeat { get; set; }

    public string? Baseuri { get; set; }

    public long? Status { get; set; }

    public long? Flags { get; set; }
}
