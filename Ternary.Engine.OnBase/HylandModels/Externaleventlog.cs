using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Externaleventlog
{
    public long Exteventlognum { get; set; }

    public string? Guid { get; set; }

    public string? Logmessage { get; set; }

    public long? Registernum { get; set; }

    public long? Usernum { get; set; }

    public long? Actionnum { get; set; }

    public long? Subactionnum { get; set; }

    public long? Httpcode { get; set; }

    public DateTime? Logdate { get; set; }

    public long? Extrainfo1 { get; set; }

    public long? Extrainfo2 { get; set; }

    public long? Revisionnum { get; set; }

    public long? Filetypenum { get; set; }
}
