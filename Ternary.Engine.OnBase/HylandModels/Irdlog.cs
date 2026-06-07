using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Irdlog
{
    public long Irdlognum { get; set; }

    public long? Itemnum { get; set; }

    public long? Usernum { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Returnreason { get; set; }

    public string? Returndescr { get; set; }

    public long? Flags { get; set; }

    public long? Actionnum { get; set; }

    public long? Subactionnum { get; set; }

    public long? Extrainfo1 { get; set; }

    public long? Severityflag { get; set; }

    public long? Tracelvl { get; set; }

    public DateTime? Logdate { get; set; }

    public long? Registernum { get; set; }
}
