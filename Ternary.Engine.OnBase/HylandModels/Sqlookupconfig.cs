using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Sqlookupconfig
{
    public long Queuenum { get; set; }

    public long? Keysetnum1 { get; set; }

    public string? Label1 { get; set; }

    public string? Title1 { get; set; }

    public long? Flags1 { get; set; }

    public long? Extrainfo1 { get; set; }

    public long? Keysetnum2 { get; set; }

    public string? Label2 { get; set; }

    public string? Title2 { get; set; }

    public long? Flags2 { get; set; }

    public long? Extrainfo2 { get; set; }

    public long? Seqnum { get; set; }

    public string? Label3 { get; set; }

    public long? Dispcontext { get; set; }

    public long Sqlookupnum { get; set; }
}
