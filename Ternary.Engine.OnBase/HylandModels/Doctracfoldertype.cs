using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Doctracfoldertype
{
    public long? Foldertypenum { get; set; }

    public long? Institution { get; set; }

    public long? Doctracfolder { get; set; }

    public string? Autonamestring { get; set; }

    public long? Parentfoldtypenum { get; set; }

    public long? Seqnum { get; set; }

    public long? Flags { get; set; }

    public long? Foldnotetplnum { get; set; }

    public DateTime? Fiscalyearstart { get; set; }
}
