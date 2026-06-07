using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Doubletakefailover
{
    public long? Diskgroupnum { get; set; }

    public long? Logicalplatternum { get; set; }

    public string? Originallastuseddrive { get; set; }

    public long? Failoverstate { get; set; }

    public long? Dtrevertjobnum { get; set; }

    public long? Status { get; set; }

    public long? Autorepairresult { get; set; }

    public long? Usernum { get; set; }
}
