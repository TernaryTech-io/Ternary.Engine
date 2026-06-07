using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Dfcytxlog
{
    public long Dfcytxlognum { get; set; }

    public long? Chtnum { get; set; }

    public DateTime? Logdate { get; set; }

    public long? Action { get; set; }

    public long? Usernum { get; set; }

    public long? Itemnum { get; set; }

    public long? Extrainfo1 { get; set; }

    public long? Extrainfo2 { get; set; }

    public long? Extrainfo3 { get; set; }

    public long? Dfcynum { get; set; }

    public string? Messagetext { get; set; }

    public long? Registernum { get; set; }

    public long? Actionnum { get; set; }

    public long? Subactionnum { get; set; }

    public long? Severityflag { get; set; }

    public long? Tracelvl { get; set; }
}
