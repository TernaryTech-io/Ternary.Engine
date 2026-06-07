using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mpixallergy
{
    public long? Mpinum { get; set; }

    public long? Allergynum1 { get; set; }

    public long? Allergynum2 { get; set; }

    public DateTime? Daterecognized { get; set; }

    public long? Severity { get; set; }

    public long? Probability { get; set; }

    public long? Reactioncode { get; set; }

    public string? Reactiontext { get; set; }

    public long? Allergytype { get; set; }

    public string? Reportername { get; set; }

    public string? Drugdetail { get; set; }

    public long? Routecode { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public long? Drugtype { get; set; }

    public long? Infosourcecode { get; set; }

    public DateTime? Onsetdate { get; set; }

    public long? Allergyindicator { get; set; }

    public string? Updatereason { get; set; }

    public long? Flags { get; set; }
}
