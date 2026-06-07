using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Zoneregexdatum
{
    public long Zoneregexnum { get; set; }

    public string? Aggregateguid { get; set; }

    public string? Matchexpression { get; set; }

    public string? Regexdescription { get; set; }

    public string? Zoneregexpression { get; set; }

    public long? Flags { get; set; }

    public long? Createduser { get; set; }

    public DateTime? Createddate { get; set; }

    public long? Updateduser { get; set; }

    public DateTime? Updateddate { get; set; }
}
