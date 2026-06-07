using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmcapturepayoridentifier
{
    public long Payoridnum { get; set; }

    public long? Payoritemnum { get; set; }

    public string? Identifiervalue { get; set; }

    public long? Identifiertype { get; set; }

    public long? Zoneregexnum { get; set; }

    public long? Flags { get; set; }

    public string? Aggregateguid { get; set; }
}
