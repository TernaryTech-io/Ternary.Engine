using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Scheduledprocess
{
    public long Schedprocnum { get; set; }

    public string? Schedprocname { get; set; }

    public long? Flags { get; set; }

    public long? Schedtype { get; set; }

    public long? Lastprocdate { get; set; }

    public long? Lastproctime { get; set; }

    public long? Procinterval { get; set; }

    public long? Prockey { get; set; }

    public long? Schedtemplatenum { get; set; }

    public long? Forcetorun { get; set; }

    public string? Semaphorepath { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Registernum { get; set; }

    public long? Idletimeout { get; set; }

    public string? Localinstanceid { get; set; }
}
