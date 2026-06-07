using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mpixmedalert
{
    public long? Mpinum { get; set; }

    public long? Medalertnum { get; set; }

    public long? Observationid { get; set; }

    public long? Abnormalflag { get; set; }

    public DateTime? Daterecognized { get; set; }

    public string? Responsibleobserver { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public string? Remarks { get; set; }

    public string? Updatereason { get; set; }

    public long? Flags { get; set; }
}
