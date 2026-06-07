using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Casehistory
{
    public long Casehistnum { get; set; }

    public long? Usernum { get; set; }

    public long? Registernum { get; set; }

    public DateTime? Logdate { get; set; }

    public long? Actionnum { get; set; }

    public long? Subactionnum { get; set; }

    public string? Messagetext { get; set; }

    public long? Severityflag { get; set; }

    public long? Tracelvl { get; set; }

    public long? Extrainfo1 { get; set; }

    public long? Extrainfo2 { get; set; }

    public long? Flags { get; set; }

    public long? Caseinstancenum { get; set; }
}
