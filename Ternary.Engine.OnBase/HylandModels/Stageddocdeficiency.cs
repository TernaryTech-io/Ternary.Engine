using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Stageddocdeficiency
{
    public long Stageddfcynum { get; set; }

    public long? Dfcytype { get; set; }

    public string? Dfcymessage { get; set; }

    public long? Itemnum { get; set; }

    public long? Pagenum { get; set; }

    public long? Notenum { get; set; }

    public long? Analystnum { get; set; }

    public DateTime? Dateadded { get; set; }

    public long? Physassignednum { get; set; }

    public long? Resassignednum { get; set; }

    public long? Reanalystnum { get; set; }

    public long? Flags { get; set; }

    public long? Stat { get; set; }
}
