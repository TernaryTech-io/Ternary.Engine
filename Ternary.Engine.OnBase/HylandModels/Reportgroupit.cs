using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Reportgroupit
{
    public long Itemtypenum { get; set; }

    public long Reportgroupnum { get; set; }

    public long? Printformatnum { get; set; }

    public long? Statementnum { get; set; }

    public long? Numbercopies { get; set; }

    public long? Reportitflags { get; set; }

    public long? Seqnum { get; set; }
}
