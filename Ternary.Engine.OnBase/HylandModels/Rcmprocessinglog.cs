using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmprocessinglog
{
    public long Rcmprocesslognum { get; set; }

    public long? Usernum { get; set; }

    public long? Registernum { get; set; }

    public DateTime? Logdate { get; set; }

    public string? Messagetext { get; set; }

    public long? Actionnum { get; set; }

    public long? Subactionnum { get; set; }

    public long? Severityflag { get; set; }

    public long? Batchnum { get; set; }

    public long? Parsefilenum { get; set; }

    public long? Verifyitemnum { get; set; }

    public long? Extrainfo1 { get; set; }

    public long? Tracelvl { get; set; }

    public long? Isacknowledged { get; set; }
}
