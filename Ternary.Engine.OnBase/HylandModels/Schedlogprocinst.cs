using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Schedlogprocinst
{
    public long Procinstnum { get; set; }

    public long? Wkstninstnum { get; set; }

    public long? Registernum { get; set; }

    public long? Logtype { get; set; }

    public string? Schedprocname { get; set; }

    public long? Schedprocnum { get; set; }

    public DateTime? Starttime { get; set; }

    public DateTime? Endtime { get; set; }

    public long? Detaillevel { get; set; }

    public long? Peakseverity { get; set; }

    public long? Status { get; set; }

    public long? Flags { get; set; }

    public long? Itemcount { get; set; }
}
