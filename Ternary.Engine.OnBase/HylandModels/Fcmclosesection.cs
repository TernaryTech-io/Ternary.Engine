using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Fcmclosesection
{
    public long Fcsectionnum { get; set; }

    public long? Fccloseeventnum { get; set; }

    public long? Seqnum { get; set; }

    public string? Fcsectionname { get; set; }

    public long? Fcsectiontemplnum { get; set; }

    public long? Fcoperationalitems { get; set; }

    public long? Flags { get; set; }

    public long? Fccompanynum { get; set; }

    public long? Fcparentnum { get; set; }
}
