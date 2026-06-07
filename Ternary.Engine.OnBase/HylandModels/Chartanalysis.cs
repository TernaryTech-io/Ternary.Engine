using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Chartanalysis
{
    public long? Chtnum { get; set; }

    public long? Chtstatus { get; set; }

    public DateTime? Availablephys { get; set; }

    public long? Analystnum { get; set; }

    public DateTime? Dateanalyzed { get; set; }

    public DateTime? Dateadded { get; set; }

    public long? Reanalystnum { get; set; }

    public DateTime? Datereanalyzed { get; set; }

    public string? Holdreason { get; set; }

    public long? Physusernum { get; set; }

    public long? Opendfcy { get; set; }

    public long? Chtqueuetxnum { get; set; }

    public long? Mrcontrolsys { get; set; }
}
