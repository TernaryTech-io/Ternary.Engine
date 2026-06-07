using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Eventlog
{
    public long Eventlognum { get; set; }

    public string? Messagetext { get; set; }

    public long? Eventnum { get; set; }

    public DateTime? Eventdate { get; set; }

    public long? Usernum { get; set; }

    public long? Actionnum { get; set; }

    public long? Batchnum { get; set; }

    public long? Extrainfo1 { get; set; }

    public long? Extrainfo2 { get; set; }

    public long? Itemnum { get; set; }

    public long? Registernum { get; set; }
}
