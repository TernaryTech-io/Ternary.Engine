using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rimlog
{
    public long Rimlognum { get; set; }

    public long? Actionnum { get; set; }

    public long? Subactionnum { get; set; }

    public long? Foldernum { get; set; }

    public long? Usernum { get; set; }

    public DateTime? Logdate { get; set; }

    public DateTime? Effectivedate { get; set; }

    public long? Flags { get; set; }

    public long? Severityflag { get; set; }

    public long? Tracelvl { get; set; }

    public long? Extrainfo1 { get; set; }

    public long? Extrainfo2 { get; set; }

    public string? Messagetext { get; set; }
}
