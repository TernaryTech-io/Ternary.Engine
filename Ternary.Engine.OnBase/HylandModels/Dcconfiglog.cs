using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Dcconfiglog
{
    public long Dcconfiglognum { get; set; }

    public long? Dccategorynum { get; set; }

    public long? Dctemplatenum { get; set; }

    public long? Usernum { get; set; }

    public long? Registernum { get; set; }

    public DateTime? Logdate { get; set; }

    public long? Actionnum { get; set; }

    public long? Subactionnum { get; set; }

    public string? Messagetext { get; set; }

    public long? Severityflag { get; set; }

    public long? Tracelvl { get; set; }

    public long? Flags { get; set; }
}
