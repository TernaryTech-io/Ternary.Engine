using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Configlog
{
    public long Configlognum { get; set; }

    public long? Usernum { get; set; }

    public long? Registernum { get; set; }

    public DateTime? Logdate { get; set; }

    public long? Severityflag { get; set; }

    public string? Messagetext { get; set; }

    public long? Actionnum { get; set; }

    public long? Subactionnum { get; set; }

    public long? Extrainfo1 { get; set; }

    public long? Extrainfo2 { get; set; }

    public long? Tracelvl { get; set; }

    public long? Objectid { get; set; }
}
